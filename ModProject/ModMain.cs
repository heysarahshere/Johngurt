using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(ModProject.ModMain), "Johngurt Test Mod", "1.0.0", "Noah Jimmy Covey")]
[assembly: MelonGame("TVGS", "Schedule I")]

namespace ModProject
{
    public class ModMain : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("JIMMY IS HERE WE DID IT");
        }

        public override void OnUpdate()
        {
        //    if (Input.GetKeyDown(KeyCode.F1))
        //    {
        //        MelonLogger.Msg("IT WAS PUSHED");
        //    }
        }
    }
}