using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ships
{
    class Tunnel
    {
        private List<Ship> tunnel;
        private int minShipsInTunnel = 0;
        private int maxShipsInTunnel = 5;
        private int shipCounter = 0;

        public Tunnel()
        {
            this.tunnel = new List<Ship>();
        }
        public bool TryToAddShip(Ship ship)
        {

            if (shipCounter < maxShipsInTunnel)
            {
                tunnel.Add(ship);
                shipCounter++;
                MessageBox.Show("Корабль прибыл в порт");
                return true;
            }
            return false;
        }

    }
}
