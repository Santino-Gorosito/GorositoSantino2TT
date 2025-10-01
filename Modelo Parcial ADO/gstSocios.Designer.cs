namespace Modelo_Parcial_ADO
{
    partial class gstSocios
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
            tbNombre = new TextBox();
            tbApellido = new TextBox();
            tbDni = new TextBox();
            dtNacimiento = new DateTimePicker();
            tbNumSocio = new TextBox();
            Si = new RadioButton();
            No = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 195);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(353, 26);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(165, 12);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(200, 23);
            tbNombre.TabIndex = 1;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(165, 41);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(200, 23);
            tbApellido.TabIndex = 2;
            // 
            // tbDni
            // 
            tbDni.Location = new Point(165, 70);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(200, 23);
            tbDni.TabIndex = 3;
            // 
            // dtNacimiento
            // 
            dtNacimiento.Location = new Point(165, 99);
            dtNacimiento.Name = "dtNacimiento";
            dtNacimiento.Size = new Size(200, 23);
            dtNacimiento.TabIndex = 4;
            // 
            // tbNumSocio
            // 
            tbNumSocio.Location = new Point(165, 128);
            tbNumSocio.Name = "tbNumSocio";
            tbNumSocio.Size = new Size(200, 23);
            tbNumSocio.TabIndex = 5;
            // 
            // Si
            // 
            Si.AutoSize = true;
            Si.Location = new Point(165, 157);
            Si.Name = "Si";
            Si.Size = new Size(34, 19);
            Si.TabIndex = 6;
            Si.TabStop = true;
            Si.Text = "Si";
            Si.UseVisualStyleBackColor = true;
            // 
            // No
            // 
            No.AutoSize = true;
            No.Location = new Point(205, 157);
            No.Name = "No";
            No.Size = new Size(41, 19);
            No.TabIndex = 7;
            No.TabStop = true;
            No.Text = "No";
            No.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 10;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 105);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 11;
            label4.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 136);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 12;
            label5.Text = "Numero Socio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 161);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 13;
            label6.Text = "Cuota Al Dia?";
            // 
            // gstSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(No);
            Controls.Add(Si);
            Controls.Add(tbNumSocio);
            Controls.Add(dtNacimiento);
            Controls.Add(tbDni);
            Controls.Add(tbApellido);
            Controls.Add(tbNombre);
            Controls.Add(btnAgregar);
            Name = "gstSocios";
            Text = "gstSocios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox tbNombre;
        private TextBox tbApellido;
        private TextBox tbDni;
        private DateTimePicker dtNacimiento;
        private TextBox tbNumSocio;
        private RadioButton Si;
        private RadioButton No;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}