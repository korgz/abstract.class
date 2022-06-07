using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession10
{
    public class Car : Vehiacle
    {

        public void SppedUp()
        {
            int productionYear = ProductionYear;

            SoundHorn();

            Console.WriteLine("I am speeding up");
        }

        public override void StarttoDrive()
        {
            Console.WriteLine("5");
        }
    }
}

