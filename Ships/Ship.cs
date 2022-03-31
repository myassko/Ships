using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Ship
    {
        public int count { get; private set; }
        public Ships type { get; }
        public Sizes size { get; }

        public Ship(Ships typeShip, Sizes sizeShip)
        {
            type = typeShip;
            size = sizeShip;
        }

        public void Add(int count)
        {
            this.count += count;
        }

        public bool CheckCount()
        {
            return count <= (int)size;
        }
    }
}
