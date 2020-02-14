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
    interface IBuilder
    {
        void AddHat();
        void AddArmor();
        void AddGloves();
    }
    class ConcreteBuilder : IBuilder
    {
        Hero product;
        public ConcreteBuilder(Hero obj)
        {
            product = obj;
        }
        public void AddHat()
        {
            product.hat = true;
        }
        public void AddArmor()
        {
            product.armor = true;
        }
        public void AddGloves()
        {
            product.gloves = true;
        }

    }

    class Director
    {
        IBuilder builder;
        public Director(IBuilder builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {
            builder.AddHat();
            builder.AddArmor();
            builder.AddGloves();
        }
    }

    class Hero : Prototype
    {
        private IAbility ability;
        private IMovement movement;
       
        public Hero()
        {
        }

        public Hero(HeroFactory factory)
        {
            ability = factory.CreateAbility();
            movement = factory.CreateMovement();
        }

        
        public void Run()
        {
            movement.Move();
        }
        public void Hit()
        {
            ability.UseAbility();
        }
        public bool gloves;
        public bool hat;
        public bool armor;

        public Hero Copy()
        {
            return this;
        }
    }

}
