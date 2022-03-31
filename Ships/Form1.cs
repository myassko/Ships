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
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1Load(object sender, EventArgs e)
        {

            MessageBox.Show("Форма загрузилась успешно");
            var tunel = new DataGridView();
            tunel.Location = new Point(220, 110);
            tunel.Size = new Size(1000, 200);
            tunel.BackgroundColor = Color.Black;
            int n = 1;
            //n = dataGridView1.Columns.Count;

            tunel.Columns.Add("column-1", "Header column - 1");
            tunel.Columns.Add("column-2", "Header column - 2");
            tunel.Columns.Add("column-3", "Header column - 3");
            tunel.Columns.Add("column-4", "Header column - 4");
            tunel.Columns.Add("column-5", "Header column - 5");
            tunel.RowHeadersVisible = false;
            tunel.ColumnHeadersVisible = false;
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
    }
}
