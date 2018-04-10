namespace LewisVentas.View.Articulos
{
    partial class CreateEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNombreError = new System.Windows.Forms.Label();
            this.labelCategoriaError = new System.Windows.Forms.Label();
            this.labelCodigoError = new System.Windows.Forms.Label();
            this.textBoxPrecioCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPrecioCompraError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEspesificaciones = new System.Windows.Forms.ComboBox();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.labelStockError = new System.Windows.Forms.Label();
            this.labelEspecificacion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.labelPreciVentaError = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(34)))));
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.labelTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(621, 32);
            this.panelHeader.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LewisVentas.Properties.Resources.icon_cerrar2;
            this.pictureBox1.Location = new System.Drawing.Point(594, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(216, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(119, 18);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Editar Producto";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(108)))));
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Image = global::LewisVentas.Properties.Resources.delete__1_;
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminar.Location = new System.Drawing.Point(387, 341);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(105, 40);
            this.buttonEliminar.TabIndex = 24;
            this.buttonEliminar.Text = "Cancelar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(163)))), ((int)(((byte)(247)))));
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Image = global::LewisVentas.Properties.Resources.save_icon_silhouette;
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(498, 341);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(105, 40);
            this.buttonGuardar.TabIndex = 25;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.White;
            this.textBoxNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(39, 74);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(252, 28);
            this.textBoxNombre.TabIndex = 26;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.BackColor = System.Drawing.Color.White;
            this.textBoxCodigo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(337, 74);
            this.textBoxCodigo.Multiline = true;
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(252, 28);
            this.textBoxCodigo.TabIndex = 27;
            // 
            // textBoxStock
            // 
            this.textBoxStock.BackColor = System.Drawing.Color.White;
            this.textBoxStock.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStock.Location = new System.Drawing.Point(39, 203);
            this.textBoxStock.Multiline = true;
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(252, 28);
            this.textBoxStock.TabIndex = 28;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelNombre.Location = new System.Drawing.Point(334, 55);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 29;
            this.labelNombre.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(36, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(36, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre";
            // 
            // labelNombreError
            // 
            this.labelNombreError.AutoSize = true;
            this.labelNombreError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(108)))));
            this.labelNombreError.Location = new System.Drawing.Point(36, 105);
            this.labelNombreError.Name = "labelNombreError";
            this.labelNombreError.Size = new System.Drawing.Size(194, 17);
            this.labelNombreError.TabIndex = 32;
            this.labelNombreError.Text = "Complete el nombre. Por favor!";
            this.labelNombreError.Visible = false;
            // 
            // labelCategoriaError
            // 
            this.labelCategoriaError.AutoSize = true;
            this.labelCategoriaError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoriaError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(108)))));
            this.labelCategoriaError.Location = new System.Drawing.Point(36, 167);
            this.labelCategoriaError.Name = "labelCategoriaError";
            this.labelCategoriaError.Size = new System.Drawing.Size(208, 17);
            this.labelCategoriaError.TabIndex = 33;
            this.labelCategoriaError.Text = "Complete la categoria. Por favor!";
            this.labelCategoriaError.Visible = false;
            // 
            // labelCodigoError
            // 
            this.labelCodigoError.AutoSize = true;
            this.labelCodigoError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(108)))));
            this.labelCodigoError.Location = new System.Drawing.Point(334, 105);
            this.labelCodigoError.Name = "labelCodigoError";
            this.labelCodigoError.Size = new System.Drawing.Size(191, 17);
            this.labelCodigoError.TabIndex = 34;
            this.labelCodigoError.Text = "Complete el codigo. Por favor!";
            this.labelCodigoError.Visible = false;
            // 
            // textBoxPrecioCompra
            // 
            this.textBoxPrecioCompra.BackColor = System.Drawing.Color.White;
            this.textBoxPrecioCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecioCompra.Location = new System.Drawing.Point(337, 203);
            this.textBoxPrecioCompra.Multiline = true;
            this.textBoxPrecioCompra.Name = "textBoxPrecioCompra";
            this.textBoxPrecioCompra.Size = new System.Drawing.Size(252, 28);
            this.textBoxPrecioCompra.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(334, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Precio Compra";
            // 
            // labelPrecioCompraError
            // 
            this.labelPrecioCompraError.AutoSize = true;
            this.labelPrecioCompraError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioCompraError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(108)))));
            this.labelPrecioCompraError.Location = new System.Drawing.Point(334, 234);
            this.labelPrecioCompraError.Name = "labelPrecioCompraError";
            this.labelPrecioCompraError.Size = new System.Drawing.Size(237, 17);
            this.labelPrecioCompraError.TabIndex = 37;
            this.labelPrecioCompraError.Text = "Complete el precio compra. Por favor!";
            this.labelPrecioCompraError.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(36, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Categorias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(334, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Especificaciones";
            // 
            // comboBoxEspesificaciones
            // 
            this.comboBoxEspesificaciones.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEspesificaciones.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBoxEspesificaciones.FormattingEnabled = true;
            this.comboBoxEspesificaciones.Items.AddRange(new object[] {
            "Unidades",
            "Caja",
            "Libras",
            "Paquete"});
            this.comboBoxEspesificaciones.Location = new System.Drawing.Point(337, 141);
            this.comboBoxEspesificaciones.Name = "comboBoxEspesificaciones";
            this.comboBoxEspesificaciones.Size = new System.Drawing.Size(252, 23);
            this.comboBoxEspesificaciones.TabIndex = 40;
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategorias.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Items.AddRange(new object[] {
            ""});
            this.comboBoxCategorias.Location = new System.Drawing.Point(39, 141);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(252, 23);
            this.comboBoxCategorias.TabIndex = 41;
            // 
            // labelStockError
            // 
            this.labelStockError.AutoSize = true;
            this.labelStockError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(108)))));
            this.labelStockError.Location = new System.Drawing.Point(36, 234);
            this.labelStockError.Name = "labelStockError";
            this.labelStockError.Size = new System.Drawing.Size(180, 17);
            this.labelStockError.TabIndex = 42;
            this.labelStockError.Text = "Complete el stock. Por favor!";
            this.labelStockError.Visible = false;
            // 
            // labelEspecificacion
            // 
            this.labelEspecificacion.AutoSize = true;
            this.labelEspecificacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspecificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(108)))));
            this.labelEspecificacion.Location = new System.Drawing.Point(334, 167);
            this.labelEspecificacion.Name = "labelEspecificacion";
            this.labelEspecificacion.Size = new System.Drawing.Size(208, 17);
            this.labelEspecificacion.TabIndex = 43;
            this.labelEspecificacion.Text = "Complete la categoria. Por favor!";
            this.labelEspecificacion.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(36, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Precio Venta";
            // 
            // textBoxPrecioVenta
            // 
            this.textBoxPrecioVenta.BackColor = System.Drawing.Color.White;
            this.textBoxPrecioVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecioVenta.Location = new System.Drawing.Point(39, 270);
            this.textBoxPrecioVenta.Multiline = true;
            this.textBoxPrecioVenta.Name = "textBoxPrecioVenta";
            this.textBoxPrecioVenta.Size = new System.Drawing.Size(252, 28);
            this.textBoxPrecioVenta.TabIndex = 45;
            // 
            // labelPreciVentaError
            // 
            this.labelPreciVentaError.AutoSize = true;
            this.labelPreciVentaError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreciVentaError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(108)))));
            this.labelPreciVentaError.Location = new System.Drawing.Point(36, 301);
            this.labelPreciVentaError.Name = "labelPreciVentaError";
            this.labelPreciVentaError.Size = new System.Drawing.Size(231, 17);
            this.labelPreciVentaError.TabIndex = 46;
            this.labelPreciVentaError.Text = "Complete el precio ventas. Por favor!";
            this.labelPreciVentaError.Visible = false;
            // 
            // CreateEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(621, 410);
            this.Controls.Add(this.labelPreciVentaError);
            this.Controls.Add(this.textBoxPrecioVenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelEspecificacion);
            this.Controls.Add(this.labelStockError);
            this.Controls.Add(this.comboBoxCategorias);
            this.Controls.Add(this.comboBoxEspesificaciones);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPrecioCompraError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPrecioCompra);
            this.Controls.Add(this.labelCodigoError);
            this.Controls.Add(this.labelCategoriaError);
            this.Controls.Add(this.labelNombreError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateEditForm";
            this.Load += new System.EventHandler(this.CreateEditForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNombreError;
        private System.Windows.Forms.Label labelCategoriaError;
        private System.Windows.Forms.Label labelCodigoError;
        private System.Windows.Forms.TextBox textBoxPrecioCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPrecioCompraError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxEspesificaciones;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.Label labelStockError;
        private System.Windows.Forms.Label labelEspecificacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPrecioVenta;
        private System.Windows.Forms.Label labelPreciVentaError;
    }
}