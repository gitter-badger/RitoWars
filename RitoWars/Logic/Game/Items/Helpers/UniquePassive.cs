using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RitoWars.Logic.Game.Items.Helpers
{
    public enum UniquePassive
    {
        /// <summary>
        /// Boots
        /// </summary>
        EnhancedMovement,

        /// <summary>
        /// Recurve Bow
        /// </summary>
        BasicAttackExtraDamage = 1043,

        /// <summary>
        /// Doran's Shield
        /// </summary>
        BlockDamageFromTargetShowdown = 1074,

        /// <summary>
        /// Doran's Shield
        /// </summary>
        BlockDamageFromTarget = 1054,

        /// <summary>
        /// Prospector's blade and ring
        /// </summary>
        Prospector,

        /// <summary>
        /// Boot enchantemtn
        /// </summary>
        Furor,

        Alarcrity,
        Captain,
        Distortain,
        Homeguard,
        CrytallineFlaskCharges = 2041,
        WardRefresh,
        GuardianHornCooldown = 2051,

    }
}
