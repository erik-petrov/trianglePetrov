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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, h;
            bool right;
            string type, perimeterA, typeA;
            listView1.Items.Clear();
            a = Convert.ToDouble(aBox.Text);
            h = Convert.ToDouble(hBox.Text);
            if (ravno.Checked)
            {
                type = "ravno";
                typeA = "Равносторонний";
            }
            else if (razno.Checked)
            {
                type = "razno";
                typeA = "Разносторонний";
            }
            else if (twosides.Checked)
            {
                type = "twosides";
                typeA = "Равнобедренный";
            }
            else 
            {
                type = "";
                typeA = "";
            }
            right = rightRadio.Checked;
            Triangle triangle = new Triangle(a, h, type, right);
            if (triangle.Perimeter() == 0.0) perimeterA = "Невозможно посчитать";
            else perimeterA = Convert.ToString(triangle.Perimeter());
            listView1.Items.Add("Сторона a");
            listView1.Items.Add("Высота");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Тип");
            listView1.Items[0].SubItems.Add(triangle.getA());
            listView1.Items[1].SubItems.Add(triangle.getH());
            listView1.Items[2].SubItems.Add(perimeterA);
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Area()));
            listView1.Items[4].SubItems.Add(typeA);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
