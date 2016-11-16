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
    public partial class ConsultarPolizaPorNumero : Form
    {
        DataSet ds;
        SQLiteDataAdapter adaptador;
        SQLiteConnection conexion;

        public ConsultarPolizaPorNumero()
        {
            InitializeComponent();
        }

        public void actualizarDataGridWiewRecibos(String numeroPoliza)
        {

            String query = "Select p.PK_Poliza as 'ID',p.Nueva as '¿Es nueva?',tp.TipoPoliza as 'Ramo', p.FinVigencia as 'Vigencia',co.NombreCompania as 'Compañía' FROM Clientes c, Polizas p, RecibosPoliza rp, TipoPolizas tp, Companias co WHERE p.FK_Cliente=c.PK_Cliente and p.FK_Compania=co.PK_Compania and p.FK_TipoPoliza=tp.PK_TipoPoliza and p.NumeroPoliza='" + numeroPoliza +"'";
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

        private void txtNumeroPoliza_TextChanged(object sender, EventArgs e)
        {
            actualizarDataGridWiewRecibos(txtNumeroPoliza.Text);
        }


        public void sugerenciaNumeroPoliza()
        {
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;

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

        private void ConsultarPolizaPorNumero_Load(object sender, EventArgs e)
        {
            sugerenciaNumeroPoliza();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
