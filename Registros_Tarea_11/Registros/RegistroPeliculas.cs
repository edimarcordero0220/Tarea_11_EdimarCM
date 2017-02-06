using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace Registros_Tarea_11.Registros
{
    public partial class RegistroPeliculas : Form
    {
        public RegistroPeliculas()
        {
            InitializeComponent();
        }
        Utilidades ut = new Utilidades();
        private void LlenarClase(Peliculas p)
        {
            p.Descripcion = DescripciontextBox.Text;
            p.Estreno = EstrenodateTimePicker.Value;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Peliculas peli = new Peliculas();
            LlenarClase(peli);
            //no
            PeliculasBLL.Insertar(peli);
            MessageBox.Show("Registro Exitoso!!!");

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            //mal
            BuscarUsuario(PeliculasBLL.Buscar(String(IdtextBox.Text)));
        }
        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }
        private void LlenarPeliculas(Peliculas peli)
        {
            IdtextBox.Text = peli.IdPelicula.ToString();
            DescripciontextBox.Text = peli.Descripcion;
            EstrenodateTimePicker.Value = peli.Estreno;
        }
        public void BuscarUsuario(Peliculas pelicula)
        {
            if (IdtextBox.Text == "")
            {
                MessageBox.Show("Para hacer una busqueda de Usuario debe ingresar el ID");
            }
            else
            {

                IdtextBox.Text = pelicula.IdPelicula.ToString();
                DescripciontextBox.Text = pelicula.Descripcion.ToString();
            }
        }
        private bool ValidarBuscar()
        {
            if (PeliculasBLL.Buscar(String(IdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;

            }

            return true;


        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdtextBox.Text = "";
            DescripciontextBox.Text = "";
        }

        private void RegistroPeliculas_Load(object sender, EventArgs e)
        {

        }
    }
}
