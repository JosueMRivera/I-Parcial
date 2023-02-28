using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO;

namespace IParcial
{
    public partial class Ejercicio_9 : Form
    {
        public Ejercicio_9()
        {
            InitializeComponent();
        }

        Coche miCoche = null;
        List<Coche> listacoches = new List<Coche>();
        private void button1_Click(object sender, EventArgs e)
        {
            //Coche miCoche = new Coche();
            //Coche miCoche2 = new Coche("Toyota", "22R");

            string marca = marcatxt.Text;
            string modelo = modelotxt.Text;
            decimal precio;
            if (preciotxt.Text == string.Empty)
            {
                precio = 0;
            }
            else
            {
                precio = Convert.ToDecimal(preciotxt.Text);
            }

            int kilometros = kilometrostxt.Text == string.Empty ? 0 : Convert.ToInt32(kilometrostxt.Text);

            miCoche = new Coche();

            miCoche.Marca = marca;
            miCoche.Modelo = modelo;
            miCoche.Precio = precio;
            miCoche.Kilometros = kilometros;

            listacoches.Add(miCoche);
            CocheDGV.DataSource = null;
            CocheDGV.DataSource = listacoches;
            limpiarControles();
            marcatxt.Focus();

            //MessageBox.Show("Objeto Coche -> Marca: " + miCoche.Marca + " Modelo: " + miCoche.Modelo + " Precio: " + miCoche.Precio + " Kilometros: " + miCoche.Kilometros);


        }

        private void limpiarControles ()
        {
            marcatxt.Clear();
            modelotxt.Text = string.Empty;
            preciotxt.Text = "";
            kilometrostxt.Clear();

        }

        private void Ejercicio_9_Load(object sender, EventArgs e)
        {
            marcatxt.Focus();
        }
    }
}
