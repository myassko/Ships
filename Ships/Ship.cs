using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Ship
    {
        public int Count { get; private set; }
        public Ships Type { get; }
        public Sizes Size { get; }

        public Ship(Ships typeShip, Sizes sizeShip)
        {
            Type = typeShip;
            Size = sizeShip;
        }

        public void Add(int count)
        {
            this.Count += count;
        }

        public bool CheckCount()
        {
            return Count <= (int)Size;
        }
    }
}
