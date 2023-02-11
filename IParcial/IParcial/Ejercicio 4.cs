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
    public partial class Ejercicio_4 : Form
    {
        public Ejercicio_4()
        {
            InitializeComponent();
        }

        private void ejecutartxt_Click(object sender, EventArgs e)
        {
            DateTime fecha = Fechatxt.Value;

            diatxt.Text = fecha.Day.ToString();
            mestxt.Text = fecha.ToString("MMMM");
            yeartxt.Text = fecha.ToString("yyyy");
            semanatxt.Text = fecha.ToString("dddd");


        }
    }
}
