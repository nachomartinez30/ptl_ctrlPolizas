using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ControlPolizas
{
    public partial class Inicio_Sesion : Form
    {
        SQLiteConnection conexion;
        //int PK_Agente;
        //String passAgente;
        FrmIndex index;

        public Inicio_Sesion()
        {
            InitializeComponent();
        }

        

        private void Inicio_Sesion_Load(object sender, EventArgs e)
        {
            conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
            conexion.Open();

            MessageBox.Show("Bienvenido");

            String query = "Select Nombre from Agentes";

            SQLiteCommand comando = new SQLiteCommand(query, conexion);
            SQLiteDataReader lectordatos = comando.ExecuteReader();
            int i=0;
            if (lectordatos.HasRows)
            {
                
                while (lectordatos.Read())
                {
                    
                    cmbAgente.Items.Add(lectordatos.GetString(i));
                    
                }
                i++;
            }


            conexion.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String ContraseniaIngresada=txtContrasenia.Text;
            String ContraseniaBD="";

            conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
            conexion.Open();

            DataTable datosTabla = new DataTable();
            String query = "Select Contrasenia from Agentes where Nombre = '"+cmbAgente.SelectedItem+"'";

        
            

            SQLiteCommand comando = new SQLiteCommand(query, conexion);
            SQLiteDataReader lectordatos = comando.ExecuteReader();
            int i = 0;
            if (lectordatos.HasRows)
            {

                while (lectordatos.Read())
                {
                    
                    ContraseniaBD=lectordatos.GetString(0);

                }

            }


            conexion.Close();

            if (ContraseniaBD.Equals(ContraseniaIngresada)&&cmbAgente.SelectedItem!=null)
            {
                this.Dispose();
            }else
            {
                MessageBox.Show("Contraseña erronea, intente de nuevo");
            }
            

          
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
