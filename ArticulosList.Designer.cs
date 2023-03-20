
namespace PlasticosCerriDeposito
{
    partial class ArticulosList
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
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.CmdExcel = new System.Windows.Forms.Button();
            this.FrmBotones = new System.Windows.Forms.GroupBox();
            this.CmdSalir = new System.Windows.Forms.Button();
            this.CmdEliminar = new System.Windows.Forms.Button();
            this.CmdModificar = new System.Windows.Forms.Button();
            this.CmdNuevo = new System.Windows.Forms.Button();
            this.Flex = new System.Windows.Forms.DataGridView();
            this.FrmBuscar = new System.Windows.Forms.GroupBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CboBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FrmBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Flex)).BeginInit();
            this.FrmBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(12, 494);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(837, 23);
            this.pBar.Step = 1;
            this.pBar.TabIndex = 4;
            // 
            // CmdExcel
            // 
            this.CmdExcel.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdExcel.Image = global::PlasticosCerriDeposito.Properties.Resources.exp_16;
            this.CmdExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdExcel.Location = new System.Drawing.Point(12, 439);
            this.CmdExcel.Name = "CmdExcel";
            this.CmdExcel.Size = new System.Drawing.Size(66, 40);
            this.CmdExcel.TabIndex = 2;
            this.CmdExcel.Text = "&Excel";
            this.CmdExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdExcel.UseVisualStyleBackColor = true;
            this.CmdExcel.Click += new System.EventHandler(this.CmdExcel_Click);
            // 
            // FrmBotones
            // 
            this.FrmBotones.Controls.Add(this.CmdSalir);
            this.FrmBotones.Controls.Add(this.CmdEliminar);
            this.FrmBotones.Controls.Add(this.CmdModificar);
            this.FrmBotones.Controls.Add(this.CmdNuevo);
            this.FrmBotones.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.FrmBotones.Location = new System.Drawing.Point(550, 416);
            this.FrmBotones.Name = "FrmBotones";
            this.FrmBotones.Size = new System.Drawing.Size(295, 72);
            this.FrmBotones.TabIndex = 3;
            this.FrmBotones.TabStop = false;
            // 
            // CmdSalir
            // 
            this.CmdSalir.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.CmdSalir.Image = global::PlasticosCerriDeposito.Properties.Resources.exit;
            this.CmdSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdSalir.Location = new System.Drawing.Point(222, 23);
            this.CmdSalir.Name = "CmdSalir";
            this.CmdSalir.Size = new System.Drawing.Size(66, 40);
            this.CmdSalir.TabIndex = 3;
            this.CmdSalir.Text = "&Salir";
            this.CmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdSalir.UseVisualStyleBackColor = true;
            this.CmdSalir.Click += new System.EventHandler(this.CmdSalir_Click);
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.CmdEliminar.Image = global::PlasticosCerriDeposito.Properties.Resources.del_16;
            this.CmdEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdEliminar.Location = new System.Drawing.Point(150, 23);
            this.CmdEliminar.Name = "CmdEliminar";
            this.CmdEliminar.Size = new System.Drawing.Size(66, 40);
            this.CmdEliminar.TabIndex = 2;
            this.CmdEliminar.Text = "&Eliminar";
            this.CmdEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdEliminar.UseVisualStyleBackColor = true;
            this.CmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // CmdModificar
            // 
            this.CmdModificar.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.CmdModificar.Image = global::PlasticosCerriDeposito.Properties.Resources.edit_16;
            this.CmdModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdModificar.Location = new System.Drawing.Point(78, 23);
            this.CmdModificar.Name = "CmdModificar";
            this.CmdModificar.Size = new System.Drawing.Size(66, 40);
            this.CmdModificar.TabIndex = 1;
            this.CmdModificar.Text = "&Modificar";
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
            this.Flex.Location = new System.Drawing.Point(12, 85);
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
            this.Flex.Size = new System.Drawing.Size(836, 325);
            this.Flex.TabIndex = 1;
            this.Flex.DoubleClick += new System.EventHandler(this.Flex_DoubleClick);
            this.Flex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Flex_KeyPress);
            // 
            // FrmBuscar
            // 
            this.FrmBuscar.Controls.Add(this.TxtBuscar);
            this.FrmBuscar.Controls.Add(this.CboBuscar);
            this.FrmBuscar.Controls.Add(this.label1);
            this.FrmBuscar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.FrmBuscar.Location = new System.Drawing.Point(12, 3);
            this.FrmBuscar.Name = "FrmBuscar";
            this.FrmBuscar.Size = new System.Drawing.Size(837, 76);
            this.FrmBuscar.TabIndex = 0;
            this.FrmBuscar.TabStop = false;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.TxtBuscar.Location = new System.Drawing.Point(123, 42);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(700, 26);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // CboBuscar
            // 
            this.CboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBuscar.DropDownWidth = 111;
            this.CboBuscar.FormattingEnabled = true;
            this.CboBuscar.Items.AddRange(new object[] {
            "CODIGO SKU",
            "CODIGO ML",
            "DESCRIPCION"});
            this.CboBuscar.Location = new System.Drawing.Point(6, 42);
            this.CboBuscar.Name = "CboBuscar";
            this.CboBuscar.Size = new System.Drawing.Size(111, 24);
            this.CboBuscar.TabIndex = 0;
            this.CboBuscar.SelectedIndexChanged += new System.EventHandler(this.CboBuscar_SelectedIndexChanged);
            this.CboBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // ArticulosList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 521);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.CmdExcel);
            this.Controls.Add(this.FrmBotones);
            this.Controls.Add(this.Flex);
            this.Controls.Add(this.FrmBuscar);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ArticulosList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.FrmBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Flex)).EndInit();
            this.FrmBuscar.ResumeLayout(false);
            this.FrmBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar pBar;
        internal System.Windows.Forms.Button CmdExcel;
        private System.Windows.Forms.GroupBox FrmBotones;
        private System.Windows.Forms.Button CmdSalir;
        private System.Windows.Forms.Button CmdEliminar;
        private System.Windows.Forms.Button CmdModificar;
        private System.Windows.Forms.Button CmdNuevo;
        private System.Windows.Forms.DataGridView Flex;
        private System.Windows.Forms.GroupBox FrmBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.ComboBox CboBuscar;
        private System.Windows.Forms.Label label1;
    }
}