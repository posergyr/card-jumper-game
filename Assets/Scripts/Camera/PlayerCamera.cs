using System;
using ScriptableSource;
using UnityEngine;

namespace Camera
{
    [RequireComponent(typeof(UnityEngine.Camera))]

    public class PlayerCamera : MonoBehaviour
    {
        // --- Taking Components
        [SerializeField] private InputManager inputManager;
        [SerializeField] private Transform cameraTarget;
        private Transform _transform;
        
        [Space] 
        
        // --- Camera characteristics for tweaking later
        [SerializeField] private float speedDefault = 10.00f;
        [SerializeField] private float acceleration = 50.00f;
        [SerializeField] private float mouseSensitivity = 25.00f;
        [SerializeField] private float smoothMovement = 0.25f;
        
        private bool _cameraPlayerMode = true;  // Private variable of camera mode:
                                                // if true -> standard 3rd person camera
                                                // if false -> free camera for development

        // --- Movement and coordinates fields
        private float _movementX;
        private float _movementY;
        private float _rotationX;
        private float _rotationY;
        
        private float _cameraDeltaInputX;
        private float _cameraDeltaInputY;

        private float _cameraMovementInputX;
        private float _cameraMovementInputY;
        
        private bool _toggleAccelerate;

        private Vector3 _currentVelocity = Vector3.zero;
        [Space]
        [SerializeField] private Vector3 offset = new(0.00f, 0.00f, 0.00f);
        [SerializeField] private Vector3 defaultRotation;
        
        // --- Input activation
        private void OnEnable()
        {
            inputManager.LookAroundDeltaEvent += LookAround;
            inputManager.AxesMovementEvent += AxesMovement;

            inputManager.ToggleCameraEvent += ToggleCamera;
            
            inputManager.AnyAccelerationEventUp += AccelerationUp;
            inputManager.AnyAccelerationEventDown += AccelerationDown;
        }

        // Input deactivation
        private void OnDisable()
        {
            inputManager.LookAroundDeltaEvent -= LookAround;
            inputManager.AxesMovementEvent -= AxesMovement;
            
            inputManager.ToggleCameraEvent -= ToggleCamera;
            
            inputManager.AnyAccelerationEventUp -= AccelerationUp;
            inputManager.AnyAccelerationEventDown -= AccelerationDown;
        }

        private void Awake()
        {
            inputManager.cameraModeFlag = _cameraPlayerMode;
        }

        private void Start()
        {
            _transform = GetComponent<Transform>();
            ResetCamera(); // resetting camera on changing mode to 3rd person
        }

        private void LateUpdate()
        {
            CameraSelection();
        }
        
        // Changing camera by button 
        private void CameraSelection()
        {
            if (!_cameraPlayerMode)
                FreeCameraMode();
            else
                ThirdPersonCameraMode();
        }

        // Third person camera movement for player
        private void ThirdPersonCameraMode()
        {
            var targetPosition = cameraTarget.position + offset;
            
            _transform.position = Vector3.SmoothDamp(_transform.position,
                targetPosition, ref _currentVelocity, smoothMovement);
        }

        // Free camera movement for debugging
        private void FreeCameraMode()
        {
            if (inputManager.mouseCapturedFlag)
            {
                var camSpeed = _toggleAccelerate ? acceleration : speedDefault;
                var localRotation = Quaternion.AngleAxis(_rotationX, Vector3.up);

                _rotationX += _cameraDeltaInputX * Time.deltaTime * mouseSensitivity;
                _rotationY += _cameraDeltaInputY * Time.deltaTime * mouseSensitivity;
                _rotationY = Math.Clamp(_rotationY, -90, 90);

                localRotation *= Quaternion.AngleAxis(_rotationY, Vector3.left);

                _movementX = _cameraMovementInputX * (camSpeed * Time.deltaTime);
                _movementY = _cameraMovementInputY * (camSpeed * Time.deltaTime);

                _transform.Translate(_movementX, 0, _movementY);
                _transform.localRotation = localRotation;
            }
        }

        // ------------- Event listeners -------------

        private void LookAround(Vector2 context)
        {
            _cameraDeltaInputX = context.x;
            _cameraDeltaInputY = context.y;
        }

        private void AxesMovement(Vector2 context)
        {
            _cameraMovementInputX = context.x;
            _cameraMovementInputY = context.y;
        }

        private void ToggleCamera()
        {
            _cameraPlayerMode = !_cameraPlayerMode;
            inputManager.cameraModeFlag = _cameraPlayerMode;
            
            ResetCamera();
        }
        
        private void ResetCamera() => _transform.rotation 
            = Quaternion.AngleAxis(defaultRotation.x, Vector3.left);

        private void AccelerationUp() => _toggleAccelerate = false;
        private void AccelerationDown() => _toggleAccelerate = true;
    }
}