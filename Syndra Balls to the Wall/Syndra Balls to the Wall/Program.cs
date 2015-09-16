// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Syndra_Balls_to_the_Wall
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;

    using LeagueSharp;
    using LeagueSharp.Common;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Gets or sets the q.
        /// </summary>
        /// <value>
        /// The q.
        /// </value>
        public static Spell Q { get; set; }

        /// <summary>
        /// Gets or sets the w.
        /// </summary>
        /// <value>
        /// The w.
        /// </value>
        public static Spell W { get; set; }

        /// <summary>
        /// Gets or sets the e.
        /// </summary>
        /// <value>
        /// The e.
        /// </value>
        public static Spell E { get; set; }

        /// <summary>
        /// Gets or sets the r.
        /// </summary>
        /// <value>
        /// The r.
        /// </value>
        public static Spell R { get; set; }

        /// <summary>
        /// Gets or sets the menu.
        /// </summary>
        /// <value>
        /// The menu.
        /// </value>
        public static Menu Menu { get; set; }

        /// <summary>
        /// Gets or sets the orbwalker.
        /// </summary>
        /// <value>
        /// The orbwalker.
        /// </value>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        public static Orbwalking.Orbwalker Orbwalker { get; set; }

        /// <summary>
        /// Gets the player.
        /// </summary>
        /// <value>
        /// The player.
        /// </value>
        private static Obj_AI_Hero Player
        {
            get
            {
                return ObjectManager.Player;
            }
        }

        /// <summary>
        /// The entry point of the application
        /// </summary>
        /// <param name="args">
        /// The arguments.
        /// </param>
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        /// <summary>
        /// Handles the OnGameLoad of the CustomEvents.Game class.
        /// </summary>
        /// <param name="args">
        /// The <see cref="EventArgs"/> instance containing the event data.
        /// </param>
        static void Game_OnGameLoad(EventArgs args)
        {
            if (Player.ChampionName != "Syndra")
            {
                return;
            }

            Q = new Spell(SpellSlot.Q);
            W = new Spell(SpellSlot.W);
            E = new Spell(SpellSlot.E);
            R = new Spell(SpellSlot.R);

            CreateMenu();

            OrbManager.Init();

            Game.OnUpdate += Game_OnUpdate;
            Drawing.OnDraw += Drawing_OnDraw;
        }

        /// <summary>
        /// Creates the menu.
        /// </summary>
        private static void CreateMenu()
        {
            Menu = new Menu("Syndra Balls to the Wall", "Syndra Balls to the Wall", true);

            var targetselectorMenu = new Menu("Target Selector", "TS");
            TargetSelector.AddToMenu(targetselectorMenu);
            Menu.AddSubMenu(targetselectorMenu);

            var orbwalkMenu = new Menu("Orbwalker", "Orbwalker");
            Orbwalker = new Orbwalking.Orbwalker(orbwalkMenu);
            Menu.AddSubMenu(orbwalkMenu);

            var comboMenu = new Menu("Combo Settings", "Combo");
            comboMenu.AddItem(new MenuItem("UseQCombo", "Use Q").SetValue(true));
            comboMenu.AddItem(new MenuItem("UseWCombo", "Use W").SetValue(true));
            comboMenu.AddItem(new MenuItem("UseECombo", "Use E").SetValue(true));
            comboMenu.AddItem(new MenuItem("UseRCombo", "Use R").SetValue(true));

            // all in
            Menu.AddSubMenu(comboMenu);

            var harassMenu = new Menu("Harass Settings", "Harass");
            harassMenu.AddItem(new MenuItem("UseQHarass", "Use Q Harass").SetValue(true));
            harassMenu.AddItem(new MenuItem("UseWHarass", "Use W to Harass").SetValue(true));
            harassMenu.AddItem(new MenuItem("UseEHarass", "Use E Harass").SetValue(true));
            harassMenu.AddItem(
                new MenuItem("HarassToggle", "Harass! (Toggle)").SetValue(new KeyBind(84, KeyBindType.Toggle)));
            Menu.AddSubMenu(harassMenu);

            var lasthitMenu = new Menu("Last Hit Settings", "Lasthit");
            lasthitMenu.AddItem(new MenuItem("UseQLastQ", "Use Q Lasthit").SetValue(false));
            Menu.AddSubMenu(lasthitMenu);

            var laneClearMenu = new Menu("Lane Clear Settings", "LaneClear");
            laneClearMenu.AddItem(new MenuItem("UseQLaneClear", "Use Q").SetValue(true));
            laneClearMenu.AddItem(new MenuItem("UseQLaneClear", "Use W").SetValue(true));
            laneClearMenu.AddItem(new MenuItem("UseELaneClear", "Use E").SetValue(true));
            laneClearMenu.AddItem(new MenuItem("WCmana", "Wave Clear Mana % >=")).SetValue(new Slider(40, 1, 100));
            Menu.AddSubMenu(laneClearMenu);

            var killstealMenu = new Menu("Kill Steal Settings", "KS");
            killstealMenu.AddItem(new MenuItem("UseQKS", "Use Q").SetValue(true));
            killstealMenu.AddItem(new MenuItem("UseEKS", "Use E").SetValue(true));
            killstealMenu.AddItem(new MenuItem("UseRKS", "Use R").SetValue(true));
            Menu.AddSubMenu(killstealMenu);

            var drawingMenu = new Menu("Drawing Settings", "Drawings");
            drawingMenu.AddItem(new MenuItem("DrawQ", "Draw Q").SetValue(true));
            drawingMenu.AddItem(new MenuItem("DrawW", "Draw W").SetValue(false));
            drawingMenu.AddItem(new MenuItem("DrawE", "Draw E").SetValue(false));
            drawingMenu.AddItem(new MenuItem("DrawR", "Draw R").SetValue(false));
            Menu.AddSubMenu(drawingMenu);

            Menu.AddToMainMenu();
        }

        /// <summary>
        /// Handles the OnDraw event for the Drawing class.
        /// </summary>
        /// <param name="args">
        /// The <see cref="EventArgs"/> instance containing the event data.
        /// </param>
        static void Drawing_OnDraw(EventArgs args)
        {
            var drawQ = Menu.Item("DrawQ").IsActive();
            var drawW = Menu.Item("DrawW").IsActive();
            var drawE = Menu.Item("DrawE").IsActive();
            var drawR = Menu.Item("DrawR").IsActive();

            if (drawQ)
            {
                Render.Circle.DrawCircle(Player.Position, Q.Range, Q.IsReady() ? Color.Aqua : Color.Red);
            }

            if (drawW)
            {
                Render.Circle.DrawCircle(Player.Position, W.Range, W.IsReady() ? Color.Aqua : Color.Red);
            }

            if (drawE)
            {
                Render.Circle.DrawCircle(Player.Position, E.Range, E.IsReady() ? Color.Aqua : Color.Red);
            }

            if (drawR)
            {
                Render.Circle.DrawCircle(Player.Position, R.Range, R.IsReady() ? Color.Aqua : Color.Red);
            }

            foreach (var orb in OrbManager.Spheres.Select(x => x.Position))
            {
                Render.Circle.DrawCircle(orb, 50, Color.Turquoise);
            }
        }

        /// <summary>
        /// Game_s the on update.
        /// </summary>
        /// <param name="args">
        /// The <see cref="EventArgs"/> instance containing the event data.
        /// </param>
        static void Game_OnUpdate(EventArgs args)
        {
            switch (Orbwalker.ActiveMode)
            {
                case Orbwalking.OrbwalkingMode.Combo:
                    DoCombo(true);
                    break;
                case Orbwalking.OrbwalkingMode.Mixed:
                    DoHarass();
                    break;
                case Orbwalking.OrbwalkingMode.LaneClear:
                    DoLaneClear();
                    break;
                case Orbwalking.OrbwalkingMode.LastHit:
                    DoLastHit();
                    break;
            }
        }

        /// <summary>
        /// Does the last hit.
        /// </summary>
        private static void DoLastHit()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Does the lane clear.
        /// </summary>
        private static void DoLaneClear()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Does the harass.
        /// </summary>
        private static void DoHarass()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Does the combo.
        /// </summary>
        /// <param name="b">
        /// if set to <c>true</c> [b].
        /// </param>
        private static void DoCombo(bool b)
        {
            throw new NotImplementedException();
        }
    }
}
