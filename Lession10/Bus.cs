using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession10
{
    public class Bus : Vehiacle
    {
        public override void SoundHorn()
        {
            Console.WriteLine("Tu");

            base.SoundHorn(); //pec izveles pasaucam bazes klASes funkcionalitatu
        }

        public override void StarttoDrive()
        {
            Console.WriteLine("4");
        }
    }
}
