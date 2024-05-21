# Mod Template Usage Guide

## Basic Usage Guide

This document provides a basic guide for using the mod template effectively. Please read through it carefully to ensure you understand the key points and best practices.

### Using Directives

- **Only the first/default script file should have using directives.**
  - The "first/default" script refers to the one first one in "ScriptExecutionOrder" list in json

### Roslyn Compiler Limitations

- There are additional limitations related to the Roslyn compiler.
- If you encounter difficulties, please refer to the Roslyn documentation for detailed information and troubleshooting.

### Harmony Patching

- You can utilize Harmony Patching in your mod.
- Be aware that on older devices, Harmony Patching may have limited effectiveness.

### Mod Image Resolution

- Ensure your mod image resolution is **512x512** pixels.
  - If the image exceeds this resolution, it might not fit properly within the mod box.

### Loading External Assets

- When loading external assets, remember the following:
  - You need to load files from the mod zip instead of using assembly load.
  - Direct use of System.IO is not allowed, so use the zip wrapper provided.
  - For faster code execution, consider preloading your assets.

## Contribution

Feel free to contribute to this guide or the mod template itself. Contributions help improve the quality and usability for everyone.

---

Thank you for using the mod template! If you have any questions or need further assistance, please don't hesitate to ask.
