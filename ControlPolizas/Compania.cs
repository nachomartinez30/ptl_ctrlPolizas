using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPolizas
{
    public partial class Compania : Form
    {
        SQLiteConnection conexion;
        int Pk_Compania;

        public Compania()
        {
            InitializeComponent();
        }

        public void valoresDefaultBotones()
        {
            btnAgregar.Visible = true;
            btnAgregar.Enabled = true;
            btnBuscar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
        }

        public void limpiarText()
        {
            txtNombreCompania.Text="";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
        private void Compania_Load(object sender, EventArgs e)
        {
            sugerenciaCompania();
            valoresDefaultBotones();
            limpiarText();
        }

        public int buscarPK_Compania(String nombreCompania)
        {
            int PK_Compania = 0;
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                string queryMax = "SELECT PK_Compania FROM Companias WHERE NombreCompania='" + nombreCompania + "'";
                MessageBox.Show(queryMax);
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_ClienteString = commandMax.ExecuteScalar().ToString();
                PK_Compania = Int32.Parse(PK_ClienteString);

                conexion.Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show("No se encontró la compañia solicitada " + ev);
            }

            return PK_Compania;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Pk_Compania = buscarPK_Compania(txtNombreCompania.Text);
            btnAgregar.Visible = false;
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            elminarCompania(txtNombreCompania.Text);
            sugerenciaCompania();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String nombreCompania;
            try
            {
                nombreCompania = txtNombreCompania.Text;
                int PK_Compania = ultimaCompania();

                insertarCompania(PK_Compania, nombreCompania);
                sugerenciaCompania();
                valoresDefaultBotones();
                limpiarText();
            }
            catch(Exception ev)
            {
                MessageBox.Show("Verifique la información " + ev);
            }

            
        }

        public void elminarCompania(String nombre)
        {
            string query;
            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                query = "DELETE FROM Companias WHERE NombreCompania='" +nombre+"'";
                MessageBox.Show(query);
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Compañia Eliminada");
                conexion.Close();

                valoresDefaultBotones();
                limpiarText();
               
                //PK_Poliza = 0;
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Eliminar el Compañia " + ev);
            }
        }

        public void insertarCompania(int PK_Compania, String nombre)
        {
            SQLiteCommand commandoInsert;
            // int PK_Agente;
            string query;


            try
            {

                //PK_Agente = ultimoAgente();
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                //MessageBox.Show("Cliente nuevo Agregado " + PK_Cliente);
                //query = "INSERT INTO Clientes VALUES(" + PK_Cliente + ",'" + nombre + "','" + RFC + "','" + fechaNacimiento + "','" + telefono + "','" + correoElectronico + "')";

                query = "INSERT INTO Companias VALUES(" + PK_Compania + ",'" + nombre + "')";


                commandoInsert = new SQLiteCommand(query, conexion);
                commandoInsert.ExecuteNonQuery();
                MessageBox.Show("Ha agregado una nueva compañia");
                conexion.Close();

                //PK_Cliente = 0;
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Agregar Compañia " + ev);
            }
        }


      public int ultimaCompania()
        {
            int PK_Compania = 0;
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                string queryMax = "SELECT max(PK_Compania) FROM Companias";
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_CompaniaString = commandMax.ExecuteScalar().ToString();
                PK_Compania = Int32.Parse(PK_CompaniaString);

                if (PK_Compania == -1)
                {
                    PK_Compania = 1;
                }
                else
                {
                    PK_Compania += 1;
                }
                conexion.Close();
            }
            catch { }

            return PK_Compania;
        }

        public void sugerenciaCompania()
        {
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;

            try
            {

                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");

                conexion.Open();
                command = new SQLiteCommand("Select NombreCompania From Companias", conexion);
                lectorDatos = command.ExecuteReader();
                txtNombreCompania.AutoCompleteCustomSource.Clear();
                while (lectorDatos.Read())
                {
                    txtNombreCompania.AutoCompleteCustomSource.Add(lectorDatos["NombreCompania"].ToString());
                }


                conexion.Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Cargar Agentes " + ev);
            }
        }

        private void txtNombreCompania_TextChanged(object sender, EventArgs e)
        {
            txtNombreCompania.CharacterCasing = CharacterCasing.Upper;
        }

        

        public void actualizarCompania(String nombreCompania)
        {
            

            SQLiteCommand commandoInsert;
            //int PK_Cliente;
            string query;

            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                query = "UPDATE Companias set NombreCompania='" + nombreCompania +"' WHERE PK_Compania=" + Pk_Compania;
                MessageBox.Show(query);
                commandoInsert = new SQLiteCommand(query, conexion);
                commandoInsert.ExecuteNonQuery();
                MessageBox.Show("Compañia Actualizada");
                limpiarText();
                valoresDefaultBotones();
                conexion.Close();

                //PK_Poliza = 0;
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Actualizar la Compañia " + ev);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actualizarCompania(txtNombreCompania.Text);
            sugerenciaCompania();
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            valoresDefaultBotones();
            limpiarText();
        }
    }
}
