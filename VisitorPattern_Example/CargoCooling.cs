/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 16.07.2020
*/

using System;

namespace VisitorPattern_Example
{
    class CargoCooling : IFeature
    {
        public void EnableFeature(IAircraft aircraft)
        {
            if (aircraft is B777)
            {
                Console.WriteLine("Cargo Cooling is enabled");
            }
            else if (aircraft is B777F)
            {
                Console.WriteLine("Corgo Cooling is not required for Cargo Aircrafts...");
            }
        }
    }
}
