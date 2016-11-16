namespace ControlPolizas
{
    partial class ConsultarPolizasPorVigencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarPolizasPorVigencia));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvRecibos = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaVencimientoFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaVencimientoInicio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(485, 433);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvRecibos
            // 
            this.dgvRecibos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibos.Location = new System.Drawing.Point(14, 132);
            this.dgvRecibos.Name = "dgvRecibos";
            this.dgvRecibos.Size = new System.Drawing.Size(546, 275);
            this.dgvRecibos.TabIndex = 29;
            this.dgvRecibos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecibos_CellContentClick);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(468, 26);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(92, 81);
            this.btnConsultar.TabIndex = 28;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaVencimientoFin);
            this.groupBox1.Controls.Add(this.dtpFechaVencimientoInicio);
            this.groupBox1.Location = new System.Drawing.Point(55, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 95);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Vencimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Entre";
            // 
            // dtpFechaVencimientoFin
            // 
            this.dtpFechaVencimientoFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimientoFin.Location = new System.Drawing.Point(215, 42);
            this.dtpFechaVencimientoFin.Name = "dtpFechaVencimientoFin";
            this.dtpFechaVencimientoFin.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaVencimientoFin.TabIndex = 14;
            // 
            // dtpFechaVencimientoInicio
            // 
            this.dtpFechaVencimientoInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimientoInicio.Location = new System.Drawing.Point(58, 42);
            this.dtpFechaVencimientoInicio.Name = "dtpFechaVencimientoInicio";
            this.dtpFechaVencimientoInicio.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaVencimientoInicio.TabIndex = 12;
            // 
            // ConsultarPolizasPorVigencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 483);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvRecibos);
            this.Controls.Add(this.btnConsultar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarPolizasPorVigencia";
            this.Text = "ConsultarPolizasPorVigencia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvRecibos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimientoFin;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimientoInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}