﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SomeAnimals
{
    class Kitten : ICat
    {
        public string owner { get; set; }
        public string personalId { get; set; }
        public string color { get; set; }
        public string breed { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public double age { get; set; }

        public string Sex
        {
            get { return this.sex; }
            private set { this.sex = "Female"; }
        }

        public string MakeNoise()
        {
            string notHappy = "Miauuuyyy!";
            return notHappy;
        }

        public void GoForAWalk()
        {
            Console.WriteLine("The kitten is on a walk.");
        }

        public void BeHungry()
        {
            Console.WriteLine("Your kitten is hungry!");
        }

        public void Prrr()
        {
            Console.WriteLine("Your kitten is making the happy noise: Prrr!");
        }
    }
}