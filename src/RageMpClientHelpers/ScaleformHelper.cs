using RAGE.Game;
using System;
using System.Collections.Generic;

namespace RageMpClientHelpers
{
    public static class ScaleformHelper
    {
        public static Scaleform BigMessageWeaponPurchased(string title, string weaponName, uint weaponHash)
        {
            var sf = RequestScaleform("mp_big_message_freemode");
            sf.CallFunction("SHOW_WEAPON_PURCHASED", title, weaponName, weaponHash);
            return sf;
        }
        public static Scaleform BigMessagePlane(string title, string planeName, uint planeHash)
        {
            var sf = RequestScaleform("mp_big_message_freemode");
            sf.CallFunction("SHOW_PLANE_MESSAGE", title, planeName, planeHash);
            return sf;
        }
        public static Scaleform BigMessageShard(string title, string message, int titleColor = 1, int bgColor = 0)
        {
            var sf = RequestScaleform("mp_big_message_freemode");
            sf.CallFunction("SHOW_SHARD_CENTERED_MP_MESSAGE", title, message, titleColor, bgColor);
            return sf;
        }

        /// <summary>
        /// Creates a vehicle dial. When in a vehicle, the dials work without being explicitly set with SetDials or SetLights. Create and render
        /// </summary>
        /// <returns></returns>
        public static Scaleform Dashboard()
        {
            var sf = RequestScaleform("DASHBOARD");
            
            sf.CallFunction("TOGGLE_BACKGROUND_VISIBILITY", 1);
            //sf.CallFunction("SET_VEHICLE_TYPE", 5);

            return sf;
        }

        /// <summary>
        /// SET_DASHBOARD_DIALS(RPM, speed, fuel, temp, vacuum, boost, oilTemperature, oilPressure, waterTemp, curGear)
        /// </summary>
        /// <param name="dashboardSf">A dashboard scaleform</param>
        public static void DashboardSetDials(Scaleform dashboardSf, float speed = 0, float fuel = 0, float temp = 0, float vacum=0, float boost=0, float oilTemp = 0, float oilPress = 0, float waterTemp = 0, float currGear = 0)
        {
            dashboardSf.CallFunction("SET_DASHBOARD_DIALS", speed, fuel, temp, vacum, boost, oilTemp, oilPress, waterTemp, currGear);           
        }

        /// <summary>
        /// W
        /// </summary>
        /// <remarks>
        /// indicator_left, indicator_right, handbrakeLight, engineLight, ABSLight, petrolLight, oilLight, headlights, fullBeam, batteryLight, shiftLight1, shiftLight2, shiftLight3, shiftLight4, shiftLight5
        /// </remarks>
        /// <param name="dashboardSf">A dashboard scaleform</param>
        public static void DashboardSetLights(Scaleform dashboardSf, 
            int indL, int indR, int handbrake, int engine, int abs, int petrol, int oil, int headlights, int fullbeam,
            int batteryLight, int shiftLight1, int shiftLight2, int shiftLight3, int shiftLight4, int shiftLight5)
        {
            dashboardSf.CallFunction("SET_DASHBOARD_LIGHTS", 
                indL, indR, handbrake, engine, abs, petrol, oil, headlights, fullbeam,
                batteryLight, shiftLight1, shiftLight2, shiftLight3, shiftLight4, shiftLight5);
        }

        public static Scaleform Dial()
        {
            var sf = RequestScaleform("DIAL_BANSHEE");
            sf.CallFunction("DIAL_BANSHEE");
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
            var sf = RequestScaleform("mp_car_stats_01");
            string mpHud = "MPCarHUD";
            sf.CallFunction("SET_VEHICLE_INFOR_AND_STATS", name, title, mpHud, p2, statName1, statName2, statName3, statName4, stat1, stat2, stat3, stat4);
            return sf;
        }

        public static Scaleform InstructionalButton(int code, string button)
        {
            var sf = RequestScaleform("instructional_buttons");            
            sf.CallFunction("SET_DATA_SLOT_EMPTY");
            sf.CallFunction("SET_DATA_SLOT", 0, code, button);
            sf.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", -1);
            return sf;
        }

        /// <summary>
        /// Creates a scaleform of instructional buttons
        /// </summary>
        /// <param name="buttons"></param>
        /// <param name="layout">-1 will be all on one line. 1 will stack the buttons</param>
        /// <returns></returns>
        public static Scaleform InstructionalButtons(Dictionary<string, string> buttons, int layout = -1)
        {
            var sf = RequestScaleform("instructional_buttons");
            sf.CallFunction("SET_DATA_SLOT_EMPTY");
            int btnIndex = 0;
            foreach (var button in buttons)
            {
                sf.CallFunction("SET_DATA_SLOT", btnIndex, button.Key, button.Value);
                btnIndex++;
            }

            sf.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", layout);            
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
            var sf = RequestScaleform("midsized_message");
            sf.CallFunction("SHOW_MIDSIZED_MESSAGE", title, message);
            return sf;
        }
        public static Scaleform MessageMidSizedShared(string title, string message, int bgColor = 0, bool dark = false, bool condensed = false)
        {
            var sf = RequestScaleform("midsized_message");
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
            var sf = RequestScaleform("player_name_01");
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
            var sf = RequestScaleform("mp_car_stats_01");

            string mpHud = "MPCarHUD";
            sf.CallFunction("SET_VEHICLE_INFOR_AND_STATS", vName, title, mpHud, p2, "Top Speed", "Acceleration", "Braking", "Traction", speed, acc, brake, traction);
            return sf;
        }

        #region Private Methods
        private static Scaleform RequestScaleform(string scaleformId)
        {            
            var sf = new Scaleform(scaleformId);            
            while (!sf.IsLoaded) Invoker.Wait(0);
            return sf;
        }
        #endregion

        public enum DataSlotKeys
        {
            DPadUp = 4,
            DPadDown = 5,
            DPadLeft = 6,
            DPadRight = 7,
            DPadNone = 8,
            DPadAll = 9,
            DPadUpDown = 10,
            DPadUpLrefRight = 11,
            LStickUp = 12,
            RStickUp = 13,
            A = 51,
        }
    }
}