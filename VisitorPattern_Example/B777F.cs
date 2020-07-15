/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 16.07.2020
*/

using System;

namespace VisitorPattern_Example
{
    class B777F : IAircraft
    {
        public B777F()
        {
            Console.WriteLine("B777F is initializing...");
        }

        public void ActivateFeature(IFeature features)
        {
            features.EnableFeature(this);
        }
    }
}
