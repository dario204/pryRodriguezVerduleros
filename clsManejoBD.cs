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
         OleDbConnection miConexion = new OleDbConnection();
         OleDbCommand miComando = new OleDbCommand();
         OleDbDataReader miLector;

        string ProveedorAccess = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VERDULEROS.mdb;";


        public void ConectarBaseDatos()
        {
            try
            {

                miConexion.ConnectionString=ProveedorAccess;

                miConexion.Open();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void CargarCboVendedores(ComboBox cboVendedores)
        {
            try
            {
                miComando.CommandType=System.Data.CommandType.TableDirect;
                miComando.CommandText = "NombreVendedores";

                miLector = miComando.ExecuteReader();

                cboVendedores.Items.Clear();
                while (miLector.Read())
                {
                    cboVendedores.Items.Add(miLector[0]);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            miLector.Close();
        }
        public void CargarCboProducto(ComboBox cboProducto)
        {
            miComando.CommandType = System.Data.CommandType.TableDirect;
            miComando.CommandText = "NomProducto";

            miLector = miComando.ExecuteReader();

            cboProducto.Items.Clear();
            while (miLector.Read())
            {
                cboProducto.Items.Add(miLector[0]);
            }
            miLector.Close();
        }

    }      
            

        

        



    
}



