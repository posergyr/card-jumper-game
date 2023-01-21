using ScriptableSource;
using UnityEngine;

namespace Managers
{
    public class CaptureMouse : MonoBehaviour
    {
        [SerializeField] private InputManager inputManager;

        private void Update()
        {
            if (inputManager.mouseCapturedFlag)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
}
