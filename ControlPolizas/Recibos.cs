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

    public partial class Recibos : Form
    {
        DataSet ds;
        SQLiteDataAdapter adaptador;
        SQLiteConnection conexion;
        SQLiteCommandBuilder constructorComandos;
        DataTable dataTable;
        public Poliza poliza;
        public int Pk_poliza=8888;
        public DateTime inicioVigenciaPoliza;
        public Recibos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            //poliza.recibos.Hide(); 
            

        }

        public void setPK_Poliza(int pk_poliza)
        {
            Pk_poliza = pk_poliza;
        }

        public void setInicioVigenciaPoliza(DateTime inicioVigencia)
        {
            inicioVigenciaPoliza = inicioVigencia;
        }


        public int buscarPK_Poliza(String numeroPoliza)
        {
            SQLiteCommand commandMax;
            int PK_Poliza = 99999999;
            String query="SELECT PK_poliza from Polizas WHERE NumeroPoliza ='"+numeroPoliza+"'";

            try
            {

                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                commandMax = new SQLiteCommand(query, conexion);
                string PK_ClienteString = commandMax.ExecuteScalar().ToString();
                PK_Poliza = Int32.Parse(PK_ClienteString);
                conexion.Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al buscar PK_Poliza");
            }
            return PK_Poliza;
        }

        private void Recibos_Load(object sender, EventArgs e)
        {
            
            actualizarDataGridWiewRecibos(Pk_poliza);

        }

        public void limpiarText()
        {
            txtNumeroRecibo.Text = "";
            txtNumeroPoliza.Text = "";
            txtImporte.Text = "";
            chkboxPagado.Checked = false;
            txtPrima.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarText();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            /*try
            {
                constructorComandos = new SQLiteCommandBuilder(adaptador);
                adaptador.Update(ds);
                MessageBox.Show("Recibos Modificados");
            }
            catch(Exception ev)
            {
                MessageBox.Show("Error al actualizar recibos " + ev);
            }*/

            int PK_ReciobosPolizas;
            double monto,prima;
            bool estado;
            String numeroPoliza="";
            DateTime inicioVigencia, finVigencia,fechaPago;

            if (txtNumeroRecibo.Text.Equals(""))
            {
                MessageBox.Show("Elija un recibo porfavor");
            }
            else
            {
                PK_ReciobosPolizas = Int32.Parse(txtNumeroRecibo.Text);
                numeroPoliza = txtNumeroPoliza.Text;
                inicioVigencia = dtpInicioVigencia.Value;
                finVigencia = dtpFinVigencia.Value;
                fechaPago = dtpFechaPago.Value;
                estado = chkboxPagado.Checked;
                monto = double.Parse(txtImporte.Text);
                prima = double.Parse(txtPrima.Text);
                actualizarRecibo(PK_ReciobosPolizas, inicioVigencia, finVigencia,fechaPago, estado, monto, prima);
                int fk_Poliza = buscarPK_Poliza(numeroPoliza);
                actualizarDataGridWiewRecibos(fk_Poliza);
            }

        }

        public void actualizarRecibo(int PK_ReciboPoliza,DateTime inicioVigencia,DateTime finVigencia,DateTime fechaPago, bool estado,double monto,double prima)
        {
            SQLiteCommand commandoInsert;

            string query;
            try
            {

                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                query = "UPDATE RecibosPoliza SET InicioVigencia='" + inicioVigencia.ToString("yyyy-MM-dd") + "',FinVigencia='" + finVigencia.ToString("yyyy-MM-dd") +"',FechaPago='"+fechaPago.ToString("yyyy-MM-dd") + "',Estado='" + estado + "',Monto=" + monto + ",Prima=" + prima + " WHERE PK_RecibosPoliza= " + PK_ReciboPoliza;
                //MessageBox.Show(query + " linea 143");
                commandoInsert = new SQLiteCommand(query, conexion);
                commandoInsert.ExecuteNonQuery();
                MessageBox.Show("Recibo actualizado");
                conexion.Close();

                //PK_Cliente = 0;
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Actualizar Recibo" + ev);
            }
        }


        public void actualizarDataGridWiewRecibos(int FK_Poliza)
        {
            
            String query = "SELECT rp.PK_RecibosPoliza AS 'N.',p.NumeroPoliza,rp.InicioVigencia,rp.FinVigencia,rp.Monto,rp.Prima,rp.Estado, rp.FechaPago FROM RecibosPoliza rp, Polizas p WHERE rp.FK_Poliza = p.PK_poliza and rp.FK_Poliza =" + FK_Poliza + " AND rp.InicioVigencia BETWEEN '" + inicioVigenciaPoliza.ToString("yyyy-MM-dd") + "' AND '" + inicioVigenciaPoliza.AddYears(1).ToString("yyyy-MM-dd") + "'";
            //MessageBox.Show(query);

            // DataTable dataTable = new DataTable();
            try
            {

                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                ds = new DataSet();
                adaptador = new SQLiteDataAdapter(query, conexion);

                //adaptador.Fill(dataTable);
                adaptador.Fill(ds);
                dgvRecibos.DataSource = ds.Tables[0].DefaultView;

                conexion.Close();
                //inicioVigenciaPoliza = null;
                //Pk_poliza = 888;
            }
            catch
            {
                MessageBox.Show("Error al cargar los Recibos");
            }
        }
        

        private void dgvRecibos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvRecibos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dgvRecibos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtPrima_LocationChanged(object sender, EventArgs e)
        {

        }

        private void dgvRecibos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvRecibos.Rows[e.RowIndex];
                //MessageBox.Show("row=" + e.RowIndex);
                txtNumeroPoliza.Text = row.Cells["NumeroPoliza"].Value.ToString();
                dtpInicioVigencia.Value = DateTime.Parse(row.Cells["InicioVigencia"].Value.ToString());
                dtpFinVigencia.Value = DateTime.Parse(row.Cells["FinVigencia"].Value.ToString());
                dtpFechaPago.Value = DateTime.Parse(row.Cells["FechaPago"].Value.ToString());
                txtNumeroRecibo.Text = row.Cells["N."].Value.ToString();
                txtImporte.Text = row.Cells["Monto"].Value.ToString();
                chkboxPagado.Checked = Convert.ToBoolean(row.Cells["Estado"].Value);
                txtPrima.Text = row.Cells["Prima"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Por favor elija una fila existente");
            }
        }
    }
}