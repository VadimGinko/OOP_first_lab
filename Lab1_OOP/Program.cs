using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1_OOP.фабрика;

namespace Lab1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin elem = Admin.Create();
            Console.WriteLine(elem.GetHashCode());
            Admin elem2 = Admin.Create();
            Console.WriteLine(elem2.GetHashCode());
            Hero elf = new Hero(new Magician());
            Teams q = new Teams("kek", 2, 2, "qew", 3, 3);
            elf.Hit();
            elf.Run();
            Console.WriteLine(q.radiant.Count());
            Console.WriteLine(q.dire.Count());
            IBuilder builder = new ConcreteBuilder(elf);
            Director director = new Director(builder);
            director.Construct();
            Hero l = elf.Copy();
            Console.ReadKey();
        }               
    }

}
