using UnityEngine;

namespace Development
{
    public class FrameRateLimiter : MonoBehaviour
    {
        private enum FrameRate
        {
            _60Hz = 59,
            _75Hz = 71
        }
        
        [SerializeField] private FrameRate frameRate = FrameRate._60Hz;
        [SerializeField] private bool lockFrameRate;
        
        private void Update()
        {
            if (lockFrameRate)
            {
                QualitySettings.vSyncCount = 1;

                switch (frameRate)
                {
                    case FrameRate._60Hz:
                        Application.targetFrameRate = (int)FrameRate._60Hz;
                        break;
                    case FrameRate._75Hz:
                        Application.targetFrameRate = (int)FrameRate._75Hz;
                        break;
                }
            }
            else
            {
                QualitySettings.vSyncCount = 0;
                Application.targetFrameRate = -1;
            }
        }
    }
}
