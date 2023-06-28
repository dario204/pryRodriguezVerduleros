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

        OleDbCommand miComandoVendedor;
        OleDbDataReader miLectorVendedor;
        OleDbCommand miComandoProductos;
        OleDbDataReader miLectorProductos;
        OleDbConnection miConexion;
        string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VERDULEROS.mdb;";


        public void CargaDatos(ComboBox cboVendedores, ComboBox cboProducto)
        {
            cboVendedores.SelectedIndex = -1;
            cboProducto.SelectedIndex = -1;
            try
            {
                miConexion = new OleDbConnection();
                miComandoProductos = new OleDbCommand();
                miComandoVendedor = new OleDbCommand();

                miComandoVendedor.Connection = miConexion;
                miComandoVendedor.CommandType = CommandType.TableDirect;
                miComandoVendedor.CommandText = "Vendedores";

                miComandoProductos.Connection = miConexion;
                miComandoProductos.CommandType = CommandType.TableDirect;
                miComandoProductos.CommandText = "Productos";
                miLectorVendedor = miComandoVendedor.ExecuteReader();
                miLectorProductos = miComandoProductos.ExecuteReader();
                cboVendedores.Items.Clear();
                cboProducto.Items.Clear();
                DataTable dtVendedores = new DataTable();
                DataTable dtProducto = new DataTable();
                if (miLectorVendedor.HasRows)
                {
                    dtVendedores.Load(miLectorVendedor);
                    cboVendedores.DataSource = dtVendedores;
                    cboVendedores.ValueMember = "IdVendedor";
                    cboVendedores.DisplayMember = "NombreVendedor";
                }
                if (miLectorProductos.HasRows)
                {
                    dtProducto.Load(miLectorProductos);
                    cboProducto.DataSource = dtProducto;
                    cboProducto.ValueMember = "IdProducto";
                    cboProducto.DisplayMember = "NomProducto";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

      
        public void RegistrarVentas(int vendedor, int producto, DateTime FechaVenta, int kilos)
        {
            string ConexionBD = "INSERT INTO Ventas ([Cod Vendedor], [Cod Producto], Fecha, Kilos) VALUES (@vendedor, @producto, @fechaventa, @cantidad)";
            try
            {
                miConexion = new OleDbConnection(CadenaConexion);
                miComandoVendedor = new OleDbCommand();
                miComandoVendedor.Connection = miConexion;
                miComandoVendedor.CommandType = CommandType.Text;
                miComandoVendedor.CommandText = ConexionBD;
                miConexion.Open();
                string Fechaa = FechaVenta.ToShortDateString();
                miComandoVendedor.Parameters.AddWithValue("@vendedor", vendedor);
                miComandoVendedor.Parameters.AddWithValue("@producto", producto);
                miComandoVendedor.Parameters.AddWithValue("@fechaventa", FechaVenta);
                miComandoVendedor.Parameters.AddWithValue("@cantidad", kilos);
                miComandoVendedor.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }      
            

        

        



    
}



