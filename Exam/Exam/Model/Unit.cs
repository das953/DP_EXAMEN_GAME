using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Laba_2.Model
{
     class Unit
    {

        public string Name { get; set; }
        public string Character { get; set; }
        public Races Race { get; set; }
        public Guilds Guild { get; set; }


        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public double[] Health { get; set; }
        public double[] Mana { get; set; }
        public double[] Stamina { get; set; }
        public double[] SpetialAttackCoolDown { get; set; }


        public WeaponType Weapon { get; set; }
        public ArmorType Armor { get; set; }

        public double WeaponSkill { get; set; }
        public double ArmorSkill { get; set; }
        public double BasicDamage { get; set; }


        public virtual void Kick(Unit opponent) { }

        public virtual bool Block() { return false; }

        public virtual bool SpecialAttack(Unit opponent, bool block) { return false; }



        public override string ToString()
        {
            return
                $"{new string('*', 80)}\nHero:\t\t{Name}\nCharacter:\t{Character}\nRace:\t\t{Race}\nGuild:\t\t{Guild}\n\nStrength:\t{Strength}\nDexterity:\t{Dexterity}\nIntelligence:\t{Intelligence}\nHealth:\t\t{Health[1]}\nMana:\t\t{Mana[1]}\nStamina:\t{Stamina[1]}\n\nWeapon:\t\t{Weapon}\nArmor:\t\t{Armor}\nWeaponSkill:\t{WeaponSkill}\nArmorSkill:\t{ArmorSkill}\n{new string('*', 80)}";
        }




    }
}
