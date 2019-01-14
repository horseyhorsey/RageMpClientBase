namespace RageMpClientHelpers
{    
    public static class ControlHelper
    {
        private static bool AttacksEnabled { get; set; }

        /// <summary>
        /// Enable the controls for the player to attack and melee, should be called every tick. Useful for Safe Zones.
        /// </summary>
        /// <param name="enabled"></param>
        public static void EnablePlayerAttacks(bool enabled)
        {
            AttacksEnabled = enabled;

            if (AttacksEnabled)
            {
                RAGE.Game.Pad.EnableControlAction(0, (int)RAGE.Game.Control.SelectWeapon, true);
                RAGE.Game.Pad.EnableControlAction(0, (int)RAGE.Game.Control.SelectNextWeapon, true);
                RAGE.Game.Pad.EnableControlAction(0, (int)RAGE.Game.Control.SelectPrevWeapon, true);
                RAGE.Game.Pad.EnableControlAction(0, (int)RAGE.Game.Control.MeleeAttack1, true);
                RAGE.Game.Pad.EnableControlAction(0, (int)RAGE.Game.Control.MeleeAttack2, true);
                RAGE.Game.Pad.EnableControlAction(0, (int)RAGE.Game.Control.MeleeAttackAlternate, true);
                RAGE.Game.Pad.EnableControlAction(0, (int)RAGE.Game.Control.MeleeAttackHeavy, true);
                RAGE.Game.Pad.EnableControlAction(0, (int)RAGE.Game.Control.MeleeAttackLight, true);
                RAGE.Game.Pad.EnableControlAction(0, (int)RAGE.Game.Control.MeleeBlock, true);
            }
            else
            {
                RAGE.Game.Pad.DisableControlAction(0, (int)RAGE.Game.Control.SelectWeapon, true);
                RAGE.Game.Pad.DisableControlAction(0, (int)RAGE.Game.Control.SelectNextWeapon, true);
                RAGE.Game.Pad.DisableControlAction(0, (int)RAGE.Game.Control.SelectPrevWeapon, true);
                RAGE.Game.Pad.DisableControlAction(0, (int)RAGE.Game.Control.MeleeAttack1, true);
                RAGE.Game.Pad.DisableControlAction(0, (int)RAGE.Game.Control.MeleeAttack2, true);
                RAGE.Game.Pad.DisableControlAction(0, (int)RAGE.Game.Control.MeleeAttackAlternate, true);
                RAGE.Game.Pad.DisableControlAction(0, (int)RAGE.Game.Control.MeleeAttackHeavy, true);
                RAGE.Game.Pad.DisableControlAction(0, (int)RAGE.Game.Control.MeleeAttackLight, true);
                RAGE.Game.Pad.DisableControlAction(0, (int)RAGE.Game.Control.MeleeBlock, true);
                RAGE.Elements.Player.LocalPlayer.SetCurrentWeapon(2725352035, true);
            }
        }
    }
}
