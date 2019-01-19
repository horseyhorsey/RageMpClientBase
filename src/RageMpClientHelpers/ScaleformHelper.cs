using RAGE;
using RAGE.Game;
using System;
using System.Collections.Generic;

namespace RageMpClientHelpers
{
    public static class ScaleformHelper
    {

        /// <summary>
        /// Phoneapps? White note in middle of screen
        /// </summary>
        /// <returns></returns>
        public static Scaleform AppJobList()
        {
            var sf = RequestScaleform("APP_JOB_LIST");
            return sf;
        }

        /// <summary>
        /// Phoneapps? Displays no signal
        /// </summary>
        /// <returns></returns>
        public static Scaleform AppSecuroserv()
        {
            var sf = RequestScaleform("APP_SECUROSERV_HACKING");

            //sf.CallFunction("APP_FUNCTION");
            //sf.CallFunction("CLOSE_APP");
            return sf;
        }

        /// <summary>
        /// Phoneapps?
        /// </summary>
        /// <returns></returns>
        public static Scaleform AppTrakify()
        {
            var sf = RequestScaleform("APP_TRACKIFY");

            //sf.CallFunction("APP_FUNCTION");
            //sf.CallFunction("CLOSE_APP");
            return sf;
        }

        #region ATM
        public static Scaleform AtmInit()
        {
            var sf = RequestScaleform("ATM");
            //sf.CallFunction("INITIALISE");                 
            sf.CallFunction("SET_DATA_SLOT_EMPTY", 0);
            sf.CallFunction("UPDATE_TEXT", 0);
            sf.CallFunction("SET_DATA_SLOT", 0);
            sf.CallFunction("SET_DATA_SLOT", 2);
            sf.CallFunction("SET_DATA_SLOT", 1);
            sf.CallFunction("DISPLAY_MENU");
            sf.CallFunction("navigate", -1);

            //sf.CallFunction("enterPINanim");
            //sf.CallFunction("DISPLAY_MENU");
            //sf.CallFunction("update");
            //sf.CallFunction("SHOW_CURSOR", true);
            
            return sf;
        }
        public static void AtmPin(Scaleform atmScaleform)
        {
            atmScaleform.CallFunction("pinBeep");
        }
        public static void AtmDisplayTransactions(Scaleform atmScaleform)
        {
            atmScaleform.CallFunction("CLEAR_ALL");
            atmScaleform.CallFunction("SET_DATA_SLOT", 0);
            BeginTextCommand("MPATM_LOG");
            atmScaleform.CallFunction("SET_DATA_SLOT", 1);
            BeginTextCommand("MPATM_BACK");
            atmScaleform.CallFunction("DISPLAY_TRANSACTIONS");
        }
        public static void AtmDisplayCashOptions(Scaleform atmScaleform)
        {
            atmScaleform.CallFunction("SET_DATA_SLOT", 0);
            BeginTextCommand("MPATM_WITMT");

            int balance = 10000;
            atmScaleform.CallFunction("SET_DATA_SLOT", 1);

            RAGE.Game.Graphics.BeginTextCommandScaleformString("ESDOLLA");
            RAGE.Game.Ui.AddTextComponentFormattedInteger(balance, true);
            RAGE.Game.Graphics.EndTextCommandScaleformString();
            Graphics.PopScaleformMovieFunctionVoid();

            atmScaleform.CallFunction("SET_DATA_SLOT", 4);
            BeginTextCommand("MPATM_BACK");

            atmScaleform.CallFunction("SET_DATA_SLOT", 5);
            RAGE.Game.Graphics.BeginTextCommandScaleformString("ESDOLLA");
            RAGE.Game.Ui.AddTextComponentFormattedInteger(balance, true);
            Graphics.PopScaleformMovieFunctionVoid();

            atmScaleform.CallFunction("DISPLAY_CASH_OPTIONS", 0);
        }
        public static void AtmDisplayBalance(Scaleform atmScaleform, int balance = 10000)
        {
            atmScaleform.CallFunction("CLEAR_ALL");
            atmScaleform.CallFunction("SET_DATA_SLOT", 0);

            //Comma seperate cash
            RAGE.Game.Graphics.BeginTextCommandScaleformString("MPATM_XDOL");
            RAGE.Game.Ui.AddTextComponentFormattedInteger(balance, true);
            RAGE.Game.Graphics.EndTextCommandScaleformString();
            Graphics.PopScaleformMovieFunctionVoid();

            atmScaleform.CallFunction("SET_DATA_SLOT", 1);
            BeginTextCommand("MO_YES");

            atmScaleform.CallFunction("SET_DATA_SLOT", 2);
            BeginTextCommand("MO_NO");

            atmScaleform.CallFunction("DISPLAY_MESSAGE");
            atmScaleform.CallFunction("DISPLAY_BALANCE");
            Graphics.PopScaleformMovieFunctionVoid();
        } 
        #endregion

