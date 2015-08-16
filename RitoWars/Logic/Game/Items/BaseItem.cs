using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RitoWars.Logic.Game.Maps;

namespace RitoWars.Logic.Game.Items
{
    public abstract class BaseItem
    {
        #region UniqueItemData
        /// <summary>
        /// The item ID
        /// </summary>
        public abstract int ItemId { get; }
        /// <summary>
        /// The name of the item
        /// </summary>
        public abstract string ItemName { get; }

        /// <summary>
        /// The target map for the item
        /// </summary>
        public abstract MapTypes TargetMap { get; }

        /// <summary>
        /// The cost to buy the item
        /// </summary>
        public abstract int Cost { get; }

        /// <summary>
        /// How many of the item you can buy max (0 for unlimited)
        /// </summary>
        public virtual int ItemLimit => 0;
        #endregion UniqueItemData

        #region Health
        /// <summary>
        /// The health gained for buying the item
        /// </summary>
        public virtual double HealthGain => 0;

        /// <summary>
        /// The health regen gained for buying the item
        /// </summary>
        public virtual double HealthRegenGain => 0;
        #endregion Health

        #region Movement
        public virtual double MovementSpeedGained => 0;


        #endregion
    }
}
