using UnityEngine;
using UnityEngine.InputSystem;

namespace DevTools
{
    public class DebugController : MonoBehaviour
    {
        [SerializeField] private InputActionReference toggleDebugInput;
        [SerializeField] private bool toggleDebug;
        
        private string _input;

        private void Update()
        {
            if (toggleDebugInput.action.WasReleasedThisFrame())
            {
                toggleDebug = !toggleDebug;
            }
        }

        private void OnGUI()
        {
            var y = 0f;

            if (toggleDebug)
            {
                GUI.Box(new Rect(0f, y, Screen.width, 30f), "");
                GUI.backgroundColor = new Color(0f, 0f, 0f, 0f);
                
                _input = GUI.TextField(new Rect(10f, y + 5f, 
                    Screen.width - 20f, 20f), _input);
            }
        }
    }
}
