using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP_Laba_2.Model;

namespace DP_Laba_2.TemplateMethod
{
    abstract class WorkHard
    {
        protected List<Unit> _heroes;

        protected abstract void CreateHeroes();
        protected abstract void Fight();

        public void OpenArena()
        {
            _heroes = new List<Unit>();
            CreateHeroes();

            Console.WriteLine($"We have 2 heroes on arena!\n{_heroes[0]}\n{_heroes[1]}\n\nPress Enter to start fight...");
            Console.ReadLine();

            Fight();

            var winner = _heroes.Where(x => x.Health[0] > 0);
            Console.WriteLine($"\n{new string('*', 80) }\nAnd WINNER is {winner.First().Character} {winner.First().Name} the {winner.First().Race} from {winner.First().Guild} guild!\nWith {winner.First().Health[0].ToString("N2")}hp ))\n{new string('*', 80) }");
        }


    }
}
