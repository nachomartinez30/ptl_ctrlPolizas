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
   

    public partial class FrmIndex : Form
    {
        public Poliza poliza;
        DateTime thisDay = DateTime.Today;
        SQLiteConnection conexion;
        Inicio_Sesion inicioSesion;
        Cliente cliente;
        Agente agente;
        String numPolizaElim = "";
        String vigenciaFinElim;
        

        public int ventanaClienteCreada = 0;
        private ContextMenu contextMenuStrip1;

        public FrmIndex()
        {
            InitializeComponent();
        }


        public void polizasPorVencer()
        {
            dgvPendientes.Refresh();
            String fecha1 = thisDay.AddDays(28).ToString("yyyy-MM-dd");
            String fecha2 = thisDay.AddDays(33).ToString("yyyy-MM-dd");
            //MessageBox.Show("path "+System.IO.Directory.GetCurrentDirectory()+"\\ControlPolizas.db");

            String query = "SELECT c.Nombre AS 'Nombre', p.NumeroPoliza as 'Numero de poliza', tp.TipoPoliza as 'Ramo', p.FinVigencia as 'Vigencia', p.ImporteTotal as 'Importe total' from Clientes c,Polizas p, TipoPolizas tp where c.PK_Cliente=p.FK_Cliente and tp.PK_TipoPoliza=p.FK_TipoPoliza AND p.FinVigencia BETWEEN '" + fecha1 + "' AND '" + fecha2 + "'";
            //String pruebaQuery="Select * from Polizas";
            //MessageBox.Show(query);
            DataTable dataTable = new DataTable();
            try
            {

                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                DataSet ds = new DataSet();
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexion);

                adaptador.Fill(dataTable);
                adaptador.Fill(ds);
                dgvPendientes.DataSource = ds.Tables[0].DefaultView;

                conexion.Close();

                //************************************************************************

            }
            catch
            {
                MessageBox.Show("No se Pudo conectar la base de Datos");
            }
        }


        public void recibosPorVencer()
        {
            dgvRecibosPorVencer.Refresh();
            String fecha1 = thisDay.AddDays(-2).ToString("yyyy-MM-dd");
            String fecha2 = thisDay.AddDays(3).ToString("yyyy-MM-dd");
            //MessageBox.Show("path "+System.IO.Directory.GetCurrentDirectory()+"\\ControlPolizas.db");

            String query = "SELECT p.NumeroPoliza as 'Poliza',c.Nombre as 'Cliente',rp.Monto,rp.InicioVigencia as 'Inicio Recibo',rp.FinVigencia as 'Fin Recibo', p.FinVigencia as 'Vigencia Poliza' FROM Clientes c, Polizas p, RecibosPoliza rp, TipoPolizas tp, Companias co WHERE p.FK_Cliente=c.PK_Cliente and p.FK_Compania=co.PK_Compania and p.FK_TipoPoliza=tp.PK_TipoPoliza AND rp.FK_Poliza=p.PK_Poliza AND rp.estado= 'False'  AND rp.FinVigencia BETWEEN '" + fecha1+"' AND '"+fecha2+"'";
            //String pruebaQuery="Select * from Polizas";
            //MessageBox.Show(query);
            DataTable dataTable = new DataTable();
            try
            {

                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                DataSet ds = new DataSet();
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexion);

                adaptador.Fill(dataTable);
                adaptador.Fill(ds);
                dgvRecibosPorVencer.DataSource = ds.Tables[0].DefaultView;

                conexion.Close();

                //************************************************************************

                
            }
            catch
            {
                MessageBox.Show("No se Pudo conectar la base de Datos");
            }
        }

        public void cumpleañosDeHoy()
        {
            dgvCumpleaños.Refresh();
            String day = thisDay.ToString("dd");
            String month = thisDay.ToString("MM");
            //MessageBox.Show("path "+System.IO.Directory.GetCurrentDirectory()+"\\ControlPolizas.db");

            String query = "SELECT Nombre FROM Clientes WHERE strftime('%m',FechaNacimiento)='"+month+"' AND strftime('%d',FechaNacimiento)='"+day+"'";
            //String pruebaQuery="Select * from Polizas";
            //MessageBox.Show(query);
            DataTable dataTable = new DataTable();
            try
            {

                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                DataSet ds = new DataSet();
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexion);

                adaptador.Fill(dataTable);
                adaptador.Fill(ds);
                dgvCumpleaños.DataSource = ds.Tables[0].DefaultView;

                conexion.Close();

                //************************************************************************
                }
                    catch
                    {
                        MessageBox.Show("No se Pudo conectar la base de Datos");
                    }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            inicioSesion = new Inicio_Sesion();
            inicioSesion.ShowDialog();
            polizasPorVencer();
            recibosPorVencer();
            cumpleañosDeHoy();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        public void ConsultarPrimas()
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            MostrarFormularioClientes();
            ventanaClienteCreada = 1;

        }

       

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioClientes();
        }

        private void btnSalirIndex_Click(object sender, EventArgs e)
        {
            this.Dispose();
           
        }

        
        private void btnAgente_Click(object sender, EventArgs e)
        {
            MostrarFormularioAgentes();
        }
        private void agenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioAgentes();
        }

        private void btnPoliza_Click(object sender, EventArgs e)
        {
            MostrarFormularioPolizas();
        }

        public void MostrarFormularioAgentes()
        {
            agente = new Agente();
            agente.Show();
        }
        public void MostrarFormularioClientes()
        {

            cliente = new ControlPolizas.Cliente();
            cliente.Show();

        }
        public void MostrarFormularioPolizas()
        {
            poliza= new Poliza();
            poliza.Show();
        }
        public void MostrarFormularioCompania()
        {
            Compania compania = new Compania();
            compania.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void polizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioPolizas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarFormularioCompania();
        }

        private void compañíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioCompania();
        }

        private void polizaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void primasNuevasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPrimasNuevas primasNuevas = new ConsultaPrimasNuevas();
            primasNuevas.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PolizasPorClientes polizaPorClientes = new PolizasPorClientes();
            polizaPorClientes.Show();
        }

        private void vigenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPolizasPorVigencia polizaPorVigencias = new ConsultarPolizasPorVigencia();
            polizaPorVigencias.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaClientesExistentes clientesExistentes = new ConsultaClientesExistentes();
            clientesExistentes.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirIndex_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            MostrarFormularioClientes();
        }

        private void btnPoliza_Click_1(object sender, EventArgs e)
        {
            MostrarFormularioPolizas();
        }

        private void btnAgente_Click_1(object sender, EventArgs e)
        {
            MostrarFormularioAgentes();
        }

        private void btnCompania_Click(object sender, EventArgs e)
        {
            MostrarFormularioCompania();
        }

        private void dgvRecibosPorVencer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String numeroPoliza, finVigencia, inicioVigencia;
            DateTime vigenciaFin, vigenciaInicio;
            try
            {
                DataGridViewRow row = dgvRecibosPorVencer.Rows[e.RowIndex];
                numeroPoliza = row.Cells["Poliza"].Value.ToString();
                vigenciaFin = DateTime.Parse(row.Cells["Vigencia Poliza"].Value.ToString());
                vigenciaInicio = vigenciaFin.AddYears(-1);
                finVigencia = vigenciaFin.ToString("yyyy-MM-dd");
                inicioVigencia = vigenciaInicio.ToString("yyyy-MM-dd");
                poliza = new Poliza();
                poliza.Show();
                poliza.buscarPolizaFinVigencia(numeroPoliza, finVigencia);

                //cliente.buscarClientePKCliente(PK_Cliente);
            }
            catch(Exception ev)
            {
                MessageBox.Show("Por favor elija una fila existente "+ev);
            }
        }

        private void controlDePólizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca_de acerca = new Acerca_de();
            acerca.Show();
        }

       

        private void dgvPendientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String numeroPoliza, finVigencia, inicioVigencia;
            DateTime vigenciaFin, vigenciaInicio;
            try
            {
                DataGridViewRow row = dgvPendientes.Rows[e.RowIndex];
                numeroPoliza = row.Cells["Numero de poliza"].Value.ToString();
                vigenciaFin = DateTime.Parse(row.Cells["Vigencia"].Value.ToString());
                //vigenciaInicio = vigenciaFin.AddYears(-1);
                finVigencia = vigenciaFin.ToString("yyyy-MM-dd");
                //inicioVigencia = vigenciaInicio.ToString("yyyy-MM-dd");
                poliza = new Poliza();
                poliza.Show();
                poliza.buscarPolizaFinVigencia(numeroPoliza, finVigencia);

                //cliente.buscarClientePKCliente(PK_Cliente);
            }
            catch (Exception ev)
            {
                MessageBox.Show("Por favor elija una fila existente " + ev);
            }
        }

        private void dgvPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvPendientes_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DateTime vigenciaFin;
                if (e.Button == MouseButtons.Right)
                {
                    dgvPendientes.ContextMenuStrip = MenuPendientes;
                    dgvPendientes.ContextMenuStrip.Show(dgvPendientes, e.Location);
                    DataGridViewRow row = dgvPendientes.Rows[e.RowIndex];
                    numPolizaElim= row.Cells["Numero de poliza"].Value.ToString();
                    vigenciaFin = DateTime.Parse(row.Cells["Vigencia"].Value.ToString());
                    //vigenciaInicio = vigenciaFin.AddYears(-1);
                    vigenciaFinElim = vigenciaFin.ToString("yyyy-MM-dd");

                  //  vigenciaFinElim = DateTime.Parse(row.Cells["Vigencia"].Value.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("no se pudo mostrar menu clic   "+ex);
            }
            
        }


        public void eliminarPolizaClick(String numeroPoliza,String finVigencia)
        {
            int pk_poliza = 0;
            
            try
            {

                poliza = new Poliza();
                pk_poliza= poliza.buscarPk_PolizaPoliza(numeroPoliza, finVigencia);

                if (pk_poliza == 0)
                {
                    MessageBox.Show("No se encontró la póliza");
                }
                else
                {
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;

                    DialogResult dialogResult = MessageBox.Show("¿Desea eliminar la póliza?, esto implica ELIMINAR tambien TODOS los RECIBOS pertenecientes a esta Poliza", "ATENCION!", botones, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                    if (dialogResult == DialogResult.Yes)
                    {
                        poliza.eliminarPoliza(pk_poliza);
                       
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                   
                }

                //cliente.buscarClientePKCliente(PK_Cliente);
            }
            catch (Exception ev)
            {
                MessageBox.Show("Por favor elija una fila existente " + ev);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarPolizaClick(numPolizaElim, vigenciaFinElim);
            polizasPorVencer();
        }
    }
}
