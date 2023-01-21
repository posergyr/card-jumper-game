using Camera;
using Managers;
using ScriptableSource;
using UnityEngine;

namespace Behaviors
{
    [RequireComponent(typeof(Rigidbody))]
    public class Movement : MonoBehaviour
    { 
        [SerializeField] private InputManager inputManager;
        
        [Space] [SerializeField] private float defaultSpeed = 6.50f;
        [Space] [SerializeField] private float runSpeed = 10.00f;
        [SerializeField] private float smoothMovement = 0.25f;
        
        private Rigidbody _rigidbody;
        private PlayerCamera _playerCamera;
        
        private Vector2 _refVector;
        private Vector3 _inputVector;
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
            _rigidbody = GetComponent<Rigidbody>();
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
                var movementFormula = transform.position + _movement * (playerSpeed * Time.fixedDeltaTime);
                
                _currentInputVector = Vector2.SmoothDamp(_currentInputVector,
                    _inputVector, ref _refVector, smoothMovement);

                _movement = new Vector3(_currentInputVector.x, 0, _currentInputVector.y);
                _rigidbody.MovePosition(movementFormula);
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
