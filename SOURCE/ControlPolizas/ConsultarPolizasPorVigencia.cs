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
    public partial class ConsultarPolizasPorVigencia : Form
    {
        DataSet ds;
        SQLiteDataAdapter adaptador;
        SQLiteConnection conexion;

        public ConsultarPolizasPorVigencia()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void actualizarDataGridWiewRecibos(DateTime vigenciaInicio, DateTime vigenciaFin)
        {

            String query = "Select p.NumeroPoliza as 'Numero de Poliza',p.Nueva as '¿Es nueva?',tp.TipoPoliza as 'Ramo', p.FinVigencia as 'Vigencia',co.NombreCompania as 'Compañía' FROM Clientes c, Polizas p, RecibosPoliza rp, TipoPolizas tp, Companias co WHERE p.FK_Cliente=c.PK_Cliente and p.FK_Compania=co.PK_Compania and p.FK_TipoPoliza=tp.PK_TipoPoliza and p.FinVigencia BETWEEN '"+vigenciaInicio.ToString("yyyy-MM-dd")+"' and '"+vigenciaFin.ToString("yyyy-MM-dd") + "' GROUP BY p.NumeroPoliza";
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
                MessageBox.Show("Error al cargar las polizas");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try { 
            DateTime inicioVigencia, finVigencia;

            inicioVigencia = dtpFechaVencimientoInicio.Value;
            finVigencia = dtpFechaVencimientoFin.Value;

            actualizarDataGridWiewRecibos(inicioVigencia, finVigencia);
            }
            catch
            {
                MessageBox.Show("No se encontró registro");
            }
        }

        private void dgvRecibos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
