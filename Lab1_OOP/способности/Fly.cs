using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP.способности
{
    class Fly : IMovement
    {
        public void Move()
        {
            PrintOut.ConsoleOut("Лететь");
        }
    }
}
