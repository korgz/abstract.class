using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession10
{
    public abstract class Vehiacle
    {
        private int _productionYear;

        public Vehiacle()
        {
            _productionYear = DateTime.UtcNow.Year;
        }

        public string Name { get; set; }

        public int Wheelscount { get; }

        protected int ProductionYear => _productionYear;

        public virtual void SoundHorn()
        {
            Console.WriteLine("Beep beep");
        }
        public abstract void StarttoDrive();
    }
}

