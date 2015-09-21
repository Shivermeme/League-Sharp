// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;

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

            Q = new Spell(SpellSlot.Q, 825f);
            W = new Spell(SpellSlot.W, 925f);
            E = new Spell(SpellSlot.E, 700f);
            R = new Spell(SpellSlot.R, 675f);

            Q.SetSkillshot(0.25f, 180f, 1750f, false, SkillshotType.SkillshotCircle);
            W.SetSkillshot(0.25f, 180f, 1750f, false, SkillshotType.SkillshotCircle);
            E.SetSkillshot(0.25f, (float) (45 * 0.5f), 2500f, false, SkillshotType.SkillshotCone);

            CreateMenu();

            OrbManager.Init();

            Game.OnUpdate += Game_OnUpdate;
            Drawing.OnDraw += Drawing_OnDraw;
            Interrupter2.OnInterruptableTarget += Interrupter2_OnInterruptableTarget;
        }

        static void Interrupter2_OnInterruptableTarget(Obj_AI_Hero sender, Interrupter2.InterruptableTargetEventArgs args)
        {
            if (!Menu.Item("InterruptQE").GetValue<bool>())
            {
                return;
            }

            if (Player.Distance(sender) < E.Range && E.IsReady())
            {
                Q.Cast(sender.ServerPosition);
                E.Cast(sender.ServerPosition);
            }

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
            comboMenu.AddItem(new MenuItem("UseQECombo", "Use QE Combo").SetValue(true));
            Menu.AddSubMenu(comboMenu);
            
            var harassMenu = new Menu("Harass Settings", "Harass");
            harassMenu.AddItem(new MenuItem("UseQHarass", "Use Q Harass").SetValue(true));
            harassMenu.AddItem(new MenuItem("UseWHarass", "Use W to Harass").SetValue(true));
            harassMenu.AddItem(new MenuItem("UseEHarass", "Use E Harass").SetValue(true));
            harassMenu.AddItem(new MenuItem("UseQEHarass", "Use QE Harass"));
            harassMenu.AddItem(new MenuItem("Q if Enemy AA", "Harass Q Enemy AA").SetValue(true));
            harassMenu.AddItem(new MenuItem("HarassMana", "Harass if mana > x %").SetValue(new Slider(30, 1, 100)));
            harassMenu.AddItem(
                new MenuItem("HarassToggle", "Harass! (Toggle)").SetValue(new KeyBind(84, KeyBindType.Toggle)));
            Menu.AddSubMenu(harassMenu);

            var lasthitMenu = new Menu("Last Hit Settings", "Lasthit");
            lasthitMenu.AddItem(new MenuItem("UseQLastQ", "Use Q Lasthit").SetValue(false));
            Menu.AddSubMenu(lasthitMenu);

            var laneClearMenu = new Menu("Lane Clear Settings", "LaneClear");
            laneClearMenu.AddItem(new MenuItem("UseQLaneClear", "Use Q").SetValue(true));
            laneClearMenu.AddItem(new MenuItem("UseWLaneClear", "Use W").SetValue(true));
            laneClearMenu.AddItem(new MenuItem("UseELaneClear", "Use E").SetValue(true));
            laneClearMenu.AddItem(new MenuItem("WCmana", "Wave Clear Mana % >=")).SetValue(new Slider(40, 1, 100));
            Menu.AddSubMenu(laneClearMenu);

            var jungleFarmMenu = new Menu("Jungle Clear Settings", "Jungle Clear");
            jungleFarmMenu.AddItem(new MenuItem("UseQJungleClear", "UseQ").SetValue(true));
            jungleFarmMenu.AddItem(new MenuItem("UseWJungleClear", "UseW").SetValue(true));
            jungleFarmMenu.AddItem(new MenuItem("UseEJungleClear", "UseE").SetValue(true));
            Menu.AddSubMenu(jungleFarmMenu);

            var killstealMenu = new Menu("Kill Steal Settings", "KS");
            killstealMenu.AddItem(new MenuItem("UseQKS", "Use Q").SetValue(true));
            killstealMenu.AddItem(new MenuItem("UseEKS", "Use E").SetValue(true));
            killstealMenu.AddItem(new MenuItem("UseRKS", "Use R").SetValue(true));
            killstealMenu.AddItem(new MenuItem("UseQEKS", "Use QE KS").SetValue(true));
            Menu.AddSubMenu(killstealMenu);

            var drawingMenu = new Menu("Drawing Settings", "Drawings");
            drawingMenu.AddItem(new MenuItem("DrawQ", "Draw Q").SetValue(true));
            drawingMenu.AddItem(new MenuItem("DrawW", "Draw W").SetValue(false));
            drawingMenu.AddItem(new MenuItem("DrawE", "Draw E").SetValue(false));
            drawingMenu.AddItem(new MenuItem("DrawR", "Draw R").SetValue(false));
            Menu.AddSubMenu(drawingMenu);

            var interruptMenu = new Menu("Interrupt Settings", "Interrupt!");
            interruptMenu.AddItem(new MenuItem("InterruptQE", "Interrupt with QE").SetValue(true));
            interruptMenu.AddItem(new MenuItem("InterruptDangerous", "Interrupt Only Dangerous").SetValue(false));

            var miscMenu = new Menu("Misc", "Misc!");
            miscMenu.AddItem(new MenuItem("AntiGap Closer", "Use On Gap Closer"));
            Menu.AddSubMenu(miscMenu);

            var qeMenu = new Menu("QESettings", "QE Settings");
            qeMenu.AddItem(
                new MenuItem("QETargetNearMouse", "QE Target Near Mouse").SetValue(new KeyBind(88, KeyBindType.Press)));
            Menu.AddSubMenu(qeMenu);

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
                    DoHarass(false);
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
            var useQ = Menu.Item("UseQLastQ").GetValue<bool>();

            if (useQ && Q.IsReady())
            {
                var minion = MinionManager.GetMinions(Q.Range)
                    .FirstOrDefault(x => x.IsValidTarget(Q.Range) && Q.GetDamage(x) >= x.Health);

                Q.Cast(minion);
            }  
        }

        /// <summary>
        /// Does the lane clear.
        /// </summary>
        private static void DoLaneClear()
        {
            var lcm = Menu.Item("WCmana").GetValue<Slider>().Value;

            if (Player.ManaPercent <= lcm)
            {
                return;
            }

            var qlc = MinionManager.GetMinions(ObjectManager.Player.ServerPosition, Q.Range);
            var wlc = MinionManager.GetMinions(ObjectManager.Player.ServerPosition, W.Range);
            var useqlc = Menu.Item("UseQLaneClear").GetValue<bool>();
            var usewlc = Menu.Item("UseWLaneClear").GetValue<bool>();

            if (Q.IsReady() && useqlc)
            {
                var qlck = Q.GetCircularFarmLocation(qlc, Q.Width);

                if (qlck.MinionsHit >= 3)
                {
                    Q.Cast(qlck.Position);
                }
            }

            if (W.IsReady() && usewlc)
            {
                var wlck = W.GetCircularFarmLocation(wlc, W.Width);

                if (wlck.MinionsHit >= 3)
                {
                    W.Cast(wlck.Position);
                }
            }
        }

        /// <summary>
        /// Does the harass.
        /// </summary>
        private static void DoHarass(bool toggle)
        {
            var target = TargetSelector.GetTarget(Q.Range, TargetSelector.DamageType.Magical);

            if (toggle && Player.ManaPercent < Menu.Item("HarassMana").GetValue<Slider>().Value)
            {
                return;
            }
        }

        /// <summary>
        /// Does the combo.
        /// </summary>
        /// <param name="b">
        /// if set to <c>true</c> [b].
        /// </param>
        private static void DoCombo(bool b)
        {
            
        }
    }
}
