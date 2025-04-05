using CommandSystem;
using Exiled.API.Features;

namespace Template_SCP_SL;

/// <summary>
/// Now let's do the Plugin!
/// after the Config.cs we need to create the info for the plugin and also a simple command!
/// </summary>



//let's start by creating the class that will use our configuration (Config.cs)
public class Plugin : Plugin<Config> //here we implemented our configuration!
{
    
    //let's assign some info that Exiled will need to know
    public class Info
    {
        public string Author => "Mrcat!"; //who created the plugin
        public string Version => "1.0.0"; //the version of the plugin
        public string Name => "MyAwsomePlugin"; //the name of the plugin
    }
    
    //now let's do our first command!
    [CommandHandler(typeof(RemoteAdminCommandHandler))] // now we select the type of command I chose the remoteAdmin one
    public class src : ICommand // we implement the Exiled Commands 
    {
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response) // now we set up the src of the command
        {
            //the command src!

            //we check if the player types the correct arguments for plugin!
            if (arguments.Count < 0)
            {
                response = "Please provide at least one argument."; //explain how to type correctly the command.
                return false; //return false because the command is not correct.
            }

            //this is a bolean method so you need a return!
            response = "Thank you for using this plugin!"; 
            return true; //if you have typed correctly the command then it will respond Thank you for using this plugin!
        }

        //info for the plugin
        public string Command => "CustomCommand"; //this is what you need to type in the Remote admin to enable the command.
        public string[] Aliases => new string[] { }; //setting up Aliases.
        public string Description => "CustomCommandDescription"; // a simple description for the plugin! 
    }
    

}
