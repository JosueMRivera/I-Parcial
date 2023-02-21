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

            int numerodedias = Convert.ToInt32(diacitatxt.Text);
            DateTime FechaActual = DateTime.Now;

            int diasrestar = Convert.ToInt32(restartxt.Text);
            diacita2txt.Text = FechaActual.AddDays(numerodedias).ToLongDateString();
            nuevafechatxt.Text = fecha.AddDays(-diasrestar).ToLongDateString();

            MessageBox.Show("La edad es: " + devolveredad(fecha));
            devolveredad(fecha);

        }

        private int devolveredad(DateTime fechanacimiento)
        {
            DateTime fechaactual = DateTime.Now;
            int edad;

            if(fechanacimiento >= fechaactual)
            {
                return 0;
            }
            else
            {
                edad = fechaactual.Year - fechanacimiento.Year;
                if (fechanacimiento.Month > fechaactual.Month)
                {
                    --edad;
                }
                return edad;
            }

        }
    }
}
