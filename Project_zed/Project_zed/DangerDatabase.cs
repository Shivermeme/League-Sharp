// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DangerDatabase.cs" company="">
//   
// </copyright>
// <summary>
//   The hit type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Project_zed
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using LeagueSharp;

    /// <summary>
    ///     The hit type.
    /// </summary>
    public enum HitType
    {
        /// <summary>
        ///     The none.
        /// </summary>
        None, 

        /// <summary>
        ///     The auto attack.
        /// </summary>
        AutoAttack, 

        /// <summary>
        ///     The minion attack.
        /// </summary>
        MinionAttack, 

        /// <summary>
        ///     The turret attack.
        /// </summary>
        TurretAttack, 

        /// <summary>
        ///     The spell.
        /// </summary>
        Spell, 

        /// <summary>
        ///     The danger.
        /// </summary>
        Danger, 

        /// <summary>
        ///     The ultimate.
        /// </summary>
        Ultimate, 

        /// <summary>
        ///     The crowd control.
        /// </summary>
        CrowdControl, 

        /// <summary>
        ///     The stealth.
        /// </summary>
        Stealth, 

        /// <summary>
        ///     The force exhaust.
        /// </summary>
        ForceExhaust
    }

    /// <summary>
    ///     The spelldata.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", 
        Justification = "Reviewed. Suppression is OK here.")]
    public class Spelldata
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes static members of the <see cref="Spelldata" /> class.
        /// </summary>
        static Spelldata()
        {
            Spells = new List<Spelldata>();

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "aatroxq", ChampionName = "aatrox", Slot = SpellSlot.Q, CastRange = 650f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileName = string.Empty, MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "aatroxw", ChampionName = "aatrox", Slot = SpellSlot.W, CastRange = 0f, Delay = 0f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "aatroxw2", ChampionName = "aatrox", Slot = SpellSlot.W, CastRange = 0f, Delay = 0f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "aatroxe", ChampionName = "aatrox", Slot = SpellSlot.E, CastRange = 1025f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "aatroxeconemissile", MissileSpeed = 1250
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "aatroxr", ChampionName = "aatrox", Slot = SpellSlot.R, CastRange = 0f, Delay = 0f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ahriorbofdeception", ChampionName = "ahri", Slot = SpellSlot.Q, CastRange = 880f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "ahriorbmissile", 
                        ExtraMissileNames = new[] { "ahriorbreturn" }, MissileSpeed = 1450
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ahrifoxfire", ChampionName = "ahri", Slot = SpellSlot.W, CastRange = 550f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1800
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ahriseduce", ChampionName = "ahri", Slot = SpellSlot.E, CastRange = 975f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileName = "ahriseducemissile", MissileSpeed = 1550
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ahritumble", ChampionName = "ahri", Slot = SpellSlot.R, CastRange = 600f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 2200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "akalimota", ChampionName = "akali", Slot = SpellSlot.Q, CastRange = 600f, 
                        Delay = 650f, HitType = new HitType[] { }, MissileSpeed = 1000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "akalismokebomb", ChampionName = "akali", Slot = SpellSlot.W, CastRange = 1000f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Stealth }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "akalishadowswipe", ChampionName = "akali", Slot = SpellSlot.E, CastRange = 325f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "akalishadowdance", ChampionName = "akali", Slot = SpellSlot.R, CastRange = 710f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 2200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "pulverize", ChampionName = "alistar", Slot = SpellSlot.Q, CastRange = 365f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "headbutt", ChampionName = "alistar", Slot = SpellSlot.W, CastRange = 650f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "triumphantroar", ChampionName = "alistar", Slot = SpellSlot.E, CastRange = 0f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "feroucioushowl", ChampionName = "alistar", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = 828
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "bandagetoss", ChampionName = "amumu", Slot = SpellSlot.Q, CastRange = 1100f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileName = "sadmummybandagetoss", MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "auraofdespair", ChampionName = "amumu", Slot = SpellSlot.W, CastRange = 300f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "tantrum", ChampionName = "amumu", Slot = SpellSlot.E, CastRange = 350f, Delay = 150f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "curseofthesadmummy", ChampionName = "amumu", Slot = SpellSlot.R, CastRange = 550f, 
                        Delay = 150f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileName = string.Empty, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "flashfrost", ChampionName = "anivia", Slot = SpellSlot.Q, CastRange = 1150f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "flashfrostspell", MissileSpeed = 850
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "crystalize", ChampionName = "anivia", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "frostbite", ChampionName = "anivia", Slot = SpellSlot.E, CastRange = 650f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = 1450
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "glacialstorm", ChampionName = "anivia", Slot = SpellSlot.R, CastRange = 625f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "disintegrate", ChampionName = "annie", Slot = SpellSlot.Q, CastRange = 625f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "incinerate", ChampionName = "annie", Slot = SpellSlot.W, CastRange = 625f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, MissileName = string.Empty, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "moltenshield", ChampionName = "annie", Slot = SpellSlot.E, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "infernalguardian", ChampionName = "annie", Slot = SpellSlot.R, CastRange = 890f, 
                        
                        //// 600 + Cast Radius
                        Delay = 0f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileName = string.Empty, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "frostshot", ChampionName = "ashe", Slot = SpellSlot.Q, CastRange = 0f, Delay = 0f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "frostarrow", ChampionName = "ashe", Slot = SpellSlot.Q, CastRange = 0f, Delay = 0f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "volley", ChampionName = "ashe", Slot = SpellSlot.W, CastRange = 1200f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "volleyattack", 
                        MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ashespiritofthehawk", ChampionName = "ashe", Slot = SpellSlot.E, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "enchantedcrystalarrow", ChampionName = "ashe", Slot = SpellSlot.R, CastRange = 20000f, 
                        Global = true, Delay = 250f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileName = "enchantedcrystalarrow", 
                        MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "azirq", ChampionName = "azir", Slot = SpellSlot.Q, CastRange = 875f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "azirsoldiermissile", 
                        FromObject = new[] { "AzirSoldier" }, MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "azirr", ChampionName = "azir", Slot = SpellSlot.R, CastRange = 475f, Delay = 250f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "bardq", ChampionName = "bard", Slot = SpellSlot.Q, CastRange = 950f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "bardqmissile", 
                        MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "bardw", ChampionName = "bard", Slot = SpellSlot.W, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = 1450
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "barde", ChampionName = "bard", Slot = SpellSlot.E, CastRange = 0f, Delay = 350f, 
                        HitType = new HitType[] { }, MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "bardr", ChampionName = "bard", Slot = SpellSlot.R, CastRange = 3400f, Delay = 450f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "bardr", MissileSpeed = 2100
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "rocketgrabmissile", ChampionName = "blitzcrank", Slot = SpellSlot.Q, 
                        CastRange = 1050f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl, Project_zed.HitType.Danger }, 
                        MissileSpeed = 1800
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "overdrive", ChampionName = "blitzcrank", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "powerfist", ChampionName = "blitzcrank", Slot = SpellSlot.E, CastRange = 100f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "staticfield", ChampionName = "blitzcrank", Slot = SpellSlot.R, CastRange = 600f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = string.Empty, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "brandblaze", ChampionName = "brand", Slot = SpellSlot.Q, CastRange = 1150f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "brandblazemissile", MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "brandfissure", ChampionName = "brand", Slot = SpellSlot.W, CastRange = 240f, 
                        Delay = 550f, HitType = new[] { Project_zed.HitType.Danger }, MissileName = string.Empty, 
                        MissileSpeed = 20
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "brandconflagration", ChampionName = "brand", Slot = SpellSlot.E, CastRange = 625f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "brandwildfire", ChampionName = "brand", Slot = SpellSlot.R, CastRange = 750f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        MissileSpeed = 1000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "braumq", ChampionName = "braum", Slot = SpellSlot.Q, CastRange = 1100f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileName = "braumqmissile", MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "braumqmissle", ChampionName = "braum", Slot = SpellSlot.Q, CastRange = 1100f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "braumw", ChampionName = "braum", Slot = SpellSlot.W, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "braume", ChampionName = "braum", Slot = SpellSlot.E, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "braumrwrapper", ChampionName = "braum", Slot = SpellSlot.R, CastRange = 1250f, 
                        Delay = 250f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileName = "braumrmissile", MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "caitlynpiltoverpeacemaker", ChampionName = "caitlyn", Slot = SpellSlot.Q, 
                        CastRange = 2000f, Delay = 625f, HitType = new HitType[] { }, 
                        MissileName = "caitlynpiltoverpeacemaker", MissileSpeed = 2200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "caitlynyordletrap", ChampionName = "caitlyn", Slot = SpellSlot.W, CastRange = 800f, 
                        Delay = 550f, HitType = new HitType[] { }, MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "caitlynentrapment", ChampionName = "caitlyn", Slot = SpellSlot.E, CastRange = 1050f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "caitlynentrapmentmissile", MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "cassiopeianoxiousblast", ChampionName = "cassiopeia", Slot = SpellSlot.Q, 
                        CastRange = 925f, Delay = 250f, HitType = new HitType[] { }, 
                        MissileName = "cassiopeianoxiousblast", MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "cassiopeiamiasma", ChampionName = "cassiopeia", Slot = SpellSlot.W, CastRange = 925f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 2500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "cassiopeiatwinfang", ChampionName = "cassiopeia", Slot = SpellSlot.E, 
                        CastRange = 700f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1900
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "cassiopeiapetrifyinggaze", ChampionName = "cassiopeia", Slot = SpellSlot.R, 
                        CastRange = 875f, Delay = 350f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileName = "cassiopeiapetrifyinggaze", 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "rupture", ChampionName = "chogath", Slot = SpellSlot.Q, CastRange = 950f, 
                        Delay = 1000f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileName = "rupture", MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "feralscream", ChampionName = "chogath", Slot = SpellSlot.W, CastRange = 675f, 
                        Delay = 175f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "vorpalspikes", ChampionName = "chogath", Slot = SpellSlot.E, CastRange = 0f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = 347
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "feast", ChampionName = "chogath", Slot = SpellSlot.R, CastRange = 500f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "phosphorusbomb", ChampionName = "corki", Slot = SpellSlot.Q, CastRange = 875f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "phosphorusbombmissile", 
                        MissileSpeed = 1125
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "carpetbomb", ChampionName = "corki", Slot = SpellSlot.W, CastRange = 0f, Delay = 0f, 
                        HitType = new HitType[] { }, MissileSpeed = 700
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ggun", ChampionName = "corki", Slot = SpellSlot.E, CastRange = 750f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "missilebarrage", ChampionName = "corki", Slot = SpellSlot.R, CastRange = 1225f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "missilebarragemissile", 
                        MissileSpeed = 828
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "dariuscleave", ChampionName = "darius", Slot = SpellSlot.Q, CastRange = 425f, 
                        Delay = 750f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "dariusnoxiantacticsonh", ChampionName = "darius", Slot = SpellSlot.W, 
                        CastRange = 205f, Delay = 150f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "dariusaxegrabcone", ChampionName = "darius", Slot = SpellSlot.E, CastRange = 555f, 
                        Delay = 150f, HitType = new[] { Project_zed.HitType.CrowdControl, Project_zed.HitType.Danger }, 
                        MissileName = "dariusaxegrabcone", MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "dariusexecute", ChampionName = "darius", Slot = SpellSlot.R, CastRange = 465f, 
                        Delay = 450f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "dianaarc", ChampionName = "diana", Slot = SpellSlot.Q, CastRange = 830f, Delay = 300f, 
                        HitType = new HitType[] { }, MissileName = "dianaarc", MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "dianaorbs", ChampionName = "diana", Slot = SpellSlot.W, CastRange = 200f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "dianavortex", ChampionName = "diana", Slot = SpellSlot.E, CastRange = 350f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl, Project_zed.HitType.Danger }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "dianateleport", ChampionName = "diana", Slot = SpellSlot.R, CastRange = 825f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = 2200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "dravenspinning", ChampionName = "draven", Slot = SpellSlot.Q, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "dravenfury", ChampionName = "draven", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "dravendoubleshot", ChampionName = "draven", Slot = SpellSlot.E, CastRange = 1050f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "dravendoubleshotmissile", MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "dravenrcast", ChampionName = "draven", Slot = SpellSlot.R, CastRange = 20000f, 
                        Global = true, Delay = 500f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        MissileName = "dravenr", MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "infectedcleavermissilecast", ChampionName = "drmundo", Slot = SpellSlot.Q, 
                        CastRange = 1000f, Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "infectedcleavermissile", MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "burningagony", ChampionName = "drmundo", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "masochism", ChampionName = "drmundo", Slot = SpellSlot.E, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sadism", ChampionName = "drmundo", Slot = SpellSlot.R, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ekkoq", ChampionName = "ekko", Slot = SpellSlot.Q, CastRange = 1075f, Delay = 66f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "ekkoqmis", 
                        ExtraMissileNames = new[] { "ekkoqreturn" }, MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ekkoeattack", ChampionName = "ekko", Slot = SpellSlot.E, CastRange = 300f, Delay = 0f, 
                        HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ekkor", ChampionName = "ekko", Slot = SpellSlot.R, CastRange = 425f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        FromObject = new[] { "Ekko_Base_R_TrailEnd" }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "elisehumanq", ChampionName = "elise", Slot = SpellSlot.Q, CastRange = 625f, 
                        Delay = 550f, HitType = new HitType[] { }, MissileSpeed = 2200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "elisespiderqcast", ChampionName = "elise", Slot = SpellSlot.Q, CastRange = 475f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "elisehumanw", ChampionName = "elise", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 750f, HitType = new HitType[] { }, MissileSpeed = 5000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "elisespiderw", ChampionName = "elise", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "elisehumane", ChampionName = "elise", Slot = SpellSlot.E, CastRange = 1075f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl, Project_zed.HitType.Danger }, 
                        MissileName = "elisehumane", MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "elisespidereinitial", ChampionName = "elise", Slot = SpellSlot.E, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "elisespideredescent", ChampionName = "elise", Slot = SpellSlot.E, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "eliser", ChampionName = "elise", Slot = SpellSlot.R, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "elisespiderr", ChampionName = "elise", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "evelynnq", ChampionName = "evelynn", Slot = SpellSlot.Q, CastRange = 500f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "evelynnw", ChampionName = "evelynn", Slot = SpellSlot.W, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "evelynne", ChampionName = "evelynn", Slot = SpellSlot.E, CastRange = 225f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "evelynnr", ChampionName = "evelynn", Slot = SpellSlot.R, CastRange = 900f, 
                        
                        //// 650f + Radius
                        Delay = 250f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileName = "evelynnr", 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ezrealmysticshot", ChampionName = "ezreal", Slot = SpellSlot.Q, CastRange = 1150f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, 
                        MissileName = "ezrealmysticshotmissile", 
                        ExtraMissileNames = new[] { "ezrealmysticshotpulsemissile" }, MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ezrealessenceflux", ChampionName = "ezreal", Slot = SpellSlot.W, CastRange = 1050f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "ezrealessencefluxmissile", 
                        MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ezrealessencemissle", ChampionName = "ezreal", Slot = SpellSlot.W, CastRange = 1050f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ezrealarcaneshift", ChampionName = "ezreal", Slot = SpellSlot.E, CastRange = 750f, 
                        
                        //// 475f + Bolt Ranfw
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ezrealtrueshotbarrage", ChampionName = "ezreal", Slot = SpellSlot.R, 
                        CastRange = 20000f, Global = true, Delay = 1000f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        MissileName = "ezrealtrueshotbarrage", MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "terrify", ChampionName = "fiddlesticks", Slot = SpellSlot.Q, CastRange = 575f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "drain", ChampionName = "fiddlesticks", Slot = SpellSlot.W, CastRange = 575f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "fiddlesticksdarkwind", ChampionName = "fiddlesticks", Slot = SpellSlot.E, 
                        CastRange = 750f, Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = 1100
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "crowstorm", ChampionName = "fiddlesticks", Slot = SpellSlot.R, CastRange = 800f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.ForceExhaust }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "fioraq", ChampionName = "fiora", Slot = SpellSlot.Q, CastRange = 400f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = 2200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "fioraw", ChampionName = "fiora", Slot = SpellSlot.W, CastRange = 750f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "fiorae", ChampionName = "fiora", Slot = SpellSlot.E, CastRange = 0f, Delay = 0f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "fiorar", ChampionName = "fiora", Slot = SpellSlot.R, CastRange = 500f, Delay = 150f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "fizzpiercingstrike", ChampionName = "fizz", Slot = SpellSlot.Q, CastRange = 550f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1900
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "fizzseastonepassive", ChampionName = "fizz", Slot = SpellSlot.W, CastRange = 175f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "fizzjump", ChampionName = "fizz", Slot = SpellSlot.E, CastRange = 450f, Delay = 700f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "fizzjumpbuffer", ChampionName = "fizz", Slot = SpellSlot.E, CastRange = 330f, 
                        Delay = 0f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "fizzjumptwo", ChampionName = "fizz", Slot = SpellSlot.E, CastRange = 270f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "fizzmarinerdoom", ChampionName = "fizz", Slot = SpellSlot.R, CastRange = 1275f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "fizzmarinerdoommissile", MissileSpeed = 1350
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "galioresolutesmite", ChampionName = "galio", Slot = SpellSlot.Q, CastRange = 1040f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "galioresolutesmite", MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "galiobulwark", ChampionName = "galio", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "galiorighteousgust", ChampionName = "galio", Slot = SpellSlot.E, CastRange = 1280f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "galiorighteousgust", MissileSpeed = 1300
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "galioidolofdurand", ChampionName = "galio", Slot = SpellSlot.R, CastRange = 600f, 
                        Delay = 0f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileName = string.Empty, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gangplankqwrapper", ChampionName = "gangplank", Slot = SpellSlot.Q, CastRange = 625f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gangplankqproceed", ChampionName = "gangplank", Slot = SpellSlot.Q, CastRange = 625f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gangplankw", ChampionName = "gangplank", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gangplanke", ChampionName = "gangplank", Slot = SpellSlot.E, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gangplankr", ChampionName = "gangplank", Slot = SpellSlot.R, CastRange = 20000f, 
                        Global = true, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 2200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "garenq", ChampionName = "garen", Slot = SpellSlot.Q, CastRange = 0f, Delay = 300f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "garenqattack", ChampionName = "garen", Slot = SpellSlot.Q, CastRange = 350f, 
                        Delay = 0f, HitType = new[] { Project_zed.HitType.CrowdControl, Project_zed.HitType.Danger }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gnarq", ChampionName = "gnar", Slot = SpellSlot.Q, CastRange = 1185f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 2400, 
                        MissileName = "gnarqmissile", ExtraMissileNames = new[] { "gnarqmissilereturn" }
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gnarbigq", ChampionName = "gnar", Slot = SpellSlot.Q, CastRange = 1150f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 2000, 
                        MissileName = "gnarbigqmissile"
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gnarbigw", ChampionName = "gnar", Slot = SpellSlot.W, CastRange = 600f, Delay = 600f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gnarult", ChampionName = "gnar", CastRange = 500f, 
                        
                        //// 590f + 10 Better safe than sorry. :)
                        Slot = SpellSlot.R, Delay = 250f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "garenw", ChampionName = "garen", Slot = SpellSlot.W, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "garene", ChampionName = "garen", Slot = SpellSlot.E, CastRange = 300f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "garenr", ChampionName = "garen", Slot = SpellSlot.R, CastRange = 400f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gragasq", ChampionName = "gragas", Slot = SpellSlot.Q, CastRange = 950f, 
                        
                        //// 850f + Radius
                        Delay = 500f, HitType = new HitType[] { }, MissileName = "gragasqmissile", 
                        MissileSpeed = 1000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gragasqtoggle", ChampionName = "gragas", Slot = SpellSlot.Q, CastRange = 1100f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gragasw", ChampionName = "gragas", Slot = SpellSlot.W, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gragase", ChampionName = "gragas", Slot = SpellSlot.E, CastRange = 600f, Delay = 200f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileName = "gragase", MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gragasr", ChampionName = "gragas", Slot = SpellSlot.R, CastRange = 11050f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileName = "gragasrboom", MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gravesclustershot", ChampionName = "graves", Slot = SpellSlot.Q, CastRange = 1025, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "gravesclustershotattack", 
                        MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gravessmokegrenade", ChampionName = "graves", Slot = SpellSlot.W, CastRange = 1100f, 
                        Delay = 300f, HitType = new HitType[] { }, MissileSpeed = 1650
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gravessmokegrenadeboom", ChampionName = "graves", Slot = SpellSlot.W, 
                        CastRange = 1100f, // 950 + Radius
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1350
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "gravesmove", ChampionName = "graves", Slot = SpellSlot.E, CastRange = 0f, 
                        Delay = 300f, HitType = new HitType[] { }, MissileSpeed = 1000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "graveschargeshot", ChampionName = "graves", Slot = SpellSlot.R, CastRange = 1000f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        MissileName = "graveschargeshotshot", MissileSpeed = 2100
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "hecarimrapidslash", ChampionName = "hecarim", Slot = SpellSlot.Q, CastRange = 350f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 2200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "hecarimw", ChampionName = "hecarim", Slot = SpellSlot.W, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "hecarimramp", ChampionName = "hecarim", Slot = SpellSlot.E, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "hecarimult", ChampionName = "hecarim", Slot = SpellSlot.R, CastRange = 1350f, 
                        Delay = 50f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "heimerdingerq", ChampionName = "heimerdinger", Slot = SpellSlot.Q, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "heimerdingerw", ChampionName = "heimerdinger", Slot = SpellSlot.W, CastRange = 1100, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "heimerdingere", ChampionName = "heimerdinger", Slot = SpellSlot.E, CastRange = 1025f, 
                        
                        //// 925 + Radius
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "heimerdingerespell", MissileSpeed = 1450
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "heimerdingerr", ChampionName = "heimerdinger", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 230f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "heimerdingereult", ChampionName = "heimerdinger", Slot = SpellSlot.E, 
                        CastRange = 1250f, Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = 1450
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ireliagatotsu", ChampionName = "irelia", Slot = SpellSlot.Q, CastRange = 650f, 
                        Delay = 150f, HitType = new HitType[] { }, MissileSpeed = 2200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ireliahitenstyle", ChampionName = "irelia", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 230f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ireliaequilibriumstrike", ChampionName = "irelia", Slot = SpellSlot.E, 
                        CastRange = 450f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ireliatranscendentblades", ChampionName = "irelia", Slot = SpellSlot.R, 
                        CastRange = 1200f, Delay = 250f, HitType = new HitType[] { }, 
                        MissileName = "ireliatranscendentblades", MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "howlinggale", ChampionName = "janna", Slot = SpellSlot.Q, CastRange = 850f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sowthewind", ChampionName = "janna", Slot = SpellSlot.W, CastRange = 600f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "eyeofthestorm", ChampionName = "janna", Slot = SpellSlot.E, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "reapthewhirlwind", ChampionName = "janna", Slot = SpellSlot.R, CastRange = 725f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jarvanivdragonstrike", ChampionName = "jarvaniv", Slot = SpellSlot.Q, 
                        CastRange = 700f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileName = string.Empty, MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jarvanivgoldenaegis", ChampionName = "jarvaniv", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jarvanivdemacianstandard", ChampionName = "jarvaniv", Slot = SpellSlot.E, 
                        CastRange = 830f, Delay = 250f, HitType = new HitType[] { }, 
                        MissileName = "jarvanivdemacianstandard", MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jarvanivcataclysm", ChampionName = "jarvaniv", Slot = SpellSlot.R, CastRange = 650f, 
                        Delay = 500f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jaxleapstrike", ChampionName = "jax", Slot = SpellSlot.Q, CastRange = 210f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = 2200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jaxempowertwo", ChampionName = "jax", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jaxrelentlessasssault", ChampionName = "jax", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jaycetotheskies", ChampionName = "jayce", Slot = SpellSlot.Q, CastRange = 600f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl, Project_zed.HitType.Danger }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jayceshockblast", ChampionName = "jayce", Slot = SpellSlot.Q, CastRange = 1050f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl, Project_zed.HitType.Danger }, 
                        MissileName = "jayceshockblastmis", MissileSpeed = 2200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jaycestaticfield", ChampionName = "jayce", Slot = SpellSlot.W, CastRange = 285f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jaycehypercharge", ChampionName = "jayce", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 750f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jaycethunderingblow", ChampionName = "jayce", Slot = SpellSlot.E, CastRange = 300f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jayceaccelerationgate", ChampionName = "jayce", Slot = SpellSlot.E, CastRange = 685f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jaycestancehtg", ChampionName = "jayce", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 750f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jaycestancegth", ChampionName = "jayce", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 750f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jinxq", ChampionName = "jinx", Slot = SpellSlot.Q, CastRange = 0f, Delay = 0f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jinxw", ChampionName = "jinx", Slot = SpellSlot.W, CastRange = 1550f, Delay = 550f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "jinxwmissile", 
                        MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jinxwmissle", ChampionName = "jinx", Slot = SpellSlot.W, CastRange = 1550f, 
                        Delay = 500f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jinxe", ChampionName = "jinx", Slot = SpellSlot.E, CastRange = 900f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jinxr", ChampionName = "jinx", Slot = SpellSlot.R, CastRange = 25000f, Global = true, 
                        Delay = 600f, MissileName = "jinxr", ExtraMissileNames = new[] { "jinxrwrapper" }, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, MissileSpeed = 1700
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "karmaq", ChampionName = "karma", Slot = SpellSlot.Q, CastRange = 1050f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileName = "karmaqmissile", MissileSpeed = 1800
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "karmaspiritbind", ChampionName = "karma", Slot = SpellSlot.W, CastRange = 800f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "karmasolkimshield", ChampionName = "karma", Slot = SpellSlot.E, CastRange = 800f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "karmamantra", ChampionName = "karma", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1300
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "laywaste", ChampionName = "karthus", Slot = SpellSlot.Q, CastRange = 875f, 
                        Delay = 250f, HitType = new HitType[] { }, 
                        ExtraMissileNames =
                            new[]
                                {
                                    "karthuslaywastea3", "karthuslaywastea1", "karthuslaywastedeada1", 
                                    "karthuslaywastedeada2", "karthuslaywastedeada3"
                                }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "wallofpain", ChampionName = "karthus", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "defile", ChampionName = "karthus", Slot = SpellSlot.E, CastRange = 550f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = 1000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "fallenone", ChampionName = "karthus", Slot = SpellSlot.R, CastRange = 22000f, 
                        Global = true, Delay = 2800f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "nulllance", ChampionName = "kassadin", Slot = SpellSlot.Q, CastRange = 650f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl, Project_zed.HitType.Danger }, 
                        MissileSpeed = 1900
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "netherblade", ChampionName = "kassadin", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "forcepulse", ChampionName = "kassadin", Slot = SpellSlot.E, CastRange = 700f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl, Project_zed.HitType.Danger }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "riftwalk", ChampionName = "kassadin", Slot = SpellSlot.R, CastRange = 675f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "riftwalk", MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "katarinaq", ChampionName = "katarina", Slot = SpellSlot.Q, CastRange = 675f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1800
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "katarinaw", ChampionName = "katarina", Slot = SpellSlot.W, CastRange = 400f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1800
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "katarinae", ChampionName = "katarina", Slot = SpellSlot.E, CastRange = 700f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "katarinar", ChampionName = "katarina", Slot = SpellSlot.R, CastRange = 550f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.ForceExhaust }, MissileSpeed = 1450
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "judicatorreckoning", ChampionName = "kayle", Slot = SpellSlot.Q, CastRange = 650f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "judicatordevineblessing", ChampionName = "kayle", Slot = SpellSlot.W, 
                        CastRange = 900f, Delay = 220f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "judicatorrighteousfury", ChampionName = "kayle", Slot = SpellSlot.E, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "judicatorintervention", ChampionName = "kayle", Slot = SpellSlot.R, CastRange = 900f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "kennenshurikenhurlmissile1", ChampionName = "kennen", Slot = SpellSlot.Q, 
                        CastRange = 1175f, Delay = 180f, HitType = new HitType[] { }, 
                        MissileName = "kennenshurikenhurlmissile1", MissileSpeed = 1700
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "kennenbringthelight", ChampionName = "kennen", Slot = SpellSlot.W, CastRange = 900f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "kennenlightningrush", ChampionName = "kennen", Slot = SpellSlot.E, CastRange = 0f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "kennenshurikenstorm", ChampionName = "kennen", Slot = SpellSlot.R, CastRange = 550f, 
                        Delay = 500f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "khazixq", ChampionName = "khazix", Slot = SpellSlot.Q, CastRange = 325f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "khazixqlong", ChampionName = "khazix", Slot = SpellSlot.Q, CastRange = 375f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "khazixw", ChampionName = "khazix", Slot = SpellSlot.W, CastRange = 1000f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "khazixwmissile", 
                        MissileSpeed = 81700
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "khazixwlong", ChampionName = "khazix", Slot = SpellSlot.W, CastRange = 1000f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1700
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "khazixe", ChampionName = "khazix", Slot = SpellSlot.E, CastRange = 600f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileName = "khazixe", MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "khazixelong", ChampionName = "khazix", Slot = SpellSlot.E, CastRange = 900f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "khazixr", ChampionName = "khazix", Slot = SpellSlot.R, CastRange = 1000f, Delay = 0f, 
                        HitType = new[] { Project_zed.HitType.Stealth }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "khazixrlong", ChampionName = "khazix", Slot = SpellSlot.R, CastRange = 1000f, 
                        Delay = 0f, HitType = new[] { Project_zed.HitType.Stealth }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "kogmawcausticspittle", ChampionName = "kogmaw", Slot = SpellSlot.Q, CastRange = 625f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "kogmawbioarcanbarrage", ChampionName = "kogmaw", Slot = SpellSlot.W, CastRange = 130f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "kogmawvoidooze", ChampionName = "kogmaw", Slot = SpellSlot.E, CastRange = 1150f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "kogmawvoidoozemissile", MissileSpeed = 1250
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "kogmawlivingartillery", ChampionName = "kogmaw", Slot = SpellSlot.R, 
                        CastRange = 2200f, Delay = 1200f, HitType = new[] { Project_zed.HitType.Danger }, 
                        MissileName = "kogmawlivingartillery", MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "leblancchaosorb", ChampionName = "leblanc", Slot = SpellSlot.Q, CastRange = 700f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "leblancslide", ChampionName = "leblanc", Slot = SpellSlot.W, CastRange = 600f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, MissileName = "leblancslide", 
                        MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "leblacslidereturn", ChampionName = "leblanc", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "leblancsoulshackle", ChampionName = "leblanc", Slot = SpellSlot.E, CastRange = 925f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "leblancsoulshackle", MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "leblancchaosorbm", ChampionName = "leblanc", Slot = SpellSlot.R, CastRange = 700f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "leblancslidem", ChampionName = "leblanc", Slot = SpellSlot.R, CastRange = 600f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        MissileName = "leblancslidem", MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "leblancslidereturnm", ChampionName = "leblanc", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "leblancsoulshacklem", ChampionName = "leblanc", Slot = SpellSlot.R, CastRange = 925f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "leblancsoulshacklem", 
                        MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "blindmonkqone", ChampionName = "leesin", Slot = SpellSlot.Q, CastRange = 1000f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, MissileName = "blindmonkqone", 
                        MissileSpeed = 1800
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "blindmonkqtwo", ChampionName = "leesin", Slot = SpellSlot.Q, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "blindmonkwone", ChampionName = "leesin", Slot = SpellSlot.W, CastRange = 700f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "blindmonkwtwo", ChampionName = "leesin", Slot = SpellSlot.W, CastRange = 700f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "blindmonkeone", ChampionName = "leesin", Slot = SpellSlot.E, CastRange = 425f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "blindmonketwo", ChampionName = "leesin", Slot = SpellSlot.E, CastRange = 350f, 
                        Delay = 0f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "blindmonkrkick", ChampionName = "leesin", Slot = SpellSlot.R, CastRange = 375f, 
                        Delay = 500f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "leonashieldofdaybreak", ChampionName = "leona", Slot = SpellSlot.Q, CastRange = 215f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "leonasolarbarrier", ChampionName = "leona", Slot = SpellSlot.W, CastRange = 250f, 
                        Delay = 3000f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "leonazenithblade", ChampionName = "leona", Slot = SpellSlot.E, CastRange = 900f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileName = "leonazenithblademissile", 
                        MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "leonasolarflare", ChampionName = "leona", Slot = SpellSlot.R, CastRange = 1200f, 
                        Delay = 550f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileName = "leonasolarflare", 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "lissandraq", ChampionName = "lissandra", Slot = SpellSlot.Q, CastRange = 725f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "lissandraqmissile", MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "lissandraw", ChampionName = "lissandra", Slot = SpellSlot.W, CastRange = 450f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "lissandrae", ChampionName = "lissandra", Slot = SpellSlot.E, CastRange = 1050f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "lissandraemissile", MissileSpeed = 850
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "lissandrar", ChampionName = "lissandra", Slot = SpellSlot.R, CastRange = 550f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "lucianq", ChampionName = "lucian", Slot = SpellSlot.Q, CastRange = 1050f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, MissileName = "lucianq", 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "lucianw", ChampionName = "lucian", Slot = SpellSlot.W, CastRange = 1050f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "lucianwmissile", MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "luciane", ChampionName = "lucian", Slot = SpellSlot.E, CastRange = 650f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "lucianr", ChampionName = "lucian", Slot = SpellSlot.R, CastRange = 1400f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, 
                        MissileName = "lucianrmissileoffhand", ExtraMissileNames = new[] { "lucianrmissile" }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "luluq", ChampionName = "lulu", Slot = SpellSlot.Q, CastRange = 925f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "luluqmissile", 
                        MissileSpeed = 1450
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "luluw", ChampionName = "lulu", Slot = SpellSlot.W, CastRange = 650f, Delay = 640f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "lulue", ChampionName = "lulu", Slot = SpellSlot.E, CastRange = 650f, Delay = 640f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "lulur", ChampionName = "lulu", Slot = SpellSlot.R, CastRange = 900f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "luxlightbinding", ChampionName = "lux", Slot = SpellSlot.Q, CastRange = 1300f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileName = "luxlightbindingmis", MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "luxprismaticwave", ChampionName = "lux", Slot = SpellSlot.W, CastRange = 1075f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "luxlightstrikekugel", ChampionName = "lux", Slot = SpellSlot.E, CastRange = 1100f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "luxlightstrikekugel", 
                        MissileSpeed = 1300
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "luxlightstriketoggle", ChampionName = "lux", Slot = SpellSlot.E, CastRange = 1100f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "luxmalicecannon", ChampionName = "lux", Slot = SpellSlot.R, CastRange = 3340f, 
                        Delay = 1750f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        MissileName = "luxmalicecannonmis", MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "kalistamysticshot", ChampionName = "kalista", Slot = SpellSlot.Q, CastRange = 1200f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "kalistamysticshotmis", ExtraMissileNames = new[] { "kalistamysticshotmistrue" }, 
                        MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "kalistaw", ChampionName = "kalista", Slot = SpellSlot.W, CastRange = 5000f, 
                        Delay = 800f, HitType = new HitType[] { }, MissileSpeed = 200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "kalistaexpungewrapper", ChampionName = "kalista", Slot = SpellSlot.E, 
                        CastRange = 1200f, Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "seismicshard", ChampionName = "malphite", Slot = SpellSlot.Q, CastRange = 625f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "obduracy", ChampionName = "malphite", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "landslide", ChampionName = "malphite", Slot = SpellSlot.E, CastRange = 400f, 
                        Delay = 500f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ufslash", ChampionName = "malphite", Slot = SpellSlot.R, CastRange = 1000f, 
                        Delay = 250f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileName = "ufslash", MissileSpeed = 2200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "alzaharcallofthevoid", ChampionName = "malzahar", Slot = SpellSlot.Q, 
                        CastRange = 900f, Delay = 600f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "alzaharcallofthevoid", MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "alzaharnullzone", ChampionName = "malzahar", Slot = SpellSlot.W, CastRange = 800f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "alzaharmaleficvisions", ChampionName = "malzahar", Slot = SpellSlot.E, 
                        CastRange = 650f, Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "alzaharnethergrasp", ChampionName = "malzahar", Slot = SpellSlot.R, CastRange = 700f, 
                        Delay = 250f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "maokaitrunkline", ChampionName = "maokai", Slot = SpellSlot.Q, CastRange = 600f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "maokaiunstablegrowth", ChampionName = "maokai", Slot = SpellSlot.W, CastRange = 650f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "maokaisapling2", ChampionName = "maokai", Slot = SpellSlot.E, CastRange = 1100f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "maokaidrain3", ChampionName = "maokai", Slot = SpellSlot.R, CastRange = 625f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "alphastrike", ChampionName = "masteryi", Slot = SpellSlot.Q, CastRange = 600f, 
                        Delay = 600f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "meditate", ChampionName = "masteryi", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "wujustyle", ChampionName = "masteryi", Slot = SpellSlot.E, CastRange = 0f, 
                        Delay = 230f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "highlander", ChampionName = "masteryi", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 370f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "missfortunericochetshot", ChampionName = "missfortune", Slot = SpellSlot.Q, 
                        CastRange = 650f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "missfortuneviciousstrikes", ChampionName = "missfortune", Slot = SpellSlot.W, 
                        CastRange = 0f, Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "missfortunescattershot", ChampionName = "missfortune", Slot = SpellSlot.E, 
                        CastRange = 1000f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "missfortunebullettime", ChampionName = "missfortune", Slot = SpellSlot.R, 
                        CastRange = 1400f, Delay = 500f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "monkeykingdoubleattack", ChampionName = "monkeyking", Slot = SpellSlot.Q, 
                        CastRange = 300f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 20
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "monkeykingdecoy", ChampionName = "monkeyking", Slot = SpellSlot.W, CastRange = 1000f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Stealth }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "monkeykingdecoyswipe", ChampionName = "monkeyking", Slot = SpellSlot.W, 
                        CastRange = 325f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "monkeykingnimbus", ChampionName = "monkeyking", Slot = SpellSlot.E, CastRange = 625f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 2200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "monkeykingspintowin", ChampionName = "monkeyking", Slot = SpellSlot.R, 
                        CastRange = 450f, Delay = 250f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "monkeykingspintowinleave", ChampionName = "monkeyking", Slot = SpellSlot.R, 
                        CastRange = 0f, Delay = 0f, HitType = new HitType[] { }, MissileSpeed = 700
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "mordekaisermaceofspades", ChampionName = "mordekaiser", Slot = SpellSlot.Q, 
                        CastRange = 600f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "mordekaisercreepindeathcast", ChampionName = "mordekaiser", Slot = SpellSlot.W, 
                        CastRange = 750f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "mordekaisersyphoneofdestruction", ChampionName = "mordekaiser", Slot = SpellSlot.E, 
                        CastRange = 700f, Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, 
                        MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "mordekaiserchildrenofthegrave", ChampionName = "mordekaiser", Slot = SpellSlot.R, 
                        CastRange = 850f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "darkbindingmissile", ChampionName = "morgana", Slot = SpellSlot.Q, CastRange = 1175f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileName = "darkbindingmissile", MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "tormentedsoil", ChampionName = "morgana", Slot = SpellSlot.W, CastRange = 850f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "blackshield", ChampionName = "morgana", Slot = SpellSlot.E, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "soulshackles", ChampionName = "morgana", Slot = SpellSlot.R, CastRange = 600f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "namiq", ChampionName = "nami", Slot = SpellSlot.Q, CastRange = 875f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileName = "namiqmissile", MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "namiw", ChampionName = "nami", Slot = SpellSlot.W, CastRange = 725f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = 1100
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "namie", ChampionName = "nami", Slot = SpellSlot.E, CastRange = 0f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "namir", ChampionName = "nami", Slot = SpellSlot.R, CastRange = 2550f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileName = "namirmissile", MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "nasusq", ChampionName = "nasus", Slot = SpellSlot.Q, CastRange = 450f, Delay = 500f, 
                        HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "nasusw", ChampionName = "nasus", Slot = SpellSlot.W, CastRange = 600f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "nasuse", ChampionName = "nasus", Slot = SpellSlot.E, CastRange = 850f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "nasusr", ChampionName = "nasus", Slot = SpellSlot.R, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "nautilusanchordrag", ChampionName = "nautilus", Slot = SpellSlot.Q, CastRange = 1080f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl, Project_zed.HitType.Danger }, 
                        MissileName = "nautilusanchordragmissile", MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "nautiluspiercinggaze", ChampionName = "nautilus", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "nautilussplashzone", ChampionName = "nautilus", Slot = SpellSlot.E, CastRange = 600f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1300
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "nautilusgandline", ChampionName = "nautilus", Slot = SpellSlot.R, CastRange = 1250f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "javelintoss", ChampionName = "nidalee", Slot = SpellSlot.Q, CastRange = 1500f, 
                        Delay = 125f, HitType = new[] { Project_zed.HitType.Danger }, MissileName = "javelintoss", 
                        MissileSpeed = 1300
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "takedown", ChampionName = "nidalee", Slot = SpellSlot.Q, CastRange = 150f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "bushwhack", ChampionName = "nidalee", Slot = SpellSlot.W, CastRange = 900f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1450
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "pounce", ChampionName = "nidalee", Slot = SpellSlot.W, CastRange = 375f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "primalsurge", ChampionName = "nidalee", Slot = SpellSlot.E, CastRange = 600f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "swipe", ChampionName = "nidalee", Slot = SpellSlot.E, CastRange = 350f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "aspectofthecougar", ChampionName = "nidalee", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "nocturneduskbringer", ChampionName = "nocturne", Slot = SpellSlot.Q, 
                        CastRange = 1125f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "nocturneshroudofdarkness", ChampionName = "nocturne", Slot = SpellSlot.W, 
                        CastRange = 0f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "nocturneunspeakablehorror", ChampionName = "nocturne", Slot = SpellSlot.E, 
                        CastRange = 350f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "nocturneparanoia", ChampionName = "nocturne", Slot = SpellSlot.R, CastRange = 20000f, 
                        Global = true, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "consume", ChampionName = "nunu", Slot = SpellSlot.Q, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "bloodboil", ChampionName = "nunu", Slot = SpellSlot.W, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "iceblast", ChampionName = "nunu", Slot = SpellSlot.E, CastRange = 550f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "absolutezero", ChampionName = "nunu", Slot = SpellSlot.R, CastRange = 650f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "olafaxethrowcast", ChampionName = "olaf", Slot = SpellSlot.Q, CastRange = 1000f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "olafaxethrow", 
                        MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "olaffrenziedstrikes", ChampionName = "olaf", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "olafrecklessstrike", ChampionName = "olaf", Slot = SpellSlot.E, CastRange = 325f, 
                        Delay = 500f, HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "olafragnarok", ChampionName = "olaf", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "orianaizunacommand", ChampionName = "orianna", Slot = SpellSlot.Q, CastRange = 900f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "orianaizuna", 
                        FromObject = new[] { "yomu_ring" }, MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "orianadissonancecommand", ChampionName = "orianna", Slot = SpellSlot.W, 
                        CastRange = 400f, Delay = 350f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "orianadissonancecommand", FromObject = new[] { "yomu_ring" }, MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "orianaredactcommand", ChampionName = "orianna", Slot = SpellSlot.E, CastRange = 1095f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "orianaredact", 
                        FromObject = new[] { "yomu_ring" }, MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "orianadetonatecommand", ChampionName = "orianna", Slot = SpellSlot.R, 
                        CastRange = 425f, Delay = 500f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileName = "orianadetonatecommand", 
                        FromObject = new[] { "yomu_ring" }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "pantheonq", ChampionName = "pantheon", Slot = SpellSlot.Q, CastRange = 600f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1900
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "pantheonw", ChampionName = "pantheon", Slot = SpellSlot.W, CastRange = 600f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "pantheone", ChampionName = "pantheon", Slot = SpellSlot.E, CastRange = 600f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "pantheonrjump", ChampionName = "pantheon", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 1000f, HitType = new HitType[] { }, MissileSpeed = 3000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "pantheonrfall", ChampionName = "pantheon", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 1000f, HitType = new HitType[] { }, MissileSpeed = 3000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "poppydevastatingblow", ChampionName = "poppy", Slot = SpellSlot.Q, CastRange = 300f, 
                        Delay = 500f, HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "poppyparagonofdemacia", ChampionName = "poppy", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "poppyheroiccharge", ChampionName = "poppy", Slot = SpellSlot.E, CastRange = 525f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1450
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "poppydiplomaticimmunity", ChampionName = "poppy", Slot = SpellSlot.R, 
                        CastRange = 900f, Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "quinnq", ChampionName = "quinn", Slot = SpellSlot.Q, CastRange = 1025f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "quinnqmissile", 
                        MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "quinnw", ChampionName = "quinn", Slot = SpellSlot.W, CastRange = 0f, Delay = 0f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "quinne", ChampionName = "quinn", Slot = SpellSlot.E, CastRange = 700f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 775
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "quinnr", ChampionName = "quinn", Slot = SpellSlot.R, CastRange = 0f, Delay = 0f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "quinnrfinale", ChampionName = "quinn", Slot = SpellSlot.R, CastRange = 700f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "powerball", ChampionName = "rammus", Slot = SpellSlot.Q, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = 775
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "defensiveballcurl", ChampionName = "rammus", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "puncturingtaunt", ChampionName = "rammus", Slot = SpellSlot.E, CastRange = 325f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "tremors2", ChampionName = "rammus", Slot = SpellSlot.R, CastRange = 300f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "renektoncleave", ChampionName = "renekton", Slot = SpellSlot.Q, CastRange = 225f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "renektonpreexecute", ChampionName = "renekton", Slot = SpellSlot.W, CastRange = 275f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "renektonsliceanddice", ChampionName = "renekton", Slot = SpellSlot.E, 
                        CastRange = 450f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "renektonreignofthetyrant", ChampionName = "renekton", Slot = SpellSlot.R, 
                        CastRange = 0f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "rengarq", ChampionName = "rengar", Slot = SpellSlot.Q, CastRange = 275f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "rengarw", ChampionName = "rengar", Slot = SpellSlot.W, CastRange = 500f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "rengare", ChampionName = "rengar", Slot = SpellSlot.E, CastRange = 1000f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "rengarefinal", 
                        MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "rengarr", ChampionName = "rengar", Slot = SpellSlot.R, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "reksaiq", ChampionName = "reksai", Slot = SpellSlot.Q, CastRange = 275f, Delay = 0f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "reksaiqburrowed", ChampionName = "reksai", Slot = SpellSlot.W, CastRange = 1650f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "reksaiqburrowedmis", MissileSpeed = 1950
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "reksaiw", ChampionName = "reksai", Slot = SpellSlot.W, CastRange = 0f, Delay = 350f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "reksaiwburrowed", ChampionName = "reksai", Slot = SpellSlot.W, CastRange = 200f, 
                        Delay = 500f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "reksaie", ChampionName = "reksai", Slot = SpellSlot.E, CastRange = 250f, Delay = 0f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "reksaieburrowed", ChampionName = "reksai", Slot = SpellSlot.E, CastRange = 350f, 
                        Delay = 900f, HitType = new HitType[] { }, MissileSpeed = 1450
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "reksair", ChampionName = "reksai", Slot = SpellSlot.R, CastRange = 2.147484E+09f, 
                        Delay = 1000f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "riventricleave", ChampionName = "riven", Slot = SpellSlot.Q, CastRange = 270f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "rivenmartyr", ChampionName = "riven", Slot = SpellSlot.W, CastRange = 260f, 
                        Delay = 0f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "rivenfeint", ChampionName = "riven", Slot = SpellSlot.E, CastRange = 0f, Delay = 0f, 
                        HitType = new HitType[] { }, MissileSpeed = 1450
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "rivenfengshuiengine", ChampionName = "riven", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "rivenizunablade", ChampionName = "riven", Slot = SpellSlot.R, CastRange = 1075f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        MissileName = "rivenlightsabermissile", ExtraMissileNames = new[] { "rivenlightsabermissileside" }, 
                        MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "rumbleflamethrower", ChampionName = "rumble", Slot = SpellSlot.Q, CastRange = 600f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "rumbleshield", ChampionName = "rumble", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "rumbegrenade", ChampionName = "rumble", Slot = SpellSlot.E, CastRange = 850f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "rumblecarpetbomb", ChampionName = "rumble", Slot = SpellSlot.R, CastRange = 1700f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ryzeq", ChampionName = "ryze", Slot = SpellSlot.Q, CastRange = 625f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ryzew", ChampionName = "ryze", Slot = SpellSlot.W, CastRange = 600f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl, Project_zed.HitType.Danger }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ryzee", ChampionName = "ryze", Slot = SpellSlot.E, CastRange = 600f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = 1000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ryzer", ChampionName = "ryze", Slot = SpellSlot.R, CastRange = 625f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sejuaniarcticassault", ChampionName = "sejuani", Slot = SpellSlot.Q, CastRange = 650f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = string.Empty, 
                        MissileSpeed = 1450
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sejuaninorthernwinds", ChampionName = "sejuani", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 1000f, HitType = new HitType[] { }, MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sejuaniwintersclaw", ChampionName = "sejuani", Slot = SpellSlot.E, CastRange = 550f, 
                        Delay = 0f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1450
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sejuaniglacialprisoncast", ChampionName = "sejuani", Slot = SpellSlot.R, 
                        CastRange = 1200f, Delay = 250f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileName = "sejuaniglacialprison", 
                        MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "deceive", ChampionName = "shaco", Slot = SpellSlot.Q, CastRange = 1000f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Stealth }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "jackinthebox", ChampionName = "shaco", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1450
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "twoshivpoison", ChampionName = "shaco", Slot = SpellSlot.E, CastRange = 625f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "hallucinatefull", ChampionName = "shaco", Slot = SpellSlot.R, CastRange = 1125f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 395
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "shenvorpalstar", ChampionName = "shen", Slot = SpellSlot.Q, CastRange = 475f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "shenfeint", ChampionName = "shen", Slot = SpellSlot.W, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "shenshadowdash", ChampionName = "shen", Slot = SpellSlot.E, CastRange = 600f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "shenshadowdash", 
                        MissileSpeed = 1250
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "shenstandunited", ChampionName = "shen", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "shyvanadoubleattack", ChampionName = "shyvana", Slot = SpellSlot.Q, CastRange = 275f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "shyvanadoubleattackdragon", ChampionName = "shyvana", Slot = SpellSlot.Q, 
                        CastRange = 325f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "shyvanaimmolationauraqw", ChampionName = "shyvana", Slot = SpellSlot.W, 
                        CastRange = 275f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "shyvanaimmolateddragon", ChampionName = "shyvana", Slot = SpellSlot.W, 
                        CastRange = 250f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "shyvanafireball", ChampionName = "shyvana", Slot = SpellSlot.E, CastRange = 925f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "shyvanafireballmissile", 
                        MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "shyvanafireballdragon2", ChampionName = "shyvana", Slot = SpellSlot.E, 
                        CastRange = 925f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "shyvanatransformcast", ChampionName = "shyvana", Slot = SpellSlot.R, 
                        CastRange = 1000f, Delay = 100f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl, 
                                    Project_zed.HitType.Ultimate
                                }, 
                        MissileName = "shyvanatransformcast", 
                        MissileSpeed = 1100
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "poisentrail", ChampionName = "singed", Slot = SpellSlot.Q, CastRange = 250f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "megaadhesive", ChampionName = "singed", Slot = SpellSlot.W, CastRange = 1175f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 700
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "fling", ChampionName = "singed", Slot = SpellSlot.E, CastRange = 125f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "insanitypotion", ChampionName = "singed", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sionq", ChampionName = "sion", Slot = SpellSlot.Q, CastRange = 600f, Delay = 2000f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sionw", ChampionName = "sion", Slot = SpellSlot.W, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sione", ChampionName = "sion", Slot = SpellSlot.E, CastRange = 725f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "sionemissile", 
                        MissileSpeed = 1800
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sionr", ChampionName = "sion", Slot = SpellSlot.R, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileName = string.Empty, MissileSpeed = 500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sivirq", ChampionName = "sivir", Slot = SpellSlot.Q, CastRange = 1165f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileName = "sivirqmissile", 
                        ExtraMissileNames = new[] { "sivirqmissilereturn" }, MissileSpeed = 1350
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sivirw", ChampionName = "sivir", Slot = SpellSlot.W, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sivire", ChampionName = "sivir", Slot = SpellSlot.E, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sivirr", ChampionName = "sivir", Slot = SpellSlot.R, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "skarnervirulentslash", ChampionName = "skarner", Slot = SpellSlot.Q, CastRange = 350f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "skarnerexoskeleton", ChampionName = "skarner", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "skarnerfracture", ChampionName = "skarner", Slot = SpellSlot.E, CastRange = 1100f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "skarnerfracturemissile", MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "skarnerimpale", ChampionName = "skarner", Slot = SpellSlot.R, CastRange = 350f, 
                        Delay = 350f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sonaq", ChampionName = "sona", Slot = SpellSlot.Q, CastRange = 700f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sonaw", ChampionName = "sona", Slot = SpellSlot.W, CastRange = 1000f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sonae", ChampionName = "sona", Slot = SpellSlot.E, CastRange = 1000f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sonar", ChampionName = "sona", Slot = SpellSlot.R, CastRange = 1000f, Delay = 250f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileName = "sonar", MissileSpeed = 2400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sorakaq", ChampionName = "soraka", Slot = SpellSlot.Q, CastRange = 970f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileName = string.Empty, MissileSpeed = 1100
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sorakaw", ChampionName = "soraka", Slot = SpellSlot.W, CastRange = 750f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sorakae", ChampionName = "soraka", Slot = SpellSlot.E, CastRange = 925f, 
                        Delay = 1750f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "sorakar", ChampionName = "soraka", Slot = SpellSlot.R, CastRange = 25000f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "swaindecrepify", ChampionName = "swain", Slot = SpellSlot.Q, CastRange = 625f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "swainshadowgrasp", ChampionName = "swain", Slot = SpellSlot.W, CastRange = 1040f, 
                        Delay = 1100f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "swainshadowgrasp", MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "swaintorment", ChampionName = "swain", Slot = SpellSlot.E, CastRange = 625f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "swainmetamorphism", ChampionName = "swain", Slot = SpellSlot.R, CastRange = 700f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 950
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "syndraq", ChampionName = "syndra", Slot = SpellSlot.Q, CastRange = 800f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileName = "syndraq", MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "syndrawcast", ChampionName = "syndra", Slot = SpellSlot.W, CastRange = 950f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "syndrawcast", 
                        MissileSpeed = 1450
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "syndrae", ChampionName = "syndra", Slot = SpellSlot.E, CastRange = 950f, Delay = 300f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "syndrae", MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "syndrar", ChampionName = "syndra", Slot = SpellSlot.R, CastRange = 675f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, MissileSpeed = 1250
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "talonnoxiandiplomacy", ChampionName = "talon", Slot = SpellSlot.Q, CastRange = 275f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "talonrake", ChampionName = "talon", Slot = SpellSlot.W, CastRange = 750f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "talonrakemissileone", MissileSpeed = 2300
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "taloncutthroat", ChampionName = "talon", Slot = SpellSlot.E, CastRange = 750f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "talonshadowassault", ChampionName = "talon", Slot = SpellSlot.R, CastRange = 750f, 
                        Delay = 260f, HitType = new[] { Project_zed.HitType.Stealth }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "imbue", ChampionName = "taric", Slot = SpellSlot.Q, CastRange = 750f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "shatter", ChampionName = "taric", Slot = SpellSlot.W, CastRange = 400f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "dazzle", ChampionName = "taric", Slot = SpellSlot.E, CastRange = 625f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "tarichammersmash", ChampionName = "taric", Slot = SpellSlot.R, CastRange = 400f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "blindingdart", ChampionName = "teemo", Slot = SpellSlot.Q, CastRange = 580f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "movequick", ChampionName = "teemo", Slot = SpellSlot.W, CastRange = 0f, Delay = 0f, 
                        HitType = new HitType[] { }, MissileSpeed = 943
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "toxicshot", ChampionName = "teemo", Slot = SpellSlot.E, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "bantamtrap", ChampionName = "teemo", Slot = SpellSlot.R, CastRange = 230f, Delay = 0f, 
                        HitType = new HitType[] { }, MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "threshq", ChampionName = "thresh", Slot = SpellSlot.Q, CastRange = 1175f, 
                        Delay = 500f, HitType = new[] { Project_zed.HitType.CrowdControl, Project_zed.HitType.Danger }, 
                        MissileName = "threshqmissile", MissileSpeed = 1900
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "threshw", ChampionName = "thresh", Slot = SpellSlot.W, CastRange = 950f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "threshe", ChampionName = "thresh", Slot = SpellSlot.E, CastRange = 400f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "threshemissile1", 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "threshrpenta", ChampionName = "thresh", Slot = SpellSlot.R, CastRange = 420f, 
                        Delay = 300f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "tristanaq", ChampionName = "tristana", Slot = SpellSlot.Q, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "tristanaw", ChampionName = "tristana", Slot = SpellSlot.W, CastRange = 900f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1150
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "tristanae", ChampionName = "tristana", Slot = SpellSlot.E, CastRange = 625f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "tristanar", ChampionName = "tristana", Slot = SpellSlot.R, CastRange = 700f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "trundletrollsmash", ChampionName = "trundle", Slot = SpellSlot.Q, CastRange = 275f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "trundledesecrate", ChampionName = "trundle", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "trundlecircle", ChampionName = "trundle", Slot = SpellSlot.E, CastRange = 1100f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "trundlepain", ChampionName = "trundle", Slot = SpellSlot.R, CastRange = 700f, 
                        Delay = 500f, HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "bloodlust", ChampionName = "tryndamere", Slot = SpellSlot.Q, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "mockingshout", ChampionName = "tryndamere", Slot = SpellSlot.W, CastRange = 400f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "slashcast", ChampionName = "tryndamere", Slot = SpellSlot.E, CastRange = 660f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "slashcast", MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "undyingrage", ChampionName = "tryndamere", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "hideinshadows", ChampionName = "twich", Slot = SpellSlot.Q, CastRange = 1000f, 
                        Delay = 450f, HitType = new[] { Project_zed.HitType.Stealth }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "twitchvenomcask", ChampionName = "twich", Slot = SpellSlot.W, CastRange = 800f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "twitchvenomcaskmissile", MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "twitchvenomcaskmissle", ChampionName = "twich", Slot = SpellSlot.W, CastRange = 800f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "expunge", ChampionName = "twich", Slot = SpellSlot.E, CastRange = 1200f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "fullautomatic", ChampionName = "twich", Slot = SpellSlot.R, CastRange = 850f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "wildcards", ChampionName = "twistedfate", Slot = SpellSlot.Q, CastRange = 1450f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "sealfatemissile", MissileSpeed = 1450
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "pickacard", ChampionName = "twistedfate", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "goldcardpreattack", ChampionName = "twistedfate", Slot = SpellSlot.W, 
                        CastRange = 600f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl, Project_zed.HitType.Danger }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "redcardpreattack", ChampionName = "twistedfate", Slot = SpellSlot.W, CastRange = 600f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "bluecardpreattack", ChampionName = "twistedfate", Slot = SpellSlot.W, 
                        CastRange = 600f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "cardmasterstack", ChampionName = "twistedfate", Slot = SpellSlot.E, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "destiny", ChampionName = "twistedfate", Slot = SpellSlot.R, CastRange = 5250f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "udyrtigerstance", ChampionName = "udyr", Slot = SpellSlot.Q, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "udyrturtlestance", ChampionName = "udyr", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "udyrbearstanceattack", ChampionName = "udyr", Slot = SpellSlot.E, CastRange = 250f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "udyrphoenixstance", ChampionName = "udyr", Slot = SpellSlot.R, CastRange = 0f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "urgotheatseekinglineqqmissile", ChampionName = "urgot", Slot = SpellSlot.Q, 
                        CastRange = 1000f, Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, 
                        MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "urgotheatseekingmissile", ChampionName = "urgot", Slot = SpellSlot.Q, 
                        CastRange = 1000f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "urgotterrorcapacitoractive2", ChampionName = "urgot", Slot = SpellSlot.W, 
                        CastRange = 0f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "urgotplasmagrenade", ChampionName = "urgot", Slot = SpellSlot.E, CastRange = 950f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "urgotplasmagrenadeboom", 
                        MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "urgotplasmagrenadeboom", ChampionName = "urgot", Slot = SpellSlot.E, CastRange = 950f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "urgotswap2", ChampionName = "urgot", Slot = SpellSlot.R, CastRange = 850f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1800
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "varusq", ChampionName = "varus", Slot = SpellSlot.Q, CastRange = 1250f, Delay = 0f, 
                        HitType = new[] { Project_zed.HitType.Danger }, MissileName = "varusqmissile", MissileSpeed = 1900
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "varusw", ChampionName = "varus", Slot = SpellSlot.W, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "varuse", ChampionName = "varus", Slot = SpellSlot.E, CastRange = 925f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "varuse", MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "varusr", ChampionName = "varus", Slot = SpellSlot.R, CastRange = 1300f, Delay = 250f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileName = "varusrmissile", MissileSpeed = 1950
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "vaynetumble", ChampionName = "vayne", Slot = SpellSlot.Q, CastRange = 850f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "vaynesilverbolts", ChampionName = "vayne", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "vaynecondemnmissile", ChampionName = "vayne", Slot = SpellSlot.E, CastRange = 450f, 
                        Delay = 500f, HitType = new[] { Project_zed.HitType.CrowdControl, Project_zed.HitType.Danger }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "vayneinquisition", ChampionName = "vayne", Slot = SpellSlot.R, CastRange = 1200f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Stealth }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "veigarbalefulstrike", ChampionName = "veigar", Slot = SpellSlot.Q, CastRange = 950f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, 
                        MissileName = "veigarbalefulstrikemis", MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "veigardarkmatter", ChampionName = "veigar", Slot = SpellSlot.W, CastRange = 900f, 
                        Delay = 1200f, HitType = new HitType[] { }, MissileName = string.Empty, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "veigareventhorizon", ChampionName = "veigar", Slot = SpellSlot.E, CastRange = 650f, 
                        Delay = 0f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = string.Empty, 
                        MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "veigarprimordialburst", ChampionName = "veigar", Slot = SpellSlot.R, CastRange = 850f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "velkozq", ChampionName = "velkoz", Slot = SpellSlot.Q, CastRange = 1050f, 
                        Delay = 300f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "velkozqmissile", 
                        MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "velkozqmissle", ChampionName = "velkoz", Slot = SpellSlot.Q, CastRange = 1050f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "velkozqplitactive", ChampionName = "velkoz", Slot = SpellSlot.Q, CastRange = 1050f, 
                        Delay = 0f, HitType = new[] { Project_zed.HitType.CrowdControl, Project_zed.HitType.Danger }, 
                        MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "velkozw", ChampionName = "velkoz", Slot = SpellSlot.W, CastRange = 1050f, Delay = 0f, 
                        HitType = new HitType[] { }, MissileName = "velkozwmissile", MissileSpeed = 1200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "velkoze", ChampionName = "velkoz", Slot = SpellSlot.E, CastRange = 850f, Delay = 0f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "velkozemissile", 
                        MissileSpeed = 1700
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "velkozr", ChampionName = "velkoz", Slot = SpellSlot.R, CastRange = 1575f, Delay = 0f, 
                        HitType = new[] { Project_zed.HitType.Ultimate }, MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "viq", ChampionName = "vi", Slot = SpellSlot.Q, CastRange = 800f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "viw", ChampionName = "vi", Slot = SpellSlot.W, CastRange = 0f, Delay = 0f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "vie", ChampionName = "vi", Slot = SpellSlot.E, CastRange = 600f, Delay = 0f, 
                        HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "vir", ChampionName = "vi", Slot = SpellSlot.R, CastRange = 800f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "viktorpowertransfer", ChampionName = "viktor", Slot = SpellSlot.Q, CastRange = 600f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "viktorgravitonfield", ChampionName = "viktor", Slot = SpellSlot.W, CastRange = 815f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "viktordeathray", ChampionName = "viktor", Slot = SpellSlot.E, CastRange = 700f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, MissileName = "viktordeathraymis", 
                        MissileSpeed = 1210
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "viktorchaosstorm", ChampionName = "viktor", Slot = SpellSlot.R, CastRange = 700f, 
                        Delay = 350f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.CrowdControl, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.Danger
                                }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "vladimirtransfusion", ChampionName = "vladimir", Slot = SpellSlot.Q, CastRange = 600f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "vladimirsanguinepool", ChampionName = "vladimir", Slot = SpellSlot.W, 
                        CastRange = 350f, Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "vladimirtidesofblood", ChampionName = "vladimir", Slot = SpellSlot.E, 
                        CastRange = 610f, Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1100
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "vladimirhemoplague", ChampionName = "vladimir", Slot = SpellSlot.R, CastRange = 875f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "volibearq", ChampionName = "volibear", Slot = SpellSlot.Q, CastRange = 300f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "volibearw", ChampionName = "volibear", Slot = SpellSlot.W, CastRange = 400f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = 1450
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "volibeare", ChampionName = "volibear", Slot = SpellSlot.E, CastRange = 425f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 825
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "volibearr", ChampionName = "volibear", Slot = SpellSlot.R, CastRange = 425f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = 825
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "hungeringstrike", ChampionName = "warwick", Slot = SpellSlot.Q, CastRange = 400f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "hunterscall", ChampionName = "warwick", Slot = SpellSlot.W, CastRange = 1000f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "bloodscent", ChampionName = "warwick", Slot = SpellSlot.E, CastRange = 1250f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "infiniteduress", ChampionName = "warwick", Slot = SpellSlot.R, CastRange = 700f, 
                        Delay = 250f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "xeratharcanopulsechargeup", ChampionName = "xerath", Slot = SpellSlot.Q, 
                        CastRange = 750f, Delay = 750f, HitType = new HitType[] { }, MissileSpeed = 500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "xeratharcanebarrage2", ChampionName = "xerath", Slot = SpellSlot.W, CastRange = 1100f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "xeratharcanebarrage2", MissileSpeed = 20
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "xerathmagespear", ChampionName = "xerath", Slot = SpellSlot.E, CastRange = 1050f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl, Project_zed.HitType.Danger }, 
                        MissileName = "xerathmagespearmissile", MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "xerathlocusofpower2", ChampionName = "xerath", Slot = SpellSlot.R, CastRange = 5600f, 
                        Delay = 750f, HitType = new HitType[] { }, MissileSpeed = 500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "xenzhaothrust3", ChampionName = "xinzhao", Slot = SpellSlot.Q, CastRange = 400f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "xenzhaobattlecry", ChampionName = "xinzhao", Slot = SpellSlot.W, CastRange = 0f, 
                        Delay = 0f, HitType = new HitType[] { }, MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "xenzhaosweep", ChampionName = "xinzhao", Slot = SpellSlot.E, CastRange = 600f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl, Project_zed.HitType.Danger }, 
                        MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "xenzhaoparry", ChampionName = "xinzhao", Slot = SpellSlot.R, CastRange = 375f, 
                        Delay = 250f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "yasuoqw", ChampionName = "yasuo", Slot = SpellSlot.Q, CastRange = 475f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "yasuoq2w", ChampionName = "yasuo", Slot = SpellSlot.Q, CastRange = 475f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "yasuoq3", ChampionName = "yasuo", Slot = SpellSlot.Q, CastRange = 1000f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "yasuoq3mis", 
                        MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "yasuowmovingwall", ChampionName = "yasuo", Slot = SpellSlot.W, CastRange = 400f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "yasuodashwrapper", ChampionName = "yasuo", Slot = SpellSlot.E, CastRange = 475f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 20
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "yasuorknockupcombow", ChampionName = "yasuo", Slot = SpellSlot.R, CastRange = 1200f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "yorickspectral", ChampionName = "yorick", Slot = SpellSlot.Q, CastRange = 350f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "yorickdecayed", ChampionName = "yorick", Slot = SpellSlot.W, CastRange = 600f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "yorickravenous", ChampionName = "yorick", Slot = SpellSlot.E, CastRange = 550f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "yorickreviveally", ChampionName = "yorick", Slot = SpellSlot.R, CastRange = 900f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "zacq", ChampionName = "zac", Slot = SpellSlot.Q, CastRange = 550f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "zacq", MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "zacw", ChampionName = "zac", Slot = SpellSlot.W, CastRange = 350f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "zace", ChampionName = "zac", Slot = SpellSlot.E, CastRange = 1550f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1500
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "zacr", ChampionName = "zac", Slot = SpellSlot.R, CastRange = 850f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.CrowdControl }, 
                        MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "zedq", ChampionName = "zed", Slot = SpellSlot.Q, CastRange = 900f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileName = "zedshurikenmisone", 
                        FromObject = new[] { "Zed_Base_W_tar.troy", "Zed_Base_W_cloneswap_buf.troy" }, 
                        ExtraMissileNames = new[] { "zedshurikenmistwo", "zedshurikenmisthree" }, MissileSpeed = 1700
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "zedw", ChampionName = "zed", Slot = SpellSlot.W, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = 1600
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "zede", ChampionName = "zed", Slot = SpellSlot.E, CastRange = 300f, Delay = 0f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "zedr", ChampionName = "zed", Slot = SpellSlot.R, CastRange = 850f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.Danger }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ziggsq", ChampionName = "ziggs", Slot = SpellSlot.Q, CastRange = 850f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileName = "ziggsqspell", 
                        ExtraMissileNames = new[] { "ziggsqspell2", "ziggsqspell3" }, MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ziggsw", ChampionName = "ziggs", Slot = SpellSlot.W, CastRange = 850f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "ziggsw", MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ziggswtoggle", ChampionName = "ziggs", Slot = SpellSlot.W, CastRange = 850f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ziggse", ChampionName = "ziggs", Slot = SpellSlot.E, CastRange = 850f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileName = "ziggse", MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ziggse2", ChampionName = "ziggs", Slot = SpellSlot.E, CastRange = 850f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "ziggsr", ChampionName = "ziggs", Slot = SpellSlot.R, CastRange = 2250f, Delay = 1800f, 
                        HitType = new[] { Project_zed.HitType.Danger, Project_zed.HitType.Ultimate }, 
                        MissileName = "ziggsr", MissileSpeed = 1750
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "zileanq", ChampionName = "zilean", Slot = SpellSlot.Q, CastRange = 900f, Delay = 300f, 
                        HitType = new HitType[] { }, MissileName = "zileanqmissile", MissileSpeed = 2000
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "zileanw", ChampionName = "zilean", Slot = SpellSlot.W, CastRange = 0f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "zileane", ChampionName = "zilean", Slot = SpellSlot.E, CastRange = 700f, Delay = 250f, 
                        HitType = new[] { Project_zed.HitType.CrowdControl }, MissileSpeed = 1100
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "zileanr", ChampionName = "zilean", Slot = SpellSlot.R, CastRange = 780f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = int.MaxValue
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "zyraqfissure", ChampionName = "zyra", Slot = SpellSlot.Q, CastRange = 800f, 
                        Delay = 250f, HitType = new HitType[] { }, MissileName = "zyraqfissure", MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "zyraseed", ChampionName = "zyra", Slot = SpellSlot.W, CastRange = 800f, Delay = 250f, 
                        HitType = new HitType[] { }, MissileSpeed = 2200
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "zyragraspingroots", ChampionName = "zyra", Slot = SpellSlot.E, CastRange = 1100f, 
                        Delay = 250f, HitType = new[] { Project_zed.HitType.CrowdControl }, 
                        MissileName = "zyragraspingroots", MissileSpeed = 1400
                    });

            Spells.Add(
                new Spelldata
                    {
                        SDataName = "zyrabramblezone", ChampionName = "zyra", Slot = SpellSlot.R, CastRange = 700f, 
                        Delay = 250f, 
                        HitType =
                            new[]
                                {
                                    Project_zed.HitType.Danger, Project_zed.HitType.Ultimate, 
                                    Project_zed.HitType.CrowdControl
                                }, 
                        MissileSpeed = int.MaxValue
                    });
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the spells.
        /// </summary>
        /// <value>
        ///     The spells.
        /// </value>
        public static List<Spelldata> Spells { get; set; }

        /// <summary>
        ///     Gets or sets the cast range.
        /// </summary>
        public float CastRange { get; set; }

        /// <summary>
        ///     Gets or sets the champion name.
        /// </summary>
        public string ChampionName { get; set; }

        /// <summary>
        ///     Gets or sets the delay.
        /// </summary>
        public float Delay { get; set; }

        /// <summary>
        ///     Gets or sets the extra missile names.
        /// </summary>
        public string[] ExtraMissileNames { get; set; }

        /// <summary>
        ///     Gets or sets the from object.
        /// </summary>
        public string[] FromObject { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether global.
        /// </summary>
        public bool Global { get; set; }

        /// <summary>
        ///     Gets or sets the hit type.
        /// </summary>
        public HitType[] HitType { get; set; }

        /// <summary>
        ///     Gets or sets the missile name.
        /// </summary>
        public string MissileName { get; set; }

        /// <summary>
        ///     Gets or sets the missile speed.
        /// </summary>
        public int MissileSpeed { get; set; }

        /// <summary>
        ///     Gets or sets the s data name.
        /// </summary>
        public string SDataName { get; set; }

        /// <summary>
        ///     Gets or sets the slot.
        /// </summary>
        public SpellSlot Slot { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Gets the spelldata by the missile.
        /// </summary>
        /// <param name="missilename">The missilename.</param>
        /// <returns>The spelldata instance that matches the missile names.</returns>
        public static Spelldata GetByMissileName(string missilename)
        {
            return
                Spells.FirstOrDefault(
                    sdata =>
                    (sdata.MissileName != null && sdata.MissileName.ToLower() == missilename)
                    || (sdata.ExtraMissileNames != null && sdata.ExtraMissileNames.Contains(missilename)));
        }

        #endregion
    }
}