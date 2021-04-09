using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Clases;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        private string[] datosUnitarios; // Lo vamos a utilizar para Representar los datos de nombres y sus respectivas notas
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonArreglo_Click(object sender, EventArgs e)
        {
            int ArreglarNombres = 0; // Variable declarada con valor de 0 
            string[] nombres = new string[ArregloNotas.Length - 1]; // Creara un String nuevo donde leera los datos 

            foreach(string linea in ArregloNotas) // Lo leera en Arreglo notas 
            {
                if (ArreglarNombres != 0) // Si ArregloNombres sigue siendo diferente a 0 entonces seguira ordenandolos 
                {
                    string[] datos = linea.Split(';'); 
                    nombres[ArreglarNombres - 1] = datos[1]; // Si sigue siendo menor a la primera variable, Seguira ordenando para pasar al suguiente dato

                }

                ArreglarNombres++;
            }

            ClsArreglos arrreglo = new ClsArreglos(nombres); // Nuevo metodo para ordenar nombres 
            string[] resultado = arrreglo.Burbujita();

            for(int indice = 0; indice < resultado.Length; indice++) // Verifica todas las lineas para ordenar 
            {
                listBox1.Items.Add($"{resultado[indice]}"); // Devuelve El valor Arreglado 
            }
            
        }



        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog(); // Abre el archivo Plano 

            ofd.Title = "Selecciona el archivo plano";
            ofd.InitialDirectory = @"D:\Zero\Escritorio\UMG\Programacion 1\Clase 7"; // Direccion del archivo 
            ofd.Filter = "Archivo Plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                textBoxResultado.Text = resultado;

            }


        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {
            
            foreach(string Linea in ArregloNotas)
            {
                datosUnitarios = Linea.Split(';');
                listBoxResultado.Items.Add($" {datosUnitarios[1]} Notas: {datosUnitarios[5]} Promedios: {datosUnitarios[6]}" ); 
            }
        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