        static void BeginTextCommand(string textCommand)
        {
            RAGE.Game.Graphics.BeginTextCommandScaleformString(textCommand);
            RAGE.Game.Graphics.EndTextCommandScaleformString();
            Graphics.PopScaleformMovieFunctionVoid();
        }

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
        /// TODO
        /// </summary>
        /// <param name="title"></param>
        /// <param name="weaponName"></param>
        /// <param name="weaponHash"></param>
        /// <returns></returns>
        public static Scaleform BikerMissionWall()
        {
            var sf = RequestScaleform("Biker_Mission_Wall");            
            return sf;
        }

        /// <summary>
        /// Webpage?
        /// </summary>
        /// <returns></returns>
        public static Scaleform BikerBusinesses()
        {
            var sf = RequestScaleform("BIKER_BUSINESSES");
            sf.CallFunction("SHOW_HOMEPAGE");
            return sf;
        }

        /// <summary>
        /// Scrolling text with scanlines
        /// </summary>
        /// <returns></returns>
        public static Scaleform BlimpText()
        {
            var sf = RequestScaleform("BLIMP_TEXT");
            sf.CallFunction("SHOW_HOMEPAGE");
            sf.CallFunction("SET_SCROLL_SPEED", 2);
            sf.CallFunction("SET_COLOUR", 2);
            sf.CallFunction("SET_MESSAGE", "blimp msg");
            sf.CallFunction("startScroll", 2000, 5);
            return sf;
        }

        public static Scaleform CameraGallery()
        {
            var sf = RequestScaleform("CAMERA_GALLERY");
            sf.CallFunction("DISPLAY_VIEW", 1);
            return sf;
        }

        /// <summary>
        /// NOT WORKING
        /// </summary>
        /// <returns></returns>
        public static Scaleform ContactList()
        {
            var sf = RequestScaleform("CONTACTLIST");
            sf.CallFunction("createContact", 1);
            sf.CallFunction("renderContainers");
            sf.CallFunction("SHOW");
            return sf;
        }

