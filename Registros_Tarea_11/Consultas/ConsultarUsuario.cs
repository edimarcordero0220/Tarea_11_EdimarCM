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

namespace Registros_Tarea_11.Consultas
{
    public partial class ConsultarUsuario : Form
    {
        public ConsultarUsuario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarConsulta() == true)
                BuscarCombo();
        }
        Utilidades util = new Utilidades();
        public List<Usuarios> lista = new List<Usuarios>();
        private void BuscarCombo()
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(BuscartextBox.Text))
                {
                    lista = UsuariosBLL.GetLista(util.String(BuscartextBox.Text));
                }
                
                else
                {
                    lista = UsuariosBLL.GetLista();
                }
                FiltrardataGridView.DataSource = lista;
            }
           

        }
        private bool ValidarConsulta()
        {
            if (FiltrarcomboBox.SelectedIndex == 5)
            {
                if (DesdedateTimePicker.Value == HastadateTimePicker.Value)
                {
                    MessageBox.Show("Favor definir una fecha entre las fechas ");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (string.IsNullOrEmpty(BuscartextBox.Text))
            {
                errorProvider.SetError(BuscartextBox, "Ingrese el campo");
                return true;
            }
            if (FiltrarcomboBox.SelectedIndex == 1 && UsuariosBLL.GetListaNombre(BuscartextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
          

            errorProvider.Clear();
            return true;
        }
        private void Cargar()
        {
            FiltrarcomboBox.Items.Insert(0, "IdCliente");
            FiltrarcomboBox.Items.Insert(1, "Nombre");
            FiltrarcomboBox.Items.Insert(2, "Apellido");
            FiltrarcomboBox.Items.Insert(3, "Direccion");
            FiltrarcomboBox.Items.Insert(4, "Cedula");
            FiltrarcomboBox.Items.Insert(5, "Fecha");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            FiltrardataGridView.DataSource = UsuariosBLL.GetLista();
        }
        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            
        }

        private void ConsultarUsuario_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
