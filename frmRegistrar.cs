using System;
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
            objManejoBD.CargaDatos(cboVendedores, cboProducto);
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            objManejoBD.RegistrarVentas(Convert.ToInt32(cboVendedores.SelectedValue), Convert.ToInt32(cboProducto), dtpFecha.Value, Convert.ToInt32(txtKilos.Text));
            MessageBox.Show("Su venta se a registrado con exito", "", MessageBoxButtons.OK);
        }

        private void cboVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblKilos_Click(object sender, EventArgs e)
        {

        }

        private void txtKilos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
