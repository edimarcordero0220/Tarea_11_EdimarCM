﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Registros_Tarea_11.Registros;

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
            Usuarios u = new Usuarios();

            u.Show();
        }
    }
}
