namespace Salon
{
    partial class FrmProductosServicios
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnModificarP = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.dtgProductosServicios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnModificarP);
            this.splitContainer1.Panel1.Controls.Add(this.btnEliminarP);
            this.splitContainer1.Panel1.Controls.Add(this.btnAgregarP);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgProductosServicios);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnModificarP
            // 
            this.btnModificarP.Location = new System.Drawing.Point(50, 118);
            this.btnModificarP.Name = "btnModificarP";
            this.btnModificarP.Size = new System.Drawing.Size(75, 23);
            this.btnModificarP.TabIndex = 2;
            this.btnModificarP.Text = "Modificar";
            this.btnModificarP.UseVisualStyleBackColor = true;
            this.btnModificarP.Click += new System.EventHandler(this.btnModificarP_Click);
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Location = new System.Drawing.Point(50, 167);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarP.TabIndex = 1;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.UseVisualStyleBackColor = true;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(50, 68);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarP.TabIndex = 0;
            this.btnAgregarP.Text = "Nuevo";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // dtgProductosServicios
            // 
            this.dtgProductosServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductosServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgProductosServicios.Location = new System.Drawing.Point(0, 0);
            this.dtgProductosServicios.Name = "dtgProductosServicios";
            this.dtgProductosServicios.Size = new System.Drawing.Size(604, 450);
            this.dtgProductosServicios.TabIndex = 0;
            this.dtgProductosServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductosServicios_CellContentClick);
            // 
            // FrmProductosServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmProductosServicios";
            this.Text = "FrmProductosServicios";
            this.Load += new System.EventHandler(this.FrmProductosServicios_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dtgProductosServicios;
        private System.Windows.Forms.Button btnModificarP;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Button btnAgregarP;
    }
}