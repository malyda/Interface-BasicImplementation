using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Play.Entity;

namespace Play
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Play();

            Cat cat = new Cat();
            cat.Play();
            
            // OR

            IAnimal animal = new Cat();
            animal.Play();

            animal = new Dog();
            animal.Play();
        }
    }
}
