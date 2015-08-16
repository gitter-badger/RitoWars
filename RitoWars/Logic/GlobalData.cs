using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RitoWars.Logic.Game.Players;

namespace RitoWars.Logic
{
    public static class GlobalData
    {
        /// <summary>
        /// The players on the blue team
        /// </summary>
        public static List<Player> TeamOnePlayers = new List<Player>();

        /// <summary>
        /// The players on the purple/red team
        /// </summary>
        public static List<Player> TeamTwoPlayers = new List<Player>();

        /// <summary>
        /// List of all developers
        /// </summary>
        public static readonly string[] Devs = { "eddy5641" };
    }
}
