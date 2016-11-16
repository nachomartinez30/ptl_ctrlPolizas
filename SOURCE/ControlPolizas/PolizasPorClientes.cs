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
    public partial class PolizasPorClientes : Form
    {
        DataSet ds;
        SQLiteDataAdapter adaptador;
        SQLiteConnection conexion;
        Poliza poliza;
        int PK_Cliente = 00;

        public PolizasPorClientes()
        {
            InitializeComponent();
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
                    txtNombreCliente.AutoCompleteCustomSource.Add(lectorDatos["Nombre"].ToString());
                }


                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error al Cargar Clientes");
            }
        }


        public int buscarPK_Cliente(String nombre)
        {
            //int pk_Cliente=7;
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;
            String query = "SELECT PK_Cliente FROM Clientes WHERE Nombre='" + nombre + "'";
            try
            {


                conexion = new SQLiteConnection("Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\ControlPolizas.db;Version=3");
                conexion.Open();
                command = new SQLiteCommand(query, conexion);
                lectorDatos = command.ExecuteReader();

                while (lectorDatos.Read())
                {
                    PK_Cliente = lectorDatos.GetInt16(0);
                    
                }

                conexion.Close();
                //buscarDireccionCliente(PK_Cliente);
                
            }
            catch (Exception ev)
            {
                MessageBox.Show("No se encontro el Cliente " + ev);
            }

            return PK_Cliente;
        }


        public void actualizarDataGridWiewRecibos(int FK_Cliente)
        {

            String query = "SELECT p.NumeroPoliza as 'Numero de Poliza',p.Nueva '¿Es nueva?',tp.TipoPoliza as 'Ramo', p.FinVigencia as 'Vigencia',co.NombreCompania as 'Compañía' FROM Clientes c, Polizas p, RecibosPoliza rp, TipoPolizas tp, Companias co WHERE p.FK_Cliente=c.PK_Cliente and p.FK_Compania=co.PK_Compania and p.FK_TipoPoliza=tp.PK_TipoPoliza and p.FK_Cliente=" + FK_Cliente+" GROUP BY p.NumeroPoliza";
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


        private void PolizasPorClientes_Load(object sender, EventArgs e)
        {
            sugerenciaClientes();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                int FK_Cliente;
                FK_Cliente= buscarPK_Cliente(txtNombreCliente.Text);
                actualizarDataGridWiewRecibos(FK_Cliente);

            }
            catch(Exception ev)
            {
                MessageBox.Show("Rectifique los datos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int FK_Cliente;
                FK_Cliente = buscarPK_Cliente(txtNombreCliente.Text);
                actualizarDataGridWiewRecibos(FK_Cliente);

            }
            catch (Exception ev)
            {
                MessageBox.Show("Rectifique los datos");
            }
        }

        private void dgvRecibos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String numeroPoliza, finVigencia, inicioVigencia;
            DateTime vigenciaFin, vigenciaInicio;
            try
            {
                DataGridViewRow row = dgvRecibos.Rows[e.RowIndex];
                numeroPoliza = row.Cells["Numero de Poliza"].Value.ToString();
                vigenciaFin = DateTime.Parse(row.Cells["Vigencia"].Value.ToString());
                vigenciaInicio = vigenciaFin.AddYears(-1);
                finVigencia = vigenciaFin.ToString("yyyy-MM-dd");
                inicioVigencia = vigenciaInicio.ToString("yyyy-MM-dd");
                poliza = new Poliza();
                poliza.Show();
                poliza.buscarPoliza(numeroPoliza, inicioVigencia, finVigencia);
                
                //cliente.buscarClientePKCliente(PK_Cliente);
            }
            catch
            {
                MessageBox.Show("Por favor elija una fila existente");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
