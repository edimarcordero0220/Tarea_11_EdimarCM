using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Registros_Tarea_11.Registros;
using Registros_Tarea_11.Consultas;

namespace Registros_Tarea_11
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void categoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuarios u = new RegistroUsuarios();

            u.Show();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPeliculas u = new RegistroPeliculas();

            u.Show();
        }

        private void peliculasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarUsuario u = new ConsultarUsuario();
            u.Show();
        }
    }
}
