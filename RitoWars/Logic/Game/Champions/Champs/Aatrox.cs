﻿using RitoWars.Logic.Game.Champions.Helpers;

namespace RitoWars.Logic.Game.Champions.Champs
{
    public abstract class Aatrox : BaseChamp
    {
        #region ChampData
        /// <summary>
        /// The champion name
        /// </summary>
        public override string ChampName => "Aatrox";

        /// <summary>
        /// The champion id
        /// </summary>
        public override int ChampId => 266;

        #endregion ChampData

        #region Health
        /// <summary>
        /// The champion's base health at level one
        /// </summary>
        public override double BaseHealth => 622.8;

        /// <summary>
        /// The champion's health gained for leveling up
        /// </summary>
        public override double HealthLevel => 85;

        /// <summary>
        /// The champion's amount of health regen
        /// </summary>
        public override double BaseHealthRegen => 7.09;

        /// <summary>
        /// The champion's health regen gained for leveling up
        /// </summary>
        public override double HealthRegenLevel => 0.5;
        #endregion Health

        #region SecondaryBar
        /// <summary>
        /// The champion's <seealso cref="SecondaryBar"/> resource the champion has
        /// </summary>
        public override SecondaryBar SecondaryBar => SecondaryBar.BloodWell;

        #region SecondaryBarData
        /// <summary>
        /// The champion's base <seealso cref="SecondaryBar"/> amount
        /// </summary>
        public override double BaseSecondaryBarData => 150.6;

        /// <summary>
        /// The champion's <seealso cref="SecondaryBar"/> amount gained for leveling up
        /// </summary>
        public override double SecondaryBarDataLevel => 45;

        /// <summary>
        /// The champion's <seealso cref="SecondaryBar"/> base regen amount
        /// </summary>
        public override double BaseSecondaryBarRegen => 0;

        /// <summary>
        /// The champion's <seealso cref="SecondaryBar"/> regen amount gained for leveling up
        /// </summary>
        public override double SecondaryBarRegenLevel => 0;
        #endregion SecondaryBarData
        #endregion SecondaryBar

        #region Attacks
        /// <summary>
        /// The champion's base attack damage
        /// </summary>
        public override double BaseAttackDamage => 63.576;

        /// <summary>
        /// The champion's attack damage gained for leveling up
        /// </summary>
        public override double AttackDamageLevel => 3.2;

        /// <summary>
        /// The champion's base attack speed
        /// </summary>
        public override double BaseAttackSpeed => 0.651;

        /// <summary>
        /// The champion's attack speed percent gained for leveling up
        /// </summary>
        public override double AttackSpeedPercent => 1.03;

        /// <summary>
        /// The champion's auto attack range
        /// </summary>
        public override double AutoAttackRange => 150;
        #endregion Attacks

        #region Defense
        /// <summary>
        /// The champion's base armor
        /// </summary>
        public override double BaseArmor => 28.184;

        /// <summary>
        /// The champion's armor gained for leveling up
        /// </summary>
        public override double ArmorLevel => 3.8;

        /// <summary>
        /// The champion's base magic resist
        /// </summary>
        public override double BaseMagicResist => 33.35;

        /// <summary>
        /// The champion's magic resist gained for leveling up
        /// </summary>
        public override double MagicResistLevel => 1.3;
        #endregion Defense

        #region CastingResource
        /// <summary>
        /// The champion's <seealso cref="CastingResource"/> for using Q
        /// </summary>
        public override CastingResource Q => CastingResource.Health;

        /// <summary>
        /// The champion's <seealso cref="CastingResource"/> for using W
        /// </summary>
        public override CastingResource W => CastingResource.Health;

        /// <summary>
        /// The champion's <seealso cref="CastingResource"/> for using E
        /// </summary>
        public override CastingResource E => CastingResource.Health;

        /// <summary>
        /// The champion's <seealso cref="CastingResource"/> for using R
        /// </summary>
        public override CastingResource R => CastingResource.Health;
        #endregion CastingResource
    }
}
