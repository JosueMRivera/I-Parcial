using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio_8 : Form
    {
        public Ejercicio_8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            recorrerdeunoenuno(1, 100);
        }

        private void recorrerdeunoenuno(int valinicial, int valfinal)
        {
            listBox1.Items.Add(valinicial);

            if (valinicial < valfinal)
            {
                recorrerdeunoenuno(valinicial + 1, valfinal);
            }
            
        }

    }
}
