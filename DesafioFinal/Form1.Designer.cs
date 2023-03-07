
namespace DesafioFinal
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
            this.NombreTienda = new System.Windows.Forms.Label();
            this.NombreApellido = new System.Windows.Forms.Label();
            this.codigoVendedor = new System.Windows.Forms.Label();
            this.checkBoxCamisa = new System.Windows.Forms.CheckBox();
            this.checkBoxMangaCorta = new System.Windows.Forms.CheckBox();
            this.checkBoxMao = new System.Windows.Forms.CheckBox();
            this.checkBoxPantalon = new System.Windows.Forms.CheckBox();
            this.checkBoxChupin = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckBoxStandard = new System.Windows.Forms.CheckBox();
            this.CheckBoxPremium = new System.Windows.Forms.CheckBox();
            this.linkLabelHistorialCotizaciones = new System.Windows.Forms.LinkLabel();
            this.textBoxPrecioUnitario = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.buttonCotizar = new System.Windows.Forms.Button();
            this.totalCotizacion = new System.Windows.Forms.Label();
            this.unidadesDisponibles = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.direccionTienda = new System.Windows.Forms.Label();
            this.mensajeStock = new System.Windows.Forms.Label();
            this.pruebaCantidad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.precioTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NombreTienda
            // 
            this.NombreTienda.AutoSize = true;
            this.NombreTienda.Location = new System.Drawing.Point(12, 41);
            this.NombreTienda.Name = "NombreTienda";
            this.NombreTienda.Size = new System.Drawing.Size(80, 13);
            this.NombreTienda.TabIndex = 1;
            this.NombreTienda.Text = "Nombre Tienda";
            // 
            // NombreApellido
            // 
            this.NombreApellido.AutoSize = true;
            this.NombreApellido.Location = new System.Drawing.Point(12, 78);
            this.NombreApellido.Name = "NombreApellido";
            this.NombreApellido.Size = new System.Drawing.Size(140, 13);
            this.NombreApellido.TabIndex = 2;
            this.NombreApellido.Text = "Nombre y apellido Vendedor";
            // 
            // codigoVendedor
            // 
            this.codigoVendedor.AutoSize = true;
            this.codigoVendedor.Location = new System.Drawing.Point(207, 78);
            this.codigoVendedor.Name = "codigoVendedor";
            this.codigoVendedor.Size = new System.Drawing.Size(89, 13);
            this.codigoVendedor.TabIndex = 3;
            this.codigoVendedor.Text = "Codigo Vendedor";
            // 
            // checkBoxCamisa
            // 
            this.checkBoxCamisa.AutoSize = true;
            this.checkBoxCamisa.Location = new System.Drawing.Point(13, 131);
            this.checkBoxCamisa.Name = "checkBoxCamisa";
            this.checkBoxCamisa.Size = new System.Drawing.Size(60, 17);
            this.checkBoxCamisa.TabIndex = 4;
            this.checkBoxCamisa.Text = "Camisa";
            this.checkBoxCamisa.UseVisualStyleBackColor = true;
            this.checkBoxCamisa.CheckedChanged += new System.EventHandler(this.checkBoxCamisa_CheckedChanged);
            // 
            // checkBoxMangaCorta
            // 
            this.checkBoxMangaCorta.AutoSize = true;
            this.checkBoxMangaCorta.Location = new System.Drawing.Point(243, 131);
            this.checkBoxMangaCorta.Name = "checkBoxMangaCorta";
            this.checkBoxMangaCorta.Size = new System.Drawing.Size(86, 17);
            this.checkBoxMangaCorta.TabIndex = 5;
            this.checkBoxMangaCorta.Text = "Manga corta";
            this.checkBoxMangaCorta.UseVisualStyleBackColor = true;
            // 
            // checkBoxMao
            // 
            this.checkBoxMao.AutoSize = true;
            this.checkBoxMao.Location = new System.Drawing.Point(375, 131);
            this.checkBoxMao.Name = "checkBoxMao";
            this.checkBoxMao.Size = new System.Drawing.Size(79, 17);
            this.checkBoxMao.TabIndex = 6;
            this.checkBoxMao.Text = "Cuello Mao";
            this.checkBoxMao.UseVisualStyleBackColor = true;
            // 
            // checkBoxPantalon
            // 
            this.checkBoxPantalon.AutoSize = true;
            this.checkBoxPantalon.Location = new System.Drawing.Point(12, 176);
            this.checkBoxPantalon.Name = "checkBoxPantalon";
            this.checkBoxPantalon.Size = new System.Drawing.Size(68, 17);
            this.checkBoxPantalon.TabIndex = 7;
            this.checkBoxPantalon.Text = "Pantalón";
            this.checkBoxPantalon.UseVisualStyleBackColor = true;
            this.checkBoxPantalon.CheckedChanged += new System.EventHandler(this.checkBoxPantalon_CheckedChanged);
            // 
            // checkBoxChupin
            // 
            this.checkBoxChupin.AutoSize = true;
            this.checkBoxChupin.Location = new System.Drawing.Point(243, 176);
            this.checkBoxChupin.Name = "checkBoxChupin";
            this.checkBoxChupin.Size = new System.Drawing.Size(61, 17);
            this.checkBoxChupin.TabIndex = 8;
            this.checkBoxChupin.Text = "Chupín";
            this.checkBoxChupin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Unidades de stock disponibles: ";
            // 
            // CheckBoxStandard
            // 
            this.CheckBoxStandard.AutoSize = true;
            this.CheckBoxStandard.Location = new System.Drawing.Point(15, 313);
            this.CheckBoxStandard.Name = "CheckBoxStandard";
            this.CheckBoxStandard.Size = new System.Drawing.Size(69, 17);
            this.CheckBoxStandard.TabIndex = 10;
            this.CheckBoxStandard.Text = "Standard";
            this.CheckBoxStandard.UseVisualStyleBackColor = true;
            this.CheckBoxStandard.CheckedChanged += new System.EventHandler(this.CheckBoxStandard_CheckedChanged);
            // 
            // CheckBoxPremium
            // 
            this.CheckBoxPremium.AutoSize = true;
            this.CheckBoxPremium.Location = new System.Drawing.Point(127, 313);
            this.CheckBoxPremium.Name = "CheckBoxPremium";
            this.CheckBoxPremium.Size = new System.Drawing.Size(66, 17);
            this.CheckBoxPremium.TabIndex = 11;
            this.CheckBoxPremium.Text = "Premium";
            this.CheckBoxPremium.UseVisualStyleBackColor = true;
            this.CheckBoxPremium.CheckedChanged += new System.EventHandler(this.CheckBoxPremium_CheckedChanged);
            // 
            // linkLabelHistorialCotizaciones
            // 
            this.linkLabelHistorialCotizaciones.AutoSize = true;
            this.linkLabelHistorialCotizaciones.Location = new System.Drawing.Point(601, 78);
            this.linkLabelHistorialCotizaciones.Name = "linkLabelHistorialCotizaciones";
            this.linkLabelHistorialCotizaciones.Size = new System.Drawing.Size(122, 13);
            this.linkLabelHistorialCotizaciones.TabIndex = 12;
            this.linkLabelHistorialCotizaciones.TabStop = true;
            this.linkLabelHistorialCotizaciones.Text = "Historial Cotizaciones=> ";
            this.linkLabelHistorialCotizaciones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHistorialCotizaciones_LinkClicked);
            // 
            // textBoxPrecioUnitario
            // 
            this.textBoxPrecioUnitario.Location = new System.Drawing.Point(484, 311);
            this.textBoxPrecioUnitario.Name = "textBoxPrecioUnitario";
            this.textBoxPrecioUnitario.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecioUnitario.TabIndex = 13;
            this.textBoxPrecioUnitario.Text = "0";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(623, 310);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantidad.TabIndex = 14;
            this.textBoxCantidad.Text = "0";
            // 
            // buttonCotizar
            // 
            this.buttonCotizar.Location = new System.Drawing.Point(51, 390);
            this.buttonCotizar.Name = "buttonCotizar";
            this.buttonCotizar.Size = new System.Drawing.Size(75, 23);
            this.buttonCotizar.TabIndex = 15;
            this.buttonCotizar.Text = "Cotizar";
            this.buttonCotizar.UseVisualStyleBackColor = true;
            this.buttonCotizar.Click += new System.EventHandler(this.buttonCotizar_Click);
            // 
            // totalCotizacion
            // 
            this.totalCotizacion.AutoSize = true;
            this.totalCotizacion.Location = new System.Drawing.Point(211, 395);
            this.totalCotizacion.Name = "totalCotizacion";
            this.totalCotizacion.Size = new System.Drawing.Size(13, 13);
            this.totalCotizacion.TabIndex = 16;
            this.totalCotizacion.Text = "0";
            // 
            // unidadesDisponibles
            // 
            this.unidadesDisponibles.AutoSize = true;
            this.unidadesDisponibles.Location = new System.Drawing.Point(192, 232);
            this.unidadesDisponibles.Name = "unidadesDisponibles";
            this.unidadesDisponibles.Size = new System.Drawing.Size(13, 13);
            this.unidadesDisponibles.TabIndex = 17;
            this.unidadesDisponibles.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Precio unitario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Catidad de Prenda";
            // 
            // direccionTienda
            // 
            this.direccionTienda.AutoSize = true;
            this.direccionTienda.Location = new System.Drawing.Point(532, 41);
            this.direccionTienda.Name = "direccionTienda";
            this.direccionTienda.Size = new System.Drawing.Size(110, 13);
            this.direccionTienda.TabIndex = 21;
            this.direccionTienda.Text = "Dirección de la tienda";
            // 
            // mensajeStock
            // 
            this.mensajeStock.AutoSize = true;
            this.mensajeStock.Location = new System.Drawing.Point(472, 357);
            this.mensajeStock.Name = "mensajeStock";
            this.mensajeStock.Size = new System.Drawing.Size(279, 13);
            this.mensajeStock.TabIndex = 23;
            this.mensajeStock.Text = "-No hay suficiente cantidad en stock de la prenda elegida";
            // 
            // pruebaCantidad
            // 
            this.pruebaCantidad.AutoSize = true;
            this.pruebaCantidad.Location = new System.Drawing.Point(471, 390);
            this.pruebaCantidad.Name = "pruebaCantidad";
            this.pruebaCantidad.Size = new System.Drawing.Size(280, 13);
            this.pruebaCantidad.TabIndex = 24;
            this.pruebaCantidad.Text = "-Coloca un valor en cantidad y/o precio unitario mayor a 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Precio Total: ";
            // 
            // precioTotal
            // 
            this.precioTotal.AutoSize = true;
            this.precioTotal.Location = new System.Drawing.Point(316, 424);
            this.precioTotal.Name = "precioTotal";
            this.precioTotal.Size = new System.Drawing.Size(0, 13);
            this.precioTotal.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.precioTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pruebaCantidad);
            this.Controls.Add(this.mensajeStock);
            this.Controls.Add(this.direccionTienda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unidadesDisponibles);
            this.Controls.Add(this.totalCotizacion);
            this.Controls.Add(this.buttonCotizar);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxPrecioUnitario);
            this.Controls.Add(this.linkLabelHistorialCotizaciones);
            this.Controls.Add(this.CheckBoxPremium);
            this.Controls.Add(this.CheckBoxStandard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxChupin);
            this.Controls.Add(this.checkBoxPantalon);
            this.Controls.Add(this.checkBoxMao);
            this.Controls.Add(this.checkBoxMangaCorta);
            this.Controls.Add(this.checkBoxCamisa);
            this.Controls.Add(this.codigoVendedor);
            this.Controls.Add(this.NombreApellido);
            this.Controls.Add(this.NombreTienda);
            this.Name = "Form1";
            this.Text = "Cotizador Express";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NombreTienda;
        private System.Windows.Forms.Label NombreApellido;
        private System.Windows.Forms.Label codigoVendedor;
        private System.Windows.Forms.CheckBox checkBoxCamisa;
        private System.Windows.Forms.CheckBox checkBoxMangaCorta;
        private System.Windows.Forms.CheckBox checkBoxMao;
        private System.Windows.Forms.CheckBox checkBoxPantalon;
        private System.Windows.Forms.CheckBox checkBoxChupin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CheckBoxStandard;
        private System.Windows.Forms.CheckBox CheckBoxPremium;
        private System.Windows.Forms.LinkLabel linkLabelHistorialCotizaciones;
        private System.Windows.Forms.TextBox textBoxPrecioUnitario;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Button buttonCotizar;
        private System.Windows.Forms.Label totalCotizacion;
        private System.Windows.Forms.Label unidadesDisponibles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label direccionTienda;
        private System.Windows.Forms.Label mensajeStock;
        private System.Windows.Forms.Label pruebaCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label precioTotal;
    }
}

