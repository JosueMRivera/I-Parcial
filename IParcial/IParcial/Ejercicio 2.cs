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
    public partial class Ejercicio_2 : Form
    {
        public Ejercicio_2()
        {
            InitializeComponent();
        }

        private void ejecutarbt_Click(object sender, EventArgs e)
        {
            if (numero1txt.Text == "")
            {
                errorProvider.SetError(operacionestxt, "Ingrese un valor");
                return;
            }
            if (numero2txt.Text == "")
            {
                errorProvider.SetError(operacionestxt, "Ingrese un valor");
                return;
            }
            if (operacionestxt.Text == "")
            {
                errorProvider.SetError(operacionestxt, "Seleccione una opcion");
                return;
            }
            errorProvider.Clear();
            decimal resultado = Calcular(Convert.ToDecimal(numero1txt.Text), Convert.ToDecimal(numero2txt.Text));
            MessageBox.Show("El resultado de la operacion es: " + resultado, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Resultadolbl.Text = Convert.ToString(resultado);
        }

        private decimal Calcular(decimal n1, decimal n2)
        {
            string operacion = operacionestxt.Text;
            decimal resultado = 0;

            if(operacion == "Sumar")
                resultado = n1 + n2;
            else if (operacion == "Restar")
                resultado = n1 - n2;
            else if (operacion == "Multiplicar")
                resultado = n1 * n2;
            else if (operacion == "Dividir")
                resultado = n1 / n2;

            return resultado;

        }

    }
}