        /// <summary>
        /// NOT WORKING
        /// </summary>
        /// <returns></returns>
        public static Scaleform CustomWarningScreenShow()
        {
            var sf = RequestScaleform("CUSTOM_WARNING_SCREEN");
            sf.CallFunction("SHOW_CUSTOM_WARNING_SCREEN");            
            return sf;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <returns></returns>
        public static Scaleform CellPhoneIFruit()
        {
            var sf = RequestScaleform("CELLPHONE_IFRUIT");
            //sf.CallFunction("createContact", 1);
            //sf.CallFunction("renderContainers");
            //sf.CallFunction("SHOW");
            return sf;
        }

        /// <summary>
        /// TODO: Need to invoke this on timer? 3 2 1 GO
        /// </summary>
        /// <returns></returns>
        public static Scaleform CountDown(string msg = "Message")
        {
            var sf = RequestScaleform("COUNTDOWN");
            sf.CallFunction("SET_MESSAGE", "1", 255, 255, 255, true);            
            sf.CallFunction("SET_MESSAGE", "2", 255, 255, 255, true);
            sf.CallFunction("SET_MESSAGE", "3", 255, 255, 255, true);
            //sf.CallFunction("FADE_MP");
            //sf.CallFunction("renderContainers");
            //sf.CallFunction("SHOW");
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

        /// <summary>
        /// TODO
        /// </summary>
        /// <returns></returns>
        public static Scaleform DigitalCamera()
        {
            var sf = RequestScaleform("DIGITAL_CAMERA");

            sf.CallFunction("iniScreenLayout");

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

        /// <summary>
        /// Shows a grid layout with reolution etc
        /// </summary>
        /// <returns></returns>
        public static Scaleform GridLayout()
        {
            var sf = RequestScaleform("GRID_LAYOUT");

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
        /// Display Dart chalked board
        /// </summary>
        /// <returns></returns>
        public static Scaleform MinigameDarts()
        {
            var sf = RequestScaleform("DARTS_SCOREBOARD_BIKER");
            sf.CallFunction("SET_PLAYER_SETS_AND_LEGS", 3, 3, 1, 1);
            sf.CallFunction("SET_DARTS_PLAYER_NAMES", "p1", "p2");
            return sf;
        }

        /// <summary>
        /// Works, no ticker moving
        /// </summary>
        /// <returns></returns>
        public static Scaleform NewsTicker()
        {
            var sf = RequestScaleform("breaking_news");
            sf.CallFunction("CLEAR_SCROLL_TEXT", 0);            
            return sf;
        }

        /// <summary>
        /// Works, no ticker moving
        /// </summary>
        /// <returns></returns>
        public static void NewsTickerSetText(Scaleform newsScaleform, string title, string subtitle, 
            string scrollTxt, float scrollSpeed = 0)
        {
            newsScaleform.CallFunction("SET_TEXT", title, subtitle);
            newsScaleform.CallFunction("SET_SCROLL_TEXT", 0f, 0f, scrollTxt);
            newsScaleform.CallFunction("SET_SCROLL_TEXT", 0f, 1f, scrollTxt);
            newsScaleform.CallFunction("SET_SCROLL_TEXT", 0f, 2f, scrollTxt);
            newsScaleform.CallFunction("SET_SCROLL_TEXT", 0f, 3f, scrollTxt);            
        }

        /// <summary>
        /// Render3D above the player.....or wherever
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Scaleform PlayerName(string name)
        {
            var sf = RequestScaleform("player_name");
            sf.CallFunction("SET_PLAYER_NAME", name);
            return sf;
        }

        public static Scaleform Leaderboard()
        {
            var sf = RequestScaleform("sc_leaderboard");
            sf.CallFunction("SET_DISPLAY_TYPE");
            sf.CallFunction("SET_MULTIPLAYER_TITLE", "LEADERBOARD");
            sf.CallFunction("SET_TITLE", "TITLE");

            sf.CallFunction("SET_SLOT_STATE", 0, 1);
            sf.CallFunction("SET_SLOT", 0, 1);

            RAGE.Game.Graphics.BeginTextCommandScaleformString("NUMBER");
            Ui.AddTextComponentInteger(1);
            Graphics.EndTextCommandScaleformString();
            Graphics.PopScaleformMovieFunctionVoid();            
            return sf;
        }

        public static Scaleform MpCelebration()
        {
            var sf = RequestScaleform("MP_CELEBRATION");
            var val = sf.CallFunctionReturn("CLEANUP");
            sf.CallFunction("CREATE_STAT_WALL");
            Chat.Output($"Mpcelebrate val : {val}");
            return sf;
        }

        /// <summary>
        /// Shows a small rank bar
        /// </summary>
        /// <returns></returns>
        public static Scaleform MpFreeModeCard(string str1 = "Player", string str2 = "Rank")
        {
            var sf = RequestScaleform("mp_mm_card_freemode");
            sf.CallFunction("SET_DATA_SLOT_EMPTY", 0, 0);
            sf.CallFunction("SET_DATA_SLOT_EMPTY", 0, 1);
            sf.CallFunction("SET_DATA_SLOT", 0);
            sf.CallFunction("SET_TITLE", str1, str2, 2);
            sf.CallFunction("SET_ICON", 0, 4, 5);
            return sf;
        }

        /// <summary>
        /// Displays yellow Title, and a small panel with given rows
        /// </summary>
        /// <returns></returns>
        public static Scaleform MpResultsPanel(string title, string subtitle, List<string> rows)
        {
            var sf = RequestScaleform("MP_RESULTS_PANEL");            
            sf.CallFunction("initScreenLayout");
            sf.CallFunction("SET_TITLE", title);
            sf.CallFunction("SET_SUBTITLE", subtitle);

            int i = 0;
            foreach (var row in rows)
            {
                sf.CallFunction("SET_SLOT", i, true, row);
                i++;
            }
            
            sf.CallFunction("updateDisplay");
            return sf;
        }

        /// <summary>
        /// NOT WORKING
        /// </summary>
        /// <returns></returns>
        public static Scaleform PauseMpMenuFriendslist()
        {
            var sf = RequestScaleform("PAUSE_MP_MENU_FRIENDS_LIST");

            sf.CallFunction("SET_DATA_SLOT", 0, 0);
            sf.CallFunction("UPDATE_SLOT", 0, 0);
            sf.CallFunction("DISPLAY_VIEW", 0, 0);
            sf.CallFunction("SET_HIGHLIGHT", 0);            
            return sf;
        }

        /// <summary>
        /// NOT WORKING
        /// </summary>
        /// <returns></returns>
        public static Scaleform PauseMenuCharacterCard()
        {
            var sf = RequestScaleform("PAUSE_MENU_CHARACTER_CARD");            
            sf.CallFunction("SET_TITLE", "Title", "Description");
            sf.CallFunction("SET_DESCRIPTION", "HelpString", false); // p2 flash help
            sf.CallFunction("DISPLAY_VIEW", 0, 0);

            return sf;
        }

        /// <summary>
        /// Big title text, small strapline description
        /// </summary>
        /// <returns></returns>
        public static Scaleform PowerPlayGeneric(string title, string strapline)
        {
            var sf = RequestScaleform("POWER_PLAY_GENERIC");
            sf.CallFunction("ADD_TEAM", 22);

            //sf.CallFunction("ADD_ICON", 1);
            sf.CallFunction("SET_ICON_SCORE", 1, 2000, 1);
            sf.CallFunction("SET_ICON_METER", 1);
            sf.CallFunction("SET_ICON_METER", 1);
            sf.CallFunction("ACTIVATE_ICON", 1, 1);

            
            sf.CallFunction("updateLayout");
            sf.CallFunction("SHOW_MESSAGE", title, strapline, 1);

            return sf;
        }

        /// <summary>
        /// NOT focused
        /// </summary>
        /// <returns></returns>
        public static Scaleform TextEntry()
        {
            var sf = RequestScaleform("TEXT_INPUT_BOX");
            sf.CallFunction("TEXT_INPUT_BOX");            
            return sf;
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