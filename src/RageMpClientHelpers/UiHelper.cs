using RAGE.Game;

namespace RageMpClientHelpers
{
    public static class UiHelper
    {
        /// <summary>
        /// Enable the games Overlays
        /// </summary>
        /// <param name="hud">Display the hud</param>
        /// <param name="radar">Display the map</param>
        public static void EnableHuds(bool hud = true, bool radar = true)
        {            
            Ui.DisplayRadar(radar);
            Ui.DisplayHud(hud);
        }

        /// <summary>
        /// Sends a standard notification to the current player without player name
        /// </summary>
        /// <param name="msg"></param>
        public static void SendNotification(string msg)
        {
            Ui.SetNotificationTextEntry("STRING");
            Ui.AddTextComponentSubstringPlayerName(msg);
            Ui.DrawNotification(false, false);
        }

    }
}
