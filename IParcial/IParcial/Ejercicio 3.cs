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
    public partial class Ejercicio_3 : Form
    {
        public Ejercicio_3()
        {
            InitializeComponent();
        }

        private void ejecutarbt_Click(object sender, EventArgs e)
        {
            string cadena = Cadenatxt.Text;
            longitudtxt.Text = cadena.Length.ToString();

            primercaractertxt.Text = cadena.Substring(0,1);
            ultimocaractertxt.Text = cadena.Substring(cadena.Length - 1, 1);

            mayusculastxt.Text = cadena.ToUpper();
            minusculastxt.Text = cadena.ToLower();

            reemplazartxt.Text = cadena.ToUpper().Replace("A", "E").ToLower();
            


        }
    }
}
