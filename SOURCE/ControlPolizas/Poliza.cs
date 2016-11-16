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
    public partial class Poliza : Form
    {
        SQLiteConnection conexion;
        double IMPORTETOTAL = 0;
        public DateTime inicioVigenciaExportar;
        public int PK_Poliza;
        public float prima = 0, fraccionado = 0, derechoPoliza = 0, iva = 0;

        public Recibos recibos;

        public Poliza()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void sugerenciaClientes()
        {
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;

            try
            {

                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");

                conexion.Open();
                command = new SQLiteCommand("Select Nombre From Clientes", conexion);
                lectorDatos = command.ExecuteReader();
                while (lectorDatos.Read())
                {
                    txtCliente.AutoCompleteCustomSource.Add(lectorDatos["Nombre"].ToString());
                }


                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error al Cargar Clientes");
            }
        }


        public void fillCmboxAgentes()
        {
            cmbAgente.Items.Clear();
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
                    cmbAgente.Items.Add(lectorDatos["Nombre"]);
                }


                conexion.Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Cargar Agentes " + ev);
            }
        }

        public void fillCmboxCompania()
        {
            cmbCompania.Items.Clear();
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;

            try
            {

                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");

                conexion.Open();
                command = new SQLiteCommand("Select NombreCompania From Companias", conexion);
                lectorDatos = command.ExecuteReader();
                while (lectorDatos.Read())
                {
                    cmbCompania.Items.Add(lectorDatos["NombreCompania"]);
                }


                conexion.Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Cargar Compañias " + ev);
            }
        }


        public void sugerenciaNumeroPoliza()
        {
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;
            txtNumeroPoliza.AutoCompleteCustomSource.Clear();
            try
            {

                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");

                conexion.Open();
                command = new SQLiteCommand("Select NumeroPoliza From Polizas", conexion);
                lectorDatos = command.ExecuteReader();
                while (lectorDatos.Read())
                {
                    txtNumeroPoliza.AutoCompleteCustomSource.Add(lectorDatos["NumeroPoliza"].ToString());
                }


                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error al Cargar Polizas");
            }
        }


        public void buscarPoliza(String numeroPoliza,String fechaInicio, String fechaFin)
        {
            PK_Poliza = 7;
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;
             try
            {
                String query = "SELECT p.PK_Poliza, p.NumeroPoliza,p.Nueva,c.Nombre,tp.TipoPoliza,co.NombreCompania, p.NumeroRenovacion,p.FrecuenciaDePago,p.InicioVigencia,p.FinVigencia,p.Adjunto,a.Nombre,p.Version,p.PrimaNeta,p.RecargoPagoFraccionado,p.DerechoPoliza,p.IVA,p.ImporteTotal FROM Polizas p, TipoPolizas tp, Clientes c, Agentes a,Companias co  WHERE p.NumeroPoliza='" + numeroPoliza + "' and tp.PK_TipoPoliza=p.FK_TipoPoliza and p.FK_Cliente=c.PK_Cliente and co.PK_Compania=p.FK_Compania and a.PK_Agente=p.FK_Agente AND p.InicioVigencia='" + fechaInicio + "' AND FinVigencia='" + fechaFin + "'";

                //Console.WriteLine(query);
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                command = new SQLiteCommand(query, conexion);
                lectorDatos = command.ExecuteReader();

                while (lectorDatos.Read())
                {
                    PK_Poliza = lectorDatos.GetInt16(0);
                    //MessageBox.Show(PK_Poliza.ToString());
                    txtNumeroPoliza.Text = lectorDatos.GetString(1);
                    String nueva = lectorDatos.GetString(2);
                    if (nueva.Equals("True"))
                    {
                        chkboxNueva.Checked = true;
                    }
                    else
                    {
                        chkboxNueva.Checked = false;
                    }
                    txtCliente.Text = lectorDatos.GetString(3);
                    cmbRamo.SelectedItem = lectorDatos.GetString(4);
                    cmbCompania.SelectedItem = lectorDatos.GetString(5);
                    txtNumeroRenovacion.Text = lectorDatos.GetString(6);
                    int frecPago = lectorDatos.GetInt16(7);

                    switch(frecPago){
                        case 0:
                            cmbFrecuenciaPago.SelectedIndex = 0;//Mensual
                            break;
                        case 1:
                            cmbFrecuenciaPago.SelectedIndex = 1;//Trimestral
                            break;
                        case 2:
                            cmbFrecuenciaPago.SelectedIndex = 2;//Semestral
                            break;
                        case 3:
                            cmbFrecuenciaPago.SelectedIndex = 3;//Anual
                            break;
                    }

                    dtpInicioVigencia.Value = lectorDatos.GetDateTime(8);
                    dtpFinVigencia.Value = lectorDatos.GetDateTime(9);
                    
                    txtAdjunto.Text = lectorDatos.GetString(10);
                    cmbAgente.SelectedItem = lectorDatos.GetString(11);
                    txtVersion.Text = lectorDatos.GetString(12);
                    txtPrima.Text = lectorDatos.GetDouble(13).ToString();
                    txtFraccionado.Text = lectorDatos.GetDouble(14).ToString();
                    txtDerechoPoliza.Text = lectorDatos.GetDouble(15).ToString();
                    txtIVA.Text = lectorDatos.GetDouble(16).ToString();
                    txtImporte.Text = lectorDatos.GetDouble(17).ToString();
                    btnRevisarRecibos.Enabled = true;
                }


                conexion.Close();

                if (txtCliente.Text.Equals(""))
                {
                    MessageBox.Show("Verifique la informacion");
                    dtpInicioVigencia.Focus();
                }
                else
                {
                    btnEliminar.Enabled = true;
                    btnAgregar.Enabled = false;
                    btnAgregar.Visible = false;
                    btnBusca.Enabled = false;
                   
                    //btnGenerarRecibos.Enabled = false;
                }

            }
            catch (Exception ev)
            {
                MessageBox.Show("No se encontro la Póliza " + ev);
            }
        }


        private void Poliza_Load(object sender, EventArgs e)
        {
            //DateTime esteDia = new DateTime();

            PK_Poliza = ultimaPoliza();
            sugerenciaNumeroPoliza();
            sugerenciaClientes();
            fillCmboxAgentes();
            fillCmboxCompania();
            dtpFinVigencia.Value= DateTime.Today.AddYears(1);

            limpiarComboBox();
            LimpiarTextBox();
            ValoresBotonesDefault();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivos PDF (.pdf)|*.pdf|All Files (*.*)|*.*";
            file.FilterIndex = 1;
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                txtAdjunto.Text = path;
            }

        }

        public int numeroDeRecibos(int PK_Poliza,DateTime inicioVigencia)
        {
            int numRecibos=0;   
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                string queryMax = "SELECT count(PK_RecibosPoliza) FROM RecibosPoliza WHERE FK_Poliza="+PK_Poliza+" AND InicioVigencia BETWEEN '"+ inicioVigencia.ToString("yyyy-MM-dd") + "' AND '"+inicioVigencia.AddYears(1).ToString("yyyy-MM-dd") + "'";
                //MessageBox.Show(queryMax);
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_PolizaString = commandMax.ExecuteScalar().ToString();
                numRecibos = Int32.Parse(PK_PolizaString);

                conexion.Close();
            }
            catch
            {


            }
            return numRecibos;
        }

        private void btcBusca_Click(object sender, EventArgs e)
        {
            if (txtNumeroPoliza.Text.Equals(""))
            {
                MessageBox.Show("Agregue un numero de póliza para buscar");
                txtNumeroPoliza.Focus();
            }
            else
            {
                //MessageBox.Show(PK_Poliza.ToString());
                inicioVigenciaExportar = dtpInicioVigencia.Value;
                
                buscarPoliza(txtNumeroPoliza.Text, dtpInicioVigencia.Value.Date.ToString("yyyy-MM-dd"), dtpFinVigencia.Value.Date.ToString("yyyy-MM-dd"));
                txtNumeroRecibos.Text= numeroDeRecibos(PK_Poliza, dtpInicioVigencia.Value).ToString();
                btnRevisarRecibos.Enabled = true;
            }
            
           
        }

        public void ValoresBotonesDefault()
        {
            btnEliminar.Enabled = false;
            btnAdjuntoPoliza.Enabled = true;
            btnAgregar.Enabled = true;
            btnAgregar.Visible = true;
            btnCancelar.Enabled = true;
            btnBusca.Enabled = true;
            btnRevisarRecibos.Enabled = false;
            chkboxPagarPrimer.Enabled = true;
            
        }
        public void LimpiarTextBox()
        {
            txtNumeroPoliza.Text = "";
            txtCliente.Text = "";
            txtNumeroRenovacion.Text = "";
            txtPrima.Text = "";
            txtFraccionado.Text = "";
            txtDerechoPoliza.Text = "";
            txtIVA.Text = "";
            txtImporte.Text = "";
            txtAdjunto.Text = "";
            txtVersion.Text = "";
            IMPORTETOTAL = 0;
            chkboxNueva.Checked = true;
            txtNumeroRecibos.Text = "";
            prima = 0;
            fraccionado = 0;
            derechoPoliza = 0;
            iva = 0;


            
        }

        public void limpiarComboBox()
        {
            cmbRamo.SelectedItem=null;
            cmbCompania.SelectedItem=null;
            cmbAgente.SelectedItem = null;
            cmbFrecuenciaPago.SelectedItem = null;
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarComboBox();
            LimpiarTextBox();
            ValoresBotonesDefault();
        }

        public void eliminarPoliza(int PK_Poliza)
        {
            // SQLiteCommand commandoInsert;
            //int PK_Cliente;
            string query;

            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                query = "DELETE FROM Polizas WHERE PK_Poliza=" + PK_Poliza;
                //MessageBox.Show(query);
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Poliza Eliminada");
                conexion.Close();

                limpiarComboBox();
                LimpiarTextBox();
                ValoresBotonesDefault();

                //PK_Poliza = 0;
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Eliminar la Póliza " + ev);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;

            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar la póliza?, esto implica ELIMINAR tambien TODOS los RECIBOS pertenecientes a esta Poliza", "ATENCION!", botones, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                eliminarPoliza(PK_Poliza);
                sugerenciaNumeroPoliza();
            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }

        public int ultimaPoliza()
        {
            int PK_Poliza = 0;
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                string queryMax = "SELECT max(PK_Poliza) FROM Polizas";
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_PolizaString = commandMax.ExecuteScalar().ToString();
                PK_Poliza = Int32.Parse(PK_PolizaString);

                if (PK_Poliza == -1)
                {
                    PK_Poliza = 1;
                }
                else
                {
                    PK_Poliza += 1;
                }
                conexion.Close();
            }
            catch {


            }

            return PK_Poliza;
        }

        public int buscarFK_Cliente(String NombreCliente)
        {
            int PK_Cliente=0;
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                string queryMax = "SELECT PK_Cliente FROM Clientes WHERE Nombre='"+NombreCliente+"'";
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_ClienteString = commandMax.ExecuteScalar().ToString();
                PK_Cliente = Int32.Parse(PK_ClienteString);

                conexion.Close();
            }
            catch(Exception ev)
            {
                MessageBox.Show("No se encontró el cliente solicitado "+ev);
            }

            return PK_Cliente;
        }


        public bool buscarPolizaRepetida(String numeroPoliza, bool nueva, int FK_Cliente, int FK_TipoPoliza, int FK_Compania, String numeroRenovacion, int frecuenciaPago, String fechaInicio, String fechaFin, int FK_Agente, String version, float primaNeta, float recargoPagoFraccionado, float derechoPoliza, float IVA, float importeTotal, String adjunto)
        {
            bool existente=false;
            int PK_Poliza = 0;
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                string queryMax = "SELECT PK_Poliza FROM Polizas WHERE NumeroPoliza='"+numeroPoliza+"' AND Nueva='"+nueva+"' AND FK_Cliente="+FK_Cliente+" and FK_TipoPoliza="+FK_TipoPoliza+" and FK_Compania="+FK_Compania+" and NumeroRenovacion='"+numeroRenovacion+"' and FrecuenciaDePago="+frecuenciaPago+" and InicioVigencia='"+fechaInicio+"' and FinVigencia='"+fechaFin+"' and FK_Agente="+FK_Agente+" and Version='"+version+"' and PrimaNeta="+primaNeta+" and RecargoPagoFraccionado="+recargoPagoFraccionado+" and DerechoPoliza="+derechoPoliza+" and IVA="+IVA+" and ImporteTotal="+importeTotal;
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_TipoPolizaString = commandMax.ExecuteScalar().ToString();
                PK_Poliza = Int32.Parse(PK_TipoPolizaString);
                if (PK_Poliza != null)
                {
                    existente= true;//Si hay una igual
                }
                else
                {
                    existente = false;
                }

                conexion.Close();
            }
            catch (Exception ev)
            {
                //MessageBox.Show("No se encontró el tipo de póliza " + ev);
            }

            return existente;
        }


        public int buscarFK_TipoPoliza(String TipoPoliza)
        {
            int PK_TipoPoliza = 0;
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                string queryMax = "SELECT PK_TipoPoliza FROM TipoPolizas WHERE TipoPoliza='" + TipoPoliza + "'";
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_TipoPolizaString = commandMax.ExecuteScalar().ToString();
                PK_TipoPoliza = Int32.Parse(PK_TipoPolizaString);

                conexion.Close();
            }
            catch(Exception ev)
            {
                MessageBox.Show("No se encontró el tipo de póliza " + ev);
            }

            return PK_TipoPoliza;
        }



        public int buscarFK_Compania(String NombreCompania)
        {
            int PK_Compania = 0;
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                string queryMax = "SELECT PK_Compania FROM Companias WHERE NombreCompania='" + NombreCompania + "'";
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_CompaniaString = commandMax.ExecuteScalar().ToString();
                PK_Compania = Int32.Parse(PK_CompaniaString);

                conexion.Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show("No se encontró la compañía " + ev);
            }

            return PK_Compania;
        }

        public int frecuenciaDePago(int Frecuencia)
        {
            int frecuenciaDePago = 4;

            switch (Frecuencia)
            {
                case 0:
                    frecuenciaDePago = 0;
                    break;
                case 1:
                    frecuenciaDePago = 1;
                    break;
                case 2:
                    frecuenciaDePago = 2;
                    break;
                case 3:
                    frecuenciaDePago = 3;
                    break;
                default:
                    MessageBox.Show("error al detectar frecuencia de pago");
                    break;
            }

            return frecuenciaDePago;
        }

        public int buscarFK_Agente(String Nombre)
        {
            int PK_Agente = 0;
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                string queryMax = "SELECT PK_Agente FROM Agentes WHERE Nombre='" + Nombre + "'";
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_AgenteString = commandMax.ExecuteScalar().ToString();
                PK_Agente = Int32.Parse(PK_AgenteString);

                conexion.Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show("No se encontró Agente " + ev);
            }

            return PK_Agente;
        }

        public void insertarPoliza(int PK_Poliza,String numeroPoliza,bool nueva,int FK_Cliente,int FK_TipoPoliza,int FK_Compania,String numeroRenovacion,int frecuenciaPago,String fechaInicio, String fechaFin,int FK_Agente,String version,float primaNeta,float recargoPagoFraccionado,float derechoPoliza,float IVA, float importeTotal,String adjunto)
        {
            SQLiteCommand commandoInsert;
            string query;

            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                
                query = "INSERT INTO Polizas VALUES("+PK_Poliza + ",'"+numeroPoliza + "','"+nueva + "',"+FK_Cliente + ","+FK_TipoPoliza + ","+FK_Compania + ",'"+numeroRenovacion + "',"+frecuenciaPago + ",'"+fechaInicio + "','"+fechaFin + "','"+adjunto+ "'," +FK_Agente + ",'"+version + "',"+primaNeta + ","+recargoPagoFraccionado + ","+derechoPoliza + ","+IVA + ","+importeTotal+")";

               // MessageBox.Show(query);
                commandoInsert = new SQLiteCommand(query, conexion);
                commandoInsert.ExecuteNonQuery();
                MessageBox.Show("Póliza Agregada");
                conexion.Close();

                PK_Poliza = 0;
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Agregar una Póliza " + ev);
            }
        }


        public void actualizarPolizas(String numeroPoliza, bool nueva, int FK_Cliente, int FK_TipoPoliza, int FK_Compania, String numeroRenovacion, int frecuenciaPago, String fechaInicio, String fechaFin, int FK_Agente, String version, float primaNeta, float recargoPagoFraccionado, float derechoPoliza, float IVA, float importeTotal, String adjunto)
        {
            SQLiteCommand commandoInsert;
            //int PK_Cliente;
            string query;

            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                query ="UPDATE Polizas set NumeroPoliza='" + numeroPoliza + "',Nueva='" + nueva + "',FK_Cliente=" + FK_Cliente + ",FK_TipoPoliza=" + FK_TipoPoliza + ",FK_Compania=" + FK_Compania + ",numeroRenovacion='" + numeroRenovacion + "',FrecuenciaDePago=" + frecuenciaPago + ",InicioVigencia='" + fechaInicio + "',FinVigencia='" + fechaFin + "',Adjunto='" + adjunto + "',FK_Agente=" + FK_Agente + ",Version='" + version + "',PrimaNeta=" + primaNeta + ",RecargoPagoFraccionado=" + recargoPagoFraccionado + ",DerechoPoliza=" + derechoPoliza + ",IVA=" + IVA + ",ImporteTotal=" + importeTotal + " WHERE NumeroPoliza='"+numeroPoliza+"' AND InicioVigencia='"+fechaInicio + "' AND FinVigencia='" + fechaFin + "'";
                //MessageBox.Show(query);
                commandoInsert = new SQLiteCommand(query, conexion);
                commandoInsert.ExecuteNonQuery();
                MessageBox.Show("Póliza Actualizada");
                conexion.Close();

                //PK_Poliza = 0;
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Actualizar la Póliza " + ev);
            }
        }

        /*public void eliminarPoliza(String numeroPoliza, String fechaInicio, String fechaFinal)
        {
            int pk_Poliza = 7;
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;
            String query = "SELECT p.PK_Poliza, p.NumeroPoliza,p.Nueva,c.Nombre,tp.TipoPoliza,co.NombreCompania, p.NumeroRenovacion,p.FrecuenciaDePago,p.InicioVigencia,p.FinVigencia,p.Adjunto,a.Nombre,p.Version,p.PrimaNeta,p.RecargoPagoFraccionado,p.DerechoPoliza,p.IVA,p.ImporteTotal FROM Polizas p, TipoPolizas tp, Clientes c, Agentes a,Companias co  WHERE p.NumeroPoliza='" + numeroPoliza + "' and tp.PK_TipoPoliza=p.FK_TipoPoliza and p.FK_Cliente=c.PK_Cliente and co.PK_Compania=p.FK_Compania and a.PK_Agente=p.FK_Agente";
            try
            {


                conexion = new SQLiteConnection("Data Source=C:\\Users\\Nacho Martinez\\Desktop\\Zerebro\\Control Polizas\\BaseDatos\\ControlPolizas.db;Version=3");
                conexion.Open();
                command = new SQLiteCommand(query, conexion);
            }
            catch
            {

            }
            */

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNumeroPoliza.Text.Equals(""))
            {
                MessageBox.Show("Agregue un numero de poliza porfavor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumeroPoliza.Focus();
            }
            else
            {
                if (txtCliente.Text.Equals(""))
                {
                    MessageBox.Show("Agregue un Cliente porfavor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCliente.Focus();
                }
                else
                {
                    try
                    {
                        bool nueva;
                        int FK_Cliente, FK_TipoPoliza, FK_Compania, frecuenciaPago, FK_Agente;
                        float primaNeta, recargoPagoFraccionado, derechoPoliza, IVA, importeTotal;
                        String numeroPoliza, numeroRenovacion, adjunto = "", version, fechaInicio, fechaFin;

                        PK_Poliza = ultimaPoliza();
                        numeroPoliza = txtNumeroPoliza.Text;
                        nueva = chkboxNueva.Checked;
                        FK_Cliente = buscarFK_Cliente(txtCliente.Text);
                        FK_TipoPoliza = buscarFK_TipoPoliza(cmbRamo.SelectedItem.ToString());
                        FK_Compania = buscarFK_Compania(cmbCompania.SelectedItem.ToString());
                        numeroRenovacion = txtNumeroRenovacion.Text;
                        frecuenciaPago = frecuenciaDePago(cmbFrecuenciaPago.SelectedIndex);
                        fechaInicio = dtpInicioVigencia.Value.Date.ToString("yyyy-MM-dd");
                        fechaFin = dtpFinVigencia.Value.Date.ToString("yyyy-MM-dd");
                        primaNeta = float.Parse(txtPrima.Text);
                        recargoPagoFraccionado = float.Parse(txtFraccionado.Text);
                        derechoPoliza = float.Parse(txtDerechoPoliza.Text);
                        IVA = float.Parse(txtIVA.Text);
                        importeTotal = float.Parse(txtImporte.Text);
                        FK_Agente = buscarFK_Agente(cmbAgente.SelectedItem.ToString());
                        version = txtVersion.Text;
                        adjunto = txtAdjunto.Text;

                        bool existe = buscarPolizaRepetida(numeroPoliza, nueva, FK_Cliente, FK_TipoPoliza, FK_Compania, numeroRenovacion, frecuenciaPago, fechaInicio, fechaFin, FK_Agente, version, primaNeta, recargoPagoFraccionado, derechoPoliza, IVA, importeTotal, adjunto);
                        if (existe == true)
                        {
                            MessageBox.Show("La poliza ya existe");
                        }
                        else
                        {
                            insertarPoliza(PK_Poliza, numeroPoliza, nueva, FK_Cliente, FK_TipoPoliza, FK_Compania, numeroRenovacion, frecuenciaPago, fechaInicio, fechaFin, FK_Agente, version, primaNeta, recargoPagoFraccionado, derechoPoliza, IVA, importeTotal, adjunto);

                            try
                            {
                                float iva;
                                double monto, prima = 0;
                                DateTime inicioVigenciaPoliza, inicioVigencia, finVigenciaPoliza, finVigencia, fechaPago;
                                int PK_Recibo;
                                bool pagoFraccionado = false;

                                primaNeta = float.Parse(txtPrima.Text);
                                recargoPagoFraccionado = float.Parse(txtFraccionado.Text);
                                derechoPoliza = float.Parse(txtDerechoPoliza.Text);
                                iva = float.Parse(txtIVA.Text);
                                importeTotal = float.Parse(txtImporte.Text);

                                inicioVigencia = dtpInicioVigencia.Value;
                                inicioVigenciaPoliza = dtpInicioVigencia.Value;
                                finVigenciaPoliza = dtpFinVigencia.Value;
                                finVigencia = dtpFinVigencia.Value;


                                ///////////////////////////////////////////////////Generar Recibos//////////////////////////////////////////////// 
                                PK_Recibo = ultimoRecibo();
                                //PK_Poliza = ultimaPoliza();
                                //MessageBox.Show("MAX RECIBO=" + PK_Recibo + "PKPOLIZA=" + PK_Poliza);

                                //MessageBox.Show(cmbFrecuenciaPago.SelectedIndex.ToString());
                                switch (cmbFrecuenciaPago.SelectedIndex)
                                {
                                    case 0://Mensual
                                        prima = primaNeta / 12;
                                        frecuenciaPago = 12;
                                        pagoFraccionado = chkboxPagarPrimer.Checked;
                                        generarRecibosBaseDatos(pagoFraccionado, frecuenciaPago, PK_Recibo, primaNeta, recargoPagoFraccionado, derechoPoliza, iva, importeTotal, inicioVigenciaPoliza, inicioVigencia, finVigenciaPoliza, finVigencia, fechaPago = finVigencia, PK_Poliza);
                                        break;
                                    case 1://Trimestral
                                        prima = primaNeta / 4;
                                        frecuenciaPago = 4;
                                        pagoFraccionado = chkboxPagarPrimer.Checked;
                                        generarRecibosBaseDatos(pagoFraccionado, frecuenciaPago, PK_Recibo, primaNeta, recargoPagoFraccionado, derechoPoliza, iva, importeTotal, inicioVigenciaPoliza, inicioVigencia, finVigenciaPoliza, finVigencia, fechaPago = finVigencia, PK_Poliza);
                                        break;
                                    case 2://Semestral
                                        prima = primaNeta / 2;
                                        frecuenciaPago = 2;
                                        pagoFraccionado = chkboxPagarPrimer.Checked;
                                        generarRecibosBaseDatos(pagoFraccionado, frecuenciaPago, PK_Recibo, primaNeta, recargoPagoFraccionado, derechoPoliza, iva, importeTotal, inicioVigenciaPoliza, inicioVigencia, finVigenciaPoliza, finVigencia, fechaPago = finVigencia, PK_Poliza);
                                        break;
                                    case 3://Anual
                                        try
                                        {
                                            prima = primaNeta;
                                            generarRecibosBaseDatos(pagoFraccionado, frecuenciaPago, PK_Recibo, primaNeta, recargoPagoFraccionado, derechoPoliza, iva, importeTotal, inicioVigenciaPoliza, inicioVigencia, finVigenciaPoliza, finVigencia, fechaPago = finVigencia, PK_Poliza);
                                            //MessageBox.Show("Se ha creado 1 recibo "+frecuenciaPago.ToString());
                                        }
                                        catch (Exception ev)
                                        {
                                            MessageBox.Show("Ocurrio un error" + ev);
                                        }

                                        break;
                                }

                                //btnRevisarRecibos.Enabled = true;
                                //recibos.Show();

                            }
                            catch (Exception ev)
                            {
                                MessageBox.Show("Ocurrio un error al crear los recibos");
                            }

                            ///////////////////////////////////////////////////Generar Recibos//////////////////////////////////////////////// 



                            sugerenciaNumeroPoliza();
                            sugerenciaClientes();
                            //fillCmboxAgentes();
                            //fillCmboxCompania();
                            //limpiarComboBox();
                            //LimpiarTextBox();
                            //ValoresBotonesDefault();
                            btnRevisarRecibos.Enabled = true;
                            btnAgregar.Visible = false;
                        }
                    }
                    catch (Exception ev)
                    {
                        MessageBox.Show("Verifique la información " + ev);
                    }

                }
            }
           
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtIVA_TextChanged(object sender, EventArgs e)
        {
            if (txtIVA.Equals(""))
            {

            }
            else
            {
                try
                {
                    iva = float.Parse(txtIVA.Text);

                    sumarImporte();
                }
                catch
                {

                }
                }
            
        }

        private void txtDerechoPolizaChanged(object sender, EventArgs e)
        {
            if (txtDerechoPoliza.Equals(""))
            {

            }
            else
            {
                try
                {
                        derechoPoliza = float.Parse(txtDerechoPoliza.Text);

                         sumarImporte();
                }
                catch
                {

                }
                    
            }
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)46; //permite digitar solo numeros y(char)8 es retroceso(borrar)

        }

        private void txtNumeroPoliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                chkboxNueva.Focus();
            }

            }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbRamo.Focus();
            }
        }

        private void chkboxNueva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCliente.Focus();
            }
        }

        private void cmbRamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbCompania.Focus();
            }
        }

        private void cmbCompania_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNumeroRenovacion.Focus();
            }
        }

        private void cmbFrecuenciaPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dtpInicioVigencia.Focus();
            }
        }

        private void txtNumeroRenovacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbFrecuenciaPago.Focus();
            }
        }

        private void dtpInicioVigencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dtpFinVigencia.Focus();
            }
        }

        private void dtpFinVigencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrima.Focus();
            }
        }

        private void txtPrima_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)46; //permite digitar solo numeros y(char)8 es retroceso(borrar)
        }

        private void txtFraccionado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)46; //permite digitar solo numeros y(char)8 es retroceso(borrar)

        }

        private void txtDerechoPoliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)46; //permite digitar solo numeros y(char)8 es retroceso(borrar)

        }

        private void cmbAgente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtVersion.Focus();
            }
        }

        private void txtVersion_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtVersion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAgregar.Focus();
            }
        }

        public void sumarImporte()
        {

            try
            {
                /*double prima, fraccionado, derechoPoliza, iva;

                prima = double.Parse(txtPrima.Text);
                fraccionado = double.Parse(txtFraccionado.Text);
                derechoPoliza = double.Parse(txtDerechoPoliza.Text);
                iva = double.Parse(txtIVA.Text);*/

                //float prima, fraccionado, derechoPoliza, iva;

               


                IMPORTETOTAL = prima + fraccionado + derechoPoliza + iva;
                txtImporte.Text = IMPORTETOTAL.ToString();
            }catch(Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }
           }


        private void txtPrima_TextChanged(object sender, EventArgs e)
        {
            
            if (txtPrima.Equals(""))
            {

            }
            else
            {
                try
                {
                    prima = float.Parse(txtPrima.Text);
                    sumarImporte();
                }
                catch
                {

                }
                 
               
            }
            
        }

        private void txtFraccionado_TextChanged(object sender, EventArgs e)
        {

            if (txtFraccionado.Equals(""))
            {

            }
            else
            {
                try
                {
                    fraccionado = float.Parse(txtFraccionado.Text);

                    sumarImporte();
                }
                catch
                {

                }
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool nueva;
                int PK_Poliza, FK_Cliente, FK_TipoPoliza, FK_Compania, frecuenciaPago, FK_Agente;
                float primaNeta, recargoPagoFraccionado, derechoPoliza, IVA, importeTotal;
                String numeroPoliza, numeroRenovacion, adjunto = "", version, fechaInicio, fechaFin;

                //PK_Poliza = ultimaPoliza();
                numeroPoliza = txtNumeroPoliza.Text;
                nueva = chkboxNueva.Checked;
                FK_Cliente = buscarFK_Cliente(txtCliente.Text);
                FK_TipoPoliza = buscarFK_TipoPoliza(cmbRamo.SelectedItem.ToString());
                FK_Compania = buscarFK_Compania(cmbCompania.SelectedItem.ToString());
                numeroRenovacion = txtNumeroRenovacion.Text;
                frecuenciaPago = frecuenciaDePago(cmbFrecuenciaPago.SelectedIndex);
                fechaInicio = dtpInicioVigencia.Value.Date.ToString("yyyy-MM-dd");
                fechaFin = dtpFinVigencia.Value.Date.ToString("yyyy-MM-dd");
                primaNeta = float.Parse(txtPrima.Text);
                recargoPagoFraccionado = float.Parse(txtFraccionado.Text);
                derechoPoliza = float.Parse(txtDerechoPoliza.Text);
                IVA = float.Parse(txtIVA.Text);
                importeTotal = float.Parse(txtImporte.Text);
                FK_Agente = buscarFK_Agente(cmbAgente.SelectedItem.ToString());
                version = txtVersion.Text;
                adjunto = txtAdjunto.Text;

                //insertarPoliza(PK_Poliza, numeroPoliza, nueva, FK_Cliente, FK_TipoPoliza, FK_Compania, numeroRenovacion, frecuenciaPago, fechaInicio, fechaFin, FK_Agente, version, primaNeta, recargoPagoFraccionado, derechoPoliza, IVA, importeTotal, adjunto);
                actualizarPolizas(numeroPoliza, nueva, FK_Cliente, FK_TipoPoliza, FK_Compania, numeroRenovacion, frecuenciaPago, fechaInicio, fechaFin, FK_Agente, version, primaNeta, recargoPagoFraccionado, derechoPoliza, IVA, importeTotal, adjunto);


                sugerenciaNumeroPoliza();
                sugerenciaClientes();
                fillCmboxAgentes();
                fillCmboxCompania();
                limpiarComboBox();
                LimpiarTextBox();
                ValoresBotonesDefault();

            }
            catch (Exception ev)
            {
                MessageBox.Show("Verifique la información " + ev);
            }

        }

        private void cmbFrecuenciaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void chkboxNueva_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxNueva.Checked == true)
            {
                txtNumeroRenovacion.Enabled = false;
            }
            if(chkboxNueva.Checked == false)
            {
                txtNumeroRenovacion.Enabled = true;
            }
        }

        public void generarRecibos(int PK_Recibo,int FK_Poliza,String inicioVigencia, String finVigencia,String fechaPago, bool estado, double monto,double prima)
        {
            SQLiteCommand commandoInsert;
            fechaPago = finVigencia;
            string query;
            try
            {

                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                query = "INSERT INTO RecibosPoliza VALUES(" + PK_Recibo + "," + FK_Poliza + ",'" + inicioVigencia + "','" + finVigencia +"','"+ estado + "'," + monto + ","+prima + ",'" +fechaPago+ "')";
                //MessageBox.Show(query + " linea 979");
                commandoInsert = new SQLiteCommand(query, conexion);
                commandoInsert.ExecuteNonQuery();
                
                conexion.Close();

                //PK_Cliente = 0;
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Agregar Recibos de la póliza " + ev);
            }
        }

        public int ultimoRecibo()
        {
            int PK_Recibo = 0;
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                string queryMax = "SELECT max(PK_RecibosPoliza) FROM RecibosPoliza";
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_ReciboString = commandMax.ExecuteScalar().ToString();
                PK_Recibo = Int32.Parse(PK_ReciboString);

                if (PK_Recibo == -1)
                {
                    PK_Recibo = 1;
                }
                else
                {
                    PK_Recibo += 1;
                }
                conexion.Close();
            }
            catch
            {

            }
            return PK_Recibo;
        }


        public void generarRecibosBaseDatos(bool pagoFraccionado,int frecuenciaPago, int PK_Recibo, float primaNeta, float recargoPagoFraccionado, float derechoPoliza, float iva, float importeTotal, DateTime inicioVigenciaPoliza, DateTime inicioVigencia, DateTime finVigenciaPoliza, DateTime finVigencia,DateTime fechaPago,int FK_Poliza)
        {
            double mensual,primerMes,prima=0;

            if (pagoFraccionado)//se paga primer mes derecho de poliza
            {
                //double prima = 0;
                
                int numRecib = 1;
                mensual = ((primaNeta + recargoPagoFraccionado) * 1.16) / frecuenciaPago; //calculo de 1 mes
                primerMes = (derechoPoliza * 1.16) + mensual; //suma el derecho de poliza al primer mes



                inicioVigencia = inicioVigenciaPoliza;
                switch (frecuenciaPago)
                {
                    case 12:
                        prima = primaNeta / 12;
                        finVigencia = inicioVigencia.AddMonths(1);
                        break;
                    case 4:
                        prima = primaNeta / 4;
                        finVigencia = inicioVigencia.AddMonths(3);
                        break;
                    case 2:
                        prima = primaNeta / 2;
                        finVigencia = inicioVigencia.AddMonths(6);
                        break;
                }
                //MessageBox.Show("Entró pago"+primerMes);
                generarRecibos(PK_Recibo, FK_Poliza, inicioVigencia.ToString("yyyy-MM-dd"), finVigencia.ToString("yyyy-MM-dd"), fechaPago.ToString("yyyy-MM-dd"), false, primerMes,prima);


                for (int i = 1; i <= frecuenciaPago - 1; i++)
                {
                    PK_Recibo = PK_Recibo + 1;
                    //MessageBox.Show(frecuenciaPago.ToString());

                    switch (frecuenciaPago)
                    {
                        case 12://mensual
                            prima = primaNeta / 12;
                            inicioVigencia = inicioVigencia.AddMonths(1);
                            finVigencia = inicioVigencia.AddMonths(1);
                            break;
                        case 4://trimestral
                            prima = primaNeta / 4;
                            inicioVigencia = inicioVigencia.AddMonths(3);
                            finVigencia = inicioVigencia.AddMonths(3);
                            break;
                        case 2://semestral
                            prima = primaNeta / 2;
                            inicioVigencia = inicioVigencia.AddMonths(6);
                            finVigencia = finVigencia.AddMonths(6);
                            break;
                    }

                    generarRecibos(PK_Recibo, FK_Poliza, inicioVigencia.ToString("yyyy-MM-dd"), finVigencia.ToString("yyyy-MM-dd"), fechaPago.ToString("yyyy-MM-dd"), false, mensual, prima);
                    numRecib++;
                }

                txtNumeroRecibos.Text = numRecib.ToString();
                MessageBox.Show("Se han creado " + numRecib.ToString() + " recibos");
            }
            else
            {
                int numRecib = 1;
                mensual = importeTotal / frecuenciaPago;


                inicioVigencia = inicioVigenciaPoliza;

                switch (frecuenciaPago)  //GENERAR RECIBO DEL PRIMER MES
                {
                    case 12:
                        prima = primaNeta / 12;
                        finVigencia = inicioVigencia.AddMonths(1);
                        break;
                    case 4:
                        prima = primaNeta / 4;
                        finVigencia = inicioVigencia.AddMonths(3);
                        break;
                    case 2:
                        prima = primaNeta / 2;
                        finVigencia = inicioVigencia.AddMonths(6);
                        break;
                    case 3:
                        prima = primaNeta;
                        mensual = importeTotal;
                        break;
                }

                generarRecibos(PK_Recibo, FK_Poliza, inicioVigencia.ToString("yyyy-MM-dd"), finVigencia.ToString("yyyy-MM-dd"), fechaPago.ToString("yyyy-MM-dd"), false, mensual, prima);

                if (frecuenciaPago != 3) {   //GENERAR DEMAS RECIBOS

                    for (int i = 1; i <= frecuenciaPago - 1; i++)
                    {
                    PK_Recibo = PK_Recibo + 1;
                    // MessageBox.Show(frecuenciaPago.ToString());

                        switch (frecuenciaPago)
                        {
                            case 12://mensual
                                prima = primaNeta / 12;
                                inicioVigencia = inicioVigencia.AddMonths(1);
                                finVigencia = inicioVigencia.AddMonths(1);
                                break;
                            case 4://trimestral
                                prima = primaNeta / 4;
                                inicioVigencia = inicioVigencia.AddMonths(3);
                                finVigencia = inicioVigencia.AddMonths(3);
                                break;
                            case 2://semestral
                                prima = primaNeta / 2;
                                inicioVigencia = inicioVigencia.AddMonths(6);
                                finVigencia = finVigencia.AddMonths(6);
                                break;

                        }

                    generarRecibos(PK_Recibo, FK_Poliza, inicioVigencia.ToString("yyyy-MM-dd"), finVigencia.ToString("yyyy-MM-dd"), fechaPago.ToString("yyyy-MM-dd"), false, mensual, prima);
                    numRecib++;
                    }
            }

                txtNumeroRecibos.Text = numRecib.ToString();
                MessageBox.Show("Se han creado " + numRecib.ToString() + " recibos");
            }
            finVigenciaPoliza = dtpFinVigencia.Value;
            finVigencia = dtpFinVigencia.Value;
            inicioVigencia = dtpInicioVigencia.Value;
            inicioVigenciaPoliza = dtpInicioVigencia.Value;

        }

        private void btnGenerarRecibos_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //recibos.Show();
           
        }

        private void txtImporte_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                txtImporte.Text = string.Format("{0:0.00}", double.Parse(txtImporte.Text));

            }catch
            {

            }
         }

        private void btnRevisarRecibos_Click(object sender, EventArgs e)
        {
            recibos = new Recibos();
            DateTime inicioVigencia = dtpInicioVigencia.Value;
            //MessageBox.Show(PK_Poliza.ToString()+"=="+inicioVigencia.ToString("yyyy-MM-dd") + "==" + inicioVigencia.AddYears(1).ToString("yyyy-MM-dd"));
            recibos.setPK_Poliza(PK_Poliza);
            recibos.setInicioVigenciaPoliza(inicioVigencia);
            recibos.Show();
        }

        private void cmbFrecuenciaPago_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbFrecuenciaPago.SelectedIndex == 3)
            {
                chkboxPagarPrimer.Enabled = false;
            }
            else
            {
                chkboxPagarPrimer.Enabled = true;
            }
        }

        private void txtPrima_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrima.SelectAll();
        }
    }
}
