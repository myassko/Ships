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

        public void AddShip(Ship ship)
        {

            if (shipCounter < maxShipsInTunnel)
            {
                tunnel.Add(ship);
                shipCounter++;
                MessageBox.Show("Корабль прибыл в порт");
                //return true;
            }
            MessageBox.Show("Мест нет");
            //return false;
        }

        public Ship GetShip(Ships shipType)
        {
            if (shipCounter > minShipsInTunnel)
            {
                foreach (var ship in tunnel)
                {
                    if (ship.Type == shipType)
                    {
                        shipCounter--;
                        return ship;
                    }
                }
                MessageBox.Show("Такого корабля нет");
            }
            else
                MessageBox.Show("Кораблей в тоннеле нет");
            return null;
        }
    }
}
