using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ControlPolizas
{
    class ConnectionSQLite
    {
        SQLiteConnection conexion;

        public void abrirConexion()
        {
            conexion = new SQLiteConnection("Data Source=C:\\Users\\Nacho Martinez\\Desktop\\Zerebro\\Control Polizas\\BaseDatos\\ControlPolizas.db;Version=3");
            conexion.Open();
        }

        public void desconectar()
        {
            conexion.Close();
        }
    }

}
