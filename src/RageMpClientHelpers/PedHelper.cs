using RAGE;
using RAGE.Elements;
using RAGE.Game;
using System;
using System.Linq;

namespace RageMpClientHelpers
{
    public static class PedHelper
    {
        /// <summary>
        /// Peds created here are deleted when the Client leaves. They are found in <see cref="RAGE.Elements.Entities.Peds"/>
        /// </summary>
        /// <param name="pedHash"></param>
        /// <param name="pos"></param>
        /// <param name="heading"></param>
        /// <returns></returns>
        public static RAGE.Elements.Ped CreatePed(uint pedHash, Vector3 pos, float heading = 180f)
        {
            //Create safe ground for ped
            Vector3 posSafe = new Vector3();
            while (!Pathfind.GetSafeCoordForPed(pos.X, pos.Y, pos.Z, true, posSafe, 16)) { }

            //Just set the Z pos otherwise get put on nearest pavement, or middle of road.
            pos.Z = posSafe.Z + 0.25f;

            Entities.Peds.All.Add(new RAGE.Elements.Ped(pedHash, pos, heading));

            return Entities.Peds.All.Last();
        }

        /// <summary>
        /// Creates a Ped with scenario sitting on a chair. They're disposed when client leaves if not dealt with
        /// </summary>
        /// <param name="pedHash"></param>
        /// <param name="pos"></param>
        /// <param name="chairprop"></param>
        /// <param name="heading"></param>
        /// <returns>The Ped and the Object</returns>
        public static Tuple<RAGE.Elements.Ped, RAGE.Elements.MapObject> CreatePedOnChair(uint pedHash, Vector3 pos, uint chairprop = 652816835, float heading = 180f)
        {
            var createdPed = CreatePed(pedHash, pos, heading);

            //Create the chair in same position            
            Entities.Objects.All.Add(new MapObject(chairprop, pos, new Vector3(0f, 0f, heading))); //TODO: Add heading

            //Create prop and put on ground.
            var chairObj = Entities.Objects.All.Last();
            RAGE.Game.Object.PlaceObjectOnGroundProperly(chairObj.Handle);

            //Add the animation
            if (!RAGE.Game.Ped.IsPedUsingScenario(createdPed.Handle, "PROP_HUMAN_SEAT_CHAIR_UPRIGHT"))
            {
                Ai.TaskStartScenarioInPlace(createdPed.Handle, "PROP_HUMAN_SEAT_CHAIR_UPRIGHT", -1, false);
            }
            return Tuple.Create(createdPed, chairObj);
        }
    }
}
