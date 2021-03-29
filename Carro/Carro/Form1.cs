using Carro.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carro
{
    public partial class Form1 : Form
    {
        private string ruta = "";

        bool Play = false;
        string[] ArchivosMP3;
        string[] rutasArchivosMP3;

        ClsAutomotor carrito;
        public Form1()
        {
            InitializeComponent();
        }

        private void botonuno_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutomotor("Meches", 130);
            carrito.color = "Negro";



            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max} KPH");

        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            if (carrito == null)
            {
                MessageBox.Show("Crea el carro primero");

            }
            else
            {
                Estado.Text = $" el carro {carrito.marca} :{carrito.encender()}";
            }

   

        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            if (carrito == null)
            {
                MessageBox.Show("Crea el carro primero");

            }
            else
            {
                labelEstadoVelocidad.Text = carrito.Acelerar();
            }


        }

        private void buttonBMW_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutomotor("BMW", 200, "NEGRO");

            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max} KPH");
        }

        private void bouttonAltoTotal_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.DetenerMarcha();
        }

        private void labelEstadoVelocidad_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.DetenerMarcha();
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaBusquedaDeArchivos = new OpenFileDialog();

            CajaBusquedaDeArchivos.Multiselect = true;

            if (CajaBusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                ArchivosMP3 = CajaBusquedaDeArchivos.SafeFileNames;
            rutasArchivosMP3 = CajaBusquedaDeArchivos.FileNames; 
            foreach(var ArchivosMP3 in ArchivosMP3){
                lstCanciones.Items.Add(ArchivosMP3); 
            }
            Reproductor.URL = rutasArchivosMP3[0];
            lstCanciones.SelectedIndex = 0; 

        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = rutasArchivosMP3[lstCanciones.SelectedIndex]; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.Frenarmaslento();
        }
    }
}
