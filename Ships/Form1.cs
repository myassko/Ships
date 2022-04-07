using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ships
{
    public partial class Shipsik : Form
    {
        Tunnel tunnel = null;
        Ship ship = null;
       // object locker = new();
        //int z = -1;
        public Shipsik()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            //НЕ ЗНАЕТ КАК РАБОТАЕТ
            #if DEBUG
            TopMost = false;
            #endif
        }

        private Tunnel CreateTunel()
        {
            // var dataGridTunnel = new DataGridView();

            // dataGridTunnel.Size = new Size(300, 70);
            // dataGridTunnel.Location = new Point(this.Width / 2 - 100, 200);
            // dataGridTunnel.BackgroundColor = Color.White;
            // dataGridTunnel.BorderStyle = BorderStyle.None;
            // dataGridTunnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // dataGridTunnel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // dataGridTunnel.AutoSize = true; dataGridTunnel.RowHeadersVisible = false;
            // dataGridTunnel.ColumnHeadersVisible = false;
            // dataGridTunnel.AllowUserToAddRows = false;
            // //dataGridTunnel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right|AnchorStyles.Top;
            // dataGridTunnel.Columns.Add("column-1", "Header column - 1");
            // dataGridTunnel.Columns.Add("column-2", "Header column - 2");
            // dataGridTunnel.Columns.Add("column-3", "Header column - 3");
            // dataGridTunnel.Columns.Add("column-4", "Header column - 4");
            // dataGridTunnel.Columns.Add("column-5", "Header column - 5");
            // dataGridTunnel.Rows.Add("Banana 100", "Clothe 50", "Bread 50", "Banana 10", "Banana 100");

            // this.Controls.Add(dataGridTunnel);
            //return new Tunnel(dataGridTunnel);
            return new Tunnel(new DataGridView());

        }
        //При загрузке формы создаем тоннель
        private void Form1Load(object sender, EventArgs e)
        {
            tunnel = CreateTunel();
        }
        //При нажатии на кнопку генерирует случайным образом кораблик
        private void ShipGenerator_Click(object sender, EventArgs e)
        {

            ship = new Ship();//Создали кораблик
            Console.WriteLine($"{ship.Type} {ship.Size}");
            Console.WriteLine("/////////////");
            tunnel.AddShip(ship);//Добавили кораблик в тоннель
           // z++;
            this.Controls.Add(ship.Picture);//Показали кораблик на форме
        }

        public class Test1
        {
            public Label Lab;
            public Button But;
            public Ship Ship;
            public Test1(Label lab, Button but, Ship ship)
            {
                Lab = lab;
                But = but;
                Ship = ship;
            }
        }
        //Отправляем кораблик к причалу с бананчикам
        private void BananaPath_Click(object sender, EventArgs e)
        {
            BananaPath.Enabled = false;
            Thread thread = new Thread(new ParameterizedThreadStart(Move));
            var ship1 = tunnel.GetShip(Ships.Banana);
            var a = new Test1(BananaCount, BananaJetty, ship1);
            thread.Start(a);



        }
        //Отправляем кораблик к причалу с одеждой
        private void ClothesPath_Click(object sender, EventArgs e)
        {
            ClothesPath.Enabled = false;
            Thread thread = new Thread(new ParameterizedThreadStart(Move));
            var ship1 = tunnel.GetShip(Ships.Clothe);
            var a = new Test1(ClothesCount, ClothesJetty, ship1);
            thread.Start(a);
        }
        //Отправляем кораблик к причалу с хлебом
        private void BreadPath_Click(object sender, EventArgs e)
        {
            BreadPath.Enabled = false;
            Thread thread = new Thread(new ParameterizedThreadStart(Move));
            var ship1 = tunnel.GetShip(Ships.Bread);
            var a = new Test1(BreadCount, BreadJetty, ship1);
            thread.Start(a);
        }
        //Позваляет кораблику двигаться по форме
        public  void Move(object button)
        {
            CheckForIllegalCrossThreadCalls = false;
            if (button is Test1 path)
            {
                try
                {
                    MoveDown(path.But, path.Ship);
                    Thread.Sleep(100);
                    MoveLeft(path.But, path.Ship);

                    var test = new Test(path.Lab, path.Ship);
                    Counter(path.Lab, path.Ship);
                    ChooseButton(path.But).Enabled = true;
                }
                catch
                {

                }
            }
        }

        public void MoveDown(Button but,Ship ship)
        {
            while (but.Location.Y > ship.Picture.Location.Y)
            {
                ship.Picture.Location = new Point(ship.Picture.Location.X, ship.Picture.Location.Y + 10);
                Thread.Sleep(100);
            }
            ship.Picture.Location = new Point(ship.Picture.Location.X, but.Location.Y);
        }
        
        public void MoveLeft(Button but, Ship ship)
        {
            while (but.Location.X + ship.Picture.Size.Width < ship.Picture.Location.X)
            {
                ship.Picture.Location = new Point(ship.Picture.Location.X - 10, ship.Picture.Location.Y);
                Thread.Sleep(100);
            }
            ship.Picture.Location = new Point(ship.Picture.Location.X, but.Location.Y);
        }

        public void MoveRight(Ship ship)
        {
            //while (this.Width-ship.Picture.Size.Width> ship.Picture.Location.X)
            //{
            //    ship.Picture.Location = new Point(ship.Picture.Location.X + 10, ship.Picture.Location.Y);
            //    Thread.Sleep(100);
            //}
            while (500> ship.Picture.Location.X)
            {
                ship.Picture.Location = new Point(ship.Picture.Location.X + 10, ship.Picture.Location.Y);
                Thread.Sleep(100);
            }
        }

        public Label ChooseLable(Button but)
        {
            switch (but.Name)
            {
                case "BananaJetty":
                    return BananaCount;
                case "ClothesJetty":
                    return ClothesCount;
                case "BreadJetty":
                    return BreadCount;
                default:
                    return null;
            }
        }

        public Button ChooseButton(Button but)
        {
            switch (but.Name)
            {
                case "BananaJetty":
                    return BananaPath;
                case "ClothesJetty":
                    return ClothesPath;
                case "BreadJetty":
                    return BreadPath;
                default:
                    return null;
            }
        }

       //Показывает текущую вместимость корабля(счетчик)
        public  void Counter(Label lab,Ship ship)
        {
                     
            //if (lab is Test p)
            //{
                int a = 0;
                //    lock (locker)
                //    {


                var ship1 =ship;
                for (int i = 0; i <= (int)ship1.Size; i++)
                {
                    lab.Text = Convert.ToString(a);
                    a++;
                   Thread.Sleep(100);
                }
                MoveRight(ship1);
                Thread.Sleep(1000);
                lab.Text = "0";
            //this.Controls.Remove(ship.Picture);
            ship.DeleatePicture();
            tunnel.port.Remove(ship); 
                //z--;
            //}
            //}
        }

        public class Test
        {
            public Label Lab;
            public Ship Ship;
            public Test(Label lab, Ship ship)
            {
                Lab = lab;
                Ship = ship;
            }
        }

        //ПАЛОЧКА НИКТО НЕ ЗНАЕТ КАК РАБОТАЕТ ВЫРУЧАЛОЧКА
        private void MagicStick_Click(object sender, EventArgs e)
        {
            BananaPath.Enabled = true;
            ClothesPath.Enabled = true;
            BananaPath.Enabled = true;
            //Close();
        }
    }
}
