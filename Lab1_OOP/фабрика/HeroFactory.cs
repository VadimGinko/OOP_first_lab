using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1_OOP.способности;
using Lab1_OOP.передвижение;

namespace Lab1_OOP.фабрика
{
    interface HeroFactory
    {
        IMovement CreateMovement();
        IAbility CreateAbility();
    }
}
