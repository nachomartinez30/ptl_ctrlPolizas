namespace ControlPolizas
{
    partial class Agente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreAgente = new System.Windows.Forms.TextBox();
            this.txtNumeroAgente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarAgente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscarAgente = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Image = global::ControlPolizas.Properties.Resources.businessman_1_;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 265);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del agente";
            // 
            // txtNombreAgente
            // 
            this.txtNombreAgente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNombreAgente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombreAgente.Location = new System.Drawing.Point(273, 115);
            this.txtNombreAgente.Name = "txtNombreAgente";
            this.txtNombreAgente.Size = new System.Drawing.Size(236, 20);
            this.txtNombreAgente.TabIndex = 1;
            // 
            // txtNumeroAgente
            // 
            this.txtNumeroAgente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNumeroAgente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNumeroAgente.Location = new System.Drawing.Point(273, 55);
            this.txtNumeroAgente.Name = "txtNumeroAgente";
            this.txtNumeroAgente.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroAgente.TabIndex = 0;
            this.txtNumeroAgente.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero de Agente";
            // 
            // btnAgregarAgente
            // 
            this.btnAgregarAgente.Location = new System.Drawing.Point(352, 296);
            this.btnAgregarAgente.Name = "btnAgregarAgente";
            this.btnAgregarAgente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarAgente.TabIndex = 4;
            this.btnAgregarAgente.Text = "&Agregar";
            this.btnAgregarAgente.UseVisualStyleBackColor = true;
            this.btnAgregarAgente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(433, 296);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscarAgente
            // 
            this.btnBuscarAgente.Location = new System.Drawing.Point(224, 296);
            this.btnBuscarAgente.Name = "btnBuscarAgente";
            this.btnBuscarAgente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAgente.TabIndex = 5;
            this.btnBuscarAgente.Text = "&Buscar";
            this.btnBuscarAgente.UseVisualStyleBackColor = true;
            this.btnBuscarAgente.Click += new System.EventHandler(this.btnBuscarAgente_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(273, 176);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(236, 20);
            this.txtContraseña.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Confirmar";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(273, 216);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.PasswordChar = '*';
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(236, 20);
            this.txtConfirmarContraseña.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(433, 251);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(352, 296);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Agente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(533, 331);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConfirmarContraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.btnBuscarAgente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarAgente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroAgente);
            this.Controls.Add(this.txtNombreAgente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(549, 370);
            this.MinimumSize = new System.Drawing.Size(549, 370);
            this.Name = "Agente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agente";
            this.Load += new System.EventHandler(this.Agente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreAgente;
        private System.Windows.Forms.TextBox txtNumeroAgente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarAgente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscarAgente;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
    }
}