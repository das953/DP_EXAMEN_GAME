using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Laba_2.Builder
{
    using Model;
    class HeroBuilder
    {

        private UnitBuilder _UB;
        private string _name;
        Guilds _guild;
        Races _race;


        public void SetTheHero(UnitBuilder ub, string name, Guilds guild, Races race)
        {
            _UB = ub;
            _name = name; _guild = guild; _race = race;
            _UB.CreateUnit();
        }

        public Unit GetUnit()
        {
            return _UB.GetUnit();
        }

        public void FillUnitsProperties()
        {
            _UB.SetArmor();
            _UB.SetArmorSkill();
            _UB.SetDexterity();
            _UB.SetGuild(_guild);
            _UB.SetHealth();
            _UB.SetIntelligence();
            _UB.SetMana();
            _UB.SetName(_name);
            _UB.SetRace(_race);
            _UB.SetStamina();
            _UB.SetStrength();
            _UB.SetWeapon();
            _UB.SetWeaponSkill();
            _UB.SetBasicDamage();
            _UB.SetSpetialAttackCoolDown();
            _UB.SetCharacter();
        }
        


    }
}
