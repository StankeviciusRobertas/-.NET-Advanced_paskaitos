using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._2.Generics
{
    internal class SportoLyga<T>
    {
        // Sąrašas, kuris laikys visas komandas priklausančias lygai.
        private List<T> teams = new List<T>();

        // Metodas pridėti naują komandą į sąrašą.
        public void AddTeam(T newTeam)
        {
            // Patikriname, ar sąrašas nėra tuščias ir ar nauja komanda turi tą pačią sporto rūšį.
            if (teams.Count > 0 && !newTeam.GetType().Equals(teams[0].GetType()))
            {
                throw new InvalidOperationException("Negalima pridėti skirtingos sporto rūšies komandos į tą pačią lygą.");
            }

            teams.Add(newTeam);
        }

        public void PrintTeam()
        {
            Console.WriteLine("Komandos priklausancios siai lygai: ");
            foreach (var team in teams)
            {
                Console.WriteLine(team.ToString());
            }
        }
    }
}
