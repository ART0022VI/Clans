using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEC;
using Qurre;
using Qurre.API;
using Qurre.API.Events;
using Qurre.Events;
using Player = Qurre.Events.Player;
using static Clans.Config;
namespace Clans
{
    internal class Main : Plugin
    {
        public override string Developer => "ГIеJIbмeнь#3519";
        public override string Name => "Clans";
        public override Version Version => new Version(1, 0, 0);
        public static Config Cfg { get; private set; }
        public override void Disable()
        {
            Player.Join -= OnJoin;
        }

        public override void Enable()
        {
            Cfg = new Config();
            CustomConfigs.Add(Cfg);
            if (!Cfg.IsEnable) return;
            Player.Join += OnJoin;
        }
        public void OnJoin(JoinEvent ev)
        {
            if(ev.Player.Nickname.Contains("[") && ev.Player.Nickname.Contains("]"))
            {
                string[] pre = ev.Player.Nickname.Split('[', ']');
                string tag = pre[1];
                //string nik = ($"[ <color=red> {tag} </color> ]") + ev.Player.Nickname.Split(']');
                //  Log.Info(tag);
                if (Cfg.Clantags.Contains(tag))
                {
                    Qurre.API.Map.ClearBroadcasts();
                    Qurre.API.Map.Broadcast(Cfg.Joinmsg, 6);
                }
            }
        }
    }
}
