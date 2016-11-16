namespace ControlPolizas
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.Cumpleaños = new System.Windows.Forms.GroupBox();
            this.dtpCumpleanios = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigoPotalDireccion = new System.Windows.Forms.TextBox();
            this.txtEstadoDireccion = new System.Windows.Forms.TextBox();
            this.txtColoniaDireccion = new System.Windows.Forms.TextBox();
            this.txtMuniciopioDireccion = new System.Windows.Forms.TextBox();
            this.txtNumeroCalle = new System.Windows.Forms.TextBox();
            this.txtCalleDireccion = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.Cumpleaños.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCliente.Location = new System.Drawing.Point(402, 400);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCliente.TabIndex = 6;
            this.btnAgregarCliente.Text = "&Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Image = global::ControlPolizas.Properties.Resources.people_1_;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 265);
            this.label1.TabIndex = 2;
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre(s)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RFC";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNombreCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombreCliente.Location = new System.Drawing.Point(268, 47);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(288, 20);
            this.txtNombreCliente.TabIndex = 0;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // txtRFC
            // 
            this.txtRFC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRFC.Location = new System.Drawing.Point(268, 86);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(220, 20);
            this.txtRFC.TabIndex = 1;
            this.txtRFC.TextChanged += new System.EventHandler(this.txtRFC_TextChanged);
            // 
            // Cumpleaños
            // 
            this.Cumpleaños.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cumpleaños.Controls.Add(this.dtpCumpleanios);
            this.Cumpleaños.Location = new System.Drawing.Point(447, 151);
            this.Cumpleaños.Name = "Cumpleaños";
            this.Cumpleaños.Size = new System.Drawing.Size(118, 49);
            this.Cumpleaños.TabIndex = 4;
            this.Cumpleaños.TabStop = false;
            this.Cumpleaños.Text = "Cumpleaños";
            this.Cumpleaños.Enter += new System.EventHandler(this.Cumpleaños_Enter);
            // 
            // dtpCumpleanios
            // 
            this.dtpCumpleanios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCumpleanios.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCumpleanios.Location = new System.Drawing.Point(13, 19);
            this.dtpCumpleanios.Name = "dtpCumpleanios";
            this.dtpCumpleanios.Size = new System.Drawing.Size(97, 20);
            this.dtpCumpleanios.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBuscar.Location = new System.Drawing.Point(245, 400);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Location = new System.Drawing.Point(268, 125);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(220, 20);
            this.txtTelefono.TabIndex = 2;
            this.txtTelefono.UseWaitCursor = true;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Teléfono";
            this.label7.UseWaitCursor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(268, 164);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "E-Mail";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(488, 400);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(12, 400);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(491, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCodigoPotalDireccion);
            this.groupBox1.Controls.Add(this.txtEstadoDireccion);
            this.groupBox1.Controls.Add(this.txtColoniaDireccion);
            this.groupBox1.Controls.Add(this.txtMuniciopioDireccion);
            this.groupBox1.Controls.Add(this.txtNumeroCalle);
            this.groupBox1.Controls.Add(this.txtCalleDireccion);
            this.groupBox1.Location = new System.Drawing.Point(245, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 137);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dirección";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Código Postal";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Municipio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Estado";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Colonia";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Número";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Calle";
            // 
            // txtCodigoPotalDireccion
            // 
            this.txtCodigoPotalDireccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCodigoPotalDireccion.Location = new System.Drawing.Point(180, 111);
            this.txtCodigoPotalDireccion.Name = "txtCodigoPotalDireccion";
            this.txtCodigoPotalDireccion.Size = new System.Drawing.Size(131, 20);
            this.txtCodigoPotalDireccion.TabIndex = 5;
            this.txtCodigoPotalDireccion.TextChanged += new System.EventHandler(this.txtCodigoPotalDireccion_TextChanged);
            this.txtCodigoPotalDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoPotalDireccion_KeyPress);
            // 
            // txtEstadoDireccion
            // 
            this.txtEstadoDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstadoDireccion.Location = new System.Drawing.Point(23, 111);
            this.txtEstadoDireccion.Name = "txtEstadoDireccion";
            this.txtEstadoDireccion.Size = new System.Drawing.Size(131, 20);
            this.txtEstadoDireccion.TabIndex = 4;
            this.txtEstadoDireccion.TextChanged += new System.EventHandler(this.txtEstadoDireccion_TextChanged);
            // 
            // txtColoniaDireccion
            // 
            this.txtColoniaDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColoniaDireccion.Location = new System.Drawing.Point(23, 72);
            this.txtColoniaDireccion.Name = "txtColoniaDireccion";
            this.txtColoniaDireccion.Size = new System.Drawing.Size(138, 20);
            this.txtColoniaDireccion.TabIndex = 2;
            this.txtColoniaDireccion.TextChanged += new System.EventHandler(this.txtColoniaDireccion_TextChanged);
            // 
            // txtMuniciopioDireccion
            // 
            this.txtMuniciopioDireccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMuniciopioDireccion.Location = new System.Drawing.Point(180, 72);
            this.txtMuniciopioDireccion.Name = "txtMuniciopioDireccion";
            this.txtMuniciopioDireccion.Size = new System.Drawing.Size(138, 20);
            this.txtMuniciopioDireccion.TabIndex = 3;
            this.txtMuniciopioDireccion.TextChanged += new System.EventHandler(this.txtMuniciopioDireccion_TextChanged);
            // 
            // txtNumeroCalle
            // 
            this.txtNumeroCalle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtNumeroCalle.Location = new System.Drawing.Point(243, 33);
            this.txtNumeroCalle.Name = "txtNumeroCalle";
            this.txtNumeroCalle.Size = new System.Drawing.Size(68, 20);
            this.txtNumeroCalle.TabIndex = 1;
            this.txtNumeroCalle.TextChanged += new System.EventHandler(this.txtNumeroCalle_TextChanged);
            // 
            // txtCalleDireccion
            // 
            this.txtCalleDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCalleDireccion.Location = new System.Drawing.Point(23, 33);
            this.txtCalleDireccion.Name = "txtCalleDireccion";
            this.txtCalleDireccion.Size = new System.Drawing.Size(201, 20);
            this.txtCalleDireccion.TabIndex = 0;
            this.txtCalleDireccion.TextChanged += new System.EventHandler(this.txtCalleDireccion_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(402, 400);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(577, 435);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.Cumpleaños);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(593, 474);
            this.MinimumSize = new System.Drawing.Size(593, 474);
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.Cumpleaños.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.GroupBox Cumpleaños;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpCumpleanios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodigoPotalDireccion;
        private System.Windows.Forms.TextBox txtMuniciopioDireccion;
        private System.Windows.Forms.TextBox txtEstadoDireccion;
        private System.Windows.Forms.TextBox txtColoniaDireccion;
        private System.Windows.Forms.TextBox txtNumeroCalle;
        private System.Windows.Forms.TextBox txtCalleDireccion;
        private System.Windows.Forms.Button btnModificar;
    }
}