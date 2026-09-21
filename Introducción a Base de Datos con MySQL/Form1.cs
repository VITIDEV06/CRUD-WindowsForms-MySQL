using ProyectoProductos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Introducción_a_Base_de_Datos_con_MySQL
{
    /// <summary>
    /// Formulario principal para gestionar productos.
    /// </summary>
    public partial class Form1 : Form
    {
        private List<Producto> listaProductos;
        private Image imagenPredeterminada;
        private Image imagenFondoPredeterminada;

        public Form1()
        {
            InitializeComponent();

            imagenPredeterminada = pbImagen.Image;
            imagenFondoPredeterminada = pbImagen.BackgroundImage;

            listaProductos = new List<Producto>();

            // Configura los eventos del formulario.
            Load += Form1_Load;
            btmAgregar.Click += btmAgregar_Click;
            btmModificar.Click += btmModificar_Click;
            btmEliminar.Click += btmEliminar_Click;
            btmLimpiar.Click += btmLimpiar_Click;
            pbImagen.Click += pbImagen_Click;
            dgvProductos.CellClick += dgvProductos_CellClick;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
        }

        // Configura el formulario y la tabla al iniciar.
        private void Form1_Load(object sender, EventArgs e)
        {
            txtFolio.ReadOnly = true;

            dgvProductos.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dgvProductos.RowTemplate.Height = 50;

            dgvProductos.Columns["id"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;

            dgvProductos.Columns["producto"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

            dgvProductos.Columns["precio"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;

            dgvProductos.Columns["cantidad"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;

            // Configura la columna de imágenes.
            DataGridViewImageColumn columnaImagen =
                (DataGridViewImageColumn)dgvProductos.Columns["imagen"];

            columnaImagen.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.None;

            columnaImagen.Width = 80;

            columnaImagen.ImageLayout =
                DataGridViewImageCellLayout.Zoom;

            columnaImagen.DefaultCellStyle.NullValue = null;

            CargarProductos();
        }

        // Carga los productos desde MySQL y los muestra en la tabla.
        private void CargarProductos(string filtro = "")
        {
            try
            {
                dgvProductos.Rows.Clear();
                listaProductos = Conexion.GetProductos(filtro);

                foreach (Producto producto in listaProductos)
                {
                    Image imagen = ConvertirImagen(producto.Imagen);

                    dgvProductos.Rows.Add(
                        producto.Id,
                        producto.Nombre,
                        producto.Precio,
                        producto.Cantidad,
                        imagen
                    );
                }
            }
            catch (Exception ex)
            {
                MostrarError(
                    "Error al cargar productos.",
                    ex
                );
            }
        }

        // Permite seleccionar una imagen desde el equipo.
        private void pbImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter =
                    "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                LiberarImagenActual();

                pbImagen.Image = null;
                pbImagen.BackgroundImage = null;

                using (Image imagenOriginal =
                    Image.FromFile(dialog.FileName))
                {
                    pbImagen.Image =
                        new Bitmap(imagenOriginal);
                }

                pbImagen.SizeMode =
                    PictureBoxSizeMode.Zoom;
            }
        }

        // Agrega un nuevo producto a la base de datos.
        private void btmAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out decimal precio, out int cantidad))
                return;

            try
            {
                Producto producto = new Producto
                {
                    Nombre = txtNombre.Text.Trim(),
                    Precio = precio,
                    Cantidad = cantidad,
                    Imagen = ObtenerImagen()
                };

                if (Conexion.AgregarProducto(producto))
                {
                    MessageBox.Show(
                        "Producto agregado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    CargarProductos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo agregar el producto.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al agregar el producto.", ex);
            }
        }

        // Modifica el producto seleccionado.
        private void btmModificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFolio.Text, out int id))
            {
                MessageBox.Show(
                    "Seleccione un producto.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!ValidarCampos(out decimal precio, out int cantidad))
                return;

            try
            {
                Producto producto = new Producto
                {
                    Id = id,
                    Nombre = txtNombre.Text.Trim(),
                    Precio = precio,
                    Cantidad = cantidad,
                    Imagen = ObtenerImagen()
                };

                if (Conexion.ModificarProducto(producto))
                {
                    MessageBox.Show(
                        "Producto modificado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    CargarProductos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo modificar el producto.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al modificar el producto.", ex);
            }
        }

        // Elimina el producto seleccionado.
        private void btmEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFolio.Text, out int id))
            {
                MessageBox.Show(
                    "Seleccione un producto.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Desea eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
                return;

            try
            {
                if (Conexion.EliminarProducto(id))
                {
                    MessageBox.Show(
                        "Producto eliminado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    CargarProductos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar el producto.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al eliminar el producto.", ex);
            }
        }

        // Limpia los campos del formulario.
        private void btmLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Restablece los campos y la imagen del formulario.
        private void LimpiarCampos()
        {
            txtFolio.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();

            LiberarImagenActual();

            pbImagen.Image = imagenPredeterminada;
            pbImagen.BackgroundImage = imagenFondoPredeterminada;
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;

            txtNombre.Focus();
        }

        // Filtra los productos mientras se escribe.
        private void txtBusqueda_TextChanged(
            object sender,
            EventArgs e)
        {
            CargarProductos(txtBusqueda.Text.Trim());
        }

        // Carga en los campos la información del producto seleccionado.
        private void dgvProductos_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvProductos.Rows[e.RowIndex];

            txtFolio.Text =
                fila.Cells["id"].Value?.ToString();

            txtNombre.Text =
                fila.Cells["producto"].Value?.ToString();

            txtPrecio.Text =
                fila.Cells["precio"].Value?.ToString();

            txtCantidad.Text =
                fila.Cells["cantidad"].Value?.ToString();

            LiberarImagenActual();

            pbImagen.BackgroundImage = null;

            if (fila.Cells["imagen"].Value is Image imagen)
            {
                pbImagen.Image = new Bitmap(imagen);
                pbImagen.SizeMode =
                    PictureBoxSizeMode.Zoom;
            }
        }

        // Valida los datos ingresados antes de guardarlos.
        private bool ValidarCampos(
            out decimal precio,
            out int cantidad)
        {
            precio = 0;
            cantidad = 0;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre del producto.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            if (!decimal.TryParse(
                txtPrecio.Text,
                out precio) || precio < 0)
            {
                MessageBox.Show("Ingrese un precio válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(
                txtCantidad.Text,
                out cantidad) || cantidad < 0)
            {
                MessageBox.Show(
                    "Ingrese una cantidad válida.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            return true;
        }

        // Convierte los datos binarios de MySQL en una imagen.
        private Image ConvertirImagen(byte[] datos)
        {
            if (datos == null || datos.Length == 0)
                return null;

            using (MemoryStream stream =
                new MemoryStream(datos))
            using (Bitmap bitmap =
                new Bitmap(stream))
            {
                return new Bitmap(bitmap);
            }
        }

        // Convierte la imagen del formulario en datos binarios.
        private byte[] ObtenerImagen()
        {
            if (pbImagen.Image == null)
                return null;

            using (MemoryStream stream =
                new MemoryStream())
            {
                pbImagen.Image.Save(
                    stream,
                    System.Drawing.Imaging.ImageFormat.Png
                );

                return stream.ToArray();
            }
        }

        // Libera la imagen seleccionada para evitar consumo de memoria.
        private void LiberarImagenActual()
        {
            if (pbImagen.Image != null &&
                pbImagen.Image != imagenPredeterminada)
            {
                pbImagen.Image.Dispose();
                pbImagen.Image = null;
            }
        }

        // Muestra un mensaje cuando ocurre un error.
        private void MostrarError(string mensaje, Exception ex)
        {
            MessageBox.Show(
                mensaje + "\n\n" + ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}