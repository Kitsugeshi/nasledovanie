using System;
using System.Collections.Generic;
using System.Text;

namespace nasledovanie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            //Cat cat = new Cat();
            //Console.WriteLine(cat.GetInfo()+"\n");
            //Animal a = new Animal();
            //Console.WriteLine(a.GetInfo());
            int animal = int.Parse(Console.ReadLine());
            Controller.CreateAnimal(animal, animals);
            Controller.GetInfo(animals);
        }
    }
}
