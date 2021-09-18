// Sourced from https://developer.vuforia.com/sites/default/files/VuforiaFocus.txt
using UnityEngine;

namespace Vuforia
{
    public class VuforiaFocus : MonoBehaviour
    {
        private void Start()
        {
            var vuforia = VuforiaARController.Instance;
            vuforia.RegisterVuforiaStartedCallback(SetAutoFocus);
            vuforia.RegisterOnPauseCallback(OnPaused);
        }

        private void SetAutoFocus()
            => CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);

        private void OnPaused(bool paused)
        {
            if(!paused)
                SetAutoFocus();
        }
    }
}