/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 16.07.2020
*/

using System;

namespace VisitorPattern_Example
{
    class B777 : IAircraft
    {
        public B777()
        {
            Console.WriteLine("B777 is initializing...");
        }

        public void ActivateFeature(IFeature features)
        {
            features.EnableFeature(this);
        }
    }
}
