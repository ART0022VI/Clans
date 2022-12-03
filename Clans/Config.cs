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
        public List<String> Clantags { get; set; } = new List<String>()
        {
            "PLM", // e.g.
            "XLT", // e.g.
            "KPB", // e.g.
        };
        [Description("Enable the plugin?")]
        public bool IsEnable { get; set; } = true;
    }
}
