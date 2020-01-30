using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIRDSFLYINGAROUNDAPP
{
    public class Sparrow : Bird, ICanFly
    {

        public override void Draw()
        {
            //Tegn fuglen på skærmen
            Console.WriteLine("I draw");
        }

        public void SetAltitude(double altitude)
        {
            //SetAltitude
            Console.WriteLine("I can fly: set Altitude");
        }

        public void SetLocation(double longitude, double latitude)
        {
            //SetLocation
            Console.WriteLine("I can fly: set Location");

        }
    }
}
