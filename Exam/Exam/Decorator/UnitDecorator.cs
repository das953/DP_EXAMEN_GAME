using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Laba_2.Decorator
{
    using Model;
   abstract class UnitDecorator : Unit
    {

        protected Unit _hero { get; set; }

        public UnitDecorator(Unit pers)
        {
            _hero = pers;

            Armor = _hero.Armor;
            ArmorSkill = _hero.ArmorSkill;
            Dexterity = _hero.Dexterity;
            Guild = _hero.Guild;

            Health = _hero.Health;
            Intelligence = _hero.Intelligence;
            Mana = _hero.Mana;
            Name = _hero.Name;
            Character = _hero.Character;

            Race = _hero.Race;
            Stamina = _hero.Stamina;
            Strength = _hero.Strength;

            Weapon = _hero.Weapon;
            WeaponSkill = _hero.WeaponSkill;
            BasicDamage = _hero.BasicDamage;
            SpetialAttackCoolDown = _hero.SpetialAttackCoolDown;

        }

        public override bool Block()
        {
            if (_hero != null) return _hero.Block();
            return base.Block();
        }

        public override void Kick(Unit opponent)
        {
            if (_hero != null)  _hero.Kick(opponent);
            base.Kick(opponent);
        }

        public override bool SpecialAttack(Unit opponent, bool block)
        {
            if (_hero != null)  _hero.SpecialAttack(opponent, block);
            base.SpecialAttack(opponent, block);
            return false;
        }
    }
}
