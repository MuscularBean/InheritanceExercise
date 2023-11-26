using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public  class Reptile : Animal
    {
        public Reptile() 
        {
            Age = 25;
            DayOrNight = "Night";
            LandOrSea = "Land";
            Limbs = 0;
        }
        public bool HasLegs { get; set; }
        public string EggsOrLiveBirth {  get; set; }
        public bool Shell {  get; set; }
        public bool WillBurrow { get; set; }

    }
}
