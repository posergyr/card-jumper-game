using Managers;
using ScriptableSource;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace DevTools
{
    public class RestartScene : MonoBehaviour
    {
        [SerializeField] private InputManager inputManager;
        private bool _restart;

        private void OnEnable()
        {
            inputManager.ActionRestartEventUp += ActionRestartUp;
            inputManager.ActionRestartEventDown += ActionRestartDown;
        }
        private void OnDisable()
        {
            inputManager.ActionRestartEventUp -= ActionRestartUp;
            inputManager.ActionRestartEventDown -= ActionRestartDown;
        }

        private void Update()
        {
            if (_restart)
            {
                SceneManager.LoadScene("Scenes/" + SceneManager.GetActiveScene().name);
            }
        }
        
        // ------------- Event listeners -------------
        
        private void ActionRestartUp() => _restart = false;
        private void ActionRestartDown() => _restart = true;
    }
}