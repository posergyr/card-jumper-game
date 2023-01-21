using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace ScriptableSource
{
    [CreateAssetMenu(fileName = "InputManager", menuName = "ScriptableObjects/InputManager", order = 1)]
    public sealed class InputManager : ScriptableObject, GameInput.IPlayerControlsActions
    {
        // --- Gameplay player's movement and actions 
        public event UnityAction<Vector2> AxesMovementEvent = delegate {  };
        public event UnityAction<Vector2> LookAroundDeltaEvent = delegate {  };
        public event UnityAction AnyAccelerationEventUp = delegate {  };
        public event UnityAction AnyAccelerationEventDown = delegate {  };
        
        // --- Toggle camera and mouse capturing / hiding 
        //public event UnityAction<Vector2> ScrollingZoomingEvent = delegate(Vector2 arg0) {  };
        public event UnityAction ToggleCameraEvent = delegate {  };
        public event UnityAction EscapeButtonEvent = delegate {  };
        public event UnityAction ActionButtonEvent = delegate {  };
        public event UnityAction ActionRestartEventUp = delegate {  }; 
        public event UnityAction ActionRestartEventDown = delegate {  };
        public event UnityAction ShootTheArrow = delegate {  }; 
        public event UnityAction BuyUpgrade = delegate {  }; 

        // --- Tools for developers which should be deactivated later
        //public event UnityAction ToggleCheatFieldEvent = delegate {  };
        
        // --- Some shitty "flags" which I should remove one day
        public bool cameraModeFlag;
        public bool mouseCapturedFlag;
        
        private GameInput _gameInput;

        private void OnEnable()
        {
            if (_gameInput == null)
            {
                _gameInput = new GameInput();
                _gameInput.PlayerControls.SetCallbacks(this);
                _gameInput.PlayerControls.SetCallbacks(this);
            }
            
            _gameInput.PlayerControls.Enable();
        }

        private void OnDisable()
        {
            _gameInput.PlayerControls.Disable();
        }
        
        // ------------- Specific keys events -------------
        
        public void OnAxesMovement(InputAction.CallbackContext context)
        {
            if (AxesMovementEvent != null)
                AxesMovementEvent.Invoke(context.ReadValue<Vector2>());
        }

        public void OnLookAroundDelta(InputAction.CallbackContext context)
        {
            if (LookAroundDeltaEvent != null)
                LookAroundDeltaEvent.Invoke(context.ReadValue<Vector2>());
        }

        public void OnAnyAccelerationUp(InputAction.CallbackContext context)
        {
            if (AnyAccelerationEventUp != null && context.phase == InputActionPhase.Canceled)
                AnyAccelerationEventUp.Invoke();
        }

        public void OnAnyAccelerationDown(InputAction.CallbackContext context)
        {
            if (AnyAccelerationEventDown != null && context.phase == InputActionPhase.Performed)
                AnyAccelerationEventDown.Invoke();
        }

        public void OnScrollingZooming(InputAction.CallbackContext context)
        {
            throw new NotImplementedException();
        }

        public void OnToggleCamera(InputAction.CallbackContext context)
        {
            if (ToggleCameraEvent != null && context.phase == InputActionPhase.Performed)
                ToggleCameraEvent.Invoke();
        }
        
        public void OnEscapeButton(InputAction.CallbackContext context)
        {
            if (EscapeButtonEvent != null && context.phase == InputActionPhase.Performed)
                EscapeButtonEvent.Invoke();
        }

        public void OnActionButton(InputAction.CallbackContext context)
        {
            if (ActionButtonEvent != null && context.phase == InputActionPhase.Performed)
                ActionButtonEvent.Invoke();
        }

        public void OnToggleCheatField(InputAction.CallbackContext context)
        {
            throw new NotImplementedException();
        }

        public void OnRestartLevelUp(InputAction.CallbackContext context)
        {
            if (ActionRestartEventUp != null && context.phase == InputActionPhase.Canceled)
                ActionRestartEventUp.Invoke();
        }
        
        public void OnRestartLevelDown(InputAction.CallbackContext context)
        {
            if (ActionRestartEventDown != null && context.phase == InputActionPhase.Performed)
                ActionRestartEventDown.Invoke();
        }

        public void OnShootTheArrow(InputAction.CallbackContext context)
        {
            if (ShootTheArrow != null && context.phase == InputActionPhase.Performed)
                ShootTheArrow.Invoke();
        }

        public void OnBuyUpgrade(InputAction.CallbackContext context)
        {
            if (BuyUpgrade != null && context.phase == InputActionPhase.Performed)
                BuyUpgrade.Invoke();
        }
    }
}
