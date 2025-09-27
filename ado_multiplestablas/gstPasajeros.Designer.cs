namespace ado_multiplestablas
{
    partial class gstPasajeros
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
            tbPasaporte = new TextBox();
            tbNombre = new TextBox();
            tbNacionalidad = new TextBox();
            dtFechaNacimiento = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(36, 143);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(326, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tbPasaporte
            // 
            tbPasaporte.Location = new Point(162, 27);
            tbPasaporte.Name = "tbPasaporte";
            tbPasaporte.Size = new Size(200, 23);
            tbPasaporte.TabIndex = 1;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(162, 56);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(200, 23);
            tbNombre.TabIndex = 2;
            // 
            // tbNacionalidad
            // 
            tbNacionalidad.Location = new Point(162, 85);
            tbNacionalidad.Name = "tbNacionalidad";
            tbNacionalidad.Size = new Size(200, 23);
            tbNacionalidad.TabIndex = 3;
            // 
            // dtFechaNacimiento
            // 
            dtFechaNacimiento.Location = new Point(162, 114);
            dtFechaNacimiento.Name = "dtFechaNacimiento";
            dtFechaNacimiento.Size = new Size(200, 23);
            dtFechaNacimiento.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 35);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 5;
            label1.Text = "Pasaporte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 63);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 92);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 7;
            label3.Text = "Nacionalidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 124);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 8;
            label4.Text = "Fecha de nacimiento";
            // 
            // gstPasajeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtFechaNacimiento);
            Controls.Add(tbNacionalidad);
            Controls.Add(tbNombre);
            Controls.Add(tbPasaporte);
            Controls.Add(btnAgregar);
            Name = "gstPasajeros";
            Text = "gstPasajeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox tbPasaporte;
        private TextBox tbNombre;
        private TextBox tbNacionalidad;
        private DateTimePicker dtFechaNacimiento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}