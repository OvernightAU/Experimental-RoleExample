# Mod Template Usage Guide

## Basic Usage Guide

This document provides a basic guide for using the mod template effectively. Please read through it carefully to ensure you understand the key points and best practices.

### Using Directives

- **Only the first/default script file should have using directives.**
  - The "first/default" script refers to the file named "Main.cs" in scripts folder.

### Roslyn Compiler Limitations

- There are additional limitations related to the Roslyn compiler.
- If you encounter difficulties, please refer to the Roslyn documentation for detailed information and troubleshooting.

### Harmony Patching

- You can utilize Harmony Patching in your mod.
- Be aware that on older devices, Harmony Patching may have limited effectiveness.

### Mod Image Resolution

- Ensure your mod image resolution is **512x512** pixels.
  - If the image exceeds this resolution, it will be automatically resized and might not look as expected.

### Loading Mod Assets

When loading mod assets, follow these guidelines:

- **Use the Correct Path Method**:
  - Instead of using System.IO, use `ModsManager.Instance.GetPathFromMod(Paths.folderName, "insert path")` to get the path to your mod asset.

- **Reading Files**:
  - This is just a wrapper for System.IO, you can still use System.IO along with ModsManager.Instance.GetPathFromMod without any issues at all.
  - To read a file as a string, use `ModsManager.Instance.ReadFromModSTR(Paths.folderName, "insert path")`.
  - To read a file as a byte array, use `ModsManager.Instance.ReadFromMod(Paths.folderName, "insert path")`.

- **Example**
```
// String :
string fromFile = ModsManager.Instance.ReadFromModSTR(Paths.folderName, "resources/targetFile.txt");
UnityEngine.Debug.Log(fromFile);

// Bytes :
byte[] fileBytes = ModsManager.Instance.ReadFromMod(Paths.folderName, "resources/targetFile.bin");
UnityEngine.Debug.Log($"File bytes length: {fileBytes.Length}");
```

By following these methods, you can ensure your mod assets are loaded correctly and efficiently within the limitations of the mod.

## Contribution

Feel free to contribute to this guide or the mod template itself. Contributions help improve the quality and usability for everyone.

---

Thank you for using the mod template! If you have any questions or need further assistance, please don't hesitate to ask.
