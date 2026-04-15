namespace pryPereiroSP1AutoCor
{
    partial class frmConsultar
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
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.rdbNacional = new System.Windows.Forms.RadioButton();
            this.rdbImportado = new System.Windows.Forms.RadioButton();
            this.rdbAmbos = new System.Windows.Forms.RadioButton();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(83, 30);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(335, 28);
            this.cmbMarca.TabIndex = 0;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(664, 21);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(108, 44);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "&Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(664, 89);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 44);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmMarca,
            this.clmOrigen,
            this.clmPrecio});
            this.dgvConsulta.Location = new System.Drawing.Point(16, 158);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.RowHeadersWidth = 62;
            this.dgvConsulta.RowTemplate.Height = 28;
            this.dgvConsulta.Size = new System.Drawing.Size(772, 280);
            this.dgvConsulta.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 33);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 20);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(14, 99);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(56, 20);
            this.lblOrigen.TabIndex = 5;
            this.lblOrigen.Text = "Origen";
            // 
            // rdbNacional
            // 
            this.rdbNacional.AutoSize = true;
            this.rdbNacional.Location = new System.Drawing.Point(83, 99);
            this.rdbNacional.Name = "rdbNacional";
            this.rdbNacional.Size = new System.Drawing.Size(95, 24);
            this.rdbNacional.TabIndex = 6;
            this.rdbNacional.TabStop = true;
            this.rdbNacional.Text = "Nacional";
            this.rdbNacional.UseVisualStyleBackColor = true;
            // 
            // rdbImportado
            // 
            this.rdbImportado.AutoSize = true;
            this.rdbImportado.Location = new System.Drawing.Point(208, 99);
            this.rdbImportado.Name = "rdbImportado";
            this.rdbImportado.Size = new System.Drawing.Size(107, 24);
            this.rdbImportado.TabIndex = 7;
            this.rdbImportado.TabStop = true;
            this.rdbImportado.Text = "Importado";
            this.rdbImportado.UseVisualStyleBackColor = true;
            // 
            // rdbAmbos
            // 
            this.rdbAmbos.AutoSize = true;
            this.rdbAmbos.Location = new System.Drawing.Point(344, 99);
            this.rdbAmbos.Name = "rdbAmbos";
            this.rdbAmbos.Size = new System.Drawing.Size(84, 24);
            this.rdbAmbos.TabIndex = 8;
            this.rdbAmbos.TabStop = true;
            this.rdbAmbos.Text = "Ambos";
            this.rdbAmbos.UseVisualStyleBackColor = true;
            // 
            // clmCodigo
            // 
            this.clmCodigo.FillWeight = 105.9322F;
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.MinimumWidth = 8;
            this.clmCodigo.Name = "clmCodigo";
            // 
            // clmNombre
            // 
            this.clmNombre.FillWeight = 102.2687F;
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.MinimumWidth = 8;
            this.clmNombre.Name = "clmNombre";
            // 
            // clmMarca
            // 
            this.clmMarca.FillWeight = 99.38132F;
            this.clmMarca.HeaderText = "Marca";
            this.clmMarca.MinimumWidth = 8;
            this.clmMarca.Name = "clmMarca";
            // 
            // clmOrigen
            // 
            this.clmOrigen.FillWeight = 97.10566F;
            this.clmOrigen.HeaderText = "Origen";
            this.clmOrigen.MinimumWidth = 8;
            this.clmOrigen.Name = "clmOrigen";
            // 
            // clmPrecio
            // 
            this.clmPrecio.FillWeight = 95.31216F;
            this.clmPrecio.HeaderText = "Precio";
            this.clmPrecio.MinimumWidth = 8;
            this.clmPrecio.Name = "clmPrecio";
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.rdbAmbos);
            this.Controls.Add(this.rdbImportado);
            this.Controls.Add(this.rdbNacional);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.cmbMarca);
            this.Name = "frmConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTOCOR - Consultar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.RadioButton rdbNacional;
        private System.Windows.Forms.RadioButton rdbImportado;
        private System.Windows.Forms.RadioButton rdbAmbos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
    }
}