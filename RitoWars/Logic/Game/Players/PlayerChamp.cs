using System.Collections.Generic;
using RitoWars.Logic.Game.Champions;
using RitoWars.Logic.Game.Items;

namespace RitoWars.Logic.Game.Players
{
    public class PlayerChamp
    {
        public BaseChamp BaseChamp;

        /// <summary>
        /// The player's current HP
        /// </summary>
        public double CurrentHealthPoints;

        /// <summary>
        /// The player's current HP regen;
        /// </summary>
        public double CurrentHealthRegen;

        /// <summary>
        /// What is the value in the secondary bar (MANA)
        /// </summary>
        public double CurrentSecondaryBarContent;

        /// <summary>
        /// What is the regen value in the secondary bar (MANA)
        /// </summary>
        public double CurrentSecondaryBarRegen;

        /// <summary>
        /// The user's current move speed
        /// </summary>
        public double CurrentMoveSpeed;
        
        /// <summary>
        /// The player's current AD
        /// </summary>
        public double CurrentAttackDamage;

        /// <summary>
        /// The player's current attackspeed
        /// </summary>
        public double CurrentAttackSpeed;

        /// <summary>
        /// The player's current magic resist
        /// </summary>
        public double CurrentMagicResist;

        /// <summary>
        /// The player's current level
        /// </summary>
        public int Level;

        /// <summary>
        /// The player's current xp
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int CurrentXP;

        /// <summary>
        /// The xp needed to level up
        /// </summary>
        //ReSharper disable once InconsistentNaming
        public int XPToLevel;

        /// <summary>
        /// The champion's current crit chance percent
        /// </summary>
        public double CurrentCrit;

        /// <summary>
        /// The damage the player does when they crit
        /// </summary>
        public double CurrentCritDamage;

        /// <summary>
        /// The list of all the player's items
        /// </summary>
        public List<BaseItem> PlayerItems;

        /// <summary>
        /// The amount of gold the player has (425 at start of game)
        /// </summary>
        public int Gold;

        /// <summary>
        /// Does calculation's for when data needs to be changed
        /// Examples are buying items or leveling
        /// </summary>
        public void OnDataChange()
        {
            double healthGain = 0;
            double healthRegenGain = 0;
            foreach (var items in PlayerItems)
            {
                healthGain = healthGain + items.HealthGain;
                healthRegenGain = healthGain + items.HealthRegenGain;
            }
            CurrentHealthPoints = BaseChamp.BaseHealth + BaseChamp.HealthLevel * (Level - 1)+ healthGain;
            CurrentHealthRegen = BaseChamp.BaseHealthRegen + BaseChamp.HealthRegenLevel * (Level - 1) + healthRegenGain;
        }
    }
}
