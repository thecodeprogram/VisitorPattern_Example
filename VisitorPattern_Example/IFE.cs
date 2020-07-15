/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 16.07.2020
*/

using System;

namespace VisitorPattern_Example
{
    class IFE : IFeature
    {
        public void EnableFeature(IAircraft aircraft)
        {
            if (aircraft is B777)
            {
                Console.WriteLine("IFE is enabled");
            }
            else if (aircraft is B777F)
            {
                Console.WriteLine("IFE is not required for Cargo Aircrafts...");
            }
        }
    }
}
