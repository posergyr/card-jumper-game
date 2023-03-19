using UnityEngine;

namespace DevTools
{
    public class FrameRateLimiter : MonoBehaviour
    {
        private enum FrameRate
        {
            _240HzRate = 239,
            _144HzRate = 143,
            _75HzRate = 74
        }
        
        [SerializeField] private FrameRate frameRate = FrameRate._240HzRate;
        [SerializeField] private bool lockFrameRate;
        
        private void Update()
        {
            if (lockFrameRate)
            {
                QualitySettings.vSyncCount = 1;

                switch (frameRate)
                {
                    case FrameRate._240HzRate:
                        Application.targetFrameRate = (int)FrameRate._240HzRate;
                        break;
                    case FrameRate._144HzRate:
                        Application.targetFrameRate = (int)FrameRate._144HzRate;
                        break;
                    case FrameRate._75HzRate:
                        Application.targetFrameRate = (int)FrameRate._75HzRate;
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
