using MelonLoader;
using UnityEngine;

namespace DisableLoadingMusic
{
    public class Class : MelonMod
    {
        public override void VRChat_OnUiManagerInit()
        {
            GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/LoadingSound").SetActive(false);
            GameObject.Find("UserInterface/LoadingBackground_TealGradient_Music/LoadingSound").SetActive(false);
        }
    }
}
