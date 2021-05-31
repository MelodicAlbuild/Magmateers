using Magmateers.lib.controller;
using Magmateers.lib.scripts;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Magmateers
{
    class Magmateers : GameMod
    {
        public static readonly string version = "1.0.0";
        public override void Load()
        {
            new Menu();

            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
        {
            switch (scene.name)
            {
                case "MainMenu":
                    GameObject.Find("EarlyAccess").gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "Magmateers " + version;
                    GameObject.Find("SteamBranch").gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "v1.0.0 First Steps";
                    GameObject.Find("Version").gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "Version: " + typeof(Magmateers).Assembly.GetName().Version;
                    break;
                case "Island":
                    new lib.controller.Island();
                    break;
            }
        }

        public override void Unload()
        {
            throw new NotImplementedException();
        }
    }
}
