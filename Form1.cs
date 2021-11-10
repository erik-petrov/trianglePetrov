using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trianglePetrov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(aBox.Text);
            b = Convert.ToDouble(bBox.Text);
            c = Convert.ToDouble(cBox.Text);
            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Add("Сторона a");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Существует");
            listView1.Items.Add("Тип");
            listView1.Items[0].SubItems.Add(Convert.ToString(triangle.A));
            listView1.Items[1].SubItems.Add(Convert.ToString(triangle.B));
            listView1.Items[2].SubItems.Add(Convert.ToString(triangle.С));
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Area()));
            listView1.Items[5].SubItems.Add(triangle.RealityCheck() ? "Да": "Нет");
        }
    }
}
