using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryConti_IEFI
{
    public static class clsConexion
    {
        private static string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=UsuariosBD.mdb";

        public static OleDbConnection ObtenerConexion()
        {
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al conectar: " + ex.Message);
            }
            return conexion;
        }
    }
}
