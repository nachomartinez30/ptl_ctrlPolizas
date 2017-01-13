namespace ControlPolizas
{
    partial class Poliza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poliza));
            this.chkboxNueva = new System.Windows.Forms.CheckBox();
            this.txtNumeroPoliza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRamo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCompania = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbAgente = new System.Windows.Forms.ComboBox();
            this.btnAdjuntoPoliza = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbFrecuenciaPago = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFinVigencia = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpInicioVigencia = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumeroRenovacion = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFraccionado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDerechoPoliza = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrima = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAdjunto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroRecibos = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chkboxPagarPrimer = new System.Windows.Forms.CheckBox();
            this.btnRevisarRecibos = new System.Windows.Forms.Button();
            this.btnRenovar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkboxNueva
            // 
            this.chkboxNueva.AutoSize = true;
            this.chkboxNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxNueva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkboxNueva.Location = new System.Drawing.Point(256, 22);
            this.chkboxNueva.Name = "chkboxNueva";
            this.chkboxNueva.Size = new System.Drawing.Size(63, 17);
            this.chkboxNueva.TabIndex = 0;
            this.chkboxNueva.Text = "Nueva";
            this.chkboxNueva.UseVisualStyleBackColor = true;
            this.chkboxNueva.CheckedChanged += new System.EventHandler(this.chkboxNueva_CheckedChanged);
            this.chkboxNueva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkboxNueva_KeyPress);
            // 
            // txtNumeroPoliza
            // 
            this.txtNumeroPoliza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNumeroPoliza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNumeroPoliza.Location = new System.Drawing.Point(342, 22);
            this.txtNumeroPoliza.Name = "txtNumeroPoliza";
            this.txtNumeroPoliza.Size = new System.Drawing.Size(166, 20);
            this.txtNumeroPoliza.TabIndex = 1;
            this.txtNumeroPoliza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroPoliza_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de póliza";
            // 
            // txtCliente
            // 
            this.txtCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCliente.Location = new System.Drawing.Point(257, 64);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(250, 20);
            this.txtCliente.TabIndex = 2;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ramo";
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
            this.cmbRamo.Location = new System.Drawing.Point(257, 103);
            this.cmbRamo.Name = "cmbRamo";
            this.cmbRamo.Size = new System.Drawing.Size(121, 21);
            this.cmbRamo.TabIndex = 3;
            this.cmbRamo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRamo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Compañía";
            // 
            // cmbCompania
            // 
            this.cmbCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompania.FormattingEnabled = true;
            this.cmbCompania.Location = new System.Drawing.Point(386, 103);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Size = new System.Drawing.Size(121, 21);
            this.cmbCompania.TabIndex = 4;
            this.cmbCompania.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCompania_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Agente";
            // 
            // cmbAgente
            // 
            this.cmbAgente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgente.FormattingEnabled = true;
            this.cmbAgente.Location = new System.Drawing.Point(12, 351);
            this.cmbAgente.Name = "cmbAgente";
            this.cmbAgente.Size = new System.Drawing.Size(137, 21);
            this.cmbAgente.TabIndex = 10;
            this.cmbAgente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAgente_KeyPress);
            // 
            // btnAdjuntoPoliza
            // 
            this.btnAdjuntoPoliza.Location = new System.Drawing.Point(135, 273);
            this.btnAdjuntoPoliza.Name = "btnAdjuntoPoliza";
            this.btnAdjuntoPoliza.Size = new System.Drawing.Size(54, 45);
            this.btnAdjuntoPoliza.TabIndex = 9;
            this.btnAdjuntoPoliza.Text = "Adjuntar &Póliza";
            this.btnAdjuntoPoliza.UseVisualStyleBackColor = true;
            this.btnAdjuntoPoliza.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(304, 575);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(433, 575);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(217, 575);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 23);
            this.btnBusca.TabIndex = 12;
            this.btnBusca.Text = "&Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btcBusca_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(13, 575);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmbFrecuenciaPago
            // 
            this.cmbFrecuenciaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrecuenciaPago.FormattingEnabled = true;
            this.cmbFrecuenciaPago.Items.AddRange(new object[] {
            "Mensual",
            "Trimestral",
            "Semestral",
            "Anual"});
            this.cmbFrecuenciaPago.Location = new System.Drawing.Point(386, 159);
            this.cmbFrecuenciaPago.Name = "cmbFrecuenciaPago";
            this.cmbFrecuenciaPago.Size = new System.Drawing.Size(120, 21);
            this.cmbFrecuenciaPago.TabIndex = 6;
            this.cmbFrecuenciaPago.SelectedIndexChanged += new System.EventHandler(this.cmbFrecuenciaPago_SelectedIndexChanged);
            this.cmbFrecuenciaPago.SelectedValueChanged += new System.EventHandler(this.cmbFrecuenciaPago_SelectedValueChanged);
            this.cmbFrecuenciaPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFrecuenciaPago_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(383, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Frecuencia de pago";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpFinVigencia);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpInicioVigencia);
            this.groupBox1.Location = new System.Drawing.Point(257, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 89);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vigencia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Fin ";
            // 
            // dtpFinVigencia
            // 
            this.dtpFinVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinVigencia.Location = new System.Drawing.Point(44, 57);
            this.dtpFinVigencia.Name = "dtpFinVigencia";
            this.dtpFinVigencia.Size = new System.Drawing.Size(103, 20);
            this.dtpFinVigencia.TabIndex = 1;
            this.dtpFinVigencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFinVigencia_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Inicio";
            // 
            // dtpInicioVigencia
            // 
            this.dtpInicioVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioVigencia.Location = new System.Drawing.Point(44, 19);
            this.dtpInicioVigencia.Name = "dtpInicioVigencia";
            this.dtpInicioVigencia.Size = new System.Drawing.Size(103, 20);
            this.dtpInicioVigencia.TabIndex = 0;
            this.dtpInicioVigencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpInicioVigencia_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(257, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Numero de Renovación";
            // 
            // txtNumeroRenovacion
            // 
            this.txtNumeroRenovacion.Location = new System.Drawing.Point(257, 159);
            this.txtNumeroRenovacion.Name = "txtNumeroRenovacion";
            this.txtNumeroRenovacion.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroRenovacion.TabIndex = 5;
            this.txtNumeroRenovacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroRenovacion_KeyPress);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(432, 461);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(163, 101);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(70, 20);
            this.txtIVA.TabIndex = 3;
            this.txtIVA.TextChanged += new System.EventHandler(this.txtIVA_TextChanged);
            this.txtIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIVA_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtImporte);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtFraccionado);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtDerechoPoliza);
            this.groupBox2.Controls.Add(this.txtIVA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPrima);
            this.groupBox2.Location = new System.Drawing.Point(195, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 165);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prima del Movimiento";
            // 
            // txtImporte
            // 
            this.txtImporte.Enabled = false;
            this.txtImporte.Location = new System.Drawing.Point(163, 127);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(127, 20);
            this.txtImporte.TabIndex = 4;
            this.txtImporte.TextChanged += new System.EventHandler(this.txtImporte_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Importe a pagar";
            // 
            // txtFraccionado
            // 
            this.txtFraccionado.Location = new System.Drawing.Point(163, 47);
            this.txtFraccionado.Name = "txtFraccionado";
            this.txtFraccionado.Size = new System.Drawing.Size(127, 20);
            this.txtFraccionado.TabIndex = 1;
            this.txtFraccionado.TextChanged += new System.EventHandler(this.txtFraccionado_TextChanged);
            this.txtFraccionado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFraccionado_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "Recargo pago fraccionado";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(58, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 13);
            this.label16.TabIndex = 75;
            this.label16.Text = "Derecho de poliza";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(127, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "IVA";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtDerechoPoliza
            // 
            this.txtDerechoPoliza.Location = new System.Drawing.Point(163, 75);
            this.txtDerechoPoliza.Name = "txtDerechoPoliza";
            this.txtDerechoPoliza.Size = new System.Drawing.Size(127, 20);
            this.txtDerechoPoliza.TabIndex = 2;
            this.txtDerechoPoliza.TextChanged += new System.EventHandler(this.txtDerechoPolizaChanged);
            this.txtDerechoPoliza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDerechoPoliza_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Prima neta";
            // 
            // txtPrima
            // 
            this.txtPrima.Location = new System.Drawing.Point(163, 21);
            this.txtPrima.Name = "txtPrima";
            this.txtPrima.Size = new System.Drawing.Size(127, 20);
            this.txtPrima.TabIndex = 0;
            this.txtPrima.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPrima_MouseClick);
            this.txtPrima.TextChanged += new System.EventHandler(this.txtPrima_TextChanged);
            this.txtPrima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrima_KeyPress);
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(12, 395);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(120, 20);
            this.txtVersion.TabIndex = 11;
            this.txtVersion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVersion_KeyDown);
            this.txtVersion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVersion_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 379);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Version";
            // 
            // txtAdjunto
            // 
            this.txtAdjunto.Location = new System.Drawing.Point(12, 286);
            this.txtAdjunto.Name = "txtAdjunto";
            this.txtAdjunto.Size = new System.Drawing.Size(120, 20);
            this.txtAdjunto.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Image = global::ControlPolizas.Properties.Resources.business_1_;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 265);
            this.label1.TabIndex = 1;
            this.label1.UseWaitCursor = true;
            // 
            // txtNumeroRecibos
            // 
            this.txtNumeroRecibos.Enabled = false;
            this.txtNumeroRecibos.Location = new System.Drawing.Point(111, 477);
            this.txtNumeroRecibos.Name = "txtNumeroRecibos";
            this.txtNumeroRecibos.Size = new System.Drawing.Size(38, 20);
            this.txtNumeroRecibos.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(99, 461);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 81;
            this.label15.Text = "No. Recibos";
            // 
            // chkboxPagarPrimer
            // 
            this.chkboxPagarPrimer.AutoSize = true;
            this.chkboxPagarPrimer.Location = new System.Drawing.Point(13, 438);
            this.chkboxPagarPrimer.Name = "chkboxPagarPrimer";
            this.chkboxPagarPrimer.Size = new System.Drawing.Size(176, 17);
            this.chkboxPagarPrimer.TabIndex = 12;
            this.chkboxPagarPrimer.Text = "Derecho de poliza el primer mes";
            this.chkboxPagarPrimer.UseVisualStyleBackColor = true;
            // 
            // btnRevisarRecibos
            // 
            this.btnRevisarRecibos.Enabled = false;
            this.btnRevisarRecibos.Location = new System.Drawing.Point(12, 461);
            this.btnRevisarRecibos.Name = "btnRevisarRecibos";
            this.btnRevisarRecibos.Size = new System.Drawing.Size(75, 36);
            this.btnRevisarRecibos.TabIndex = 14;
            this.btnRevisarRecibos.Text = "Revisar &Recibos";
            this.btnRevisarRecibos.UseVisualStyleBackColor = true;
            this.btnRevisarRecibos.Click += new System.EventHandler(this.btnRevisarRecibos_Click);
            // 
            // btnRenovar
            // 
            this.btnRenovar.Location = new System.Drawing.Point(217, 575);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(75, 23);
            this.btnRenovar.TabIndex = 82;
            this.btnRenovar.Text = "Renovar";
            this.btnRenovar.UseVisualStyleBackColor = true;
            this.btnRenovar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Poliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(519, 610);
            this.Controls.Add(this.chkboxPagarPrimer);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtNumeroRecibos);
            this.Controls.Add(this.txtAdjunto);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtNumeroRenovacion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.cmbFrecuenciaPago);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAdjuntoPoliza);
            this.Controls.Add(this.cmbAgente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbCompania);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbRamo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroPoliza);
            this.Controls.Add(this.chkboxNueva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRevisarRecibos);
            this.Controls.Add(this.btnRenovar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 649);
            this.MinimumSize = new System.Drawing.Size(535, 649);
            this.Name = "Poliza";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pólizas";
            this.Load += new System.EventHandler(this.Poliza_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkboxNueva;
        private System.Windows.Forms.TextBox txtNumeroPoliza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRamo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCompania;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbAgente;
        private System.Windows.Forms.Button btnAdjuntoPoliza;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbFrecuenciaPago;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFinVigencia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpInicioVigencia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumeroRenovacion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDerechoPoliza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrima;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFraccionado;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAdjunto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNumeroRecibos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkboxPagarPrimer;
        private System.Windows.Forms.Button btnRevisarRecibos;
        private System.Windows.Forms.Button btnRenovar;
    }
}