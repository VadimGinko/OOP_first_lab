using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1_OOP.способности;
using Lab1_OOP.передвижение;

namespace Lab1_OOP.фабрика
{
    class Warrior : HeroFactory
    {
        public IMovement CreateMovement()
        {
            return new Run();
        }

        public IAbility CreateAbility()
        {
            return new FireBall();
        }
    }
}
