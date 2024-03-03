namespace Salon
{
    partial class FrmClientes
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnModificarC = new System.Windows.Forms.Button();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.btnNuevoC = new System.Windows.Forms.Button();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.btnCitaC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(42, 60);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(0, 20);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCitaC);
            this.splitContainer1.Panel1.Controls.Add(this.btnModificarC);
            this.splitContainer1.Panel1.Controls.Add(this.btnEliminarC);
            this.splitContainer1.Panel1.Controls.Add(this.btnNuevoC);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgClientes);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnModificarC
            // 
            this.btnModificarC.Location = new System.Drawing.Point(46, 146);
            this.btnModificarC.Name = "btnModificarC";
            this.btnModificarC.Size = new System.Drawing.Size(75, 23);
            this.btnModificarC.TabIndex = 3;
            this.btnModificarC.Text = "Modificar";
            this.btnModificarC.UseVisualStyleBackColor = true;
            this.btnModificarC.Click += new System.EventHandler(this.btnModificarC_Click);
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.Location = new System.Drawing.Point(46, 192);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarC.TabIndex = 2;
            this.btnEliminarC.Text = "Eliminar";
            this.btnEliminarC.UseVisualStyleBackColor = true;
            this.btnEliminarC.Click += new System.EventHandler(this.btnEliminarC_Click);
            // 
            // btnNuevoC
            // 
            this.btnNuevoC.Location = new System.Drawing.Point(46, 96);
            this.btnNuevoC.Name = "btnNuevoC";
            this.btnNuevoC.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoC.TabIndex = 1;
            this.btnNuevoC.Text = "Nuevo";
            this.btnNuevoC.UseVisualStyleBackColor = true;
            this.btnNuevoC.Click += new System.EventHandler(this.btnNuevoC_Click);
            // 
            // dtgClientes
            // 
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgClientes.Location = new System.Drawing.Point(0, 0);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.Size = new System.Drawing.Size(601, 450);
            this.dtgClientes.TabIndex = 0;
            this.dtgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellContentClick);
            // 
            // btnCitaC
            // 
            this.btnCitaC.Location = new System.Drawing.Point(46, 237);
            this.btnCitaC.Name = "btnCitaC";
            this.btnCitaC.Size = new System.Drawing.Size(75, 23);
            this.btnCitaC.TabIndex = 4;
            this.btnCitaC.Text = "Agendar";
            this.btnCitaC.UseVisualStyleBackColor = true;
            this.btnCitaC.Click += new System.EventHandler(this.btnCitaC_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lbNombre);
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnModificarC;
        private System.Windows.Forms.Button btnEliminarC;
        private System.Windows.Forms.Button btnNuevoC;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Button btnCitaC;
    }
}