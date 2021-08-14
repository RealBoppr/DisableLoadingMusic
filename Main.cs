using System.Collections;
using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(DisableLoadingMusic.Main), "DisableLoadingMusic", "1.1", "Boppr")]
[assembly: MelonGame("VRChat", "VRChat")]

namespace DisableLoadingMusic
{
    public class Main : MelonMod
    {
        public override void OnApplicationStart() => MelonCoroutines.Start(CheckUIManager());
        private IEnumerator CheckUIManager()
        {
            while (VRCUiManager.prop_VRCUiManager_0 == null) { yield return null; }
            GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/LoadingSound").SetActive(false);
            GameObject.Find("UserInterface/LoadingBackground_TealGradient_Music/LoadingSound").SetActive(false);
        }
    }
}
