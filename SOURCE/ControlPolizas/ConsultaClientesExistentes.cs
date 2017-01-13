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
        int pk_ClienteEliminar;

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
            dgvRecibos.Refresh();
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elmiminarClienteClick(pk_ClienteEliminar);
            try
            {
                
                actualizarDataGridWiewRecibos();

            }
            catch (Exception ev)
            {
                MessageBox.Show("Rectifique los datos");
            }
        }

        private void dgvRecibos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DateTime vigenciaFin;
                if (e.Button == MouseButtons.Right)
                {
                    dgvRecibos.ContextMenuStrip = MenuClienteClic;
                    dgvRecibos.ContextMenuStrip.Show(dgvRecibos, e.Location);
                    DataGridViewRow row = dgvRecibos.Rows[e.RowIndex];
                    pk_ClienteEliminar = int.Parse(row.Cells["PK_cliente"].Value.ToString());
                    //vigenciaFin = DateTime.Parse(row.Cells["Vigencia"].Value.ToString())

                    //  vigenciaFinElim = DateTime.Parse(row.Cells["Vigencia"].Value.ToString());
                }
            }
            catch (Exception ex)
            {

            }
        }


        public void elmiminarClienteClick(int pk_cliente)
        {
            Cliente cl = new Cliente();
            try { 
                if (pk_cliente== 0)
                {
                    MessageBox.Show("No se encontró la Cliente");
                }
                else
                {
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;

                    DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el Cliente?, esto implica ELIMINAR tambien TODAS las POLIZAS pertenecientes a este Cliente", "ATENCION!", botones, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Console.WriteLine(pk_cliente);
                        cl.eliminarCliente(pk_cliente);

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

    }
}
