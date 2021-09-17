using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{

    public abstract class SpaceObjects
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private Position _position = new Position() { X = 4, Y = 3 };
        public Position position
        {
            get { return _position; }
            set { _position = value; }
        }




        public class Position
        {
            public int X { get; set; }
            public int Y { get; set; }

            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }


    }
}
