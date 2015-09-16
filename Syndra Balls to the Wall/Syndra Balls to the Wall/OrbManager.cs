// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OrbManager.cs" company="">
//   
// </copyright>
// <summary>
//   Manages Syndra's Spheres.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Syndra_Balls_to_the_Wall
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using LeagueSharp;
    using LeagueSharp.Common;

    /// <summary>
    ///     Manages Syndra's Spheres.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", 
        Justification = "Reviewed. Suppression is OK here.")]
    public class OrbManager
    {
        #region Static Fields

        /// <summary>
        ///     The orbs
        /// </summary>
        private static readonly List<Obj_AI_Base> Orbs = new List<Obj_AI_Base>();

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the spheres.
        /// </summary>
        /// <value>
        ///     The spheres.
        /// </value>
        public static IEnumerable<Obj_AI_Base> Spheres
        {
            get
            {
                return Orbs.Where(x => x.IsValid && !x.IsDead);
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Initializes this instance.
        /// </summary>
        public static void Init()
        {
            GameObject.OnCreate += GameObject_OnCreate;
            GameObject.OnDelete += GameObject_OnDelete;
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Handles the OnCreate event of the GameObject class.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="args">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private static void GameObject_OnCreate(GameObject sender, EventArgs args)
        {
            if (!sender.IsAlly || !sender.IsValid<Obj_AI_Base>())
            {
                return;
            }

            var obj = (Obj_AI_Base)sender;

            if (obj.CharData.BaseSkinName.Equals("syndrasphere"))
            {
                Orbs.Add(obj);
            }
        }

        /// <summary>
        ///     Handles the OnDelete event of the GameObject class.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="args">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private static void GameObject_OnDelete(GameObject sender, EventArgs args)
        {
            if (!sender.IsAlly || !sender.IsValid<Obj_AI_Base>())
            {
                return;
            }

            var obj = (Obj_AI_Base)sender;

            if (obj.CharData.BaseSkinName.Equals("syndrasphere"))
            {
                Orbs.RemoveAll(x => x.NetworkId == obj.NetworkId);
            }
        }

        #endregion
    }
}