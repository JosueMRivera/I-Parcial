using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace IParcial
{
    public partial class Ejercicio_5 : Form
    {
        public Ejercicio_5()
        {
            InitializeComponent();
        }

        private void hornearbt_Click(object sender, EventArgs e)
        {
            hornearpizza();
        }

        private void hornearpizza()
        {
            Thread.Sleep(10000);
            MessageBox.Show("Mensaje Normal");
        }

        private void hornearasincronabt_Click(object sender, EventArgs e)
        {
            hornearpizzaasync();
            MessageBox.Show("Mensaje Asincrona");
        }

        private Task hornearpizzaasync()
        {
            return Task.Delay(10000);
        }

        private async void calcularbt_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(numero1txt.Text);
            decimal num2 = Convert.ToDecimal(numero2txt.Text);
            decimal total = await sumarAsync(num1, num2);

            MessageBox.Show($"La suma es: {total}");
        }

        private async Task<decimal> sumarAsync(decimal n1, decimal n2)
        {

            decimal suma = await Task.Run(() =>
            {
                return n1 + n2;
            });
            return suma;
        }

    }
}
