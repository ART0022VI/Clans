using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qurre.API.Addons;

namespace Clans
{
    internal class Config : IConfig
    {
        private static object tag;

        public string Name { get; set; } = "Clans";
        public List<String> Clantags { get; set; } = new List<String>() // Tags list
        {
            "PLM", // e.g.
            "XLT", // e.g.
            "KPB", // e.g.
        };


        [Description("Enable the plugin?")]
        public bool IsEnable { get; set; } = true;


        [Description("Join msg")]
        public string Joinmsg { get; set; } = $"<color=green>Член клана <color=red> <<{tag}>> </color> зашёл!</color>"; //EN: $"<color=green>Member of <color=red> <<{tag}>> </color> connected!</color>"
    }
}
