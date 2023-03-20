
namespace PlasticosCerriDeposito
{
    partial class IngresoStockList
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
            this.FrmBotones = new System.Windows.Forms.GroupBox();
            this.CmdSalir = new System.Windows.Forms.Button();
            this.CmdModificar = new System.Windows.Forms.Button();
            this.CmdNuevo = new System.Windows.Forms.Button();
            this.Flex = new System.Windows.Forms.DataGridView();
            this.FrmBuscar = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.CmdBuscar = new System.Windows.Forms.Button();
            this.DtpHasta = new System.Windows.Forms.DateTimePicker();
            this.DtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CboTipoComprobante = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FrmBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Flex)).BeginInit();
            this.FrmBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // FrmBotones
            // 
            this.FrmBotones.Controls.Add(this.CmdSalir);
            this.FrmBotones.Controls.Add(this.CmdModificar);
            this.FrmBotones.Controls.Add(this.CmdNuevo);
            this.FrmBotones.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.FrmBotones.Location = new System.Drawing.Point(710, 427);
            this.FrmBotones.Name = "FrmBotones";
            this.FrmBotones.Size = new System.Drawing.Size(225, 72);
            this.FrmBotones.TabIndex = 2;
            this.FrmBotones.TabStop = false;
            // 
            // CmdSalir
            // 
            this.CmdSalir.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.CmdSalir.Image = global::PlasticosCerriDeposito.Properties.Resources.exit;
            this.CmdSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdSalir.Location = new System.Drawing.Point(150, 23);
            this.CmdSalir.Name = "CmdSalir";
            this.CmdSalir.Size = new System.Drawing.Size(66, 40);
            this.CmdSalir.TabIndex = 2;
            this.CmdSalir.Text = "&Salir";
            this.CmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdSalir.UseVisualStyleBackColor = true;
            this.CmdSalir.Click += new System.EventHandler(this.CmdSalir_Click);
            // 
            // CmdModificar
            // 
            this.CmdModificar.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.CmdModificar.Image = global::PlasticosCerriDeposito.Properties.Resources.srch_16;
            this.CmdModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdModificar.Location = new System.Drawing.Point(78, 23);
            this.CmdModificar.Name = "CmdModificar";
            this.CmdModificar.Size = new System.Drawing.Size(66, 40);
            this.CmdModificar.TabIndex = 1;
            this.CmdModificar.Text = "&Ver";
            this.CmdModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdModificar.UseVisualStyleBackColor = true;
            this.CmdModificar.Click += new System.EventHandler(this.CmdModificar_Click);
            // 
            // CmdNuevo
            // 
            this.CmdNuevo.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.CmdNuevo.Image = global::PlasticosCerriDeposito.Properties.Resources.add_16;
            this.CmdNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdNuevo.Location = new System.Drawing.Point(6, 23);
            this.CmdNuevo.Name = "CmdNuevo";
            this.CmdNuevo.Size = new System.Drawing.Size(66, 40);
            this.CmdNuevo.TabIndex = 0;
            this.CmdNuevo.Text = "&Nuevo";
            this.CmdNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdNuevo.UseVisualStyleBackColor = true;
            this.CmdNuevo.Click += new System.EventHandler(this.CmdNuevo_Click);
            // 
            // Flex
            // 
            this.Flex.AllowUserToAddRows = false;
            this.Flex.AllowUserToDeleteRows = false;
            this.Flex.AllowUserToOrderColumns = true;
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
            this.Flex.Location = new System.Drawing.Point(11, 96);
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
            this.Flex.Size = new System.Drawing.Size(924, 325);
            this.Flex.TabIndex = 1;
            this.Flex.DoubleClick += new System.EventHandler(this.Flex_DoubleClick);
            this.Flex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Flex_KeyPress);
            // 
            // FrmBuscar
            // 
            this.FrmBuscar.Controls.Add(this.label6);
            this.FrmBuscar.Controls.Add(this.TxtNumero);
            this.FrmBuscar.Controls.Add(this.CmdBuscar);
            this.FrmBuscar.Controls.Add(this.DtpHasta);
            this.FrmBuscar.Controls.Add(this.DtpDesde);
            this.FrmBuscar.Controls.Add(this.label3);
            this.FrmBuscar.Controls.Add(this.label2);
            this.FrmBuscar.Controls.Add(this.CboTipoComprobante);
            this.FrmBuscar.Controls.Add(this.label1);
            this.FrmBuscar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.FrmBuscar.Location = new System.Drawing.Point(11, 14);
            this.FrmBuscar.Name = "FrmBuscar";
            this.FrmBuscar.Size = new System.Drawing.Size(924, 76);
            this.FrmBuscar.TabIndex = 0;
            this.FrmBuscar.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Numero";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.TxtNumero.Location = new System.Drawing.Point(423, 41);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(140, 26);
            this.TxtNumero.TabIndex = 3;
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // CmdBuscar
            // 
            this.CmdBuscar.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.CmdBuscar.Image = global::PlasticosCerriDeposito.Properties.Resources.srch_16;
            this.CmdBuscar.Location = new System.Drawing.Point(873, 41);
            this.CmdBuscar.Name = "CmdBuscar";
            this.CmdBuscar.Size = new System.Drawing.Size(42, 29);
            this.CmdBuscar.TabIndex = 4;
            this.CmdBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdBuscar.UseVisualStyleBackColor = true;
            this.CmdBuscar.Click += new System.EventHandler(this.CmdBuscar_Click);
            // 
            // DtpHasta
            // 
            this.DtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpHasta.Location = new System.Drawing.Point(300, 41);
            this.DtpHasta.Name = "DtpHasta";
            this.DtpHasta.Size = new System.Drawing.Size(117, 27);
            this.DtpHasta.TabIndex = 2;
            // 
            // DtpDesde
            // 
            this.DtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDesde.Location = new System.Drawing.Point(178, 41);
            this.DtpDesde.Name = "DtpDesde";
            this.DtpDesde.Size = new System.Drawing.Size(116, 27);
            this.DtpDesde.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Desde";
            // 
            // CboTipoComprobante
            // 
            this.CboTipoComprobante.DropDownHeight = 200;
            this.CboTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoComprobante.DropDownWidth = 200;
            this.CboTipoComprobante.FormattingEnabled = true;
            this.CboTipoComprobante.IntegralHeight = false;
            this.CboTipoComprobante.Items.AddRange(new object[] {
            "ENTRADA"});
            this.CboTipoComprobante.Location = new System.Drawing.Point(6, 44);
            this.CboTipoComprobante.Name = "CboTipoComprobante";
            this.CboTipoComprobante.Size = new System.Drawing.Size(166, 24);
            this.CboTipoComprobante.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Comprobante";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IngresoStockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 513);
            this.Controls.Add(this.FrmBotones);
            this.Controls.Add(this.Flex);
            this.Controls.Add(this.FrmBuscar);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IngresoStockList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresos de Stock";
            this.FrmBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Flex)).EndInit();
            this.FrmBuscar.ResumeLayout(false);
            this.FrmBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FrmBotones;
        private System.Windows.Forms.Button CmdSalir;
        private System.Windows.Forms.Button CmdModificar;
        private System.Windows.Forms.Button CmdNuevo;
        private System.Windows.Forms.DataGridView Flex;
        private System.Windows.Forms.GroupBox FrmBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNumero;
        public System.Windows.Forms.Button CmdBuscar;
        private System.Windows.Forms.DateTimePicker DtpHasta;
        private System.Windows.Forms.DateTimePicker DtpDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboTipoComprobante;
        private System.Windows.Forms.Label label1;
    }
}