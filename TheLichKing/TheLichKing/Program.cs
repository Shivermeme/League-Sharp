﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = System.Drawing.Color;
using LeagueSharp.Common;
using LeagueSharp;
using SharpDX;

namespace TheLichKing
{
    class Program
    {
        private static Obj_AI_Hero Player { get { return ObjectManager.Player; } }
        private static Orbwalking.Orbwalker Orbwalker;
        private static Spell Q, W, E, R;
        private static Menu Menu;
        private static Obj_AI_Hero target;

        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            if (Player.ChampionName != "Tryndamere")
                return;

            Q = new Spell(SpellSlot.Q);
            W = new Spell(SpellSlot.W, 400f);
            E = new Spell(SpellSlot.E, 660f);
            R = new Spell(SpellSlot.R);

            E.SetSkillshot(0f, 93f, 600, false, SkillshotType.SkillshotLine);

            Menu = new Menu(Player.ChampionName, Player.ChampionName, true);
            Menu orbwalkerMenu = Menu.AddSubMenu(new Menu("Orbwalker", "Orbwalker"));
            Orbwalker = new Orbwalking.Orbwalker(orbwalkerMenu);
            Menu ts = Menu.AddSubMenu(new Menu("Target Selector", "Target Selector")); ;
            TargetSelector.AddToMenu(ts);
            Menu spellMenu = Menu.AddSubMenu(new Menu("Spells", "Spells"));

            spellMenu.AddItem(new MenuItem("useQ", "Use Q").SetValue(true));
            spellMenu.AddItem(new MenuItem("qBelow", "Q below % hp").SetValue(new Slider(20, 0, 95)));
            spellMenu.AddItem(new MenuItem("useW", "Use W").SetValue(true));
            spellMenu.AddItem(new MenuItem("useE", "Use E").SetValue(true));
            spellMenu.AddItem(new MenuItem("useR", "Use R Before Death").SetValue(true));
            spellMenu.AddItem(new MenuItem("rBelow", "R below % hp").SetValue(new Slider(15, 0, 95)));

            Menu fleeMenu = Menu.AddSubMenu(new Menu("Flee", "Run Nigger"));
            fleeMenu.AddItem(new MenuItem("useEFlee", "Use E")).SetValue(new KeyBind('Z', KeyBindType.Press));

            Menu.AddToMainMenu();
            Drawing.OnDraw += Drawing_OnDraw;
            Game.OnUpdate += Game_OnGameUpdate;
            Game.PrintChat("I'm a DK");
        }

        static void Drawing_OnDraw(EventArgs args)
        {
            throw new NotImplementedException();
        }

        private static void Game_OnGameUpdate(EventArgs args)
        {
            if (Player.IsDead)
                return;
            {


                target = TargetSelector.GetTarget(E.Range, TargetSelector.DamageType.Physical);

                RunNigger();
                if (target.IsValid && Orbwalker.ActiveMode == Orbwalking.OrbwalkingMode.Combo)
                {
                    MockingShout();
                    SpinningSlash();
                }
                UndyingRage();
                Bloodlust();
            }
        }

        private static void RunNigger()
        {
            if (Menu.Item("useEFlee").GetValue<KeyBind>().Active)
            {
                E.Cast(Game.CursorPos);
                Player.IssueOrder(GameObjectOrder.MoveTo, Game.CursorPos);
            }
        }

        private static void Bloodlust()
        {
            if (Q.IsReady() && (Player.Health / Player.MaxHealth) * 100 < Menu.Item("qBelow").GetValue<Slider>().Value && !Player.HasBuff("UndyingRage",true))
            {
                if (ObjectManager.Get<Obj_AI_Hero>().Where(x => x.IsEnemy && x.Distance(Player.Position) <= 1200).Count() > 0)
                {
                    Q.Cast();
                }
            }
        }

        private static void MockingShout()
        {
            if (W.IsReady() && !target.IsFacing(Player))
            {
                W.Cast();
            }
        }

        private static void SpinningSlash()
        {
            if (E.IsReady() && Player.Distance(target) <= E.Range - 125)
            {      
                //var extendPos = target.ServerPosition.To2D().Extend(target.ServerPosition.To2D(), 200).To3D();       

                E.Cast(target);
            }
        }

        private static void UndyingRage()
        {
            if (R.IsReady() && ObjectManager.Get<Obj_AI_Hero>().Where(x => x.IsEnemy && x.Distance(Player.Position) <= 1200).Count() > 0 && (Player.Health / Player.MaxHealth) * 100 < Menu.Item("rBelow").GetValue<Slider>().Value)
            {
                R.Cast();
            }
        }
    }
}
