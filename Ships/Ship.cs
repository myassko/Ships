using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ships
{
   public class Ship
    {
        public int Count { get; private set; }
        public Ships Type { get; }
        public Sizes Size { get; }
        public PictureBox Picture{ get; set; }

        public Ship()
        {
            Type = CreateShip();
            Size = CreateSize();
            var picture = new PictureBox();
            switch (Type)
            {
                case Ships.Banana:
                    picture.Image = Image.FromFile(@"..\..\..\Pictures\korablik1.jpg");
                    break;
                case Ships.Clothe:
                    picture.Image = Image.FromFile(@"..\..\..\Pictures\korablik2.jpg");
                    break;
                case Ships.Bread:
                    picture.Image = Image.FromFile(@"..\..\..\Pictures\korablik3.jpg");
                    break;
                default:
                    break;
            }
           
            picture.Size = new Size(50, 50);
            picture.Location = new Point(Shipsik.ActiveForm.Size.Width / 2 - (picture.Size.Width / 2), 20);
            picture.Anchor = AnchorStyles.Top;
            picture.SizeMode = PictureBoxSizeMode.AutoSize;
            picture.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            Picture = picture;
        }
        public void DeleatePicture()
        {
            Picture.Image = null;
        }
        public void Add(int count)
        {
            this.Count += count;
        }

        public bool CheckCount()
        {
            return Count <= (int)Size;
        }

        private Sizes CreateSize()
        {
            var a = Enum.GetValues(typeof(Sizes));
            return (Sizes)a.GetValue(new Random().Next(a.Length));
        }

        public static Ships CreateShip()
        {
            var a = Enum.GetValues(typeof(Ships));
            return (Ships)a.GetValue(new Random().Next(a.Length));
        }
    }
}
