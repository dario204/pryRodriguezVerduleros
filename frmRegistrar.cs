﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryRodriguezVerduleros
{
    public partial class frmRegistrar : Form
    {
        clsManejoBD objManejoBD= new clsManejoBD();
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            objManejoBD.ConectarBaseDatos();
            objManejoBD.CargarCboProducto(cboProducto);
            objManejoBD.CargarCboVendedores(cboVendedores);
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            

        }

        private void cboVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
