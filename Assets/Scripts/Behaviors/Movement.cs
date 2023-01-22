using Camera;
using ScriptableSource;
using UnityEngine;

namespace Behaviors
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Movement : MonoBehaviour
    { 
        [SerializeField] private InputManager inputManager;
        
        [Space] [SerializeField] private float defaultSpeed = 15.00f;
        [Space] [SerializeField] private float runSpeed = 25.00f;
        [SerializeField] private float smoothMovement = 0.25f;
        
        private Rigidbody2D _rigidbody2d;
        private PlayerCamera _playerCamera;
        
        private Vector2 _refVector;
        private Vector2 _inputVector;
        private Vector3 _currentInputVector;
        private Vector3 _movement;
        
        private bool _toggleInput;
        private bool _toggleAccelerate;

        private void OnEnable()
        {
            inputManager.AxesMovementEvent += AxesMovement;
            inputManager.EscapeButtonEvent += MouseSetFree;
            inputManager.ActionButtonEvent += MouseLocker;
            
            inputManager.AnyAccelerationEventUp += AccelerationUp;
            inputManager.AnyAccelerationEventDown += AccelerationDown;
        }

        private void OnDisable()
        {
            inputManager.AxesMovementEvent -= AxesMovement;
            inputManager.EscapeButtonEvent -= MouseSetFree;
            inputManager.ActionButtonEvent -= MouseLocker;
            
            inputManager.AnyAccelerationEventUp -= AccelerationUp;
            inputManager.AnyAccelerationEventDown -= AccelerationDown;
        }

        private void Start()
        {
            _rigidbody2d = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            SmoothMovement();
        }

        private void SmoothMovement()
        {
            if (inputManager.cameraModeFlag)
            {
                var playerSpeed = _toggleAccelerate ? runSpeed : defaultSpeed;
                var movementFormula = transform.forward + _movement * (playerSpeed * Time.fixedDeltaTime);
                var velocity = _rigidbody2d.velocity;
                
                _currentInputVector = Vector2.SmoothDamp(_currentInputVector,
                    _inputVector, ref _refVector, smoothMovement);
                _movement = new Vector3(_currentInputVector.x, _currentInputVector.y, 0);
                
                velocity = new Vector2(velocity.x + movementFormula.x, 
                    velocity.y + movementFormula.y);
                
                _rigidbody2d.velocity = velocity;
            }
        }
        
        // ------------- Event listeners -------------

        private void AxesMovement(Vector2 context) => _inputVector = context;
        private void MouseLocker() => inputManager.mouseCapturedFlag = true;
        private void MouseSetFree() => inputManager.mouseCapturedFlag = false;
        private void AccelerationUp() => _toggleAccelerate = false;
        private void AccelerationDown() => _toggleAccelerate = true;
    }
}
