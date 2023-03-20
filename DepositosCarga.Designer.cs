
namespace PlasticosCerriDeposito
{
    partial class DepositosCarga
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
            this.CmdGuardar.TabIndex = 2;
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
            this.CmdSalir.TabIndex = 3;
            this.CmdSalir.Text = "&Salir";
            this.CmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdSalir.UseVisualStyleBackColor = true;
            this.CmdSalir.Click += new System.EventHandler(this.CmdSalir_Click);
            // 
            // DepositosCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 114);
            this.Controls.Add(this.CmdGuardar);
            this.Controls.Add(this.CmdSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCodigo);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepositosCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposito";
            this.Load += new System.EventHandler(this.DepositosCarga_Load);
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
    }
}