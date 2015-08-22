using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using Color = System.Drawing.Color;

namespace Orianna
{
    internal class Program
    {
        public static Menu Menu { get; set; }

        private static Obj_AI_Hero Player
        {
            get { return ObjectManager.Player; }
        }

        private static Orbwalking.Orbwalker Orbwalker { get; set; }

        private static Spell Q { get; set; }
        private static Spell W { get; set; }
        private static Spell E { get; set; }
        private static Spell R { get; set; }

        private static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            if (Player.ChampionName != "Orianna")
            {
                return;
            }

            Q = new Spell(SpellSlot.Q, 825f);
            W = new Spell(SpellSlot.W, 250f);
            E = new Spell(SpellSlot.E, 1100f);
            R = new Spell(SpellSlot.R, 325f);

            Q.SetSkillshot(0f, 130f, 1400f, false, SkillshotType.SkillshotCircle);
            W.SetSkillshot(0.25f, 240f, float.MaxValue, false, SkillshotType.SkillshotCircle);
            E.SetSkillshot(0.25f, 80f, 1700f, true, SkillshotType.SkillshotLine);
            R.SetSkillshot(0.6f, 375f, float.MaxValue, false, SkillshotType.SkillshotCircle);

            CreateMenu();

            Game.OnUpdate += Game_OnUpdate;
            Drawing.OnDraw += Drawing_OnDraw;

        }

        private static void CreateMenu()
        {
            Menu = new Menu("Orianna", "ChewyShiver Orianna", true);

                var tsMenu = new Menu("Target Selector", "TS");
                TargetSelector.AddToMenu(tsMenu);
                Menu.AddSubMenu(tsMenu);

                var orbwalkMenu = new Menu("Orbwalker", "Orbwalk");
                Orbwalker = new Orbwalking.Orbwalker(orbwalkMenu);
                Menu.AddSubMenu(orbwalkMenu);

                var comboMenu = new Menu("Combo Settings", "Combo");
                comboMenu.AddItem(new MenuItem("UseQCombo", "Use Q").SetValue(true));
                comboMenu.AddItem(new MenuItem("UseWCombo", "Use W").SetValue(true));
                comboMenu.AddItem(new MenuItem("UseECombo", "Use E").SetValue(true));
                comboMenu.AddItem(new MenuItem("UseRCombo", "Use R").SetValue(true));
                comboMenu.AddItem(new MenuItem("AutoWEnemies>X", "Auto W X Enemies").SetValue(true));
                Menu.AddSubMenu(comboMenu);

                var harassMenu = new Menu("Harass Settings", "Harass");
                harassMenu.AddItem(new MenuItem("UseQHarass", "Use Q").SetValue(true));
                harassMenu.AddItem(new MenuItem("UseWHarass", "Use W").SetValue(true));
                harassMenu.AddItem(new MenuItem("UseEHarass", "Use E").SetValue(true));


                var laneClearMenu = new Menu("Lane Clear Settings", "LaneClearFarm");
                laneClearMenu.AddItem(new MenuItem("UseQLaneClear", "Use Q").SetValue(true));
                laneClearMenu.AddItem(new MenuItem("UseWLaneClear", "Use W").SetValue(true));
                laneClearMenu.AddItem(new MenuItem("LaneClearMana", "Lane Clear Mana").SetValue(new Slider(45)));
                Menu.AddSubMenu(laneClearMenu);

                var ultMenu = new Menu("Ultimate Settings", "Ult");
                ultMenu.AddItem(new MenuItem("AutoREnemies>X", "Auto R X Enemies").SetValue(new Slider(3, 1, 5)));
                //ultMenu.AddItem(new MenuItem("RFlash", "R Flash")); IDK CUZ PRY SUCKS WITH SCRITPOR MEMES
                Menu.AddSubMenu(ultMenu);

                var ksMenu = new Menu("KillSteal Settings", "KS");
                ksMenu.AddItem(new MenuItem("UseQKS", "Use Q").SetValue(true));
                ksMenu.AddItem(new MenuItem("UseWKS", "Use W").SetValue(true));
                Menu.AddSubMenu(ksMenu);

                var miscMenu = new Menu("Miscellaneous Settings", "Misc");
                miscMenu.AddItem(new MenuItem("AutoW", "Auto W to Speed up Allies").SetValue(new Slider(3, 1, 5)));
                miscMenu.AddItem(new MenuItem("EngageE", "Use E on Engaging Allies").SetValue(true));
                Menu.AddSubMenu(miscMenu);

                var drawingMenu = new Menu("Drawing", "Drawing");
                drawingMenu.AddItem(new MenuItem("DrawQ", "Draw Q").SetValue(true));
                //drawingMenu.AddItem(new MenuItem("DrawW", "Draw W").SetValue(true));
                drawingMenu.AddItem(new MenuItem("DrawE", "Draw E").SetValue(false));
                //drawingMenu.AddItem(new MenuItem("DrawR", "Draw R").SetValue(true));
                Menu.AddSubMenu(drawingMenu);
        }

        private static void Drawing_OnDraw(EventArgs args)
        {
            var drawQ = Menu.Item("DrawQ").IsActive();
            var drawW = Menu.Item("DrawW").IsActive();
            var drawE = Menu.Item("DrawE").IsActive();
            var drawR = Menu.Item("DrawR").IsActive();

            if (drawQ)
            {
                Render.Circle.DrawCircle(Player.Position, Q.Range, Q.IsReady() ? Color.Green : Color.Red);
            }

            //if (drawW)
            //{
            //    Render.Circle.DrawCircle(Player.Position, W.Range, W.IsReady() ? Color.Green : Color.Red);
            //}

            if (drawE)
            {
                Render.Circle.DrawCircle(Player.Position, E.Range, E.IsReady() ? Color.Green : Color.Red);
            }

            //if (drawR)
            //{
            //    Render.Circle.DrawCircle(Player.Position, W.Range, W.IsReady() ? Color.Green: Color.Red);
            //}

        }

        private static void Game_OnUpdate(EventArgs args)
        {
            switch (Orbwalker.ActiveMode)
            {
                case Orbwalking.OrbwalkingMode.Mixed:
                    DoHarass();
                    break;
                case Orbwalking.OrbwalkingMode.LaneClear:
                    DoLaneClear();
                    break;
                case Orbwalking.OrbwalkingMode.Combo:
                    DoCombo();
                    break;
            }

            
        }

        private static void DoCombo()
        {
            var target = TargetSelector.GetTarget(Q.Range, TargetSelector.DamageType.Magical);

            var useQ = Menu.Item("UseQCombo").IsActive();
            var useW = Menu.Item("UseWCombo").IsActive();
            var useE = Menu.Item("UseECombo").IsActive();
            var useR = Menu.Item("UseRCombo").IsActive();


            if (Q.IsReady() && useQ)
            {
                Q.Cast();
            }

            if (W.IsReady() && useW)
            {
                
            }

            if (E.IsReady() && useE)
            {
                
            }

            if (R.IsReady() && useR)
            {
                
            }
        }

        private static void DoLaneClear()
        {
            throw new NotImplementedException();
        }

        private static void DoHarass()
        {
            throw new NotImplementedException();
        }
    }
}
