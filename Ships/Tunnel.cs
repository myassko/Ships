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
        public List<Ship> port { get; }
        public DataGridView dataGrid { get; set; }
        private int minShipsInTunnel = 0;
        private int maxShipsInTunnel = 5;
        private int shipCounter = 0;
        //Создаем тоннель
        public Tunnel(DataGridView dataGrid)
        {
            this.port = new List<Ship>();
            this.dataGrid = dataGrid;
        }
        //Добавляем корабль в тоннель
        public void AddShip(Ship ship)
        {

            if (shipCounter < maxShipsInTunnel)
            {
                port.Add(ship);
                shipCounter++;
                //MessageBox.Show("Корабль прибыл в порт");
                //return true;
            }
            else
            {
                MessageBox.Show("Мест нет");
            }

            //return false;
        }

        //Выбираем 1 случайный корабль
        public Ship GetShip()
        {
                var random = new Random();
                return port[random.Next(port.Count)];
        }
        //Выбираем корабль нужного типа
        public Ship GetShip(Ships shipType)
        {
            if (shipCounter > minShipsInTunnel)
            {
                foreach (var ship in port)
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
