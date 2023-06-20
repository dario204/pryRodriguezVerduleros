using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace pryRodriguezVerduleros
{
    class clsManejoBD
    {
         OleDbConnection miConexion;
         OleDbCommand miComando;
         OleDbDataReader miLector;

        string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VERDULEROS.mdb;";


        public void ConectarBaseDatos()
        {
            try
            {
               miConexion= new OleDbConnection();
               miConexion.ConnectionString = CadenaConexion;
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
               miComando=new OleDbCommand();
                miComando.CommandType = System.Data.CommandType.TableDirect;
                miComando.CommandText = "Vendedores";

                miLector = miComando.ExecuteReader();
                cboVendedores.Items.Clear();
                DataTable dt = new DataTable();

                if (miLector.HasRows)
                {
                    dt.Load(miLector);
                    cboVendedores.DataSource = dt;
                    cboVendedores.ValueMember = "IdVendedor";
                    cboVendedores.DisplayMember = "NomVendedor";
                }
                miLector.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            miLector.Close();
        }
        public void CargarCboProducto(ComboBox cboProducto)
        {
            try
            {
                miComando.Connection = miConexion;
                miComando.CommandType = System.Data.CommandType.TableDirect;
                miComando.CommandText = "Productos";

                miLector = miComando.ExecuteReader();
                cboProducto.Items.Clear();
                DataTable dt = new DataTable();

                if (miLector.HasRows)
                {
                    dt.Load(miLector);
                    cboProducto.DataSource = dt;
                    cboProducto.ValueMember = "IdProducto";
                    cboProducto.DisplayMember = "NomProducto";
                }
                miLector.Close();
            }
            catch (Exception ex)
            {
              MessageBox.Show("Error: " + ex.Message);
            }
           
        }
        public void RegistrarVentas(string vendedor, string producto, DateTime FechaVenta, string kilos)
        {
            try
            {
                miComando.Connection = miConexion;
                miComando.CommandType = System.Data.CommandType.Text;

                miComando.CommandText= "INSERT INTO Ventas ([CodVendedor], [CodProducto]," + "Fecha, Kilos) VALUES (" + vendedor + "," + producto + "," + "´" + FechaVenta + "´" + "," + kilos + ")";
                miComando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }      
            

        

        



    
}



