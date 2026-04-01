using System;
using System.Collections.Generic;
using System.Text;

namespace _09.Upcasting_and_Downcasting__Explicit_and_Implicit.Models
{
    internal abstract class Animal
    {
        public int AvgLifeTime { get; set; }
        public string Gender { get; set; }


        public virtual void Eat()
        {
            Console.WriteLine("qidalanir");
        }
    }
}
