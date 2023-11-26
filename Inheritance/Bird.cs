using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() 
        {
            Limbs = 2;
            Age = 20;
            DayOrNight = "Day";
            LandOrSea = "Land";
        }
        public int WingSpan { get; set; }
        public bool CanFly { get; set; }
        public string LongShortBeak { get; set; }
        public bool Migrate { get; set; }

    }
}
