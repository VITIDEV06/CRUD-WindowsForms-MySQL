using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ProyectoProductos
{
    /// <summary>
    /// Gestiona la conexión y las operaciones CRUD de productos en MySQL.
    /// </summary>
    public class Conexion
    {
        // Cadena de conexión a la base de datos.
        private static readonly string cadenaConexion =
            "Server=localhost;Database=productos;Uid=root;Pwd=CAMBIAR_CONTRASENA;";

        /// <summary>
        /// Abre una conexión con MySQL.
        /// </summary>
        public static MySqlConnection ObtenerConexion()
        {
            try
            {
                MySqlConnection conexion =
                    new MySqlConnection(cadenaConexion);

                conexion.Open();
                return conexion;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(
                    "Error al conectar con MySQL: " + ex.Message);

                return null;
            }
        }

        /// <summary>
        /// Obtiene los productos y permite aplicar un filtro de búsqueda.
        /// </summary>
        public static List<Producto> GetProductos(
            string filtro = "")
        {
            List<Producto> productos =
                new List<Producto>();

            string query = @"
                SELECT id, nombre, precio, cantidad, imagen
                FROM productos";

            // Aplica el filtro a los campos principales.
            if (!string.IsNullOrWhiteSpace(filtro))
            {
                query += @"
                    WHERE id LIKE @filtro
                    OR nombre LIKE @filtro
                    OR precio LIKE @filtro
                    OR cantidad LIKE @filtro";
            }

            using (MySqlConnection conexion =
                ObtenerConexion())
            {
                if (conexion == null)
                    return productos;

                using (MySqlCommand comando =
                    new MySqlCommand(query, conexion))
                {
                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        comando.Parameters.AddWithValue(
                            "@filtro",
                            "%" + filtro + "%"
                        );
                    }

                    using (MySqlDataReader reader =
                        comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(new Producto
                            {
                                Id = Convert.ToInt32(
                                    reader["id"]),

                                Nombre = reader["nombre"]
                                    .ToString(),

                                Precio = Convert.ToDecimal(
                                    reader["precio"]),

                                Cantidad = Convert.ToInt32(
                                    reader["cantidad"]),

                                Imagen = reader["imagen"] != DBNull.Value
                                    ? (byte[])reader["imagen"]
                                    : null
                            });
                        }
                    }
                }
            }

            return productos;
        }

        /// <summary>
        /// Agrega un nuevo producto a la base de datos.
        /// </summary>
        public static bool AgregarProducto(
            Producto producto)
        {
            const string query = @"
                INSERT INTO productos
                (nombre, precio, cantidad, imagen)
                VALUES
                (@nombre, @precio, @cantidad, @imagen)";

            using (MySqlConnection conexion =
                ObtenerConexion())
            {
                if (conexion == null)
                    return false;

                using (MySqlCommand comando =
                    new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@nombre", producto.Nombre);

                    comando.Parameters.AddWithValue(
                        "@precio", producto.Precio);

                    comando.Parameters.AddWithValue(
                        "@cantidad", producto.Cantidad);

                    comando.Parameters.AddWithValue(
                        "@imagen",
                        (object)producto.Imagen ?? DBNull.Value);

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        /// <summary>
        /// Modifica los datos de un producto existente.
        /// </summary>
        public static bool ModificarProducto(
            Producto producto)
        {
            const string query = @"
                UPDATE productos
                SET nombre = @nombre,
                    precio = @precio,
                    cantidad = @cantidad,
                    imagen = @imagen
                WHERE id = @id";

            using (MySqlConnection conexion =
                ObtenerConexion())
            {
                if (conexion == null)
                    return false;

                using (MySqlCommand comando =
                    new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@id", producto.Id);

                    comando.Parameters.AddWithValue(
                        "@nombre", producto.Nombre);

                    comando.Parameters.AddWithValue(
                        "@precio", producto.Precio);

                    comando.Parameters.AddWithValue(
                        "@cantidad", producto.Cantidad);

                    comando.Parameters.AddWithValue(
                        "@imagen",
                        (object)producto.Imagen ?? DBNull.Value);

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        /// <summary>
        /// Elimina un producto mediante su ID.
        /// </summary>
        public static bool EliminarProducto(int id)
        {
            const string query =
                "DELETE FROM productos WHERE id = @id";

            using (MySqlConnection conexion =
                ObtenerConexion())
            {
                if (conexion == null)
                    return false;

                using (MySqlCommand comando =
                    new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@id", id);

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}