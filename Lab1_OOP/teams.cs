using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1_OOP.способности;
using Lab1_OOP.передвижение;
using Lab1_OOP.фабрика;

namespace Lab1_OOP
{
    class Teams
    {
        public Teams(string name_of_radiant_team, int count_of_mags1, int count_of_warrs1, string name_of_dire_team, int count_of_mags2, int count_of_warrs2)
        {
            radiant = new List<Hero>();
            dire = new List<Hero>();
            name_radiant = name_of_radiant_team;
            name_dire = name_of_dire_team;
            int pos = 1;
            for (int i = 1; i <= count_of_mags1 + count_of_warrs1; i++)
            {
               
                if (pos <= count_of_mags1)
                {
                    radiant.Add(new Hero(new Magician()));
                }
                else
                {
                    radiant.Add(new Hero(new Warrior()));
                }
                pos++;
            }
               pos = 0;

            for (int i = 1; i <= count_of_mags2 + count_of_warrs2; i++)
            {

                if (pos <= count_of_mags2)
                {
                    dire.Add(new Hero(new Magician()));
                }
                else
                {
                    dire.Add(new Hero(new Warrior()));
                }
                pos++;
            }
        }
        public string name_radiant;
        public List<Hero> radiant;
        public string name_dire;
        public   List<Hero> dire;

    }
}
