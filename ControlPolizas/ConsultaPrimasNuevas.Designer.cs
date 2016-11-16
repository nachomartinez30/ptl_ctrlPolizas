namespace ControlPolizas
{
    partial class ConsultaPrimasNuevas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPrimasNuevas));
            this.cmbCompania = new System.Windows.Forms.ComboBox();
            this.cmbRamo = new System.Windows.Forms.ComboBox();
            this.dtpFechaPagoFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaPagoInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkboxNueva = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvRecibos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtPrimaCumulada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCompania
            // 
            this.cmbCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompania.FormattingEnabled = true;
            this.cmbCompania.Location = new System.Drawing.Point(59, 32);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Size = new System.Drawing.Size(121, 21);
            this.cmbCompania.TabIndex = 16;
            // 
            // cmbRamo
            // 
            this.cmbRamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRamo.FormattingEnabled = true;
            this.cmbRamo.Items.AddRange(new object[] {
            "Auto",
            "Daño",
            "Gastos médicos",
            "Vida"});
            this.cmbRamo.Location = new System.Drawing.Point(59, 80);
            this.cmbRamo.Name = "cmbRamo";
            this.cmbRamo.Size = new System.Drawing.Size(121, 21);
            this.cmbRamo.TabIndex = 15;
            // 
            // dtpFechaPagoFin
            // 
            this.dtpFechaPagoFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPagoFin.Location = new System.Drawing.Point(16, 61);
            this.dtpFechaPagoFin.Name = "dtpFechaPagoFin";
            this.dtpFechaPagoFin.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaPagoFin.TabIndex = 14;
            // 
            // dtpFechaPagoInicio
            // 
            this.dtpFechaPagoInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPagoInicio.Location = new System.Drawing.Point(16, 20);
            this.dtpFechaPagoInicio.Name = "dtpFechaPagoInicio";
            this.dtpFechaPagoInicio.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaPagoInicio.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Compañía";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ramo";
            // 
            // chkboxNueva
            // 
            this.chkboxNueva.AutoSize = true;
            this.chkboxNueva.Location = new System.Drawing.Point(488, 53);
            this.chkboxNueva.Name = "chkboxNueva";
            this.chkboxNueva.Size = new System.Drawing.Size(58, 17);
            this.chkboxNueva.TabIndex = 13;
            this.chkboxNueva.Text = "Nueva";
            this.chkboxNueva.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaPagoFin);
            this.groupBox1.Controls.Add(this.dtpFechaPagoInicio);
            this.groupBox1.Location = new System.Drawing.Point(277, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 98);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha De Pago";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(634, 20);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(92, 81);
            this.btnConsultar.TabIndex = 20;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvRecibos
            // 
            this.dgvRecibos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibos.Location = new System.Drawing.Point(12, 141);
            this.dgvRecibos.Name = "dgvRecibos";
            this.dgvRecibos.Size = new System.Drawing.Size(742, 371);
            this.dgvRecibos.TabIndex = 21;
            this.dgvRecibos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecibos_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(651, 538);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtPrimaCumulada
            // 
            this.txtPrimaCumulada.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPrimaCumulada.Location = new System.Drawing.Point(146, 538);
            this.txtPrimaCumulada.Name = "txtPrimaCumulada";
            this.txtPrimaCumulada.Size = new System.Drawing.Size(206, 20);
            this.txtPrimaCumulada.TabIndex = 23;
            this.txtPrimaCumulada.TextChanged += new System.EventHandler(this.txtPrimaCumulada_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(31, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Prima Acumulada=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConsultaPrimasNuevas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 590);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrimaCumulada);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvRecibos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCompania);
            this.Controls.Add(this.cmbRamo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkboxNueva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaPrimasNuevas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaPrimasNuevas";
            this.Load += new System.EventHandler(this.ConsultaPrimasNuevas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCompania;
        private System.Windows.Forms.ComboBox cmbRamo;
        private System.Windows.Forms.DateTimePicker dtpFechaPagoFin;
        private System.Windows.Forms.DateTimePicker dtpFechaPagoInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkboxNueva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvRecibos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtPrimaCumulada;
        private System.Windows.Forms.Label label1;
    }
}