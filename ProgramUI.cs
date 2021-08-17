using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBaker
{
    public class ProgramUI
    {
        public void Run() {

            while (Menu())
            {
                Console.WriteLine("Press any key to conitnue...");
            }
        }

        public bool Menu()
        {
            return true;
        }
    }
}
