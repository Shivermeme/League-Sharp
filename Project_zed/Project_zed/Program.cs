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
    using System.Diagnostics.CodeAnalysis;

    using LeagueSharp.Common.Data;

    /// <summary>
    /// The program class.
    /// </summary>
    class Program
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
        /// Gets or sets the last target.
        /// </summary>
        /// <value>
        /// The last target.
        /// </value>
        private static Obj_AI_Hero LastTarget { get; set; }

        /// <summary>
        /// Gets or sets the botrk.
        /// </summary>
        /// <value>
        /// The botrk.
        /// </value>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        private static Items.Item Botrk { get; set; }

        /// <summary>
        /// Gets or sets the cutlass.
        /// </summary>
        /// <value>
        /// The cutlass.
        /// </value>
        private static Items.Item Cutlass { get; set; }

        /// <summary>
        /// Gets or sets the hydra.
        /// </summary>
        /// <value>
        /// The hydra.
        /// </value>
        private static Items.Item Hydra { get; set; }

        /// <summary>
        /// Gets or sets the tiamat.
        /// </summary>
        /// <value>
        /// The tiamat.
        /// </value>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        private static Items.Item Tiamat { get; set; }

        /// <summary>
        /// Gets or sets the orbwalker.
        /// </summary>
        /// <value>
        /// The orbwalker.
        /// </value>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        private static Orbwalking.Orbwalker Orbwalker { get; set; }

        /// <summary>
        /// The entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        /// <summary>
        /// Fired when the game loads.
        /// </summary>
        /// <param name="args">The <see cref="EventArgs"/> instance containing the event data.</param>
        private static void Game_OnGameLoad(EventArgs args)
        {
            if (Player.ChampionName != "Zed")
            {
                return;
            }

            Q = new Spell(SpellSlot.Q, 900f);
            W = new Spell(SpellSlot.W, 600f);
            E = new Spell(SpellSlot.E, 290f);
            R = new Spell(SpellSlot.R, 625f);

            Q.SetSkillshot(.4f, 45, 1700, false, SkillshotType.SkillshotLine);

            CreateMenu();

            ObjectManager.Player.LastCastedSpellName();
            ShadowManager.Initialize();

            Botrk = new Items.Item((int)ItemId.Blade_of_the_Ruined_King, 550);
            Cutlass = new Items.Item((int) ItemId.Bilgewater_Cutlass, 550);
            Hydra = new Items.Item((int)ItemId.Ravenous_Hydra_Melee_Only, 400);
            Tiamat = new Items.Item((int)ItemId.Tiamat_Melee_Only);

            Utility.HpBarDamageIndicator.DamageToUnit = DamageToUnit;
            Utility.HpBarDamageIndicator.Enabled = true;

            Game.PrintChat("<font color=\"#7CFC00\"><b>Project Zed:</b></font> by Shiver & ChewyMoon loaded");

            Game.OnUpdate += Game_OnUpdate;
            Drawing.OnDraw += Drawing_OnDraw;
            Obj_AI_Base.OnProcessSpellCast += Obj_AI_Base_OnProcessSpellCast;
        }

        private static void Obj_AI_Base_OnProcessSpellCast(Obj_AI_Base sender, GameObjectProcessSpellCastEventArgs args)
        {
            if (!sender.IsValidTarget())
            {
                return;
            }

            var dangeDbItem = Spelldata.Spells.FirstOrDefault(x => args.SData.Name.Equals(x.SDataName));

            if (dangeDbItem == null)
            {
                return;
            }

            if (Player.Distance(sender) > dangeDbItem.CastRange)
            {
                return;
            }

            if (!dangeDbItem.HitType.Contains(HitType.Danger) || !dangeDbItem.HitType.Contains(HitType.Ultimate))
            {
                return;
            }

            if (Menu.Item("CastRDodge").IsActive() && ShadowManager.RShadowState == ShadowManager.ShadowState.Cast)
            {
                var target = TargetSelector.GetTarget(R.Range, TargetSelector.DamageType.Physical);

                if (target != null)
                {
                    R.CastOnUnit(target);
                }
            }
            else if (Menu.Item("ShadowSwapDodge").IsActive())
            {
                if (ShadowManager.RShadowState == ShadowManager.ShadowState.Swap)
                {
                    R.Cast();
                }
                else if (ShadowManager.WShadowState == ShadowManager.ShadowState.Swap)
                {
                    W.Cast();
                }
            }
        }

        /// <summary>
        /// Gets the damage to a specific unit.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <returns>The damage that the combo will deal to a target.</returns>
        private static float DamageToUnit(Obj_AI_Hero target)
        {
            return
                (float)
                ((Q.IsReady() ? Q.GetDamage(target) : 0) + (E.IsReady() ? E.GetDamage(target) : 0)
                 + (R.IsReady() ? R.GetDamage(target) : 0) + Player.GetAutoAttackDamage(target) * 2
                 + (Botrk.IsReady() ? Player.GetItemDamage(target, Damage.DamageItems.Botrk) : 0)
                 + (Hydra.IsReady() ? Player.GetItemDamage(target, Damage.DamageItems.Hydra) : 0)
                 + (Cutlass.IsReady() ? Player.GetItemDamage(target, Damage.DamageItems.Bilgewater) : 0));
        }

        /// <summary>
        /// Fired when the game draws itself.
        /// </summary>
        /// <param name="args">The <see cref="EventArgs"/> instance containing the event data.</param>
        private static void Drawing_OnDraw(EventArgs args)
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

            if (ShadowManager.WShadow != null)
            {
                Render.Circle.DrawCircle(ShadowManager.WShadow.Position, 100, Color.Orange);
            }

            if (ShadowManager.RShadow != null)
            {
                Render.Circle.DrawCircle(ShadowManager.RShadow.Position, 100, Color.Orange);
            }
        }

        /// <summary>
        /// Fired when the game updates it self.
        /// </summary>
        /// <param name="args">The <see cref="EventArgs"/> instance containing the event data.</param>
        private static void Game_OnUpdate(EventArgs args)
        {
            if (LastTarget != null)
            {
                // Update source positions
                var objects = new List<Vector3>() { Player.ServerPosition };
                objects.AddRange(ShadowManager.Shadows.Select(x => x.Position));

                var closestObject = objects.OrderBy(x => x.Distance(LastTarget.ServerPosition)).First();
                Q.UpdateSourcePosition(closestObject);
            }
           
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

            if (Menu.Item("AllInCombo").IsActive())
            {
                DoCombo(false);
            }

            if (Menu.Item("HarassToggle").IsActive() && Orbwalker.ActiveMode != Orbwalking.OrbwalkingMode.Mixed)
            {
                DoHarass();
            }

            KillSteal();
            AutoE();
        }

        /// <summary>
        /// Automatics the e.
        /// </summary>
        private static void AutoE()
        {
            if (!Menu.Item("AutoE").IsActive() || !ShadowManager.CanCastE)
            {
                return;
            }

            E.Cast();
        }

        /// <summary>
        /// Steals kills from your teammates.
        /// </summary>
        private static void KillSteal()
        {
         
        }


        /// <summary>
        /// Does the last hit.
        /// </summary>
        private static void DoLastHit()
        {
            var lhenergy = Menu.Item("LHEnergy").GetValue<Slider>().Value;

            if (Player.ManaPercent <= lhenergy)
            {
                return;
            }
      
            var useQ = Menu.Item("UseQLastQ").GetValue<bool>();      
            var useE = Menu.Item("UseELastE").GetValue<bool>();

            if (useQ && Q.IsReady())
            {
                var minion =
                    MinionManager.GetMinions(Q.Range)
                        .FirstOrDefault(x => x.IsValidTarget(Q.Range) && Q.GetDamage(x) >= x.Health);

                Q.Cast(minion);
            }

            if (useE && E.IsReady() && MinionManager.GetMinions(E.Range).Any(x => E.GetDamage(x) >= x.Health))
            {
                E.Cast();
            }
        }

        /// <summary>
        /// Does the lane clear.
        /// </summary>
        private static void DoLaneClear()
        {
            var wcenergy = Menu.Item("LCEnergy").GetValue<Slider>().Value;

            if (Player.Mana <= wcenergy)
            {
                return;
            }

            var qwc = MinionManager.GetMinions(ObjectManager.Player.ServerPosition, Q.Range);
            var ewc = MinionManager.GetMinions(ObjectManager.Player.ServerPosition, E.Range);     
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

        /// <summary>
        /// Does the harass.
        /// </summary>
        private static void DoHarass()
        {
            
        }

        /// <summary>
        /// Does the combo.
        /// </summary>
        /// <param name="checkHp">if set to <c>true</c> will use R only if the target is killable.</param>
        private static void DoCombo(bool checkHp)
        {
            var target =
                TargetSelector.GetTarget(
                    ShadowManager.RShadowState == ShadowManager.ShadowState.Cast ? R.Range : Q.Range,
                    TargetSelector.DamageType.Physical);

            if (target == null)
            {
                CloseGap();
            }

            if (target == null || !target.IsValidTarget())
            {
                return;
            } 
               
            var useQCombo = Menu.Item("UseQCombo").IsActive();
            var useWCombo = Menu.Item("UseWCombo").IsActive();
            var useECombo = Menu.Item("UseECombo").IsActive();
            var useRCombo = Menu.Item("UseRCombo").IsActive();        

            if (useRCombo && R.IsReady() && ShadowManager.RShadowState == ShadowManager.ShadowState.Cast)
            {
                if (checkHp && DamageToUnit(target) > target.Health)
                {
                    R.CastOnUnit(target);
                }
                else if (!checkHp)
                {
                    R.CastOnUnit(target);
                }
            }

            if (useRCombo && R.IsReady() && ShadowManager.RShadowState == ShadowManager.ShadowState.Swap && ShadowManager.CanSwapToR(target, LastTarget))
            {
                R.Cast();
            }

            if (useWCombo && W.IsReady() && ShadowManager.WShadowState == ShadowManager.ShadowState.Cast)
            {
                var position = Player.ServerPosition.Extend(target.ServerPosition, W.Range);
                W.Cast(position);
            }

            if (useWCombo && W.IsReady() && ShadowManager.WShadowState == ShadowManager.ShadowState.Swap
                && ShadowManager.CanSwapToW(target, LastTarget))
            {
                W.Cast();
            }

            if (useQCombo && Q.IsReady())
            {
                Q.Cast(target);
            }

            if (useECombo && E.IsReady() && ShadowManager.CanCastE)
            {
                E.Cast();
            }          

            LastTarget = target;
        }

        /// <summary>
        /// Closes the gap.
        /// </summary>
        private static void CloseGap()
        {
            if (ShadowManager.WShadowState == ShadowManager.ShadowState.Swap)
            {
                if (ShadowManager.WShadow.Position.CountEnemiesInRange(Orbwalking.GetRealAutoAttackRange(Player)) == 1)
                {
                    W.Cast();
                }
            }
            else if (ShadowManager.RShadowState == ShadowManager.ShadowState.Swap)
            {
                if (ShadowManager.RShadow.Position.CountEnemiesInRange(Orbwalking.GetRealAutoAttackRange(Player)) == 1)
                {
                    R.Cast();
                }
            }
        }

        /// <summary>
        /// Creates the menu.
        /// </summary>
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
            comboMenu.AddItem(new MenuItem("AllInCombo", "All in Combo").SetValue(new KeyBind(83, KeyBindType.Press)));
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
            lasthitMenu.AddItem(new MenuItem("UseELastE", "Use E Lasthit").SetValue(true));
            lasthitMenu.AddItem(new MenuItem("LHEnergy", "Use % of Energy in Lasthit").SetValue(new Slider(80, 1)));
            Menu.AddSubMenu(lasthitMenu);

            var laneClearMenu = new Menu("Lane Clear Settings", "LaneClear");
            laneClearMenu.AddItem(new MenuItem("UseQLaneClear", "Use Q").SetValue(true));
            laneClearMenu.AddItem(new MenuItem("UseELaneClear", "Use E").SetValue(true));
            laneClearMenu.AddItem(new MenuItem("LCEnergy", "Use % Energy in LaneClear>")).SetValue(new Slider(60, 1, 100));
            Menu.AddSubMenu(laneClearMenu);

            var ultDodge = new Menu("Ult Dodge Settings", "DodgeUlt");
            ultDodge.AddItem(new MenuItem("CastRDodge", "Cast R on Unit to Dodge Dangerous").SetValue(true));
            ultDodge.AddItem(new MenuItem("ShadowSwapDodge", "Swap with Shadow to Dodge Dangerous").SetValue(true));
            Menu.AddSubMenu(ultDodge);

            var shadowMenu = new Menu("Shadow Settings", "ShadowSettings");
            shadowMenu.AddItem(new MenuItem("ShadowSwapHP", "Dont swap to shadow if my HP below %").SetValue(new Slider(40)));
            shadowMenu.AddItem(new MenuItem("DontWIntoEnemies", "Dont W into Enemies").SetValue(new Slider(3, 1, 5)));
            shadowMenu.AddItem(new MenuItem("ShadowBackDead", "Swap to shadow if enemy is dead").SetValue(true));
            shadowMenu.AddItem(new MenuItem("AutoE", "Auto use E").SetValue(true));
            Menu.AddSubMenu(shadowMenu);

            var killstealMenu = new Menu("Kill Steal Settings", "KS");
            killstealMenu.AddItem(new MenuItem("UseQKS", "Use Q").SetValue(true));
            Menu.AddSubMenu(killstealMenu);

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
