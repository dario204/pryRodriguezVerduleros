using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace PryCantallops_TP1
{
    class ClassConexion
    {
        public OleDbConnection conn = new OleDbConnection();
        public OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rdr;

        string ProveedorAccess = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =";


        public void ConectarBaseDatos(string rutaArchivo)
        {
            try
            {


                conn = new OleDbConnection();

                conn.ConnectionString = ProveedorAccess + rutaArchivo;

                conn.Open();

                MessageBox.Show("Base de datos abierta con éxito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public string ListarTablasBD(ComboBox cmbTablas, DataGridView dgvTablas, Label lblNombreDB)
        {
            dgvTablas.DataSource = null;
            cmbTablas.SelectedIndex = -1;
            string cadenaConexion = "";
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = openFile.FileName;
                    lblNombreDB.Text = Path.GetFileName(rutaArchivo);

                    if (Path.GetExtension(rutaArchivo) == ".accdb")
                    {
                        cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo + ";Persist Security Info=False;";
                    }
                    else
                    {
                        cadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + rutaArchivo + ";";
                    }


                    conn.ConnectionString = cadenaConexion;

                    cmbTablas.Items.Clear();

                    try
                    {
                        conn.Open();

                        DataTable tablas = conn.GetSchema("Tables");

                        foreach (DataRow tabla in tablas.Rows)
                        {
                            if (tabla[3].ToString() == "TABLE")
                            {
                                cmbTablas.Items.Add(tabla[2].ToString());
                            }


                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

            }
            return cadenaConexion;

        }

        public void MostrarTablasDB(ComboBox cmbTablas, string cadenaConexion, DataGridView dgvTablas)
        {
            if (cmbTablas.SelectedIndex != -1)
            {
                
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb";

                try
                {
                    
                    cmd.Connection = conn;
                    cmd.CommandText = cmbTablas.Text;
                    cmd.CommandType = CommandType.TableDirect;
                    cmd.Connection.Open();

                    rdr = cmd.ExecuteReader();

                    DataTable tabla = new DataTable();
                    tabla.Load(rdr);

                    dgvTablas.DataSource = tabla;

                    cmd.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        

    }
}
