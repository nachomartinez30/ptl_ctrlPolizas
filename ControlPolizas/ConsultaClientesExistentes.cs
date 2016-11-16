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
    public partial class ConsultaClientesExistentes : Form
    {

        DataSet ds;
        SQLiteDataAdapter adaptador;
        SQLiteConnection conexion;
        Cliente cliente;

        public ConsultaClientesExistentes()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void actualizarDataGridWiewRecibos()
        {

            String query = "Select * FROM Clientes";
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
            
        }

        private void ConsultaClientesExistentes_Load(object sender, EventArgs e)
        {
            actualizarDataGridWiewRecibos();
        }

        private void dgvRecibos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String nombreCliente;
            try
            {
                DataGridViewRow row = dgvRecibos.Rows[e.RowIndex];
                nombreCliente = row.Cells["Nombre"].Value.ToString();
                cliente = new Cliente();
                cliente.Show();
                cliente.buscarCliente(nombreCliente);    
               
            }
            catch (Exception ev)
            {
                MessageBox.Show("Verifique la información " + ev);
            }
        }
    }
}
