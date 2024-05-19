This is the mod template, here is a basic usage guide:

Only the first/default script file should have using directives. The "first/default" refers to the script executed initially.
It's theoretically possible to use using directives throughout, but it's not recommended. Doing so would make them global,
leading to duplication.

There are additional limitations related to the Roslyn compiler, so refer to their documentation if you encounter difficulties.

You can utilize Harmony Patching, but be aware that on older devices, its effectiveness may be limited.

Your mod image resolution should be 512x512. If it exceeds this resolution, it might not fit properly within the mod box.

When loading external assets, remember:
There is a basic example of how to load files, you need to load them from the mod zip instead of using assembly load.
You cant directly use System.IO, so use the zip wrapper.
For faster code, you can preload them.