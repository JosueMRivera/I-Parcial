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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Sumarbt_Click(object sender, EventArgs e)
        {
            //Variables
            decimal n1 = Convert.ToDecimal(Numero1txt.Text);
            decimal n2 = Convert.ToDecimal(Numero2txt.Text);

            //Resultado de la suma
            decimal resultado = n1 + n2;

            resultadolbl.Text = Convert.ToString(resultado);

            //Mensaje que muestra el resultado
            //MessageBox.Show("La suma es: " + resultado);

        }
    }
}
