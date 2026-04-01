using System;
using System.Collections.Generic;
using System.Text;

namespace _09.Upcasting_and_Downcasting__Explicit_and_Implicit.Models
{
    internal class Dollar
    }

    internal class Dollar
    {
        public decimal USD { get; set; }

        public Dollar(decimal usd)
        {
            USD = usd;
        }
        public static implicit operator Dollar(Manat mant)
        {
            return new Dollar(mant.AZN / 1.7m);
        }

    }
