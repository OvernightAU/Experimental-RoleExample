using System.Collections;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityObject = UnityEngine.Object;
using Kino;
using Hazel;

public class DynamicCode
{
    public void Execute()
    {
        // Paths.folderName is the content folder name of the mod, completely required if you want to load mod assets.
        // Read bytes: ModsManager.Instance.ReadFromMod(Paths.folder, "resources/yourfile.txt")

        if (!DestroyableSingleton<ModsManager>.InstanceExists) return;

        Array.Resize(ref AssetPreloader.MapNames, AssetPreloader.MapNames.Length + 1);
        AssetPreloader.MapNames[AssetPreloader.MapNames.Length - 1] = "Trolley";

        UnityEngine.Debug.Log(ModsManager.Instance.ReadFromModSTR(Paths.folderName, "resources/gyatt.txt"));
        RoleManager.Instance.AddRole<TrolleyRole>();

        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            LoadKanyeWest();
        }

        SceneManager.sceneLoaded += (scene, _) =>
        {
            if (scene.name == "MainMenu")
            {
                LoadKanyeWest();
            }
        };
    }

    internal void LoadKanyeWest()
    {
        string imagePath = ModsManager.Instance.GetPathFromMod(Paths.folderName, "resources/modLogo.png");
        GameObject logo = GameObject.Find("bannerLogo_AmongUs");
        logo.GetComponent<SpriteRenderer>().sprite = ImageUtils.LoadNewSprite(imagePath, 80f, SpriteMeshType.FullRect);
        logo.transform.position = new Vector3(0, 0, -2);
    }
}