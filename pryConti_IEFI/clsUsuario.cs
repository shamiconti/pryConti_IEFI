using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryConti_IEFI
{
    internal class clsUsuario
    {
        //Busca usuario por nombre y contraseña, devuelve fila o null
        public DataRow BuscarUsuario(string usuario, string contraseña)
        {
            try
            {
                using (OleDbConnection conexionBD = clsConexion.ObtenerConexion())
                {
                    string consulta = "SELECT * FROM Usuario WHERE Usuario = ? AND Contraseña = ?";
                    OleDbCommand cmd = new OleDbCommand(consulta, conexionBD);
                    cmd.Parameters.AddWithValue("?", usuario);
                    cmd.Parameters.AddWithValue("?", contraseña);

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    if (tabla.Rows.Count > 0)
                        return tabla.Rows[0];
                    else
                        return null;
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario:\n" + ex.Message, "Error al buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void RegistrarLog(string nombreUsuario, int idCategoria, string tiempo)
        {
            try
            {
                using (OleDbConnection conexionBD = clsConexion.ObtenerConexion())
                {
                    string insert = "INSERT INTO Logs (Usuario, IdCategoria, FechaHora, Tiempo) VALUES (?, ?, ?, ?)";
                    OleDbCommand cmd = new OleDbCommand(insert, conexionBD);

                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = nombreUsuario;
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = idCategoria;
                    cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = tiempo;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar log:\n" + ex.Message, "Error al registrar log", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ObtenerLogs()
        {
            try
            {
                using (OleDbConnection conexionBD = clsConexion.ObtenerConexion())
                {
                    string consulta = "SELECT * FROM Logs";
                    OleDbCommand cmd = new OleDbCommand(consulta, conexionBD);
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los logs:\n" + ex.Message, "Error al obtener logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void CargarComboCategorias(ComboBox combo)
        {
            try
            {
                using (OleDbConnection conexionBD = clsConexion.ObtenerConexion())
                {
                    string sql = "SELECT IdCategoria, Nombre FROM Categoria";

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(sql, conexionBD);
                    DataTable dt = new DataTable();

                    adaptador.Fill(dt);

                    combo.DataSource = dt;
                    combo.DisplayMember = "Nombre";        //Lo que ve el usuario
                    combo.ValueMember = "IdCategoria";     //Lo que se guarda internamente
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías:\n" + ex.Message, "Error al cargar combo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarComboUsuarios(ComboBox combo)
        {
            try
            {
                using (OleDbConnection conexionBD = clsConexion.ObtenerConexion())
                {
                    string sql = "SELECT IdUsuario, Usuario FROM Usuario";
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(sql, conexionBD);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    combo.DataSource = dt;
                    combo.DisplayMember = "Usuario";
                    combo.ValueMember = "IdUsuario";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios:\n" + ex.Message, "Error al cargar combo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AgregarUsuario(string usuario, string contraseña, int idCategoria)
        {
            try
            {
                using (OleDbConnection conexionBD = clsConexion.ObtenerConexion())
                {
                    string sql = "INSERT INTO Usuario (Usuario, Contraseña, IdCategoria, FechaCreado, FechaModificado) VALUES (?, ?, ?, ?, ?)";

                    OleDbCommand cmd = new OleDbCommand(sql, conexionBD);
                    cmd.Parameters.AddWithValue("?", usuario);
                    cmd.Parameters.AddWithValue("?", contraseña);
                    cmd.Parameters.AddWithValue("?", idCategoria);
                    cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;    //FechaCreado
                    cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;    //FechaModificado

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario:\n" + ex.Message, "Error al agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        public void EliminarUsuario(int idUsuario)
        {
            try
            {
                using (OleDbConnection conexionBD = clsConexion.ObtenerConexion())
                {
                    string sql = "DELETE FROM Usuario WHERE IdUsuario = ?";

                    OleDbCommand cmd = new OleDbCommand(sql, conexionBD);
                    cmd.Parameters.AddWithValue("?", idUsuario);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas == 0)
                        MessageBox.Show("No se encontró usuario con ese Id.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario:\n" + ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ModificarUsuario(int idUsuario, string nuevoNombre, string nuevaContraseña, int idCategoria)
        {
            try
            {
                using (OleDbConnection conexionBD = clsConexion.ObtenerConexion())
                {
                    string update = "UPDATE Usuario SET Usuario = ?, Contraseña = ?, IdCategoria = ?, FechaModificado = ? WHERE IdUsuario = ?";

                    OleDbCommand cmd = new OleDbCommand(update, conexionBD);
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = nuevoNombre;
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = nuevaContraseña;
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = idCategoria;
                    cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = idUsuario;

                    int filas = cmd.ExecuteNonQuery();

                    if (filas == 0)
                    {
                        MessageBox.Show("No se encontró el usuario para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar usuario:\n" + ex.Message, "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ObtenerUsuarios()
        {
            try
            {
                using (OleDbConnection conexionBD = clsConexion.ObtenerConexion())
                {
                    string consulta = "SELECT * FROM Usuario";
                    OleDbCommand cmd = new OleDbCommand(consulta, conexionBD);
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios:\n" + ex.Message, "Error al obtener usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
