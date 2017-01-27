using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Laba_2.Builder
{
    class MageBuilder : UnitBuilder
    {
        Random rn = new Random();
        public override void SetBasicDamage()
        {
            littleManCanCry.BasicDamage = 100;
        }
        public override void SetArmor()
        {
           
           
            littleManCanCry.Armor = (ArmorType)Enum.GetValues(typeof(ArmorType)).GetValue(rn.Next(Enum.GetValues(typeof(ArmorType)).Length));
            if (littleManCanCry.Armor == ArmorType.Heavy) littleManCanCry.Armor = ArmorType.Medium;

        }

        public override void SetArmorSkill()
        {
            littleManCanCry.ArmorSkill = rn.Next(101);
        }

        public override void SetDexterity()
        {
            littleManCanCry.Dexterity = 25;
        }


        public override void SetGuild(Guilds guild)
        {
            littleManCanCry.Guild = guild;
        }

        public override void SetHealth()
        {
            littleManCanCry.Health[0] = 200;
            littleManCanCry.Health[1] = 200;
        }

        public override void SetIntelligence()
        {
            littleManCanCry.Intelligence = rn.Next(70,101);
        }

        public override void SetMana()
        {
            littleManCanCry.Mana[0] = 301;
            littleManCanCry.Mana[1] = 301;
        }



        public override void SetName(string name)
        {
            littleManCanCry.Name = name;
        }


        public override void SetRace(Races race)
        {
            littleManCanCry.Race = race;
        }

        public override void SetStamina()
        {
            littleManCanCry.Stamina[0] = 75;
            littleManCanCry.Stamina[1] = 75;
        }

        public override void SetStrength()
        {
            littleManCanCry.Strength = 25;
        }

        public override void SetWeapon()
        {
            littleManCanCry.Weapon = WeaponType.MagicStaff;
        }

        public override void SetWeaponSkill()
        {
            littleManCanCry.WeaponSkill = rn.Next(25,101);
        }

        public override void SetSpetialAttackCoolDown()
        {
            littleManCanCry.SpetialAttackCoolDown[0] = 2;
            littleManCanCry.SpetialAttackCoolDown[1] = 5;
        }

        public override void SetCharacter()
        {
            littleManCanCry.Character = "Wizard";
        }
    }
}
