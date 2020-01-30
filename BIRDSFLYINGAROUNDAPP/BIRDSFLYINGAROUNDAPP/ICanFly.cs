using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIRDSFLYINGAROUNDAPP
{
    interface ICanFly
    {
        void SetLocation(double longitude, double latitude);
        void SetAltitude(double altitude);
    }
}
