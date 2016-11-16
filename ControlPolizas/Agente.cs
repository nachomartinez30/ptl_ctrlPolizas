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
    public partial class Agente : Form
    {
        SQLiteConnection conexion;
        public int PK_Agente = 0;

        public Agente()
        {
            InitializeComponent();
        }


        public int ultimoAgente()
        {
            
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                string queryMax = "SELECT max(PK_Agente) FROM Agentes";
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_AgenteString = commandMax.ExecuteScalar().ToString();
                PK_Agente = Int32.Parse(PK_AgenteString);

                if (PK_Agente == -1)
                {
                    PK_Agente = 1;
                }
                else
                {
                    PK_Agente += 1;
                }
                conexion.Close();
            }
            catch
            {

            }

            return PK_Agente;
        }

        public void insertarAgente(int PK_Agente,int numeroAgente, String nombre, String contrasenia)
        {
            SQLiteCommand  commandoInsert;
           // int PK_Agente;
            string query;


            try
            {

                //PK_Agente = ultimoAgente();
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                //MessageBox.Show("Cliente nuevo Agregado " + PK_Cliente);
                //query = "INSERT INTO Clientes VALUES(" + PK_Cliente + ",'" + nombre + "','" + RFC + "','" + fechaNacimiento + "','" + telefono + "','" + correoElectronico + "')";

                query = "INSERT INTO Agentes VALUES("+PK_Agente+ "," +numeroAgente + ",'" +nombre + "','" +contrasenia + "')";


                commandoInsert = new SQLiteCommand(query, conexion);
                commandoInsert.ExecuteNonQuery();
                MessageBox.Show("Ha creado Un Nuevo Agente");
                conexion.Close();

                //PK_Cliente = 0;
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Agregar Direccion del cliente " + ev);
            }
        }

        public void valoresDefaultBotones()
        {
            btnAgregarAgente.Enabled = true;
            btnBuscarAgente.Enabled = true;
            btnCancelar.Enabled = true;
            //btnEliminar.Enabled = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Agente_Load(object sender, EventArgs e)
        {
            sugerenciaAgentes();

            LimpiarText();
            valoresDefaultBotones();
        }

        public void sugerenciaAgentes()
        {
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;

            try
            {

                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");

                conexion.Open();
                command = new SQLiteCommand("Select Nombre From Agentes", conexion);
                lectorDatos = command.ExecuteReader();
                while (lectorDatos.Read())
                {
                    txtNombreAgente.AutoCompleteCustomSource.Add(lectorDatos["Nombre"].ToString());
                }


                conexion.Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Cargar Agentes " + ev);
            }
        }


        public void LimpiarText()
        {
            txtConfirmarContraseña.Text = "";
            txtContraseña.Text = "";
            txtNombreAgente.Text = "";
            txtNumeroAgente.Text = "";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarText();
            btnAgregarAgente.Enabled = true;
            btnBuscarAgente.Enabled = false;
        }



        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            String nombre,contrasenia="",contra1,contra2;
            int numeroAgente;

            try
            {
                nombre = txtNombreAgente.Text;
                numeroAgente = Int32.Parse(txtNumeroAgente.Text);
                PK_Agente = ultimoAgente();

                contra1 = txtContraseña.Text;
                contra2 = txtConfirmarContraseña.Text;

                if (contra1.Equals(contra2))
                {
                    contrasenia = txtContraseña.Text;
                    insertarAgente(PK_Agente, numeroAgente, nombre, contrasenia);
                    sugerenciaAgentes();

                    LimpiarText();
                    valoresDefaultBotones();
                }
                else
                {
                    MessageBox.Show("Las contraseñias no coinciden");
                }
                
                
            }
            catch(Exception ev)
            {
                MessageBox.Show("Verifique la información " + ev);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LimpiarText();
            valoresDefaultBotones();
            
        }

        private void btnBuscarAgente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreAgente.Text != "")
                {
                    buscarAgente(txtNombreAgente.Text);

                    //btnEliminar.Enabled = true;
                    btnAgregarAgente.Enabled = false;
                    btnBuscarAgente.Enabled = false;
                }
            }
            catch(Exception ev)
            {
                MessageBox.Show("Verifique la información " + ev);
            }
        }

        public void buscarAgente(String nombre)
        {
            //int pk_Agente = 7;
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;
            String query = "SELECT PK_Agente,NumeroAgente,Nombre,Contrasenia FROM Agentes WHERE Nombre='" + nombre + "'";
            try
            {


                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                command = new SQLiteCommand(query, conexion);
                lectorDatos = command.ExecuteReader();

                while (lectorDatos.Read())
                {
                    PK_Agente = lectorDatos.GetInt16(0);
                    txtNumeroAgente.Text = lectorDatos.GetInt16(1).ToString();
                    txtNombreAgente.Text = lectorDatos.GetString(2);
                    txtContraseña.Text = lectorDatos.GetString(3);
                    txtConfirmarContraseña.Text = lectorDatos.GetString(3);


                }

                conexion.Close();

            }
            catch (Exception ev)
            {
                MessageBox.Show("No se encontro el Cliente " + ev);
            }
        }





        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }
       
        public void actualizarAgente(int PK_Agente, int numeroAgente, String nombre,String contrasenia)
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

                query = "UPDATE  Agentes SET NumeroAgente="+ numeroAgente + ",Nombre='" + nombre + "',Contrasenia='" + contrasenia + "' WHERE PK_Agente="+PK_Agente;
                MessageBox.Show(query);

                commandoInsert = new SQLiteCommand(query, conexion);
                commandoInsert.ExecuteNonQuery();
                MessageBox.Show("Ha Actualizado Un Agente");
                conexion.Close();

                //PK_Cliente = 0;
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al modificar los datos del agente " + ev);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String nombre, contrasenia = "", contra1, contra2;
            int numeroAgente;

            try
            {
                nombre = txtNombreAgente.Text;
                numeroAgente = Int32.Parse(txtNumeroAgente.Text);
                //int PK_Agente = ultimoAgente();

                contra1 = txtContraseña.Text;
                contra2 = txtConfirmarContraseña.Text;

                if (contra1.Equals(contra2))
                {
                    contrasenia = txtContraseña.Text;
                    actualizarAgente(PK_Agente, numeroAgente, nombre, contrasenia);
                    sugerenciaAgentes();

                    //LimpiarText();
                    //valoresDefaultBotones();
                }
                else
                {
                    MessageBox.Show("Las contraseñias no coinciden");
                }


            }
            catch (Exception ev)
            {
            }
        }
    }
}
