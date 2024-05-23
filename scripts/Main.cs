using System.Collections;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityObject = UnityEngine.Object;
using Kino;
using Hazel;
using System.Linq;
using TMPro;
using System.Collections.Generic;

public class DynamicCode
{
    public static AudioClip clip = null;

    public void Execute()
    {
        // Paths.folderName is the content folder name of the mod, completely required if you want to load mod assets.
        // Read bytes: ModsManager.Instance.ReadFromMod(Paths.folder, "resources/yourfile.txt")

        /* PARTIAL MAP EXAMPLE
        Array.Resize(ref AssetPreloader.MapNames, AssetPreloader.MapNames.Length + 1);
        AssetPreloader.MapNames[AssetPreloader.MapNames.Length - 1] = "Trolley";
        */

        // Hook Example => AmongUsClient.Instance.gameObject.AddComponent<HookBehaviour>();

        if (!DestroyableSingleton<ModsManager>.InstanceExists) return;

        clip = AudioUtils.LoadAudioClipFromFile(ModsManager.Instance.GetPathFromMod(Paths.folderName, "resources/audio/explode.wav"));

        Sprite explodeSprite = ImageUtils.LoadNewSprite(ModsManager.Instance.GetPathFromMod(Paths.folderName, "resources/images/explode.png"), 100f, SpriteMeshType.FullRect);
        RoleManager.Instance.AddSprite("explodeSprite", explodeSprite.texture, 720f);

        RoleManager.Instance.AddRole<BomberRole>();

        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            AddWaterMrk();
        }

		SceneManager.activeSceneChanged += delegate(Scene oldScene, Scene scene)
		{
            if (scene.name == "MainMenu")
            {
                AddWaterMrk();
            }
		};
    }

    internal void AddWaterMrk()
    {
        Coroutines.Instance.StartCoroutine(AddWaterMrkCoroutine());
    }

    private IEnumerator AddWaterMrkCoroutine()
    {
        yield return new WaitForSeconds(0.05f); // Wait for code execution

        GameObject.Find("VersionShower").GetComponent<TextMeshPro>().text += "\nBomber role loaded :)";
    }
}