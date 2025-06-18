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
    internal class clsTareas
    {
        #region CargarCombos
        public void CargarComboTareas(ComboBox combo)
        {
            try
            {
                using (OleDbConnection conexion = clsConexion.ObtenerConexion())
                {
                    string sql = "SELECT IdTarea, Nombre FROM Tarea";

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(sql, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    combo.DataSource = dt;
                    combo.DisplayMember = "Nombre";
                    combo.ValueMember = "IdTarea";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo de tareas: " + ex.Message);
            }
        }

        // Cargar combo box con lugares (tabla Lugar)
        public void CargarComboLugares(ComboBox combo)
        {
            try
            {
                using (OleDbConnection conexion = clsConexion.ObtenerConexion())
                {
                    string sql = "SELECT IdLugar, Nombre FROM Lugar";

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(sql, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    combo.DataSource = dt;
                    combo.DisplayMember = "Nombre";
                    combo.ValueMember = "IdLugar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo de lugares: " + ex.Message);
            }
        }
        #endregion

        public int AgregarTarea(DateTime fecha, int idTarea, int idLugar)
        {
            try
            {
                using (OleDbConnection conexion = clsConexion.ObtenerConexion())
                {
                    string sql = "INSERT INTO RegistroTarea (Fecha, IdTarea, IdLugar) VALUES (?, ?, ?)";

                    OleDbCommand cmd = new OleDbCommand(sql, conexion);

                    cmd.Parameters.Add("?", OleDbType.Date).Value = fecha.Date;
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = idTarea;
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = idLugar;

                    cmd.ExecuteNonQuery();

                    //Recuperar el último ID generado
                    OleDbCommand cmdId = new OleDbCommand("SELECT @@IDENTITY", conexion);
                    int idRegistro = Convert.ToInt32(cmdId.ExecuteScalar());

                    return idRegistro; //Devuelve el ID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la tarea: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; //En caso de error devuelve -1
            }
        }


        public void GrabarDetalle(int idRegistro, bool insumo, bool estudio, bool vacaciones, bool salario, bool recibo, string comentario)
        {
            try
            {
                using (OleDbConnection conexion = clsConexion.ObtenerConexion())
                {
                    string sql = @"UPDATE RegistroTarea 
                           SET Insumo = ?, Estudio = ?, Vacaciones = ?, Salario = ?, Recibo = ?, Comentario = ?
                           WHERE IdRegistro = ?";

                    OleDbCommand cmd = new OleDbCommand(sql, conexion);

                    cmd.Parameters.Add("?", OleDbType.Boolean).Value = insumo;
                    cmd.Parameters.Add("?", OleDbType.Boolean).Value = estudio;
                    cmd.Parameters.Add("?", OleDbType.Boolean).Value = vacaciones;
                    cmd.Parameters.Add("?", OleDbType.Boolean).Value = salario;
                    cmd.Parameters.Add("?", OleDbType.Boolean).Value = recibo;
                    cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comentario;
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = idRegistro;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar los detalles:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public DataTable ObtenerListadoTareas()
        {
            try
            {
                using (OleDbConnection conexion = clsConexion.ObtenerConexion())
                {
                    string sql = @"
                SELECT RegistroTarea.Fecha, Tarea.Nombre AS Tarea, Lugar.Nombre AS Lugar
                FROM (RegistroTarea
                INNER JOIN Tarea ON RegistroTarea.IdTarea = Tarea.IdTarea)
                INNER JOIN Lugar ON RegistroTarea.IdLugar = Lugar.IdLugar
            ";

                    OleDbDataAdapter da = new OleDbDataAdapter(sql, conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el listado de tareas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        #region TareaCRUD

        public void AgregarTareaCRUD(string nombre)
        {
            using (OleDbConnection conexion = clsConexion.ObtenerConexion())
            {
                string sql = "INSERT INTO Tarea (Nombre) VALUES (?)";
                OleDbCommand cmd = new OleDbCommand(sql, conexion);
                cmd.Parameters.AddWithValue("?", nombre);
                cmd.ExecuteNonQuery();
            }
        }

        public void ModificarTarea(int idTarea, string nuevoNombre)
        {
            using (OleDbConnection conexion = clsConexion.ObtenerConexion())
            {
                string sql = "UPDATE Tarea SET Nombre = ? WHERE IdTarea = ?";
                OleDbCommand cmd = new OleDbCommand(sql, conexion);
                cmd.Parameters.AddWithValue("?", nuevoNombre);
                cmd.Parameters.AddWithValue("?", idTarea);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarTarea(int idTarea)
        {
            using (OleDbConnection conexion = clsConexion.ObtenerConexion())
            {
                string sql = "DELETE FROM Tarea WHERE IdTarea = ?";
                OleDbCommand cmd = new OleDbCommand(sql, conexion);
                cmd.Parameters.AddWithValue("?", idTarea);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable MostrarTarea()
        {
            try
            {
                using (OleDbConnection conexionBD = clsConexion.ObtenerConexion())
                {
                    string consulta = "SELECT * FROM Tarea";
                    OleDbCommand cmd = new OleDbCommand(consulta, conexionBD);
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar las tareas: " + ex.Message);
                return null;
            }
        }

        #endregion

        #region LugarCRUD

        public void AgregarLugarCRUD(string nombre)
        {
            using (OleDbConnection conexion = clsConexion.ObtenerConexion())
            {
                string sql = "INSERT INTO Lugar (Nombre) VALUES (?)";
                OleDbCommand cmd = new OleDbCommand(sql, conexion);
                cmd.Parameters.AddWithValue("?", nombre);
                cmd.ExecuteNonQuery();
            }
        }

        public void ModificarLugar(int idLugar, string nuevoNombre)
        {
            using (OleDbConnection conexion = clsConexion.ObtenerConexion())
            {
                string sql = "UPDATE Lugar SET Nombre = ? WHERE IdLugar = ?";
                OleDbCommand cmd = new OleDbCommand(sql, conexion);
                cmd.Parameters.AddWithValue("?", nuevoNombre);
                cmd.Parameters.AddWithValue("?", idLugar);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarLugar(int idLugar)
        {
            using (OleDbConnection conexion = clsConexion.ObtenerConexion())
            {
                string sql = "DELETE FROM Lugar WHERE IdLugar = ?";
                OleDbCommand cmd = new OleDbCommand(sql, conexion);
                cmd.Parameters.AddWithValue("?", idLugar);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable MostrarLugar()
        {
            try
            {
                using (OleDbConnection conexionBD = clsConexion.ObtenerConexion())
                {
                    string consulta = "SELECT * FROM Lugar";
                    OleDbCommand cmd = new OleDbCommand(consulta, conexionBD);
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los lugares: " + ex.Message);
                return null;
            }
        }

        #endregion
    }
}
