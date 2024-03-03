namespace Salon
{
    partial class FrmAgregarC
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnGuardarC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(37, 38);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(65, 20);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(137, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidos.Location = new System.Drawing.Point(37, 69);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(73, 20);
            this.lbApellidos.TabIndex = 8;
            this.lbApellidos.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(121, 71);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(137, 20);
            this.txtApellidos.TabIndex = 10;
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.Location = new System.Drawing.Point(37, 101);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(57, 20);
            this.lbCorreo.TabIndex = 11;
            this.lbCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(121, 97);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(137, 20);
            this.txtCorreo.TabIndex = 12;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.Location = new System.Drawing.Point(39, 131);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(71, 20);
            this.lbTelefono.TabIndex = 13;
            this.lbTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(121, 131);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(137, 20);
            this.txtTelefono.TabIndex = 14;
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.Location = new System.Drawing.Point(272, 183);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarC.TabIndex = 15;
            this.btnGuardarC.Text = "Guardar";
            this.btnGuardarC.UseVisualStyleBackColor = true;
            this.btnGuardarC.Click += new System.EventHandler(this.btnGuardarC_Click);
            // 
            // FrmAgregarC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 270);
            this.Controls.Add(this.btnGuardarC);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lbCorreo);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lbApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.Name = "FrmAgregarC";
            this.Text = "FrmAgregarC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnGuardarC;
    }
}