namespace pryPereiroSP1AutoCor
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlRepuesto = new System.Windows.Forms.Panel();
            this.rdbImportado = new System.Windows.Forms.RadioButton();
            this.rdbNacional = new System.Windows.Forms.RadioButton();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.pnlRepuesto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(130, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(130, 26);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(130, 268);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(130, 26);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(27, 47);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 112);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(27, 192);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 20);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(27, 268);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(27, 341);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(56, 20);
            this.lblOrigen.TabIndex = 8;
            this.lblOrigen.Text = "Origen";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(549, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 44);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(549, 40);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 44);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(549, 231);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(121, 44);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(549, 329);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 44);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlRepuesto
            // 
            this.pnlRepuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRepuesto.Controls.Add(this.rdbImportado);
            this.pnlRepuesto.Controls.Add(this.lblCodigo);
            this.pnlRepuesto.Controls.Add(this.rdbNacional);
            this.pnlRepuesto.Controls.Add(this.txtCodigo);
            this.pnlRepuesto.Controls.Add(this.cmbMarca);
            this.pnlRepuesto.Controls.Add(this.txtNombre);
            this.pnlRepuesto.Controls.Add(this.txtPrecio);
            this.pnlRepuesto.Controls.Add(this.lblNombre);
            this.pnlRepuesto.Controls.Add(this.lblMarca);
            this.pnlRepuesto.Controls.Add(this.lblPrecio);
            this.pnlRepuesto.Controls.Add(this.lblOrigen);
            this.pnlRepuesto.Location = new System.Drawing.Point(12, 32);
            this.pnlRepuesto.Name = "pnlRepuesto";
            this.pnlRepuesto.Size = new System.Drawing.Size(500, 394);
            this.pnlRepuesto.TabIndex = 13;
            // 
            // rdbImportado
            // 
            this.rdbImportado.AutoSize = true;
            this.rdbImportado.Location = new System.Drawing.Point(293, 339);
            this.rdbImportado.Name = "rdbImportado";
            this.rdbImportado.Size = new System.Drawing.Size(107, 24);
            this.rdbImportado.TabIndex = 16;
            this.rdbImportado.TabStop = true;
            this.rdbImportado.Text = "Importado";
            this.rdbImportado.UseVisualStyleBackColor = true;
            // 
            // rdbNacional
            // 
            this.rdbNacional.AutoSize = true;
            this.rdbNacional.Location = new System.Drawing.Point(134, 337);
            this.rdbNacional.Name = "rdbNacional";
            this.rdbNacional.Size = new System.Drawing.Size(95, 24);
            this.rdbNacional.TabIndex = 15;
            this.rdbNacional.TabStop = true;
            this.rdbNacional.Text = "Nacional";
            this.rdbNacional.UseVisualStyleBackColor = true;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(130, 192);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(272, 28);
            this.cmbMarca.TabIndex = 14;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlRepuesto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTOCOR - Repuesto";
            this.pnlRepuesto.ResumeLayout(false);
            this.pnlRepuesto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlRepuesto;
        private System.Windows.Forms.RadioButton rdbImportado;
        private System.Windows.Forms.RadioButton rdbNacional;
        private System.Windows.Forms.ComboBox cmbMarca;
    }
}

