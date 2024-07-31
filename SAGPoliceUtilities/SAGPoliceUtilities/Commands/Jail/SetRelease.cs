﻿using System.Collections.Generic;
using Rocket.API;
using Rocket.Unturned.Player;

namespace SAGPoliceUtilities.Commands.JailCommands
{
    public class SetRelease : IRocketCommand
    {
        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer unturnedPlayer = (UnturnedPlayer)caller;

            SAGPoliceUtilities.Instance.Configuration.Instance.RelaseLocation = unturnedPlayer.Position;
            SAGPoliceUtilities.Instance.Configuration.Save();
        }

        public AllowedCaller AllowedCaller => AllowedCaller.Player;
        public string Name => "setrelease";
        public string Help => "Sets the universal release position.";
        public string Syntax => "/setrelease";
        public List<string> Aliases => new List<string>();
        public List<string> Permissions => new List<string> { "jailmanager" };
    }
}