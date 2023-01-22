using System;
using Camera;
using ScriptableSource;
using UnityEngine;

namespace Behaviors
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Movement : MonoBehaviour
    {
        #region Characteristics
        [SerializeField] private InputManager inputManager;
        [Space] 
        [SerializeField] private float defaultMaxSpeed = 15.00f;
        [SerializeField] private float runMaxSpeed = 25.00f;
        [Space] 
        [SerializeField] private float acceleration = 1f;
        [SerializeField] private float deceleration = 1f;
        [SerializeField] private float velocityPower = 0.45f;
        [SerializeField] private float frictionAmount = 0.55f;
        #endregion

        private Rigidbody2D _rigidbody2D;
        private PlayerCamera _playerCamera;
        
        private Vector2 _inputVector;

        private bool _toggleInput;
        private bool _toggleAccelerate;

        public float InputVectorX
        {
            get => _inputVector.x;
            private set => _inputVector.x = value;
        }

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
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            SmoothMovement();
            FlipPlayer();
        }

        private void SmoothMovement()
        {
            if (inputManager.cameraModeFlag)
            {
                var playerSpeed = _toggleAccelerate ? runMaxSpeed : defaultMaxSpeed;
                var targetSpeed = _inputVector.x * playerSpeed;
                
                var speedDif = targetSpeed - _rigidbody2D.velocity.x;
                var accelerate = (Mathf.Abs (targetSpeed) > 0.01f) ? acceleration : deceleration;
                var movement = Mathf.Pow(Mathf .Abs (speedDif) * accelerate, velocityPower) * Mathf. Sign (speedDif);

                if (Math.Abs(_inputVector.x) < 0.01f)
                {
                    var amount = Mathf.Min(Mathf.Abs(_rigidbody2D.velocity.x), Math.Abs(frictionAmount));
                    amount *= Mathf .Sign (_rigidbody2D.velocity.x);
                    _rigidbody2D.AddForce (Vector2.right * -amount, ForceMode2D. Impulse);
                }

                _rigidbody2D.AddForce (movement * Vector2.right) ;
            }
        }

        private void FlipPlayer()
        {
            if (_inputVector.x < 0)
            {
                InputVectorX = _inputVector.x;
                transform.eulerAngles = new Vector3(0, 180, 0);
            }
            else if (_inputVector.x > 0)
            {
                InputVectorX = _inputVector.x;
                transform.eulerAngles = new Vector3(0, 0, 0);
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
