using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    enum Startype { YellowDwarf, White, BlueNeutron, RedGiant }

    class Star : SpaceObjects
    {
        public Startype Type { get; set; }
        public float Temperature {  get; set; }
        
        public List<Planet> planets = new List<Planet>();

        private Position _position = new Position() { X = 2, Y = 2 };
        public new Position position
        {
            get { return _position; }
            //set { _position = value; }
        }
    }
}
