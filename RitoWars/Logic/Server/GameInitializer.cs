using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using RitoWars.Logic.Game.Players;

namespace RitoWars.Logic.Server
{
    public class GameInitializer
    {
        public GameInitializer(IPEndPoint ipEndPoint, string serverKey, List<Player> teamBluePlayers, List<Player> teamRedPlayers)
        {
            var server = new UdpClient(ipEndPoint);

        }
    }
}
