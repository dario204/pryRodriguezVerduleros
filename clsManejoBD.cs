using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
namespace pryRodriguezVerduleros
{
    class clsManejoBD
    {
        public OleDbConnection miConexion = new OleDbConnection();
        public OleDbCommand miComando = new OleDbCommand();
        OleDbDataReader miLector;

        string ProveedorAccess = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =";


        public void ConectarBaseDatos(string rutaArchivo)
        {
            try
            {


                miConexion = new OleDbConnection();

                miConexion.ConnectionString = ProveedorAccess + rutaArchivo;

                miConexion.Open();

                MessageBox.Show("Base de datos abierta con éxito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void ListarTablasBD(ComboBox cmbTablas, DataGridView dgvTablas, Label lblNombreDB)
        {

            try
            {
                miConexion.Open();

                DataTable tablas = miConexion.GetSchema("Tables");

                foreach (DataRow tabla in tablas.Rows)
                {
                    if (tabla[3].ToString() == "TABLE")
                    {
                        cmbTablas.Items.Add(tabla[2].ToString());
                    }


                }
                miConexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return cadenaConexion;
        }

    }      
            

        

        public void MostrarTablasDB(ComboBox cmbTablas, string cadenaConexion, DataGridView dgvTablas)
        {

        }



    }
}



