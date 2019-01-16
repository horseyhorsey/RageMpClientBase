using RAGE.Game;
using RageMpClientShared;
using System;

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
        /// Sends a standard notification to the current player without player name. Snippets from rootcause std.
        /// </summary>
        /// <param name="msg"></param>
        public static void SendNotification(string msg, bool flash = false, int textCol = -1, int bgCol = -1, int[]
            flashCol = null)
        {
            //Set color and bg color if values high
            if (textCol > -1)
                Ui.SetNotificationColorNext(Convert.ToInt32(0x39BBF623FC803EAC));
            if (bgCol > -1)
                Ui.SetNotificationBackgroundColor(Convert.ToInt32(0x92F0DA1E27DB96DC));

            //Flash color
            if (flash)
            {
                //set default value if null
                if (flashCol == null)
                    flashCol = new int[] { 77, 77, 77, 255 };

                //set to flash the color
                Ui.SetNotificationFlashColor(flashCol[0], flashCol[1], flashCol[2], flashCol[3]);
            }

            Ui.SetNotificationTextEntry("STRING");
            SetMaxTextComponentSubstringMessage(msg);

            Ui.DrawNotification(false, true);
        }

        /// <summary>
        /// Sends a picture notification to the current player without player name. Snippets from rootcause std.
        /// </summary>
        /// <param name="msg"></param>
        public static void SendPicNotification(string title, string sender, string msg, string notifPic, int icon = 0, bool flash = false, int textCol = -1, int bgCol = -1, int[]
            flashCol = null)
        {
            //Set color and bg color if values high
            if (textCol > -1)
                Ui.SetNotificationColorNext(Convert.ToInt32(0x39BBF623FC803EAC));
            if (bgCol > -1)
                Ui.SetNotificationBackgroundColor(Convert.ToInt32(0x92F0DA1E27DB96DC));

            //Flash color
            if (flash)
            {
                //set default value if null
                if (flashCol == null)
                    flashCol = new int[] { 77, 77, 77, 255 };

                //set to flash the color
                Ui.SetNotificationFlashColor(flashCol[0], flashCol[1], flashCol[2], flashCol[3]);
            }

            //Ui.SetNotificationTextEntry("STRING");
            Ui.SetNotificationTextEntry("CELL_EMAIL_BCON");

            SetMaxTextComponentSubstringMessage(msg);

            Ui.SetNotificationMessage2(notifPic, notifPic, flash, icon, title, sender);
            Ui.DrawNotification(false, true);
        }

        /// <summary>
        /// Sends a picture notification to the current player without player name.
        /// </summary>
        /// <param name="msg"></param>
        public static void SendPicNotification(string title, string sender, string msg, NotifyChar notifyChar, int icon = 0, bool flash = false, int textCol = -1, int bgCol = -1, int[]
            flashCol = null)
        {
            var pic = notifyChar.ToString();

            SendPicNotification(title, sender, msg, pic, icon, flash, textCol, bgCol, flashCol);
        }

        /// <summary>
        /// Draws a subtitle to the bottom center of screen.
        /// </summary>
        /// <remarks>
        /// Subtitle("~y~This is a yellow subtitle", 3000);
        /// </remarks>
        /// <param name="subtitle"></param>
        /// <param name="duration"></param>
        /// <param name="drawImmediatley"></param>
        public static void ShowSubtitle(string subtitle, int duration = 5000, bool drawImmediatley = true)
        {            
            Ui.BeginTextCommandPrint("STRING");            
            Ui.AddTextComponentSubstringPlayerName(subtitle);
            Ui.EndTextCommandPrint(duration, drawImmediatley);            
        }

        private static void SetMaxTextComponentSubstringMessage(string msg)
        {
            int maxLength = 99;
            for (int i = 0; i < msg.Length; i += maxLength)
            {
                Ui.AddTextComponentSubstringPlayerName(msg.Substring(i, Math.Min(maxLength, msg.Length - i)));
            }
        }
    }
}