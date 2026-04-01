using System;
using System.Collections.Generic;
using System.Text;

namespace _09__UpcastingDowncastingExplicitImplicit.Models
{
    internal class Eagle : Animal
    {
        public int FlySpeed { get; set; }

        public void Fly()
        {
            Console.WriteLine("Field away");
        }
    }
}