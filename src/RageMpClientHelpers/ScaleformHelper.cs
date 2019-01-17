using RAGE.Game;
using System;
using System.Collections.Generic;

namespace RageMpClientHelpers
{
    public static class ScaleformHelper
    {
        public static Scaleform BigMessageWeaponPurchased(string title, string weaponName, uint weaponHash)
        {
            var sf = new Scaleform("mp_big_message_freemode");
            while (!sf.IsLoaded) Invoker.Wait(0);
            sf.CallFunction("SHOW_WEAPON_PURCHASED", title, weaponName, weaponHash);
            return sf;
        }
        public static Scaleform BigMessagePlane(string title, string planeName, uint planeHash)
        {
            var sf = new Scaleform("mp_big_message_freemode");
            while (!sf.IsLoaded) Invoker.Wait(0);
            sf.CallFunction("SHOW_PLANE_MESSAGE", title, planeName, planeHash);
            return sf;
        }
        public static Scaleform BigMessageShard(string title, string message, int titleColor = 1, int bgColor = 0)
        {
            var sf = new Scaleform("mp_big_message_freemode");
            while (!sf.IsLoaded) Invoker.Wait(0);
            sf.CallFunction("SHOW_SHARD_CENTERED_MP_MESSAGE", title, message, titleColor, bgColor);
            return sf;
        }
        /// <summary>
        /// Uses the Shard anim out to fade out message
        /// </summary>
        /// <param name="scaleform"></param>
        /// <param name="bgColor"></param>
        public static void FadeOutShard(Scaleform scaleform, int bgColor = 0)
        {
            scaleform.CallFunction("SHARD_ANIM_OUT", bgColor);
        }
        /// <summary>
        /// Creates an card with info. Uses the same as <see cref="VehicleInfo(string, string, string, int, int, int, int)"/>
        /// </summary>
        /// <param name="scaleform"></param>
        /// <param name="bgColor"></param>
        public static Scaleform InfoCard(string name, string statName1, string statName2, string statName3, string statName4,
            int stat1 = 0, int stat2 = 0, int stat3 = 0, int stat4 = 0, string title = "Title", string p2 = "Annis")
        {
            var sf = new Scaleform("mp_car_stats_01");
            while (!sf.IsLoaded) Invoker.Wait(0);

            string mpHud = "MPCarHUD";
            sf.CallFunction("SET_VEHICLE_INFOR_AND_STATS", name, title, mpHud, p2, statName1, statName2, statName3, statName4, stat1, stat2, stat3, stat4);
            return sf;
        }
        /// <summary>
        /// Returns a scaleform that shows a "midsized_message" on the screen when rendered
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static Scaleform MessageMidSized(string title, string message)
        {
            var sf = new Scaleform("midsized_message");
            while (!sf.IsLoaded) Invoker.Wait(0);
            sf.CallFunction("SHOW_MIDSIZED_MESSAGE", title, message);
            return sf;
        }
        public static Scaleform MessageMidSizedShared(string title, string message, int bgColor = 0, bool dark = false, bool condensed = false)
        {
            var sf = new Scaleform("midsized_message");
            while (!sf.IsLoaded) Invoker.Wait(0);
            sf.CallFunction("SHOW_SHARD_MIDSIZED_MESSAGE", title, message, bgColor, dark, condensed);
            return sf;
        }
        /// <summary>
        /// Render3D above the player.....or wherever
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Scaleform PlayerName(string name)
        {
            var sf = new Scaleform("player_name_01");
            while (!sf.IsLoaded) Invoker.Wait(0);
            sf.CallFunction("SET_PLAYER_NAME", name);
            return sf;
        }
        /// <summary>
        /// Create a STAT WALL
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [Obsolete("Needs more tests")]
        public static IEnumerable<Scaleform> StatWall(string param)
        {            
            var cele1 = new Scaleform("MP_CELEBRATION_BG");
            var cele2 = new Scaleform("MP_CELEBRATION_FG");
            var cele3 = new Scaleform("MP_CELEBRATION");

            cele1.CallFunction("SHOW_STAT_WALL", param);
            cele2.CallFunction("SHOW_STAT_WALL", param);
            cele3.CallFunction("SHOW_STAT_WALL", param);

            var scaleForms = new List<Scaleform>();
            scaleForms.Add(cele1); scaleForms.Add(cele2); scaleForms.Add(cele3);

            return scaleForms;            
        }
        /// <summary>
        /// Creates vehicle stats card. Render 2D or 3D?
        /// </summary>
        /// <param name="scaleform"></param>
        /// <param name="bgColor"></param>
        public static Scaleform VehicleInfo(string vName, string title = "Insured", string p2 = "Annis", int speed = 0, int acc = 0, int brake = 0, int traction = 0 )
        {
            var sf = new Scaleform("mp_car_stats_01");
            while (!sf.IsLoaded) Invoker.Wait(0);

            string mpHud = "MPCarHUD";
            sf.CallFunction("SET_VEHICLE_INFOR_AND_STATS", vName, title, mpHud, p2, "Top Speed", "Acceleration", "Braking", "Traction", speed, acc, brake, traction);
            return sf;
        }
    }
}