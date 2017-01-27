using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Laba_2.Builder
{
    using Model;
    abstract class UnitBuilder
    {
        protected Unit littleManCanCry { get; set; }


        public void CreateUnit()
        {
            littleManCanCry = new Unit();
            littleManCanCry.Stamina = new double[2];
            littleManCanCry.Mana = new double[2];
            littleManCanCry.Health= new double[2];
            littleManCanCry.SpetialAttackCoolDown = new double[2];
        }

        public Unit GetUnit()
        {
            return littleManCanCry;
        }


        public abstract void SetName(string name);
        public abstract void SetRace(Races race);
        public abstract void SetGuild(Guilds guild);

        public abstract void SetStrength();
        public abstract void SetDexterity();
        public abstract void SetIntelligence();

        public abstract void SetHealth();
        public abstract void SetMana();
        public abstract void SetStamina();
        public abstract void SetSpetialAttackCoolDown();

        public abstract void SetWeapon();
        public abstract void SetArmor();

        public abstract void SetWeaponSkill();
        public abstract void SetArmorSkill();
        public abstract void SetBasicDamage();
        public abstract void SetCharacter();


    }
}
