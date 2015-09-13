using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_zed
{
    using System.Diagnostics.CodeAnalysis;

    using LeagueSharp;
    using LeagueSharp.Common;

    /// <summary>
    /// Manages Zed's Shadows.
    /// </summary>
    public class ShadowManager
    {
        /// <summary>
        /// The state of a shadow.
        /// </summary>
        public enum ShadowState
        {
            /// <summary>
            /// The shadow spell is not ready.
            /// </summary>
            NotReady,

            /// <summary>
            /// The shadow can be casted, without swapping.
            /// </summary>
            Cast,

            /// <summary>
            /// The shadow will be swapped to.
            /// </summary>
            Swap
        }

        /// <summary>
        /// Gets the w shadow.
        /// </summary>
        /// <value>
        /// The w shadow.
        /// </value>
        public static GameObject WShadow { get; private set; }

        /// <summary>
        /// Gets the r shadow.
        /// </summary>
        /// <value>
        /// The r shadow.
        /// </value>
        public static GameObject RShadow { get; private set; }

        /// <summary>
        /// Gets the state of the w shadow.
        /// </summary>
        /// <value>
        /// The state of the w shadow.
        /// </value>
        public static ShadowState WShadowState
        {
            get
            {
                if (!Program.W.IsReady())
                {
                    return ShadowState.NotReady;
                }

                return Program.W.Instance.Name.Equals("ZedW") ? ShadowState.Cast : ShadowState.Swap;
            }
        }

        /// <summary>
        /// Gets the state of the w shadow.
        /// </summary>
        /// <value>
        /// The state of the w shadow.
        /// </value>
        public static ShadowState RShadowState
        {
            get
            {
                if (!Program.R.IsReady())
                {
                    return ShadowState.NotReady;
                }

                return Program.R.Instance.Name.Equals("ZedR") ? ShadowState.Cast : ShadowState.Swap;
            }
        }

        /// <summary>
        /// Gets the shadows.
        /// </summary>
        /// <value>
        /// The shadows.
        /// </value>
        public static IEnumerable<GameObject> Shadows
        {
            get
            {
                var list = new List<GameObject>();

                if (WShadow != null)
                {
                    list.Add(WShadow);
                }

                if (RShadow != null)
                {
                    list.Add(RShadow);
                }

                return list;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance can cast e.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance can cast e; otherwise, <c>false</c>.
        /// </value>
        public static bool CanCastE
        {
            get
            {
                return
                    HeroManager.Enemies.Any(
                        x =>
                        x.IsValidTarget()
                        && (Program.E.IsInRange(x)
                            || Shadows.Any(y => y.Position.Distance(x.ServerPosition) <= Program.E.Range)));
            }
        }

        /// <summary>
        /// Gets or sets the last r casted.
        /// </summary>
        /// <value>
        /// The last r casted.
        /// </value>
        private static int LastRCasted { get; set; }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public static void Initialize()
        {
            GameObject.OnCreate += GameObject_OnCreate;
            Game.OnUpdate += Game_OnUpdate;
        }

        /// <summary>
        /// Determines whether this instance can swap to w depending on  the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="lastTarget">The last target.</param>
        /// <returns>True if the player can safely swap to the W shadow.</returns>
        public static bool CanSwapToW(Obj_AI_Hero target, Obj_AI_Hero lastTarget)
        {
            if (WShadowState != ShadowState.Swap || WShadow == null)
            {
                return false;
            }

            if (Program.Menu.Item("ShadowSwapHP").GetValue<Slider>().Value > ObjectManager.Player.HealthPercent)
            {
                return false;
            }

            if (WShadow.Position.CountEnemiesInRange(700) >= Program.Menu.Item("DontWIntoEnemies").GetValue<Slider>().Value)
            {
                return false;
            }

            return !(WShadow.Position.Distance(target.ServerPosition) > ObjectManager.Player.Distance(target));
        }

        /// <summary>
        /// Handles the OnUpdate event of the Game class.
        /// </summary>
        /// <param name="args">The <see cref="EventArgs"/> instance containing the event data.</param>
        private static void Game_OnUpdate(EventArgs args)
        {      
            if (WShadow != null)
            {
                if (!WShadow.IsValid || WShadow.IsDead)
                {
                    WShadow = null;
                }
            }

            if (RShadow != null)
            {
                if (!RShadow.IsValid || RShadow.IsDead)
                {
                    RShadow = null;
                }
            }          
        }

        /// <summary>
        /// Handles the OnCreate event of the GameObject class.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The <see cref="EventArgs"/> instance containing the event data.</param>
        private static void GameObject_OnCreate(GameObject sender, EventArgs args)
        {
            if (!sender.IsValid<Obj_AI_Base>())
            {
                return;
            }

            var obj = (Obj_AI_Minion)sender;

            if (!(obj.IsAlly && obj.CharData.BaseSkinName.Equals("zedshadow")))
            {
                return;
            }

            var lastCastedSpell = ObjectManager.Player.LastCastedSpellName();

            if (lastCastedSpell.Equals("ZedW"))
            {
                WShadow = sender;
            }
            else if (lastCastedSpell.Equals("ZedR") && Environment.TickCount - LastRCasted >= 1000)
            {
                RShadow = sender;
                LastRCasted = Environment.TickCount;
            }
        }

        /// <summary>
        /// Determines whether this instance can swap to r with the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="lastTarget">The last target.</param>
        /// <returns>If the player can swap to the ult shadow.</returns>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        public static bool CanSwapToR(Obj_AI_Hero target, Obj_AI_Hero lastTarget)
        {
            if (Program.Menu.Item("ShadowSwapHP").GetValue<Slider>().Value > ObjectManager.Player.HealthPercent)
            {
                return false;
            }

            if (RShadow.Position.Distance(target.ServerPosition) > ObjectManager.Player.Distance(target))
            {
                return false;
            }

            return true;
        }
    }
}
