
namespace PlasticosCerriDeposito
{
    partial class SalidaStockCarga
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.CboTipo = new System.Windows.Forms.ComboBox();
            this.CmdSalir = new System.Windows.Forms.Button();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.Articulos = new System.Windows.Forms.TabPage();
            this.LblCapacidadDisponible = new System.Windows.Forms.Label();
            this.LblCapacidadTotal = new System.Windows.Forms.Label();
            this.LblStockActual = new System.Windows.Forms.Label();
            this.CboPosicion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.cmdDel = new System.Windows.Forms.Button();
            this.CboArticulo = new System.Windows.Forms.ComboBox();
            this.TxtCodArt = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.Flex = new System.Windows.Forms.DataGridView();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CboDeposito = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNumComprobante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdImprimir = new System.Windows.Forms.Button();
            this.CmdGuardar = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.Articulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Flex)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Tipo";
            // 
            // CboTipo
            // 
            this.CboTipo.DropDownWidth = 320;
            this.CboTipo.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.CboTipo.FormattingEnabled = true;
            this.CboTipo.Items.AddRange(new object[] {
            "INGRESO"});
            this.CboTipo.Location = new System.Drawing.Point(306, 31);
            this.CboTipo.Name = "CboTipo";
            this.CboTipo.Size = new System.Drawing.Size(191, 28);
            this.CboTipo.TabIndex = 2;
            // 
            // CmdSalir
            // 
            this.CmdSalir.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.CmdSalir.Image = global::PlasticosCerriDeposito.Properties.Resources.exit;
            this.CmdSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdSalir.Location = new System.Drawing.Point(755, 446);
            this.CmdSalir.Name = "CmdSalir";
            this.CmdSalir.Size = new System.Drawing.Size(65, 40);
            this.CmdSalir.TabIndex = 7;
            this.CmdSalir.Text = "&Salir";
            this.CmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdSalir.UseVisualStyleBackColor = true;
            this.CmdSalir.Click += new System.EventHandler(this.CmdSalir_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.Articulos);
            this.TabControl1.Location = new System.Drawing.Point(15, 65);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(805, 375);
            this.TabControl1.TabIndex = 4;
            // 
            // Articulos
            // 
            this.Articulos.BackColor = System.Drawing.SystemColors.Control;
            this.Articulos.Controls.Add(this.LblCapacidadDisponible);
            this.Articulos.Controls.Add(this.LblCapacidadTotal);
            this.Articulos.Controls.Add(this.LblStockActual);
            this.Articulos.Controls.Add(this.CboPosicion);
            this.Articulos.Controls.Add(this.label2);
            this.Articulos.Controls.Add(this.CmdAdd);
            this.Articulos.Controls.Add(this.cmdDel);
            this.Articulos.Controls.Add(this.CboArticulo);
            this.Articulos.Controls.Add(this.TxtCodArt);
            this.Articulos.Controls.Add(this.label26);
            this.Articulos.Controls.Add(this.Flex);
            this.Articulos.Controls.Add(this.TxtCantidad);
            this.Articulos.Controls.Add(this.label11);
            this.Articulos.Controls.Add(this.label10);
            this.Articulos.Location = new System.Drawing.Point(4, 25);
            this.Articulos.Name = "Articulos";
            this.Articulos.Padding = new System.Windows.Forms.Padding(3);
            this.Articulos.Size = new System.Drawing.Size(797, 346);
            this.Articulos.TabIndex = 0;
            this.Articulos.Text = "Artículos";
            // 
            // LblCapacidadDisponible
            // 
            this.LblCapacidadDisponible.AutoSize = true;
            this.LblCapacidadDisponible.Location = new System.Drawing.Point(440, 86);
            this.LblCapacidadDisponible.Name = "LblCapacidadDisponible";
            this.LblCapacidadDisponible.Size = new System.Drawing.Size(153, 16);
            this.LblCapacidadDisponible.TabIndex = 5;
            this.LblCapacidadDisponible.Text = "Capacidad Disponible: ";
            // 
            // LblCapacidadTotal
            // 
            this.LblCapacidadTotal.AutoSize = true;
            this.LblCapacidadTotal.Location = new System.Drawing.Point(284, 86);
            this.LblCapacidadTotal.Name = "LblCapacidadTotal";
            this.LblCapacidadTotal.Size = new System.Drawing.Size(117, 16);
            this.LblCapacidadTotal.TabIndex = 4;
            this.LblCapacidadTotal.Text = "Capacidad Total: ";
            // 
            // LblStockActual
            // 
            this.LblStockActual.AutoSize = true;
            this.LblStockActual.Location = new System.Drawing.Point(136, 86);
            this.LblStockActual.Name = "LblStockActual";
            this.LblStockActual.Size = new System.Drawing.Size(95, 16);
            this.LblStockActual.TabIndex = 3;
            this.LblStockActual.Text = "Stock Actual: ";
            // 
            // CboPosicion
            // 
            this.CboPosicion.DropDownWidth = 320;
            this.CboPosicion.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.CboPosicion.FormattingEnabled = true;
            this.CboPosicion.Location = new System.Drawing.Point(10, 79);
            this.CboPosicion.Name = "CboPosicion";
            this.CboPosicion.Size = new System.Drawing.Size(120, 28);
            this.CboPosicion.TabIndex = 2;
            this.CboPosicion.SelectedIndexChanged += new System.EventHandler(this.CboPosiciones_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Posición";
            // 
            // CmdAdd
            // 
            this.CmdAdd.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.CmdAdd.Image = global::PlasticosCerriDeposito.Properties.Resources.add_16;
            this.CmdAdd.Location = new System.Drawing.Point(715, 72);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(35, 35);
            this.CmdAdd.TabIndex = 7;
            this.CmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // cmdDel
            // 
            this.cmdDel.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.cmdDel.Image = global::PlasticosCerriDeposito.Properties.Resources.del_16;
            this.cmdDel.Location = new System.Drawing.Point(756, 72);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(35, 35);
            this.cmdDel.TabIndex = 9;
            this.cmdDel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdDel.UseVisualStyleBackColor = true;
            this.cmdDel.Click += new System.EventHandler(this.CmdDel_Click);
            // 
            // CboArticulo
            // 
            this.CboArticulo.DropDownWidth = 320;
            this.CboArticulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.CboArticulo.FormattingEnabled = true;
            this.CboArticulo.Location = new System.Drawing.Point(136, 26);
            this.CboArticulo.Name = "CboArticulo";
            this.CboArticulo.Size = new System.Drawing.Size(655, 28);
            this.CboArticulo.TabIndex = 1;
            this.CboArticulo.SelectedIndexChanged += new System.EventHandler(this.CboArticulo_SelectedIndexChanged);
            // 
            // TxtCodArt
            // 
            this.TxtCodArt.Location = new System.Drawing.Point(10, 27);
            this.TxtCodArt.Name = "TxtCodArt";
            this.TxtCodArt.Size = new System.Drawing.Size(120, 27);
            this.TxtCodArt.TabIndex = 0;
            this.TxtCodArt.TextChanged += new System.EventHandler(this.TxtCodArt_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 8);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 16);
            this.label26.TabIndex = 27;
            this.label26.Text = "Cod Art";
            // 
            // Flex
            // 
            this.Flex.AllowUserToAddRows = false;
            this.Flex.AllowUserToDeleteRows = false;
            this.Flex.AllowUserToResizeColumns = false;
            this.Flex.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Flex.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Flex.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Flex.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Flex.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Flex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Flex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Flex.EnableHeadersVisualStyles = false;
            this.Flex.Location = new System.Drawing.Point(10, 113);
            this.Flex.MultiSelect = false;
            this.Flex.Name = "Flex";
            this.Flex.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Flex.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Flex.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Flex.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Flex.RowTemplate.Height = 25;
            this.Flex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Flex.ShowCellErrors = false;
            this.Flex.ShowEditingIcon = false;
            this.Flex.ShowRowErrors = false;
            this.Flex.Size = new System.Drawing.Size(781, 227);
            this.Flex.TabIndex = 10;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(635, 80);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(74, 27);
            this.TxtCantidad.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(632, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Artículo";
            // 
            // CboDeposito
            // 
            this.CboDeposito.DropDownWidth = 320;
            this.CboDeposito.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.CboDeposito.FormattingEnabled = true;
            this.CboDeposito.Location = new System.Drawing.Point(503, 32);
            this.CboDeposito.Name = "CboDeposito";
            this.CboDeposito.Size = new System.Drawing.Size(317, 28);
            this.CboDeposito.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Depósito";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(185, 32);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(115, 27);
            this.DtpFecha.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Fecha";
            // 
            // TxtNumComprobante
            // 
            this.TxtNumComprobante.Location = new System.Drawing.Point(15, 32);
            this.TxtNumComprobante.Name = "TxtNumComprobante";
            this.TxtNumComprobante.Size = new System.Drawing.Size(164, 27);
            this.TxtNumComprobante.TabIndex = 0;
            this.TxtNumComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "N° Comprobante";
            // 
            // CmdImprimir
            // 
            this.CmdImprimir.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.CmdImprimir.Image = global::PlasticosCerriDeposito.Properties.Resources.print_16;
            this.CmdImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdImprimir.Location = new System.Drawing.Point(684, 446);
            this.CmdImprimir.Name = "CmdImprimir";
            this.CmdImprimir.Size = new System.Drawing.Size(65, 40);
            this.CmdImprimir.TabIndex = 6;
            this.CmdImprimir.Text = "&Imprimir";
            this.CmdImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdImprimir.UseVisualStyleBackColor = true;
            this.CmdImprimir.Click += new System.EventHandler(this.CmdImprimir_Click);
            // 
            // CmdGuardar
            // 
            this.CmdGuardar.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.CmdGuardar.Image = global::PlasticosCerriDeposito.Properties.Resources.save_16;
            this.CmdGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdGuardar.Location = new System.Drawing.Point(618, 446);
            this.CmdGuardar.Name = "CmdGuardar";
            this.CmdGuardar.Size = new System.Drawing.Size(60, 40);
            this.CmdGuardar.TabIndex = 5;
            this.CmdGuardar.Text = "&Guardar";
            this.CmdGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdGuardar.UseVisualStyleBackColor = true;
            this.CmdGuardar.Click += new System.EventHandler(this.CmdGuardar_Click);
            // 
            // SalidaStockCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 498);
            this.Controls.Add(this.CboDeposito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboTipo);
            this.Controls.Add(this.CmdSalir);
            this.Controls.Add(this.CmdImprimir);
            this.Controls.Add(this.CmdGuardar);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNumComprobante);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SalidaStockCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Salida de Stock";
            this.Load += new System.EventHandler(this.SalidaStockCarga_Load);
            this.TabControl1.ResumeLayout(false);
            this.Articulos.ResumeLayout(false);
            this.Articulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Flex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox CboTipo;
        public System.Windows.Forms.Button CmdSalir;
        public System.Windows.Forms.Button CmdImprimir;
        public System.Windows.Forms.Button CmdGuardar;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage Articulos;
        public System.Windows.Forms.Button CmdAdd;
        public System.Windows.Forms.Button cmdDel;
        public System.Windows.Forms.ComboBox CboArticulo;
        public System.Windows.Forms.TextBox TxtCodArt;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView Flex;
        public System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtNumComprobante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblCapacidadDisponible;
        private System.Windows.Forms.Label LblCapacidadTotal;
        private System.Windows.Forms.Label LblStockActual;
        public System.Windows.Forms.ComboBox CboPosicion;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox CboDeposito;
        private System.Windows.Forms.Label label5;
    }
}