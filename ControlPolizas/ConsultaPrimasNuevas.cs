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
    public partial class ConsultaPrimasNuevas : Form
    {
        DataSet ds;
        SQLiteDataAdapter adaptador;
        SQLiteConnection conexion;

        public ConsultaPrimasNuevas()
        {
            InitializeComponent();
        }

        private void ConsultaPrimasNuevas_Load(object sender, EventArgs e)
        {
            
            fillCmboxCompania();
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
            catch (Exception ev)
            {
                MessageBox.Show("No se encontró el tipo de póliza " + ev);
            }

            return PK_TipoPoliza;
        }

        public double SumarDataGridWiewRecibos(int FK_Compania, int FK_Tipooliza, DateTime fechaPagoInicio, DateTime fechaPagoFin, bool estado, bool nueva)
        {
            SQLiteCommand commandMax;
            String query = "SELECT SUM(rp.Prima) FROM Clientes c, Polizas p, RecibosPoliza rp WHERE rp.Estado='" + estado + "' AND p.FK_TipoPoliza=" + FK_Tipooliza + "  AND p.PK_poliza=rp.FK_Poliza and c.PK_Cliente=p.FK_Cliente AND p.Nueva='" + nueva + "' AND p.FK_Compania=" + FK_Compania + " AND rp.FechaPago BETWEEN '" + fechaPagoInicio.ToString("yyyy-MM-dd") + "' AND '" + fechaPagoFin.ToString("yyyy-MM-dd") + "' ORDER BY rp.PK_RecibosPoliza";
            double total=0;
            //MessageBox.Show(query);

            // DataTable dataTable = new DataTable();
            try
            {

                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();

                commandMax = new SQLiteCommand(query, conexion);
                string PK_TipoPolizaString = commandMax.ExecuteScalar().ToString();
                total = double.Parse(PK_TipoPolizaString);

                conexion.Close();
                //inicioVigenciaPoliza = null;
                //Pk_poliza = 888;
            }
            catch
            {
                MessageBox.Show("No se encontró la consulta");
            }
            return total;
        }

        public void actualizarDataGridWiewRecibos(int FK_Compania, int FK_Tipooliza,DateTime fechaPagoInicio, DateTime fechaPagoFin, bool estado,bool nueva)
        {

            String query = "SELECT rp.PK_RecibosPoliza as 'No.', p.NumeroPoliza, c.Nombre, rp.InicioVigencia,rp.FinVigencia,rp.Prima,rp.FechaPago FROM Clientes c, Polizas p, RecibosPoliza rp WHERE rp.Estado='"+estado+"' AND p.FK_TipoPoliza="+FK_Tipooliza+"  AND p.PK_poliza=rp.FK_Poliza and c.PK_Cliente=p.FK_Cliente AND p.Nueva='"+nueva+"' AND p.FK_Compania="+FK_Compania+" AND rp.FechaPago BETWEEN '"+fechaPagoInicio.ToString("yyyy-MM-dd")+"' AND '"+fechaPagoFin.ToString("yyyy-MM-dd") + "' ORDER BY rp.PK_RecibosPoliza";
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
                MessageBox.Show("No se encontró la consulta");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                int fk_compania, fk_tipoPoliza;
                bool nueva, estado = true;
                DateTime fechaPagoInicio, fechaPagoFin;

                fk_compania = buscarFK_Compania(cmbCompania.SelectedItem.ToString());
                fk_tipoPoliza = buscarFK_TipoPoliza(cmbRamo.SelectedItem.ToString()); ;

                nueva = chkboxNueva.Checked;

                fechaPagoInicio = dtpFechaPagoInicio.Value;
                fechaPagoFin = dtpFechaPagoFin.Value;

                actualizarDataGridWiewRecibos(fk_compania, fk_tipoPoliza, fechaPagoInicio, fechaPagoFin, estado, nueva);
                txtPrimaCumulada.Text= SumarDataGridWiewRecibos(fk_compania, fk_tipoPoliza, fechaPagoInicio, fechaPagoFin, estado, nueva).ToString();

            }
            catch (Exception ev)
            {
                MessageBox.Show("No se Encontraron Registros");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtPrimaCumulada_TextChanged(object sender, EventArgs e)
        {
            txtPrimaCumulada.Text = string.Format("{0:0.00}", double.Parse(txtPrimaCumulada.Text));
        }

        private void dgvRecibos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
