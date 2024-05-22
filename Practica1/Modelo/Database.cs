using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Practica1.Modelo
{
    public class Database
    {
        // Directorio del archivo de base de datos relativo al directorio de ejecución
        // A diferencia de la anterior versión, forzamos a que coja la ruta relativa con el
        // Path.GetFullPath
        private static string databaseFileName = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\SampleDatabase.mdf"));
        //string databaseFileName = "baseDatosGestiona.mdf";
        // Cadena de conexión
        private static string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";
        // Usar la cadena de conexión


        // Modificado: Ahora los parámetros son pasados como argumentos
        public void insertarProyecto(string descripcion, string fechaInicio, string fechaFin, string estado, double presupuestoInicial, double presupuestoFinal, string cambios, string codigoCliente)
        {
            // Query de inserción
            string query = "INSERT INTO Proyectos (Descripcion, FechaInicio, FechaFin, Estado, PresupuestoInicial, presupuestoFinal, Cambios, CodigoCliente) VALUES (@Descripcion, @FechaInicio, @FechaFin, @Estado, @PresupuestoInicial, @PresupuestoFinal, @Cambios, @CodigoCliente)";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros y sus valores
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);
                    command.Parameters.AddWithValue("@Estado", estado);
                    command.Parameters.AddWithValue("@PresupuestoInicial", presupuestoInicial);
                    command.Parameters.AddWithValue("@PresupuestoFinal", presupuestoFinal);
                    command.Parameters.AddWithValue("@Cambios", cambios);
                    command.Parameters.AddWithValue("@CodigoCliente", codigoCliente);
                    try
                    {
                        // Ejecutar la consulta de inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se insertó correctamente el registro. Registros afectados: {registrosAfectados}");
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al insertar el registro: {ex.Message}");
                        connection.Close();
                    }
                }
            }
        }
        public DataTable ObtenerProyectos()
        {
            // Query para obtener los proyectos
            string query = "SELECT * FROM Proyectos";

            // Crear una tabla para almacenar los resultados
            DataTable dataTable = new DataTable();

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                // Crear un adaptador de datos
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    // Llenar la tabla con los resultados de la consulta
                    adapter.Fill(dataTable);
                }
                connection.Close();
            }

            return dataTable;

        }
        public void CargarDatosEspecificosDataGridView(DataGridView dataGridView)
        {
            // Query para obtener los datos específicos
            string query = "SELECT Id, estado FROM Proyectos";

            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("Id", "Id");
            dataGridView.Columns.Add("Estado", "Estado");


            // Crear la conexión

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Agregar una nueva fila al DataGridView con el código y el nombre del proyecto
                                dataGridView.Rows.Add(reader["Id"].ToString(), reader["estado"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}\n{ex.StackTrace}");
                    connection.Close();
                }
            }

        }
        public static void borrarProyecto(int cod)
        {
            string query = "DELETE FROM Proyectos where Id = @cod";
            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros y sus valores
                    command.Parameters.AddWithValue("@cod", cod);
                    try
                    {
                        // Ejecutar la consulta de inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se borró correctamente el registro. Registros afectados: {registrosAfectados}");
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al borrar el registro: {ex.Message}");
                        connection.Close();
                    }
                }
            }
        }
        public static void modificarProyecto(int id, string descripcion, string fechaInicio, string fechaFin, string estado, double presupuestoInicial, double presupuestoFinal, string cambios, string codigoCliente)
        {
            // Query de inserción
            string query = "UPDATE Incidencias SET (Descripcion=@descripcion, FechaInicio=@fechaIni, FechaFin=@fechaFin, Estado=@estado, PresupuestoInicial=@presupuestoInicial, presupuestoFinal=@presupuestoFinal, Cambios=@cambios, CodigoCliente=@codigoCliente) WHERE Id = (@id)";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros y sus valores
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@desc", descripcion);
                    command.Parameters.AddWithValue("@estado", fechaInicio);
                    command.Parameters.AddWithValue("@fecha", fechaFin);
                    command.Parameters.AddWithValue("@coste", estado);
                    command.Parameters.AddWithValue("@coste", presupuestoInicial);
                    command.Parameters.AddWithValue("@coste", presupuestoFinal);
                    command.Parameters.AddWithValue("@coste", cambios);
                    command.Parameters.AddWithValue("@coste", codigoCliente);
                    try
                    {
                        // Ejecutar la consulta de inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se actualizó correctamente el registro. Registros afectados: {registrosAfectados}");
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al actualizarel registro: {ex.Message}");
                        connection.Close();
                    }
                }
            }
        }
    }
}