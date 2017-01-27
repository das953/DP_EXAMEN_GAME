using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Laba_2.Builder
{
    class RogueBuilder : UnitBuilder
    {
        Random rn = new Random();
        public override void SetBasicDamage()
        {
            littleManCanCry.BasicDamage = 50;
        }
        public override void SetArmor()
        {
           
            littleManCanCry.Armor = (ArmorType)Enum.GetValues(typeof(ArmorType)).GetValue(rn.Next(Enum.GetValues(typeof(ArmorType)).Length));

        }

        public override void SetArmorSkill()
        {
            littleManCanCry.ArmorSkill = rn.Next(101);
        }

        public override void SetDexterity()
        {
            littleManCanCry.Dexterity = rn.Next(70,101);
        }


        public override void SetGuild(Guilds guild)
        {
            littleManCanCry.Guild = guild;
        }

        public override void SetHealth()
        {
            littleManCanCry.Health[0] = 250;
            littleManCanCry.Health[1] = 250;
        }

        public override void SetIntelligence()
        {
            littleManCanCry.Intelligence = 40;
        }

        public override void SetMana()
        {
            littleManCanCry.Mana[0] = 50;
            littleManCanCry.Mana[1] = 50;
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
            littleManCanCry.Stamina[0] = 100;
            littleManCanCry.Stamina[1] = 100;
        }

        public override void SetStrength()
        {
            littleManCanCry.Strength = 50;
        }

        public override void SetWeapon()
        {
            littleManCanCry.Weapon = WeaponType.Bow;
        }

        public override void SetWeaponSkill()
        {
            littleManCanCry.WeaponSkill = rn.Next(25,101);
        }
        public override void SetSpetialAttackCoolDown()
        {
            littleManCanCry.SpetialAttackCoolDown[0] = 1;
            littleManCanCry.SpetialAttackCoolDown[1] = 4;
        }

        public override void SetCharacter()
        {
            littleManCanCry.Character = "Rogue";
        }
    }
}
