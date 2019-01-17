using RAGE.Game;
using RageMpClientShared;
using System;
using System.Collections.Generic;

namespace RageMpClientHelpers
{
    public static class PlayerHelper
    {
        #region Fields
        private const int HUD_RANK_ID = 19;
        private const int HUD_RANK_COLOR = 116;
        private static bool IsFrozen = false;
        #endregion

        /// <summary>
        /// Displays the player levelling up. currlevel, prevXp, currXp, limit, nextLimit
        /// </summary>
        public static void DisplayLevelUpScaleform(IList<int> lvl, int hudRankId = 0, int hudRankColor = 0)
        {
            //Get vals from list of numbers
            var currentLevel = lvl[0];
            var prevXp = lvl[1]; var currentXP = lvl[2];
            var limit = lvl[3]; var nextLimit = lvl[4];

            //Get colors if provided in sig
            var hudId = hudRankId == 0 ? HUD_RANK_ID : hudRankId;
            var hudColor = hudRankColor == 0 ? HUD_RANK_COLOR : hudRankColor;

            //Make sure scaleform ready before pushing
            if (!Graphics.HasHudScaleformLoaded(hudId))
            {
                Graphics.RequestHudScaleform(hudId);

                while (!Graphics.HasHudScaleformLoaded(hudId)) Invoker.Wait(0);

                Graphics.PushScaleformMovieFunctionFromHudComponent(hudId, "SET_COLOUR");
                Graphics.PushScaleformMovieFunctionParameterInt(hudColor);
                Graphics.PopScaleformMovieFunctionVoid();
            }

            Graphics.PushScaleformMovieFunctionFromHudComponent(hudId, "SET_RANK_SCORES");
            Graphics.PushScaleformMovieFunctionParameterInt(limit);         // Limit
            Graphics.PushScaleformMovieFunctionParameterInt(nextLimit);     // Next Limit
            Graphics.PushScaleformMovieFunctionParameterInt(prevXp);        // previous XP
            Graphics.PushScaleformMovieFunctionParameterInt(currentXP);     // Current XP
            Graphics.PushScaleformMovieFunctionParameterInt(currentLevel);  // Current Level
            Graphics.PopScaleformMovieFunctionVoid();
        }

        public static void WastedClear()
        {
            GfxHelper.ScreenFxStop(ScreenEffect.DeathFailMPIn);
            ChatHelper.EnableChat(true);
            UiHelper.EnableHuds(true);
            RAGE.Game.Misc.SetTimeScale(1);
        }

        /// <summary>
        /// Freezes the player and their controls
        /// </summary>
        /// <param name="player"></param>
        /// <param name="freeze"></param>
        /// <param name="freezeCtrl"></param>
        public static void FreezePlayer(bool freeze, bool freezeCtrl = false)
        {
            IsFrozen = freeze;
            if (IsFrozen)                
                RAGE.Elements.Player.LocalPlayer.FreezePosition(true);
            else
                RAGE.Elements.Player.LocalPlayer.FreezePosition(false);

            if (!freezeCtrl)
                Pad.EnableAllControlActions(0);
            else
                Pad.DisableAllControlActions(0);
        }

        public static void WastedStart()
        {
            GfxHelper.ScreenFxStart(ScreenEffect.DeathFailMPIn);
            UiHelper.EnableHuds(false, false);
            ChatHelper.EnableChat(false);
            RAGE.Game.Misc.SetTimeScale(0.2f);
        }
    }
}
