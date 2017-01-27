using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Laba_2.TemplateMethod
{

    using Builder;
    using Decorator;
    class RandomHeroesBattle : WorkHard
    {


        protected override void CreateHeroes()
        {
            HeroBuilder HB = new HeroBuilder();


            string[] names = new string[2];
            Races[] race = new Races[2];

            Random rn = new Random();
            Array allGuilds = Enum.GetValues(typeof(Guilds));
            Array allRaces = Enum.GetValues(typeof(Races));

            race[0] = (Races)allRaces.GetValue(rn.Next(allRaces.Length));
            race[1] = (Races)allRaces.GetValue(rn.Next(allRaces.Length));

            var elfNames = GetNameFromFile("ElfNames.txt");
            var humanNames = GetNameFromFile("HumanNames.txt");




            do
            {

                if (race[0] == Races.Elf || race[0] == Races.Pixy)
                {
                    names[0] = elfNames[rn.Next(elfNames.Count())];
                }
                else
                {
                    names[0] = humanNames[rn.Next(elfNames.Count())];
                }

                if (race[1] == Races.Elf || race[1] == Races.Pixy)
                {
                    names[1] = elfNames[rn.Next(humanNames.Count())];
                }
                else
                {
                    names[1] = humanNames[rn.Next(humanNames.Count())];
                }




            } while (names[0] == names[1]);

            for (int i = 0; i < 2; i++)
            {


                switch (rn.Next(3))
                {
                    case 0:
                        HB.SetTheHero(new WarriorBuilder(), names[i], (Guilds)allGuilds.GetValue(rn.Next(allGuilds.Length)), race[i]);
                        HB.FillUnitsProperties();
                        _heroes.Add(new Warrior(HB.GetUnit()));
                        break;

                    case 1:
                        HB.SetTheHero(new RogueBuilder(), names[i], (Guilds)allGuilds.GetValue(rn.Next(allGuilds.Length)), race[i]);
                        HB.FillUnitsProperties();
                        _heroes.Add(new Rogue(HB.GetUnit()));
                        break;

                    case 2:
                        HB.SetTheHero(new MageBuilder(), names[i], (Guilds)allGuilds.GetValue(rn.Next(allGuilds.Length)), race[i]);
                        HB.FillUnitsProperties();
                        _heroes.Add(new Wizard(HB.GetUnit()));
                        break;
                    default:
                        throw new Exception("Something wrong :\\");
                }

                System.Threading.Thread.Sleep(5);

            }

        }

        protected override void Fight()
        {
            int count = 0;
            do
            {
                Console.WriteLine($"\nROUND {count + 1}\n");
                _heroes[0].Kick(_heroes[1]);
                if (_heroes[1].Health[0] <= 0) break;

                _heroes[1].Kick(_heroes[0]);
                if (_heroes[0].Health[0] <= 0) break;

                count++;

                Console.WriteLine($"\n{_heroes[0].Name}`s health {_heroes[0].Health[0].ToString("N2")}\\{_heroes[0].Health[1]} mana {_heroes[0].Stamina[0].ToString("N2")}\\{_heroes[0].Stamina[1]}");

                Console.WriteLine($"{_heroes[1].Name}`s health {_heroes[1].Health[0].ToString("N2")}\\{_heroes[1].Health[1]} mana {_heroes[1].Stamina[0].ToString("N2")}\\{_heroes[1].Stamina[1]}");

            } while (true);



        }


        List<string> GetNameFromFile(string filename)
        {
            List<string> lst = new List<string>();
            using (System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Open))
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(fs))
                {
                    do
                    {
                        lst.Add(sr.ReadLine());
                    } while (lst.Last() != null);
                    lst.Remove(lst.Last());

                }
            }

            return lst;
        }
    }
}
