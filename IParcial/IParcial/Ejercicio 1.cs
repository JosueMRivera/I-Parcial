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
        //Variable Global
        decimal sumatotal;

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

            //Mensaje que muestra el resultado
            //MessageBox.Show("La suma es: " + resultado);
            //resultadolbl.Text = Convert.ToString(resultado);

            //Sumar(n1, n2);
            sumatotal = Sumatoria(n1, n2);
            MessageBox.Show("La suma es: " + sumatotal, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // Procedimiento
        private void Sumar(decimal num1, decimal num2) 
        {
            sumatotal = num1 + num2;
        }

        //Funcion
        private decimal Sumatoria(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

    }
}
