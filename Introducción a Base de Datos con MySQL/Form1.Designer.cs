namespace Introducción_a_Base_de_Datos_con_MySQL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.pbBusuqeda = new System.Windows.Forms.PictureBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btmAgregar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btmModificar = new System.Windows.Forms.Button();
            this.btmEliminar = new System.Windows.Forms.Button();
            this.btmLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusuqeda)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.producto,
            this.precio,
            this.cantidad,
            this.imagen});
            this.dgvProductos.Location = new System.Drawing.Point(33, 414);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.Size = new System.Drawing.Size(834, 211);
            this.dgvProductos.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // producto
            // 
            this.producto.HeaderText = "producto";
            this.producto.MinimumWidth = 8;
            this.producto.Name = "producto";
            this.producto.Width = 150;
            // 
            // precio
            // 
            this.precio.HeaderText = "precio";
            this.precio.MinimumWidth = 8;
            this.precio.Name = "precio";
            this.precio.Width = 150;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 8;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 150;
            // 
            // imagen
            // 
            this.imagen.HeaderText = "imagen";
            this.imagen.MinimumWidth = 8;
            this.imagen.Name = "imagen";
            this.imagen.Width = 150;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelBusqueda.Controls.Add(this.pbBusuqeda);
            this.panelBusqueda.Controls.Add(this.txtBusqueda);
            this.panelBusqueda.Controls.Add(this.lblBusqueda);
            this.panelBusqueda.Location = new System.Drawing.Point(33, 345);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(853, 63);
            this.panelBusqueda.TabIndex = 1;
            // 
            // pbBusuqeda
            // 
            this.pbBusuqeda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBusuqeda.BackgroundImage")));
            this.pbBusuqeda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBusuqeda.Location = new System.Drawing.Point(429, 9);
            this.pbBusuqeda.Name = "pbBusuqeda";
            this.pbBusuqeda.Size = new System.Drawing.Size(50, 49);
            this.pbBusuqeda.TabIndex = 13;
            this.pbBusuqeda.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(186, 17);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(232, 35);
            this.txtBusqueda.TabIndex = 12;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBusqueda.Location = new System.Drawing.Point(9, 20);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(161, 29);
            this.lblBusqueda.TabIndex = 12;
            this.lblBusqueda.Text = "BUSQUEDA:";
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.BackColor = System.Drawing.Color.Transparent;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFolio.Location = new System.Drawing.Point(32, 114);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(102, 37);
            this.lblFolio.TabIndex = 2;
            this.lblFolio.Text = "Folio:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(32, 168);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(148, 37);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrecio.Location = new System.Drawing.Point(32, 226);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(123, 37);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantidad.Location = new System.Drawing.Point(32, 288);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(164, 37);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.BackColor = System.Drawing.Color.Transparent;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblImagen.Location = new System.Drawing.Point(455, 125);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(139, 37);
            this.lblImagen.TabIndex = 6;
            this.lblImagen.Text = "Imagen:";
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(200, 125);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(232, 26);
            this.txtFolio.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(200, 178);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(232, 26);
            this.txtNombre.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(200, 235);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(232, 26);
            this.txtPrecio.TabIndex = 9;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(200, 288);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(232, 26);
            this.txtCantidad.TabIndex = 10;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Location = new System.Drawing.Point(-16, -8);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(931, 97);
            this.panelHeader.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(46, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(390, 37);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "CRUD DE PRODUCTOS";
            // 
            // pbImagen
            // 
            this.pbImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbImagen.BackgroundImage")));
            this.pbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagen.Location = new System.Drawing.Point(630, 125);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(218, 208);
            this.pbImagen.TabIndex = 11;
            this.pbImagen.TabStop = false;
            // 
            // btmAgregar
            // 
            this.btmAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btmAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmAgregar.ImageIndex = 4;
            this.btmAgregar.ImageList = this.imageList1;
            this.btmAgregar.Location = new System.Drawing.Point(28, 632);
            this.btmAgregar.Name = "btmAgregar";
            this.btmAgregar.Size = new System.Drawing.Size(208, 62);
            this.btmAgregar.TabIndex = 12;
            this.btmAgregar.Text = "AGREGAR";
            this.btmAgregar.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "anadir.png");
            this.imageList1.Images.SetKeyName(1, "borrar.png");
            this.imageList1.Images.SetKeyName(2, "componer.png");
            this.imageList1.Images.SetKeyName(3, "limpiar.png");
            this.imageList1.Images.SetKeyName(4, "agregar-producto.png");
            // 
            // btmModificar
            // 
            this.btmModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btmModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmModificar.ImageIndex = 2;
            this.btmModificar.ImageList = this.imageList1;
            this.btmModificar.Location = new System.Drawing.Point(263, 634);
            this.btmModificar.Name = "btmModificar";
            this.btmModificar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btmModificar.Size = new System.Drawing.Size(204, 62);
            this.btmModificar.TabIndex = 13;
            this.btmModificar.Text = "MODIFICAR";
            this.btmModificar.UseVisualStyleBackColor = false;
            // 
            // btmEliminar
            // 
            this.btmEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btmEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmEliminar.ImageKey = "borrar.png";
            this.btmEliminar.ImageList = this.imageList1;
            this.btmEliminar.Location = new System.Drawing.Point(499, 633);
            this.btmEliminar.Name = "btmEliminar";
            this.btmEliminar.Size = new System.Drawing.Size(184, 62);
            this.btmEliminar.TabIndex = 14;
            this.btmEliminar.Text = "ELIMINAR";
            this.btmEliminar.UseVisualStyleBackColor = false;
            // 
            // btmLimpiar
            // 
            this.btmLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btmLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmLimpiar.ImageIndex = 3;
            this.btmLimpiar.ImageList = this.imageList1;
            this.btmLimpiar.Location = new System.Drawing.Point(700, 633);
            this.btmLimpiar.Name = "btmLimpiar";
            this.btmLimpiar.Size = new System.Drawing.Size(188, 62);
            this.btmLimpiar.TabIndex = 15;
            this.btmLimpiar.Text = "LIMPIAR";
            this.btmLimpiar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 702);
            this.Controls.Add(this.btmLimpiar);
            this.Controls.Add(this.btmEliminar);
            this.Controls.Add(this.btmModificar);
            this.Controls.Add(this.btmAgregar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.dgvProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusuqeda)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.PictureBox pbBusuqeda;
        private System.Windows.Forms.Button btmAgregar;
        private System.Windows.Forms.Button btmModificar;
        private System.Windows.Forms.Button btmEliminar;
        private System.Windows.Forms.Button btmLimpiar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewImageColumn imagen;
    }
}

