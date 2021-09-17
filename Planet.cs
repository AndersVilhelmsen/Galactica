using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    enum Planettype { Terrestial, Giant, Dwarf, Gas_Giant}
    class Planet : SpaceObjects
    {
        public int Diameter { get; set; }
        public int RotationPeriod { get; set; }
        public int RevolutionPeriod { get; set; }
        public Planettype Type {  get; set;}

        public List<Moon> moons = new List<Moon>();

        public int Distance(Star star)
        {
            return (int)Math.Sqrt(Math.Pow(position.X - star.position.X, 2) + Math.Pow(position.Y - star.position.Y, 2));
        }

    }
}
