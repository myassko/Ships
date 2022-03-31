using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ships
{
    public partial class Form1 : Form
    {
        private object currObject = null;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.MouseMove += new MouseEventHandler(mouseMove);
            this.MouseClick += new MouseEventHandler(mouseRightClick);
        }

        private void mouseRightClick(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Right")
                currObject= null;
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (currObject != null)
            {
                currObject.GetType().GetProperty("Location").SetValue(currObject, new Point(Cursor.Position.X, Cursor.Position.Y));
            }
        }

        private void Form1Load(object sender, EventArgs e)
        {

            MessageBox.Show("Форма загрузилась успешно");
            var tunel = new DataGridView();
            tunel.Location = new Point(220, 110);
            tunel.Size = new Size(300, 300);
            tunel.BackgroundColor = Color.Black;
            tunel.BorderStyle = BorderStyle.None;
            tunel.MouseClick += new MouseEventHandler(GridClick);
            int n = 1;
            //n = dataGridView1.Columns.Count;
            tunel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tunel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tunel.AutoSize = true;
            tunel.Columns.Add("column-1", "Header column - 1");
            tunel.Columns.Add("column-2", "Header column - 2");
            tunel.Columns.Add("column-3", "Header column - 3");
            tunel.Columns.Add("column-4", "Header column - 4");
            tunel.Columns.Add("column-5", "Header column - 5");
            tunel.RowHeadersVisible = false;
            tunel.ColumnHeadersVisible = false;
            tunel.AllowUserToAddRows = false;
            tunel.Rows.Add("Banana 100", "Clothe 50", "Bread 50", "Banana 10", "Banana 100");
            //tunel.Rows[0].Visible = false;
            int a = 20;
            //for (int i = 0; i < 10; i++)
            //{
            //    tunel.Location = new Point(tunel.Location.X + a, 110);
            //}

            this.Controls.Add(tunel);
            MessageBox.Show("Датагрид загрузился успешно");
        }

        private void GridClick(object sender, MouseEventArgs e)
        {
            currObject = sender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }
    }
}
