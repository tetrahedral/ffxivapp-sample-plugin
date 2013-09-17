ffxivapp-sample-plugin
======================

## Initial Release:
Please make sure you change the GUID in the sample. A good idea would be to open the project up in VS2012 and export the entire thing as a project template.

Once you do that; you can create new project as you go and rename them to what you need. The build locations would need to be updated as well as the GUID in this case.

## Requirements

* Nuget package manager
 * Restore packages once installed
* VS2012
* .NET4.5 installed

You will have to copy the following files from the most recent version of the app and update the system references:

* FFXIVAPP.Common.dll
* FFXIVAPP.IPluginInterface.dll
* MahApps.Metro.dll
* System.Windows.Interactivity.dll

## Notes:

I've tried to give an example of most of the binding features available. If you have a question please post it in the issues section as such and I can address the response there for everyone to see.

Thanks!
