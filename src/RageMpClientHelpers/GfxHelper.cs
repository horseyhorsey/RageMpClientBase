using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RageMpHelper
{
    public static class GfxHelper
    {
        public static void ClearCycle()
        {
            RAGE.Game.Graphics.ClearTimecycleModifier();
        }

        /// <summary>
        /// This sets a timecyle from id (1 - 774)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="strength"></param>
        /// <param name="clearCycle"></param>
        /// <returns>the name of the cycle playing</returns>
        public static string SetTimeCycleById(int id, float strength = 0.5f, bool clearCycle = true)
        {
            if (clearCycle == true)
                ClearCycle();

            //Get cycle by id in dict
            if (id < 0) id = 1;
            if (id <= RageMpClientShared.TimeCycle.TimeCycleMods.Count)
            {
                var cycle = RageMpClientShared.TimeCycle.TimeCycleMods[id];
                SetCycleAndModifier(cycle, strength);
                return cycle;
            }

            return string.Empty;
        }

        /// <summary>
        /// Sets a cycle searching name in dictionary
        /// </summary>
        /// <param name="name"></param>
        /// <param name="strength"></param>
        /// <param name="clearCycle"></param>
        /// <returns></returns>
        public static bool SetTimeCycleByName(string name, float strength = 0.5f, bool clearCycle = true)
        {
            if (clearCycle == true)
                ClearCycle();

            if (RageMpClientShared.TimeCycle.TimeCycleMods.ContainsValue(name))
            {
                var cycle = RageMpClientShared.TimeCycle.TimeCycleMods.
                    Values.FirstOrDefault(x => x == name);

                SetCycleAndModifier(cycle, strength);
            }

            return false;
        }

        /// <summary>
        /// Sets a timecycle if given correct cycle name
        /// </summary>
        /// <param name="cycle"></param>
        /// <param name="strength"></param>
        public static void SetCycleAndModifier(string cycle, float strength)
        {
            RAGE.Game.Graphics.SetTimecycleModifier(cycle);
            RAGE.Game.Graphics.SetTimecycleModifierStrength(strength);
        }
    }
}
