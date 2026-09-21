namespace ProyectoProductos
{
    /// <summary>
    /// Representa la información de un producto.
    /// </summary>
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public byte[] Imagen { get; set; }
    }
}