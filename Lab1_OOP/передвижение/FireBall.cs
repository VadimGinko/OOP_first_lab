using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP.передвижение
{
    class FireBall : IAbility
    {
        public void UseAbility()
        {
            PrintOut.ConsoleOut("Бросать огненный шар");
        }
    }
}
