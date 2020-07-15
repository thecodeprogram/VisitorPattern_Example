/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 16.07.2020
*/

using System;

namespace VisitorPattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Visitor Design Pattern Example - Thecodeprogram";
            //Features Arrasy
            IFeature[] listFeatures = { new IFE(), new CargoCooling() };

            //Concrete classes to initialize class and features
            B777 _b777 = new B777();
            for (int i = 0; i < listFeatures.Length; i++)
            {
                _b777.ActivateFeature(listFeatures[i]);
            }
            

            Console.WriteLine("-----------------------------------------");

            B777F _b777f = new B777F();
            for (int i = 0; i < listFeatures.Length; i++)
            {
                _b777f.ActivateFeature(listFeatures[i]);
            }

            Console.ReadLine();
        }
    }
}
