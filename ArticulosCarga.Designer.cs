
namespace PlasticosCerriDeposito
{
    partial class ArticulosCarga
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
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdGuardar = new System.Windows.Forms.Button();
            this.CmdSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigoSKU = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtStockMinimo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CboTipoProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigoCerri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.TxtDescripcion.Location = new System.Drawing.Point(124, 29);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(514, 26);
            this.TxtDescripcion.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descripción";
            // 
            // CmdGuardar
            // 
            this.CmdGuardar.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.CmdGuardar.Image = global::PlasticosCerriDeposito.Properties.Resources.save_16;
            this.CmdGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdGuardar.Location = new System.Drawing.Point(500, 294);
            this.CmdGuardar.Name = "CmdGuardar";
            this.CmdGuardar.Size = new System.Drawing.Size(66, 40);
            this.CmdGuardar.TabIndex = 3;
            this.CmdGuardar.Text = "&Guardar";
            this.CmdGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdGuardar.UseVisualStyleBackColor = true;
            this.CmdGuardar.Click += new System.EventHandler(this.CmdGuardar_Click);
            // 
            // CmdSalir
            // 
            this.CmdSalir.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.CmdSalir.Image = global::PlasticosCerriDeposito.Properties.Resources.exit;
            this.CmdSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdSalir.Location = new System.Drawing.Point(572, 294);
            this.CmdSalir.Name = "CmdSalir";
            this.CmdSalir.Size = new System.Drawing.Size(66, 40);
            this.CmdSalir.TabIndex = 4;
            this.CmdSalir.Text = "&Salir";
            this.CmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdSalir.UseVisualStyleBackColor = true;
            this.CmdSalir.Click += new System.EventHandler(this.CmdSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código SKU";
            // 
            // TxtCodigoSKU
            // 
            this.TxtCodigoSKU.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.TxtCodigoSKU.Location = new System.Drawing.Point(12, 29);
            this.TxtCodigoSKU.Name = "TxtCodigoSKU";
            this.TxtCodigoSKU.Size = new System.Drawing.Size(106, 26);
            this.TxtCodigoSKU.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.TxtStockMinimo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.CboTipoProducto);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TxtCodigoCerri);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 198);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos";
            // 
            // TxtStockMinimo
            // 
            this.TxtStockMinimo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.TxtStockMinimo.Location = new System.Drawing.Point(209, 27);
            this.TxtStockMinimo.Name = "TxtStockMinimo";
            this.TxtStockMinimo.Size = new System.Drawing.Size(197, 26);
            this.TxtStockMinimo.TabIndex = 1;
            this.TxtStockMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStockMinimo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Stock Minimo";
            // 
            // CboTipoProducto
            // 
            this.CboTipoProducto.DropDownWidth = 320;
            this.CboTipoProducto.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.CboTipoProducto.FormattingEnabled = true;
            this.CboTipoProducto.Location = new System.Drawing.Point(412, 27);
            this.CboTipoProducto.Name = "CboTipoProducto";
            this.CboTipoProducto.Size = new System.Drawing.Size(197, 28);
            this.CboTipoProducto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "TipoProducto";
            // 
            // TxtCodigoCerri
            // 
            this.TxtCodigoCerri.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.TxtCodigoCerri.Location = new System.Drawing.Point(6, 27);
            this.TxtCodigoCerri.Name = "TxtCodigoCerri";
            this.TxtCodigoCerri.Size = new System.Drawing.Size(197, 26);
            this.TxtCodigoCerri.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Codigo Cerri";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 227);
            this.tabControl1.TabIndex = 2;
            // 
            // ArticulosCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 345);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmdGuardar);
            this.Controls.Add(this.CmdSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCodigoSKU);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ArticulosCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.ArticulosCarga_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CmdGuardar;
        private System.Windows.Forms.Button CmdSalir;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtCodigoSKU;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox TxtStockMinimo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox CboTipoProducto;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtCodigoCerri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
    }
}