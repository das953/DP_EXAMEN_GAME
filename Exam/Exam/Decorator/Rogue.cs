using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP_Laba_2.Model;

namespace DP_Laba_2.Decorator
{
    class Rogue : UnitDecorator
    {
        public Rogue(Unit pers) : base(pers)
        {

        }


        public override bool Block()
        {
            Random rn = new Random();
            if (rn.Next(100) >= 50) return true;
            return false;
        }

        public override void Kick(Unit opponent)
        {



            var t = opponent.Block();

            if (Stamina[0] >= (Stamina[1] * 0.1))
            {

                if (!SpecialAttack(opponent, t) && !t)
                {
                    switch (opponent.Armor)
                    {

                        case ArmorType.Light:


                            opponent.Health[0] -= ((WeaponSkill / 100 * Dexterity / 100 * BasicDamage) - BasicDamage * (opponent.ArmorSkill / 100 * 0.15));
                            Console.WriteLine($"{Name} attacked {opponent.Name} and caused damage {((WeaponSkill / 100 * Dexterity / 100 * BasicDamage) - BasicDamage * (opponent.ArmorSkill / 100 * 0.1)).ToString("N2")}hp");

                            break;
                        case ArmorType.Medium:

                            opponent.Health[0] -= ((WeaponSkill / 100 * Dexterity / 100 * BasicDamage) - BasicDamage * (opponent.ArmorSkill / 100 * 0.30));
                            Console.WriteLine($"{Name} attacked {opponent.Name} and caused damage {((WeaponSkill / 100 * Dexterity / 100 * BasicDamage) - BasicDamage * (opponent.ArmorSkill / 100 * 0.2)).ToString("N2")}hp");


                            break;
                        case ArmorType.Heavy:

                            opponent.Health[0] -= ((WeaponSkill / 100 * Dexterity / 100 * BasicDamage) - BasicDamage * (opponent.ArmorSkill / 100 * 0.50));
                            Console.WriteLine($"{Name} attacked {opponent.Name} and caused damage {((WeaponSkill / 100 * Dexterity / 100 * BasicDamage) - BasicDamage * (opponent.ArmorSkill / 100 * 0.3)).ToString("N2")}hp");
                            break;


                        default:
                            break;
                    }
                    Stamina[0] -= Stamina[1] * 0.1;
                    Mana[0] += (Mana[1] * 0.05);
                }
                else if (t)
                    Console.WriteLine($"{opponent.Name} has blocked {Name}s attack");


            }

            else
            {
                Console.WriteLine($"{Name} need to rest");
                Stamina[0] += Stamina[1] * 0.25;
                Mana[0] += (Mana[1] * 0.15);
            }

        }

        public override bool SpecialAttack(Unit opponent, bool block)
        {

            if (Stamina[0] >= (Stamina[1] * 0.25) && Mana[0] >= 15 && SpetialAttackCoolDown[0] == 0 && !block)
            {
                if(opponent.Armor == ArmorType.Heavy)
                {
                    Console.WriteLine($"{Name} used special attack and caused damage {((WeaponSkill / 100 * Dexterity / 100 * BasicDamage) * 4.5).ToString("N2")}hp");
                    opponent.Health[0] -= ((WeaponSkill / 100 * Dexterity / 100 * BasicDamage) * 4.5);
                }
                else
                {
                    Console.WriteLine($"{Name} used special attack and caused damage {((WeaponSkill / 100 * Dexterity / 100 * BasicDamage) * 2.5).ToString("N2")}hp");
                    opponent.Health[0] -= ((WeaponSkill / 100 * Dexterity / 100 * BasicDamage) * 2.5);
                }
                
                Stamina[0] -= (Stamina[1] * 0.25);
                Mana[0] -= 15;
                SpetialAttackCoolDown[0] = SpetialAttackCoolDown[1];
                return true;
            }
            else if (block && Stamina[0] >= (Stamina[1] * 0.25) && Mana[0] >= 15 && SpetialAttackCoolDown[0] == 0)
            {
                Stamina[0] -= (Stamina[1] * 0.25);
                Mana[0] -= 15;
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
