using RAGE.Game;

namespace RageMpClientHelpers
{
    public static class CamHelper
    {
        /// <summary>
        /// Rotate the player cam. 0 is front, -360 - 360
        /// </summary>
        /// <param name="cam"></param>
        /// <param name="rotation"></param>
        public static void RotatePlayerCam(float rotation)
        {
            Cam.SetGameplayCamRelativeHeading(rotation);
        }

        /// <summary>
        /// Fade in or Out the screen to black with spinner loading.
        /// </summary>
        /// <param name="isLoading"></param>
        /// <param name="duration"></param>
        public static void SetPlayerLoading(bool isLoading, int duration = 200)
        {
            if (isLoading)
            {                
                if (!Cam.IsScreenFadedOut())
                    Cam.DoScreenFadeOut(duration);
            }
            else
            {
                if (!Cam.IsScreenFadedIn())
                    Cam.DoScreenFadeIn(duration);
            }
        }
    }
}
