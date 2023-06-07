using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace PryVentasVerduleros_Cantallops
{
    class ClsConexion
    {
        OleDbConnection miConexion;
        OleDbCommand ComandoVendedor;
        OleDbCommand ComandoProducto;
        OleDbCommand ComandoVentas;
        OleDbDataReader LectorVendedor;
        OleDbDataReader LectorProducto;
        OleDbDataReader LectorVentas;

        public void CargarDatos(ComboBox cmbProducto, ComboBox cmbVendedor)
        {
            string conexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VERDULEROS.mdb;";
            cmbProducto.SelectedIndex = -1;
            cmbVendedor.SelectedIndex = -1;
            try
            {
               miConexion = new OleDbConnection(conexion);
                ComandoVendedor = new OleDbCommand();
                ComandoVendedor.Connection = miConexion;
                ComandoVendedor.CommandType= CommandType.TableDirect;
                ComandoVendedor.CommandText = "Vendedores";
                ComandoProducto = new OleDbCommand();
                ComandoProducto.Connection = miConexion;
                ComandoProducto.CommandType = CommandType.TableDirect;
                ComandoProducto.CommandText = "Productos";
                ComandoVentas = new OleDbCommand();
                ComandoVentas.Connection = miConexion;
                ComandoVentas.CommandType = CommandType.TableDirect;
                ComandoVentas.CommandText = "Ventas";
                miConexion.Open();
                LectorVendedor = ComandoVendedor.ExecuteReader();
                LectorProducto = ComandoProducto.ExecuteReader();
                LectorVentas = ComandoVentas.ExecuteReader();

                HashSet<string> Vendedores = new HashSet<string>();
                HashSet<string> Productos = new HashSet<string>();


                while (LectorVendedor.Read())
                {
                    string Vendedor = LectorVendedor[1].ToString();
                    Vendedores.Add(Vendedor);
                }

                while (LectorProducto.Read())
                {
                    string Producto = LectorProducto[1].ToString();
                    Productos.Add(Producto);
                }

                cmbProducto.Items.AddRange(Productos.ToArray());
                cmbVendedor.Items.AddRange(Vendedores.ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK);

            }
        }
    }
}
