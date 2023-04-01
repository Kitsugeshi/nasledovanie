using System;
using System.Collections.Generic;
using System.Text;

namespace nasledovanie
{
    class Animal
    {
        private int hunger;
        private string kind;
        private string sound;
        public Animal(int hunger = 0, string kind = "Undefined", string sound = "Undefined")
        {
            this.hunger = hunger;
            this.kind = kind;
            this.sound = sound;
        }

        public string Sound
        {
            get
            {
                return sound;
            }
            set
            {
                sound = value;
            }
        }

        public string Kind
        {
            get
            {
                return kind;
            }
            set
            {
                kind = value;
            }
        }

        public int Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                hunger = value;
            }
        }

        public string GetInfo()
        {
            string s = $"Вид: {Kind}\nЗвук: {Sound}\nСытость: {Hunger}";
            return s;
        }

        public void Voice(string voice)
        {
            voice = Sound;
            Console.WriteLine(voice);
        }

        public void Eat()
        {

        }

        public void Sleep()
        {

        }
    }
}
