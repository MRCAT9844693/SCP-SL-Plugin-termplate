using Exiled.API.Interfaces;

namespace Template_SCP_SL;
/// <summary>
/// Let's begin!
/// now for first we need to set up how the plugin will load on DEBUG or not!
/// So this is also a config to disable and enable the plugin.
/// </summary>


//now we create a class that is public (for all project) and implements the IConfig.
public class Config : IConfig     
{
    public bool IsEnabled { get; set; } = true; //the plugin must be enabled to work.
    public bool Debug { get; set; } = false; //we don't need the Debug.
}