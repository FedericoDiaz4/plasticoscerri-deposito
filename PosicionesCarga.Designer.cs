
namespace PlasticosCerriDeposito
{
    partial class PosicionesCarga
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.CmdGuardar = new System.Windows.Forms.Button();
            this.CmdSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCapacidad = new System.Windows.Forms.TextBox();
            this.CboDeposito = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripcion";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.TxtDescripcion.Location = new System.Drawing.Point(87, 28);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(440, 26);
            this.TxtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.TxtCodigo.Location = new System.Drawing.Point(12, 28);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(69, 26);
            this.TxtCodigo.TabIndex = 0;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // CmdGuardar
            // 
            this.CmdGuardar.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.CmdGuardar.Image = global::PlasticosCerriDeposito.Properties.Resources.save_16;
            this.CmdGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdGuardar.Location = new System.Drawing.Point(389, 62);
            this.CmdGuardar.Name = "CmdGuardar";
            this.CmdGuardar.Size = new System.Drawing.Size(66, 40);
            this.CmdGuardar.TabIndex = 4;
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
            this.CmdSalir.Location = new System.Drawing.Point(461, 62);
            this.CmdSalir.Name = "CmdSalir";
            this.CmdSalir.Size = new System.Drawing.Size(66, 40);
            this.CmdSalir.TabIndex = 5;
            this.CmdSalir.Text = "&Salir";
            this.CmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdSalir.UseVisualStyleBackColor = true;
            this.CmdSalir.Click += new System.EventHandler(this.CmdSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Capacidad";
            // 
            // TxtCapacidad
            // 
            this.TxtCapacidad.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.TxtCapacidad.Location = new System.Drawing.Point(173, 74);
            this.TxtCapacidad.Name = "TxtCapacidad";
            this.TxtCapacidad.Size = new System.Drawing.Size(88, 26);
            this.TxtCapacidad.TabIndex = 3;
            this.TxtCapacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCapacidad_KeyPress);
            // 
            // CboDeposito
            // 
            this.CboDeposito.DropDownWidth = 320;
            this.CboDeposito.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.CboDeposito.FormattingEnabled = true;
            this.CboDeposito.Location = new System.Drawing.Point(12, 72);
            this.CboDeposito.Name = "CboDeposito";
            this.CboDeposito.Size = new System.Drawing.Size(155, 28);
            this.CboDeposito.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Deposito";
            // 
            // PosicionesCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 114);
            this.Controls.Add(this.CboDeposito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCapacidad);
            this.Controls.Add(this.CmdGuardar);
            this.Controls.Add(this.CmdSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCodigo);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PosicionesCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posicion";
            this.Load += new System.EventHandler(this.PosicionesCarga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Button CmdGuardar;
        private System.Windows.Forms.Button CmdSalir;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtCapacidad;
        public System.Windows.Forms.ComboBox CboDeposito;
        private System.Windows.Forms.Label label4;
    }
}