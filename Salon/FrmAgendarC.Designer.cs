namespace Salon
{
    partial class FrmAgendarC
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
            this.mcAgregarC = new System.Windows.Forms.MonthCalendar();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mcAgregarC
            // 
            this.mcAgregarC.Location = new System.Drawing.Point(101, 36);
            this.mcAgregarC.Name = "mcAgregarC";
            this.mcAgregarC.TabIndex = 0;
            // 
            // cmbCliente
            // 
            this.cmbCliente.AllowDrop = true;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(53, 233);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 1;
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(278, 233);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(121, 21);
            this.cmbServicio.TabIndex = 2;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(53, 294);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(121, 20);
            this.txtHora.TabIndex = 3;
            // 
            // FrmAgendarC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 363);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.mcAgregarC);
            this.Name = "FrmAgendarC";
            this.Text = "FrmAgendarC";
            this.Load += new System.EventHandler(this.FrmAgendarC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcAgregarC;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.TextBox txtHora;
    }
}