using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qurre;
using Qurre.API;
using Qurre.API.Events;
using Qurre.Events;
using Player = Qurre.Events.Player;
namespace Clans
{
    internal class Main : Plugin
    {
        public override string Developer => "ГIеJIbмeнь#3519";
        public override string Name => "Clans";
        public override Version Version => new Version(1, 0, 0);

        public List<string> plids = new List<string>()
        {
            "PLM",
            "XLT",
        };
        public override void Disable()
        {
            Player.Join -= OnJoin;
        }

        public override void Enable()
        {
            Player.Join += OnJoin;
        }
        public void OnJoin(JoinEvent ev)
        {
            if(ev.Player.Nickname.Contains("[") && ev.Player.Nickname.Contains("]"))
            {
                string[] pre = ev.Player.Nickname.Split('[', ']');
                string tag = pre[1];
              //  Log.Info(tag);
                if (plids.Contains(tag))
                {
                    if (tag == "PLM")
                    {
                        Qurre.API.Map.Broadcast($"Член клана PLM тут, он самый крутой!!!", 4);
                    }
                    else
                    {
                        Qurre.API.Map.Broadcast($"Член клана {tag} зашёл!", 4);
                    }
                }
                else
                {
                    //plids.Add(tag);
                    //Log.Info("добавил");
                    foreach(var p in plids)
                    {
                       //bla bla
                    }
                }
            }
        }
    }
}
