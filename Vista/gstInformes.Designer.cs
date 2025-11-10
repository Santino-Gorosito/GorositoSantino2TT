namespace Vista
{
    partial class gstInformes
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dtCuentas = new DataGridView();
            colNumero = new DataGridViewTextBoxColumn();
            colSaldo = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btnDebito = new Button();
            label5 = new Label();
            dtDebito = new DateTimePicker();
            label6 = new Label();
            tbMontoDebito = new TextBox();
            tbDescripcionDebito = new TextBox();
            label7 = new Label();
            tbNumeroDebito = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            btnCredito = new Button();
            label4 = new Label();
            dtCredito = new DateTimePicker();
            label3 = new Label();
            tbMontoCredito = new TextBox();
            tbDescripcionCredito = new TextBox();
            label2 = new Label();
            tbNumeroCredito = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            label9 = new Label();
            btnResumen = new Button();
            tbNumeroResumen = new TextBox();
            groupBox3 = new GroupBox();
            label10 = new Label();
            btnMovimientos = new Button();
            tbNumeroCuenta = new TextBox();
            dtMovimientos = new DataGridView();
            colTipo = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtCuentas).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtMovimientos).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(24, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1294, 680);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dtCuentas);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1286, 652);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Movimientos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtCuentas
            // 
            dtCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtCuentas.Columns.AddRange(new DataGridViewColumn[] { colNumero, colSaldo });
            dtCuentas.Location = new Point(286, 15);
            dtCuentas.Name = "dtCuentas";
            dtCuentas.ReadOnly = true;
            dtCuentas.Size = new Size(248, 511);
            dtCuentas.TabIndex = 2;
            // 
            // colNumero
            // 
            colNumero.HeaderText = "Numero";
            colNumero.Name = "colNumero";
            colNumero.ReadOnly = true;
            // 
            // colSaldo
            // 
            colSaldo.HeaderText = "Saldo";
            colSaldo.Name = "colSaldo";
            colSaldo.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDebito);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dtDebito);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbMontoDebito);
            groupBox2.Controls.Add(tbDescripcionDebito);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tbNumeroDebito);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(6, 277);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(224, 249);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Debitos";
            // 
            // btnDebito
            // 
            btnDebito.Location = new Point(12, 204);
            btnDebito.Name = "btnDebito";
            btnDebito.Size = new Size(198, 23);
            btnDebito.TabIndex = 17;
            btnDebito.Text = "Registrar";
            btnDebito.UseVisualStyleBackColor = true;
            btnDebito.Click += btnDebito_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 145);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 16;
            label5.Text = "Fecha";
            // 
            // dtDebito
            // 
            dtDebito.Location = new Point(110, 137);
            dtDebito.Name = "dtDebito";
            dtDebito.Size = new Size(102, 23);
            dtDebito.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 101);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 14;
            label6.Text = "Monto";
            // 
            // tbMontoDebito
            // 
            tbMontoDebito.Location = new Point(110, 93);
            tbMontoDebito.Name = "tbMontoDebito";
            tbMontoDebito.Size = new Size(100, 23);
            tbMontoDebito.TabIndex = 13;
            // 
            // tbDescripcionDebito
            // 
            tbDescripcionDebito.Location = new Point(110, 54);
            tbDescripcionDebito.Name = "tbDescripcionDebito";
            tbDescripcionDebito.Size = new Size(100, 23);
            tbDescripcionDebito.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 62);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 11;
            label7.Text = "Descripcion";
            // 
            // tbNumeroDebito
            // 
            tbNumeroDebito.Location = new Point(110, 22);
            tbNumeroDebito.Name = "tbNumeroDebito";
            tbNumeroDebito.Size = new Size(100, 23);
            tbNumeroDebito.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 30);
            label8.Name = "label8";
            label8.Size = new Size(92, 15);
            label8.TabIndex = 9;
            label8.Text = "Numero Cuenta";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCredito);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtCredito);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbMontoCredito);
            groupBox1.Controls.Add(tbDescripcionCredito);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbNumeroCredito);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(224, 249);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Creditos";
            // 
            // btnCredito
            // 
            btnCredito.Location = new Point(8, 203);
            btnCredito.Name = "btnCredito";
            btnCredito.Size = new Size(198, 23);
            btnCredito.TabIndex = 8;
            btnCredito.Text = "Registrar";
            btnCredito.UseVisualStyleBackColor = true;
            btnCredito.Click += btnCredito_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 144);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha";
            // 
            // dtCredito
            // 
            dtCredito.Location = new Point(106, 136);
            dtCredito.Name = "dtCredito";
            dtCredito.Size = new Size(102, 23);
            dtCredito.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 100);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Monto";
            // 
            // tbMontoCredito
            // 
            tbMontoCredito.Location = new Point(106, 92);
            tbMontoCredito.Name = "tbMontoCredito";
            tbMontoCredito.Size = new Size(100, 23);
            tbMontoCredito.TabIndex = 4;
            // 
            // tbDescripcionCredito
            // 
            tbDescripcionCredito.Location = new Point(106, 53);
            tbDescripcionCredito.Name = "tbDescripcionCredito";
            tbDescripcionCredito.Size = new Size(100, 23);
            tbDescripcionCredito.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 61);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripcion";
            // 
            // tbNumeroCredito
            // 
            tbNumeroCredito.Location = new Point(106, 21);
            tbNumeroCredito.Name = "tbNumeroCredito";
            tbNumeroCredito.Size = new Size(100, 23);
            tbNumeroCredito.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 29);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero Cuenta";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(dtMovimientos);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1286, 652);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Informes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(btnResumen);
            groupBox4.Controls.Add(tbNumeroResumen);
            groupBox4.Location = new Point(18, 151);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 100);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Resumen";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 33);
            label9.Name = "label9";
            label9.Size = new Size(92, 15);
            label9.TabIndex = 4;
            label9.Text = "Numero Cuenta";
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(6, 71);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(188, 23);
            btnResumen.TabIndex = 1;
            btnResumen.Text = "Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // tbNumeroResumen
            // 
            tbNumeroResumen.Location = new Point(104, 25);
            tbNumeroResumen.Name = "tbNumeroResumen";
            tbNumeroResumen.Size = new Size(90, 23);
            tbNumeroResumen.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(btnMovimientos);
            groupBox3.Controls.Add(tbNumeroCuenta);
            groupBox3.Location = new Point(18, 31);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Movimientos por cuenta";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 33);
            label10.Name = "label10";
            label10.Size = new Size(92, 15);
            label10.TabIndex = 4;
            label10.Text = "Numero Cuenta";
            // 
            // btnMovimientos
            // 
            btnMovimientos.Location = new Point(6, 71);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Size = new Size(188, 23);
            btnMovimientos.TabIndex = 1;
            btnMovimientos.Text = "Movimientos";
            btnMovimientos.UseVisualStyleBackColor = true;
            btnMovimientos.Click += btnMovimientos_Click;
            // 
            // tbNumeroCuenta
            // 
            tbNumeroCuenta.Location = new Point(104, 25);
            tbNumeroCuenta.Name = "tbNumeroCuenta";
            tbNumeroCuenta.Size = new Size(90, 23);
            tbNumeroCuenta.TabIndex = 3;
            // 
            // dtMovimientos
            // 
            dtMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtMovimientos.Columns.AddRange(new DataGridViewColumn[] { colTipo, colMonto, colFecha });
            dtMovimientos.Location = new Point(250, 18);
            dtMovimientos.Name = "dtMovimientos";
            dtMovimientos.Size = new Size(487, 614);
            dtMovimientos.TabIndex = 0;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            // 
            // colMonto
            // 
            colMonto.HeaderText = "Monto";
            colMonto.Name = "colMonto";
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            // 
            // gstInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1519, 778);
            Controls.Add(tabControl1);
            Name = "gstInformes";
            Text = "gstInformes";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtCuentas).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtMovimientos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox tbDescripcionCredito;
        private Label label2;
        private TextBox tbNumeroCredito;
        private Label label1;
        private Button btnCredito;
        private Label label4;
        private DateTimePicker dtCredito;
        private Label label3;
        private TextBox tbMontoCredito;
        private Button btnDebito;
        private Label label5;
        private DateTimePicker dtDebito;
        private Label label6;
        private TextBox tbMontoDebito;
        private TextBox tbDescripcionDebito;
        private Label label7;
        private TextBox tbNumeroDebito;
        private Label label8;
        private DataGridView dtCuentas;
        private DataGridViewTextBoxColumn colNumero;
        private DataGridViewTextBoxColumn colSaldo;
        private DataGridView dtMovimientos;
        private GroupBox groupBox4;
        private Label label9;
        private Button btnResumen;
        private TextBox tbNumeroResumen;
        private GroupBox groupBox3;
        private Label label10;
        private Button btnMovimientos;
        private TextBox tbNumeroCuenta;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colMonto;
        private DataGridViewTextBoxColumn colFecha;
    }
}