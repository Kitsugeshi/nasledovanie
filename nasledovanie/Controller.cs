using System;
using System.Collections.Generic;
using System.Text;

namespace nasledovanie
{
    class Controller
    {
        public static void CreateAnimal(int animal, List<Animal> animals)
        {
            switch (animal)
            {
                case 1:
                    Cat a = new Cat();
                    animals.Add(a);
                    break;
                case 2:
                    Dog b = new Dog();
                    animals.Add(b);
                    break;
                case 3:
                    Horse c = new Horse();
                    animals.Add(c);
                    break;
                default:
                    break;
            }
        }
        
        public static void GetInfo(List<Animal> animals)
        {
            foreach(var item in animals)
            {
                Console.WriteLine(item);
            }
        }
    }
}
