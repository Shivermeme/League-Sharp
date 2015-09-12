using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_zed
{
    using LeagueSharp;
    using LeagueSharp.Common;

    class ShadowManager
    {
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
            if (Program.W.Instance.Name.Equals("ZedW") || WShadow == null)
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

            if (lastTarget.IsDead)
            {
                return true;
            }

            return true;
        }

        private static void Game_OnUpdate(EventArgs args)
        {
            
            if (!WShadow.IsValid || WShadow.IsDead)
            {
                WShadow = null;
            }

            if (!RShadow.IsValid || RShadow.IsDead)
            {
                RShadow = null;
            }
        }

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
    }
}
