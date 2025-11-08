namespace Vista
{
    partial class gstCuentas
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
            btnAgregar = new Button();
            tbNumeroCuenta = new TextBox();
            cbCliente = new ComboBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            tbNumeroEstado = new TextBox();
            button1 = new Button();
            dtCuentas = new DataGridView();
            colNumero = new DataGridViewTextBoxColumn();
            colSaldo = new DataGridViewTextBoxColumn();
            btnListar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtCuentas).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(6, 89);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(255, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tbNumeroCuenta
            // 
            tbNumeroCuenta.Location = new Point(103, 22);
            tbNumeroCuenta.Name = "tbNumeroCuenta";
            tbNumeroCuenta.Size = new Size(121, 23);
            tbNumeroCuenta.TabIndex = 2;
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(103, 60);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(121, 23);
            cbCliente.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbNumeroCuenta);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(cbCliente);
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 120);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 5;
            label2.Text = "Cliente asociado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 4;
            label1.Text = "Numero cuenta";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tbNumeroEstado);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(23, 138);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(267, 83);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 25);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 2;
            label3.Text = "Numero Cuenta";
            // 
            // tbNumeroEstado
            // 
            tbNumeroEstado.Location = new Point(103, 22);
            tbNumeroEstado.Name = "tbNumeroEstado";
            tbNumeroEstado.Size = new Size(121, 23);
            tbNumeroEstado.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(6, 51);
            button1.Name = "button1";
            button1.Size = new Size(255, 23);
            button1.TabIndex = 0;
            button1.Text = "Estado cuenta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtCuentas
            // 
            dtCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtCuentas.Columns.AddRange(new DataGridViewColumn[] { colNumero, colSaldo });
            dtCuentas.Location = new Point(316, 12);
            dtCuentas.Name = "dtCuentas";
            dtCuentas.Size = new Size(534, 711);
            dtCuentas.TabIndex = 6;
            // 
            // colNumero
            // 
            colNumero.HeaderText = "Numero";
            colNumero.Name = "colNumero";
            // 
            // colSaldo
            // 
            colSaldo.HeaderText = "Saldo";
            colSaldo.Name = "colSaldo";
            // 
            // btnListar
            // 
            btnListar.Location = new Point(23, 227);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(267, 23);
            btnListar.TabIndex = 7;
            btnListar.Text = "Listar todas las cuentas";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // gstCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 755);
            Controls.Add(btnListar);
            Controls.Add(dtCuentas);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "gstCuentas";
            Text = "gstCuentas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtCuentas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAgregar;
        private TextBox tbNumeroCuenta;
        private ComboBox cbCliente;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox tbNumeroEstado;
        private Button button1;
        private DataGridView dtCuentas;
        private DataGridViewTextBoxColumn colNumero;
        private DataGridViewTextBoxColumn colSaldo;
        private Button btnListar;
    }
}