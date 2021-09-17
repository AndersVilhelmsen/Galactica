using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    sealed class Moon : Planet
    {
        public Planet Orbiting { get; set; }

        public int Distance()
        {
            return (int)Math.Sqrt(Math.Pow(position.X - Orbiting.position.X, 2) + Math.Pow(position.Y, 2));
        }

    }
}
