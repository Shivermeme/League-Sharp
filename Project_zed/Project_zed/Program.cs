using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using Color = System.Drawing.Color;

namespace Project_zed
{
    class Program
    {
        private static Spell Q { get; set; }
        private static Spell W { get; set; }
        private static Spell E { get; set; }
        private static Spell R { get; set; }

        private static Menu Menu { get; set; }

        private static Obj_AI_Hero Player
        {
            get
            {
                return ObjectManager.Player;
            }
        }

        private static Orbwalking.Orbwalker Orbwalker { get; set; }

        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        static void Game_OnGameLoad(EventArgs args)
        {

            if (Player.ChampionName != "Zed")
                return;

            Q = new Spell(SpellSlot.Q, 900f);
            W = new Spell(SpellSlot.W, 600f);
            E = new Spell(SpellSlot.E, 290f);
            R = new Spell(SpellSlot.R, 625f);

            Q.SetSkillshot(.4f, 45, 1700, false, SkillshotType.SkillshotLine);

            CreateMenu();

            Game.PrintChat("<font color=\"#7CFC00\"><b>Project Zed:</b></font> by Shiver loaded");

            Game.OnUpdate += Game_OnUpdate;
            Drawing.OnDraw += Drawing_OnDraw;

        }

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
        }

        static void Game_OnUpdate(EventArgs args)
        {
            switch (Orbwalker.ActiveMode)
            {
                case Orbwalking.OrbwalkingMode.Combo:
                    DoCombo();
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

            if (Menu.Item("HarassToggle").IsActive() && Orbwalker.ActiveMode != Orbwalking.OrbwalkingMode.Mixed)
            {
                DoHarass();
            }



            KillSteal();
        }

        private static void KillSteal()
        {
         
        }


        private static void DoLastHit()
        {
            var lhenergy = Menu.Item("LHEnergy").GetValue<Slider>().Value;

            if (Player.Mana <= lhenergy)
            {
                return;
            }

            var qlh = MinionManager.GetMinions(ObjectManager.Player.ServerPosition, Q.Range, MinionTypes.All);

            //var elh = MinionManager.GetMinions(ObjectManager.Player.ServerPosition, E.Range, MinionTypes.All);
            
            var useQl = Menu.Item("UseQLastQ").GetValue<bool>();
            
            var useEl = Menu.Item("UseELastE").GetValue<bool>();

            

            foreach (var minion in qlh)
            {
                if (useQl && Q.IsReady() && Player.Distance(minion.ServerPosition) < Q.Range && minion.Health < Player.GetSpellDamage(minion, SpellSlot.Q))
                {
                    Q.Cast(minion);
                }

            
                if (useEl && E.IsReady() && Player.Distance(minion.ServerPosition) < E.Range && minion.Health <  Player.GetSpellDamage(minion, SpellSlot.E))
                {
                    E.Cast();
                }
            }
        }

        private static void DoLaneClear()
        {
            var wcenergy = Menu.Item("LCEnergy").GetValue<Slider>().Value;

            if (Player.Mana <= wcenergy)
            {
                return;
            }

            var qwc = MinionManager.GetMinions(ObjectManager.Player.ServerPosition, Q.Range, MinionTypes.All);

            var ewc = MinionManager.GetMinions(ObjectManager.Player.ServerPosition, E.Range, MinionTypes.All);
            
            var useqlc = Menu.Item("UseQLaneClear").GetValue<bool>();
            
            var useelc = Menu.Item("UseELaneClear").GetValue<bool>();

            if (Q.IsReady() && useqlc)
            {
                var qlcline = Q.GetLineFarmLocation(qwc, Q.Width);

                if (qlcline.MinionsHit >= 3)
                {
                    Q.Cast(qlcline.Position);
                }
            }

            if (E.IsReady() && useelc)
            {

                var elccircle = E.GetCircularFarmLocation(ewc, E.Range);

                if (elccircle.MinionsHit >= 2)
                {
                    E.Cast(Player.ServerPosition);
                }
            }
        }

        private static void DoHarass()
        {
            
        }

        private static void DoCombo()
        {
            var target = TargetSelector.GetTarget(Q.Range, TargetSelector.DamageType.Physical);

            if (!target.IsValidTarget())
            {
                return;
            }

            var useQCombo = Menu.Item("UseQCOmbo").IsActive();
            var useWCombo = Menu.Item("UseWCOmbo").IsActive();
            var useECombo = Menu.Item("UseECOmbo").IsActive();
            var useRCombo = Menu.Item("UseRCOmbo").IsActive();

        }

        private static void CreateMenu()
        {
          Menu = new Menu("Project Zed", "ProjectZed", true);

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
            //comboMenu.AddItem(new MenuItem("UseRifKillable", "Use R if selected target killable").SetValue(true));
            Menu.AddSubMenu(comboMenu);

            var harassMenu = new Menu("Harass Settings", "Harass");
            harassMenu.AddItem(new MenuItem("UseQHarass", "Use Q Harass"));
            harassMenu.AddItem(new MenuItem("UseWHarass", "Use W to Harass"));
            harassMenu.AddItem(new MenuItem("UseEHarass", "Use E Harass"));
            harassMenu.AddItem(
                new MenuItem("HarassToggle", "Harass! (Toggle)").SetValue(new KeyBind(84, KeyBindType.Toggle)));
            Menu.AddSubMenu(harassMenu);

            var lasthitMenu = new Menu("Last Hit Settings", "Lasthit");
            lasthitMenu.AddItem(new MenuItem("UseQLastQ", "Use Q Lasthit").SetValue(false));
            lasthitMenu.AddItem(new MenuItem("UseELastE", "Use E Lasthit").SetValue(true));
            lasthitMenu.AddItem(new MenuItem("LHEnergy", "Use % of Energy in Lasthit").SetValue(new Slider(80, 1, 100)));
            Menu.AddSubMenu(lasthitMenu);

            var laneClearMenu = new Menu("Lane Clear Settings", "LaneClear");
            laneClearMenu.AddItem(new MenuItem("UseQLaneClear", "Use Q").SetValue(true));
            laneClearMenu.AddItem(new MenuItem("UseELaneClear", "Use E").SetValue(true));
            laneClearMenu.AddItem(new MenuItem("LCEnergy", "Use % Energy in LaneClear>")).SetValue(new Slider(60, 1, 100));
            Menu.AddSubMenu(laneClearMenu);

            var ksMenu = new Menu("Kill Steal Settings", "KS");
            ksMenu.AddItem(new MenuItem("UseQKS", "Use Q").SetValue(true));
            Menu.AddSubMenu(ksMenu);

            var drawingMenu = new Menu("Drawing Settings", "Drawings");
            drawingMenu.AddItem(new MenuItem("DrawQ", "Draw Q").SetValue(true));
            drawingMenu.AddItem(new MenuItem("DrawW", "Draw W").SetValue(false));
            drawingMenu.AddItem(new MenuItem("DrawE", "Draw E").SetValue(false));
            drawingMenu.AddItem(new MenuItem("DrawR", "Draw R").SetValue(false));
            Menu.AddSubMenu(drawingMenu);

            Menu.AddToMainMenu();
        }
    }
}
