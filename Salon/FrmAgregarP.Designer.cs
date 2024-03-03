namespace Salon
{
    partial class FrmAgregarP
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
            this.lbNombreP = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.lbUnidadC = new System.Windows.Forms.Label();
            this.lbPrecioC = new System.Windows.Forms.Label();
            this.txtPrecioP = new System.Windows.Forms.TextBox();
            this.lbCantidadC = new System.Windows.Forms.Label();
            this.txtCantidadP = new System.Windows.Forms.TextBox();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.cmbUnidadP = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbNombreP
            // 
            this.lbNombreP.AutoSize = true;
            this.lbNombreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreP.Location = new System.Drawing.Point(38, 35);
            this.lbNombreP.Name = "lbNombreP";
            this.lbNombreP.Size = new System.Drawing.Size(65, 20);
            this.lbNombreP.TabIndex = 4;
            this.lbNombreP.Text = "Nombre";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(133, 35);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(119, 20);
            this.txtNombreP.TabIndex = 8;
            // 
            // lbUnidadC
            // 
            this.lbUnidadC.AutoSize = true;
            this.lbUnidadC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnidadC.Location = new System.Drawing.Point(38, 65);
            this.lbUnidadC.Name = "lbUnidadC";
            this.lbUnidadC.Size = new System.Drawing.Size(60, 20);
            this.lbUnidadC.TabIndex = 9;
            this.lbUnidadC.Text = "Unidad";
            // 
            // lbPrecioC
            // 
            this.lbPrecioC.AutoSize = true;
            this.lbPrecioC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioC.Location = new System.Drawing.Point(38, 124);
            this.lbPrecioC.Name = "lbPrecioC";
            this.lbPrecioC.Size = new System.Drawing.Size(53, 20);
            this.lbPrecioC.TabIndex = 12;
            this.lbPrecioC.Text = "Precio";
            // 
            // txtPrecioP
            // 
            this.txtPrecioP.Location = new System.Drawing.Point(133, 127);
            this.txtPrecioP.Name = "txtPrecioP";
            this.txtPrecioP.Size = new System.Drawing.Size(119, 20);
            this.txtPrecioP.TabIndex = 13;
            // 
            // lbCantidadC
            // 
            this.lbCantidadC.AutoSize = true;
            this.lbCantidadC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidadC.Location = new System.Drawing.Point(38, 95);
            this.lbCantidadC.Name = "lbCantidadC";
            this.lbCantidadC.Size = new System.Drawing.Size(73, 20);
            this.lbCantidadC.TabIndex = 14;
            this.lbCantidadC.Text = "Cantidad";
            // 
            // txtCantidadP
            // 
            this.txtCantidadP.Location = new System.Drawing.Point(133, 95);
            this.txtCantidadP.Name = "txtCantidadP";
            this.txtCantidadP.Size = new System.Drawing.Size(119, 20);
            this.txtCantidadP.TabIndex = 15;
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.Location = new System.Drawing.Point(278, 169);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(89, 37);
            this.btnGuardarP.TabIndex = 16;
            this.btnGuardarP.Text = "Guardar";
            this.btnGuardarP.UseVisualStyleBackColor = true;
            this.btnGuardarP.Click += new System.EventHandler(this.btnGuardarP_Click);
            // 
            // cmbUnidadP
            // 
            this.cmbUnidadP.FormattingEnabled = true;
            this.cmbUnidadP.Items.AddRange(new object[] {
            "pza",
            "paquete"});
            this.cmbUnidadP.Location = new System.Drawing.Point(133, 61);
            this.cmbUnidadP.Name = "cmbUnidadP";
            this.cmbUnidadP.Size = new System.Drawing.Size(121, 21);
            this.cmbUnidadP.TabIndex = 17;
            // 
            // FrmAgregarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 268);
            this.Controls.Add(this.cmbUnidadP);
            this.Controls.Add(this.btnGuardarP);
            this.Controls.Add(this.txtCantidadP);
            this.Controls.Add(this.lbCantidadC);
            this.Controls.Add(this.txtPrecioP);
            this.Controls.Add(this.lbPrecioC);
            this.Controls.Add(this.lbUnidadC);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.lbNombreP);
            this.Name = "FrmAgregarP";
            this.Text = "FrmAgregarP";
            this.Load += new System.EventHandler(this.FrmAgregarP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombreP;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label lbUnidadC;
        private System.Windows.Forms.Label lbPrecioC;
        private System.Windows.Forms.TextBox txtPrecioP;
        private System.Windows.Forms.Label lbCantidadC;
        private System.Windows.Forms.TextBox txtCantidadP;
        private System.Windows.Forms.Button btnGuardarP;
        private System.Windows.Forms.ComboBox cmbUnidadP;
    }
}