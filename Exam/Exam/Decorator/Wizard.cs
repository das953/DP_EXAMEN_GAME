using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP_Laba_2.Model;


namespace DP_Laba_2.Decorator
{
    class Wizard : UnitDecorator
    {
        public Wizard(Unit pers) : base(pers)
        {

        }


        public override bool Block()
        {
            Random rn = new Random();
            if (rn.Next(100) >= 65) return true;
            return false;
        }

        public override void Kick(Unit opponent)
        {



            var t = opponent.Block();
            if (Mana[0] >= (Mana[1] * 0.31) && Health[0] <= (Health[1] * 0.5))
            {
                Health[0] += (Health[1] * 0.26);
                Mana[0] -= (Mana[1] * 0.31);
                Console.WriteLine($"{Name} healed himself by {(Health[1] * 0.26).ToString("N2")}hp");
            }
            else
            { 
            if (Mana[0] >= (Mana[1] * 0.1))
            {

                if (!SpecialAttack(opponent, t) && !t)
                {
                    switch (opponent.Armor)
                    {

                        case ArmorType.Light:


                            opponent.Health[0] -= ((WeaponSkill / 100 * Intelligence / 100 * BasicDamage) - BasicDamage * (opponent.ArmorSkill / 100 * 0.03));
                            Console.WriteLine($"{Name} attacked {opponent.Name} and caused damage {((WeaponSkill / 100 * Intelligence / 100 * BasicDamage) - BasicDamage * (opponent.ArmorSkill / 100 * 0.03)).ToString("N2")}hp");

                            break;
                        case ArmorType.Medium:

                            opponent.Health[0] -= ((WeaponSkill / 100 * Intelligence / 100 * BasicDamage) - BasicDamage * (opponent.ArmorSkill / 100 * 0.07));
                            Console.WriteLine($"{Name} attacked {opponent.Name} and caused damage {((WeaponSkill / 100 * Intelligence / 100 * BasicDamage) - BasicDamage * (opponent.ArmorSkill / 100 * 0.07)).ToString("N2")}hp");


                            break;
                        case ArmorType.Heavy:

                            opponent.Health[0] -= ((WeaponSkill / 100 * Intelligence / 100 * BasicDamage) - BasicDamage * (opponent.ArmorSkill / 100 * 0.1));
                            Console.WriteLine($"{Name} attacked {opponent.Name} and caused damage {((WeaponSkill / 100 * Intelligence / 100 * BasicDamage) - BasicDamage * (opponent.ArmorSkill / 100 * 0.1)).ToString("N2")}hp");
                            break;


                        default:
                            break;
                    }
                    Mana[0] -= Mana[1] * 0.1;
                }
                else if (t)
                    Console.WriteLine($"{opponent.Name} has blocked {Name}s attack");


            }

            else
            {
                Console.WriteLine($"{Name} need to rest");
                Mana[0] += Mana[1] * 0.25;
            }
        }
        }

        public override bool SpecialAttack(Unit opponent, bool block)
        {

            if (Mana[0] >= 75 && SpetialAttackCoolDown[0] == 0 && !block)
            {
                Console.WriteLine($"{Name} used special attack and caused damage {((WeaponSkill / 100 * Intelligence / 100 * BasicDamage) * 2).ToString("N2")}hp");
                opponent.Health[0] -= ((WeaponSkill / 100 * Intelligence / 100 * BasicDamage) * 2);
                Mana[0] -= 75;
                SpetialAttackCoolDown[0] = SpetialAttackCoolDown[1];
                return true;
            }
            else if (block && Mana[0] >= 75 && SpetialAttackCoolDown[0] == 0)
            {
                Mana[0] -= 75;
                SpetialAttackCoolDown[0] = SpetialAttackCoolDown[1];
                Console.WriteLine($"{Name}s special attack was blocked by {opponent.Name}");
                return false;
            }
            else if (SpetialAttackCoolDown[0] != 0)
            {
                SpetialAttackCoolDown[0]--;
            }

            return false;
        }

    }

}
