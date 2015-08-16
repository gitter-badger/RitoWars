using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RitoWars.Logic.Game.Players
{
    public class Player
    {
        /// <summary>
        /// The player's username
        /// </summary>
        public string Username;

        /// <summary>
        /// The player's user id
        /// </summary>
        public int UserId;

        /// <summary>
        /// The player's champion id
        /// </summary>
        public int ChampId;

        /// <summary>
        /// The champion data for the player
        /// </summary>
        public PlayerChamp PlayerChamp;
    }
}
