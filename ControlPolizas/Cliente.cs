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
    public partial class Cliente : Form
    {
        //Direccion direccion;
        SQLiteConnection conexion;
        int PK_Cliente = 0;
        FrmIndex index;
        

        public void valoreDefaultBotones()
        {
            btnEliminar.Enabled = false;
            btnAgregarCliente.Enabled = true;
            btnCancelar.Enabled = true;
            //btnDireccion.Enabled = true;
            btnBuscar.Enabled = true;
            btnAgregarCliente.Visible = true;
        }
        public void limpiarTextBox()
        {
            txtNombreCliente.Text = "";
            txtRFC.Text = "";
            txtTelefono.Text = "";
            //txtDiaCumpleanios.Text = "";
            //txtAnioCumpleanios.Text = "";
            txtEmail.Text = "";
            txtCalleDireccion.Text = "";
            txtNumeroCalle.Text = "";
            txtColoniaDireccion.Text = "";
            txtEstadoDireccion.Text = "";
            txtMuniciopioDireccion.Text = "";
            txtCodigoPotalDireccion.Text = "";
        }



        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            sugerenciaClientes();

            //direccion = new Direccion();
            //limpiarComboBox();
            limpiarTextBox();
            valoreDefaultBotones();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
              
            this.Hide();
            //direccion.Dispose();
            
        }

        public void sugerenciaClientes()
        {
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;
            txtNombreCliente.AutoCompleteCustomSource.Clear();
            try
            {

                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");

                conexion.Open();
                command = new SQLiteCommand("Select Nombre From Clientes", conexion);
                lectorDatos = command.ExecuteReader();
                while (lectorDatos.Read())
                {
                    txtNombreCliente.AutoCompleteCustomSource.Add(lectorDatos["Nombre"].ToString());
                }


                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error al Cargar Clientes");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cumpleaños_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreCliente.Text != "") 
                {
                    buscarCliente(txtNombreCliente.Text);
                }
                else
                {
                    MessageBox.Show("Verifique el Cliente a buscar");
                }
            }
            catch(Exception ev)
            {
                MessageBox.Show("Verifique la información "+ ev);
            }

            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //direccion.getCliente(txtNombreCliente.Text);
            //direccion.ShowDialog();

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                String nombreCliente, RFC, fechaNacimiento, correoElectronico,telefono;
                String calle, numero, colonia, estado, municipio, codigoPostal;

                nombreCliente = txtNombreCliente.Text;
                RFC = txtRFC.Text;
                fechaNacimiento = dtpCumpleanios.Value.ToString("yyyy-MM-dd");
                telefono = txtTelefono.Text;
                correoElectronico = txtEmail.Text;

                calle=txtCalleDireccion.Text;
                numero=txtNumeroCalle.Text;
                colonia=txtColoniaDireccion.Text;
                estado=txtEstadoDireccion.Text;
                municipio=txtEstadoDireccion.Text;
                codigoPostal=txtCodigoPotalDireccion.Text;

                int pk_cliente = ultimoCliente();

                insertarCliente(pk_cliente, nombreCliente, RFC, fechaNacimiento, telefono, correoElectronico);
                insertarDireccionCliente(pk_cliente, calle, numero, colonia, estado, municipio, codigoPostal);
                
               
                limpiarTextBox();
                valoreDefaultBotones();
                sugerenciaClientes();
              
            }
            catch(Exception even)
            {
                MessageBox.Show("Verifique la información "+even);
            }

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //direccion.Dispose();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //limpiarComboBox();
            limpiarTextBox();
            valoreDefaultBotones();
        }

        public void eliminarCliente(int PK_Cliente)
        {
           // SQLiteCommand commandoInsert;
            //int PK_Cliente;
            string query;

            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                query = "DELETE FROM Clientes WHERE PK_Cliente=" + PK_Cliente;
                //MessageBox.Show(query);
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cliente Eliminado");
                conexion.Close();

                limpiarTextBox();
                valoreDefaultBotones();

                //PK_Poliza = 0;
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Eliminar el Cliente " + ev);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;

           DialogResult dialogResult = MessageBox.Show("¿Desea Eliminar el Cliente?, esto implica eliminar tambien todas las polizas pertenecientes a este cliente", "ATENCION!",botones, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                eliminarCliente(PK_Cliente);
                sugerenciaClientes();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
          

            //limpiarComboBox();
           
        }







        public void insertarCliente(int PK_Cliente,String nombre, String RFC, String fechaNacimiento, String telefono, String correoElectronico)
        {
            SQLiteCommand commandMax,commandoInsert;
            //int PK_Cliente;
            string query;
            

            try
            {

                //PK_Cliente = ultimoCliente();
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                //MessageBox.Show("Cliente nuevo Agregado " + PK_Cliente);
                //query = "INSERT INTO Clientes VALUES(" + PK_Cliente + ",'" + nombre + "','" + RFC + "','" + fechaNacimiento + "','" + telefono + "','" + correoElectronico + "')";

                query = "INSERT INTO Clientes VALUES(" + PK_Cliente + ",'" + nombre + "','" + RFC + "','" + fechaNacimiento + "','" + telefono + "','" + correoElectronico + "')";
               

                commandoInsert = new SQLiteCommand(query, conexion);
                commandoInsert.ExecuteNonQuery();
                MessageBox.Show("Cliente Agregado");
                conexion.Close();

                PK_Cliente = 0;
            }
            catch(Exception ev)
            {
                MessageBox.Show("Error al Agregar un Cliente "+ev);
            }
        }

        public int ultimoCliente()
        {
            
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                string queryMax = "SELECT max(PK_Cliente) FROM Clientes";
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_ClienteString = commandMax.ExecuteScalar().ToString();
                PK_Cliente = Int32.Parse(PK_ClienteString);

                if (PK_Cliente == -1)
                {
                    PK_Cliente = 1;
                }else
                {
                    PK_Cliente += 1;
                }
                conexion.Close();
            }
            catch { }

            return PK_Cliente;
        }

        public void buscarCliente(String nombre)
        {
            //int pk_Cliente=7;
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;
            String query = "SELECT PK_Cliente,Nombre,RFC,FechaNacimiento,Telefono,CorreoElectronico FROM Clientes WHERE Nombre='"+nombre+"'";
            try
            {


                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                command = new SQLiteCommand(query,conexion);
                lectorDatos = command.ExecuteReader();

                while (lectorDatos.Read())
                {
                    PK_Cliente = lectorDatos.GetInt16(0);
                    txtNombreCliente.Text = lectorDatos.GetString(1);
                    txtRFC.Text = lectorDatos.GetString(2);
                    txtTelefono.Text= lectorDatos.GetString(4);
                    txtEmail.Text= lectorDatos.GetString(5);
                    dtpCumpleanios.Value = lectorDatos.GetDateTime(3);
                }
                btnEliminar.Enabled = true;
                btnBuscar.Enabled = false;
                btnAgregarCliente.Visible = false;
                conexion.Close();
                buscarDireccionCliente(PK_Cliente);

            }catch(Exception ev)
            {
                MessageBox.Show("No se encontro el Cliente "+ev);
            }
        }

        public void insertarDireccionCliente(int PK_Cliente,String calle, String numero, String colonia, String estado, String municipio, String codigoPostal)
        {
            SQLiteCommand commandMax, commandoInsert;
            int PK_DireccionCliente;
            string query;


            try
            {

                PK_DireccionCliente = ultimaDireccion();
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                //MessageBox.Show("Cliente nuevo Agregado " + PK_Cliente);
                //query = "INSERT INTO Clientes VALUES(" + PK_Cliente + ",'" + nombre + "','" + RFC + "','" + fechaNacimiento + "','" + telefono + "','" + correoElectronico + "')";

                query = "INSERT INTO DireccionClientes VALUES("+PK_DireccionCliente +","+ PK_Cliente + ",'" + calle + "','" + numero + "','" + colonia + "','" + estado + "','" + municipio + "','" +codigoPostal + "')";


                commandoInsert = new SQLiteCommand(query, conexion);
                commandoInsert.ExecuteNonQuery();
                MessageBox.Show("Direccion de cliente Agregada");
                conexion.Close();

                //PK_Cliente = 0;
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Agregar Direccion del cliente " + ev);
            }
        }

        public int ultimaDireccion()
        {
            int PK_DireccionCliente = 0;
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                string queryMax = "SELECT max(PK_DireccionCliente) FROM DireccionClientes";
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_ClienteString = commandMax.ExecuteScalar().ToString();
                PK_DireccionCliente = Int32.Parse(PK_ClienteString);

                if (PK_DireccionCliente == -1)
                {
                    PK_DireccionCliente = 1;
                }
                else
                {
                    PK_DireccionCliente += 1;
                }
                conexion.Close();
            }
            catch { }

            return PK_DireccionCliente;
        }

        public void buscarDireccionCliente(int PK_Cliente)
        {
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;
            String query = "SELECT Calle,NumeroInterior,Colonia,Estado,Municipio,CodigoPostal FROM DireccionClientes WHERE FK_Cliente="+PK_Cliente;
            try
            {


                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                command = new SQLiteCommand(query, conexion);
                lectorDatos = command.ExecuteReader();

                while (lectorDatos.Read())
                {
                    txtCalleDireccion.Text = lectorDatos.GetString(0);
                    txtNumeroCalle.Text = lectorDatos.GetString(1);
                    txtColoniaDireccion.Text = lectorDatos.GetString(2);
                    txtEstadoDireccion.Text = lectorDatos.GetString(3);
                    txtMuniciopioDireccion.Text = lectorDatos.GetString(4);
                    txtCodigoPotalDireccion.Text = lectorDatos.GetInt32(5).ToString();
                }

                conexion.Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show("No se encontro el Cliente " + ev);
            }
        }

        public void actualizarCliente(int PK_Cliente, String nombre, String rfc, String fechaNacimiento, String telefono, String correo)
        {
            SQLiteCommand commandoInsert;
            //int PK_Cliente;
            string query;

            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                query = "UPDATE Clientes set Nombre='" + nombre + "',RFC='" + rfc + "',FechaNacimiento='" + fechaNacimiento + "',Telefono='" + telefono + "',CorreoElectronico='" + correo + "' WHERE PK_Cliente="+PK_Cliente;
                //MessageBox.Show(query);
                commandoInsert = new SQLiteCommand(query, conexion);
                commandoInsert.ExecuteNonQuery();
                MessageBox.Show("Cliente Actualizado");
                conexion.Close();

                //PK_Poliza = 0;
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Actualizar el Cliente " + ev);
            }
        }


        public void actualizarDireccionCliente(int PK_Direccion,int FK_Cliente, String calle, String numeroInterior, String colonia, String estado, String municipio,String codigoPostal)
        {
            SQLiteCommand commandoInsert;
            //int PK_Cliente;
            string query;

            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                query = "UPDATE DireccionClientes set Calle='" + calle + "',NumeroInterior='" + numeroInterior + "',Colonia='" + colonia+ "',Estado='" + estado + "',Municipio='" + municipio+ "',CodigoPostal='"+codigoPostal+"' WHERE FK_Cliente="+FK_Cliente+" AND PK_DireccionCliente="+PK_Direccion;
               // MessageBox.Show(query);
                commandoInsert = new SQLiteCommand(query, conexion);
                commandoInsert.ExecuteNonQuery();
                MessageBox.Show("Direccion Actualizada");
                conexion.Close();

                //PK_Poliza = 0;
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Actualizar el Cliente " + ev);
            }
        }


        public int buscarPK_Cliente(String NombreCliente)
        {
            int PK_Cliente = 0;
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                string queryMax = "SELECT PK_Cliente FROM Clientes WHERE Nombre='" + NombreCliente + "'";
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_ClienteString = commandMax.ExecuteScalar().ToString();
                PK_Cliente = Int32.Parse(PK_ClienteString);

                conexion.Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show("No se encontró el cliente solicitado " + ev);
            }

            return PK_Cliente;
        }

        public int buscarPK_DireccionCliente(int FK_Cliente)
        {
            int PK_DireccionCliente = 0;
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                string queryMax = "SELECT PK_DireccionCliente FROM DireccionClientes WHERE FK_Cliente=" + FK_Cliente;
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_DireccionClienteString = commandMax.ExecuteScalar().ToString();
                PK_DireccionCliente = Int32.Parse(PK_DireccionClienteString);

                conexion.Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show("No se encontró el cliente solicitado " + ev);
            }

            return PK_DireccionCliente;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtMuniciopioDireccion_TextChanged(object sender, EventArgs e)
        {
            txtMuniciopioDireccion.CharacterCasing = CharacterCasing.Upper;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //PK_Cliente = buscarPK_Cliente(txtNombreCliente.Text);
            //MessageBox.Show(PK_Cliente.ToString());
            int PK_DireccionCliente = buscarPK_DireccionCliente(PK_Cliente);

            String nombreCliente, RFC, fechaNacimiento, correoElectronico, telefono;
            String calle, numero, colonia, estado, municipio, codigoPostal;

            nombreCliente = txtNombreCliente.Text;
            RFC = txtRFC.Text;
            fechaNacimiento = dtpCumpleanios.Value.ToString("yyyy-MM-dd");
            telefono = txtTelefono.Text;
            correoElectronico = txtEmail.Text;

            calle = txtCalleDireccion.Text;
            numero = txtNumeroCalle.Text;
            colonia = txtColoniaDireccion.Text;
            estado = txtEstadoDireccion.Text;
            municipio = txtEstadoDireccion.Text;
            codigoPostal = txtCodigoPotalDireccion.Text;

            try
            {
                actualizarCliente(PK_Cliente, nombreCliente, RFC, fechaNacimiento, telefono, correoElectronico);
                actualizarDireccionCliente(PK_DireccionCliente, PK_Cliente, calle, numero, colonia, estado, municipio, codigoPostal);
                sugerenciaClientes();
                PK_Cliente = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Al Actualizar Cliente, verifique la informacion");
            }
            }

        private void txtCodigoPotalDireccion_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtRFC_TextChanged(object sender, EventArgs e)
        {
            txtRFC.CharacterCasing= CharacterCasing.Upper;
            //txtRFC.Text= String.Format("{0:0000-000000-000}", txtRFC.Text);
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            txtNombreCliente.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtCodigoPotalDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar)&&e.KeyChar!=(char)8; //permite digitar solo numeros y(char)8 es retroceso(borrar)
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCalleDireccion_TextChanged(object sender, EventArgs e)
        {
            txtCalleDireccion.CharacterCasing = CharacterCasing.Upper;

        }

        private void txtColoniaDireccion_TextChanged(object sender, EventArgs e)
        {
            txtColoniaDireccion.CharacterCasing = CharacterCasing.Upper;

        }

        private void txtNumeroCalle_TextChanged(object sender, EventArgs e)
        {
            txtNumeroCalle.CharacterCasing = CharacterCasing.Upper;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtEstadoDireccion_TextChanged(object sender, EventArgs e)
        {
            txtEstadoDireccion.CharacterCasing = CharacterCasing.Upper;

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
    }
}
