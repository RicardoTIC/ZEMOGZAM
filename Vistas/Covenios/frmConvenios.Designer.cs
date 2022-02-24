namespace ZEMOGZAMMODIFICACIONES.Covenios
{
    partial class frmConvenios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaCovenios = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNombrerRuta = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.txtidDestinatario = new System.Windows.Forms.TextBox();
            this.txtidRemitente = new System.Windows.Forms.TextBox();
            this.txtRemitente = new System.Windows.Forms.TextBox();
            this.txtNombreConvenio = new System.Windows.Forms.TextBox();
            this.txtidconvenio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtOperacion = new System.Windows.Forms.TextBox();
            this.txtFactorSencillo = new System.Windows.Forms.TextBox();
            this.txtFactorFull = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaCovenios)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Id.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cboSucursal);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ListaCovenios);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de convenios";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(384, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Nombre de la ruta";
            // 
            // cboSucursal
            // 
            this.cboSucursal.AutoCompleteCustomSource.AddRange(new string[] {
            "Selecciona"});
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(121, 18);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(202, 21);
            this.cboSucursal.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(857, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(511, 17);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(289, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscar_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Sucursal";
            // 
            // ListaCovenios
            // 
            this.ListaCovenios.AllowUserToAddRows = false;
            this.ListaCovenios.AllowUserToDeleteRows = false;
            this.ListaCovenios.AllowUserToResizeColumns = false;
            this.ListaCovenios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaCovenios.Location = new System.Drawing.Point(16, 63);
            this.ListaCovenios.Name = "ListaCovenios";
            this.ListaCovenios.ReadOnly = true;
            this.ListaCovenios.Size = new System.Drawing.Size(916, 214);
            this.ListaCovenios.TabIndex = 0;
            this.ListaCovenios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaCovenios_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTarifa);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtFactorFull);
            this.groupBox2.Controls.Add(this.txtFactorSencillo);
            this.groupBox2.Controls.Add(this.txtOperacion);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.Id);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtNombrerRuta);
            this.groupBox2.Controls.Add(this.txtDestino);
            this.groupBox2.Controls.Add(this.txtOrigen);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.txtDestinatario);
            this.groupBox2.Controls.Add(this.txtRemitente);
            this.groupBox2.Controls.Add(this.txtNombreConvenio);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(938, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de datos";
            // 
            // txtNombrerRuta
            // 
            this.txtNombrerRuta.Location = new System.Drawing.Point(121, 129);
            this.txtNombrerRuta.Name = "txtNombrerRuta";
            this.txtNombrerRuta.Size = new System.Drawing.Size(322, 20);
            this.txtNombrerRuta.TabIndex = 23;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(121, 196);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(322, 20);
            this.txtDestino.TabIndex = 20;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(121, 162);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(322, 20);
            this.txtOrigen.TabIndex = 19;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(551, 28);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(322, 20);
            this.txtCliente.TabIndex = 18;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(121, 52);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(322, 20);
            this.txtDestinatario.TabIndex = 17;
            // 
            // txtidDestinatario
            // 
            this.txtidDestinatario.Location = new System.Drawing.Point(100, 64);
            this.txtidDestinatario.Name = "txtidDestinatario";
            this.txtidDestinatario.Size = new System.Drawing.Size(73, 20);
            this.txtidDestinatario.TabIndex = 16;
            // 
            // txtidRemitente
            // 
            this.txtidRemitente.Location = new System.Drawing.Point(100, 28);
            this.txtidRemitente.Name = "txtidRemitente";
            this.txtidRemitente.Size = new System.Drawing.Size(73, 20);
            this.txtidRemitente.TabIndex = 15;
            // 
            // txtRemitente
            // 
            this.txtRemitente.Location = new System.Drawing.Point(121, 78);
            this.txtRemitente.Name = "txtRemitente";
            this.txtRemitente.Size = new System.Drawing.Size(322, 20);
            this.txtRemitente.TabIndex = 14;
            // 
            // txtNombreConvenio
            // 
            this.txtNombreConvenio.Location = new System.Drawing.Point(121, 28);
            this.txtNombreConvenio.Name = "txtNombreConvenio";
            this.txtNombreConvenio.Size = new System.Drawing.Size(322, 20);
            this.txtNombreConvenio.TabIndex = 13;
            // 
            // txtidconvenio
            // 
            this.txtidconvenio.Location = new System.Drawing.Point(284, 25);
            this.txtidconvenio.Name = "txtidconvenio";
            this.txtidconvenio.Size = new System.Drawing.Size(100, 20);
            this.txtidconvenio.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Nombre de Ruta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Destino";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Origen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(499, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Destinatario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "id destinatario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "id remitente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Remitente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre Convenio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "id convenio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Registros";
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(93, 545);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(35, 13);
            this.lblTotalRegistros.TabIndex = 3;
            this.lblTotalRegistros.Text = "label3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Sucursal";
            // 
            // Id
            // 
            this.Id.Controls.Add(this.txtIdCliente);
            this.Id.Controls.Add(this.label13);
            this.Id.Controls.Add(this.txtidRemitente);
            this.Id.Controls.Add(this.label6);
            this.Id.Controls.Add(this.label7);
            this.Id.Controls.Add(this.txtidDestinatario);
            this.Id.Controls.Add(this.txtidconvenio);
            this.Id.Controls.Add(this.label3);
            this.Id.Location = new System.Drawing.Point(511, 144);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(421, 100);
            this.Id.TabIndex = 26;
            this.Id.TabStop = false;
            this.Id.Text = "IDs";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(195, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "id Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(284, 59);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(451, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Tipo Operacion";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(494, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Factor S";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(494, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Factor F";
            // 
            // txtOperacion
            // 
            this.txtOperacion.Location = new System.Drawing.Point(551, 52);
            this.txtOperacion.Name = "txtOperacion";
            this.txtOperacion.Size = new System.Drawing.Size(184, 20);
            this.txtOperacion.TabIndex = 30;
            // 
            // txtFactorSencillo
            // 
            this.txtFactorSencillo.Location = new System.Drawing.Point(551, 75);
            this.txtFactorSencillo.Name = "txtFactorSencillo";
            this.txtFactorSencillo.Size = new System.Drawing.Size(100, 20);
            this.txtFactorSencillo.TabIndex = 31;
            // 
            // txtFactorFull
            // 
            this.txtFactorFull.Location = new System.Drawing.Point(551, 98);
            this.txtFactorFull.Name = "txtFactorFull";
            this.txtFactorFull.Size = new System.Drawing.Size(100, 20);
            this.txtFactorFull.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(494, 122);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Tarifa";
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(551, 122);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(100, 20);
            this.txtTarifa.TabIndex = 34;
            // 
            // frmConvenios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 578);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConvenios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Covenios";
            this.Load += new System.EventHandler(this.frmConvenios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaCovenios)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Id.ResumeLayout(false);
            this.Id.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ListaCovenios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.TextBox txtNombrerRuta;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.TextBox txtidDestinatario;
        private System.Windows.Forms.TextBox txtidRemitente;
        private System.Windows.Forms.TextBox txtRemitente;
        private System.Windows.Forms.TextBox txtNombreConvenio;
        private System.Windows.Forms.TextBox txtidconvenio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox Id;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFactorFull;
        private System.Windows.Forms.TextBox txtFactorSencillo;
        private System.Windows.Forms.TextBox txtOperacion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Label label19;
    }
}