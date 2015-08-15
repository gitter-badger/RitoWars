namespace RitoWars.Logic.Game.Champions.Helpers
{
    /// <summary>
    /// What the champion will use for their castingresource
    /// </summary>
    public enum CastingResource
    {
        /// <summary>
        /// Champion uses their hp
        /// <para>Example champ: Lee Sin</para>
        /// </summary>
        Energy,

        /// <summary>
        /// Champion uses their hp
        /// <para>Example champ: Aatrox</para>
        /// </summary>
        Health,

        /// <summary>
        /// Champion uses their hp
        /// <para>Example champ: Ahri</para>
        /// </summary>
        Mana,

        /// <summary>
        /// Champion uses nothing
        /// <para>Example champ: Yasuo</para>
        /// </summary>
        NoCastingResource
    }
}
