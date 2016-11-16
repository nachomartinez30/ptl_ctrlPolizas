namespace ControlPolizas
{
    partial class ConsultarPolizaPorNumero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarPolizaPorNumero));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvRecibos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroPoliza = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(485, 433);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvRecibos
            // 
            this.dgvRecibos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecibos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibos.Location = new System.Drawing.Point(14, 132);
            this.dgvRecibos.Name = "dgvRecibos";
            this.dgvRecibos.Size = new System.Drawing.Size(546, 275);
            this.dgvRecibos.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Numero de póliza";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNumeroPoliza
            // 
            this.txtNumeroPoliza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNumeroPoliza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNumeroPoliza.Location = new System.Drawing.Point(56, 47);
            this.txtNumeroPoliza.Name = "txtNumeroPoliza";
            this.txtNumeroPoliza.Size = new System.Drawing.Size(166, 20);
            this.txtNumeroPoliza.TabIndex = 33;
            this.txtNumeroPoliza.TextChanged += new System.EventHandler(this.txtNumeroPoliza_TextChanged);
            // 
            // ConsultarPolizaPorNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroPoliza);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvRecibos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarPolizaPorNumero";
            this.Text = "ConsultarPolizaPorNumero";
            this.Load += new System.EventHandler(this.ConsultarPolizaPorNumero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvRecibos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroPoliza;
    }
}