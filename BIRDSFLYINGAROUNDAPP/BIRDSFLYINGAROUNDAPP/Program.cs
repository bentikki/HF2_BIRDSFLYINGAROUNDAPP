using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIRDSFLYINGAROUNDAPP
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Bird> birds = new List<Bird>()
            {
                new Sparrow(),
                new Penguin()
            };

            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird.ToString());
                bird.Draw();
                if(bird is ICanFly)
                {
                    ((ICanFly)bird).SetAltitude(1.1);
                    ((ICanFly)bird).SetLocation(2.2, 3.3);

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
