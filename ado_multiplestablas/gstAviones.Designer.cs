namespace ado_multiplestablas
{
    partial class gstAviones
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
            tbMatricula = new TextBox();
            tbModelo = new TextBox();
            tbCapacidad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(50, 158);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(289, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tbMatricula
            // 
            tbMatricula.Location = new Point(113, 41);
            tbMatricula.Name = "tbMatricula";
            tbMatricula.Size = new Size(226, 23);
            tbMatricula.TabIndex = 1;
            // 
            // tbModelo
            // 
            tbModelo.Location = new Point(113, 80);
            tbModelo.Name = "tbModelo";
            tbModelo.Size = new Size(226, 23);
            tbModelo.TabIndex = 2;
            // 
            // tbCapacidad
            // 
            tbCapacidad.Location = new Point(113, 120);
            tbCapacidad.Name = "tbCapacidad";
            tbCapacidad.Size = new Size(226, 23);
            tbCapacidad.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 49);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "Matricula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 88);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 5;
            label2.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 128);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Capacidad";
            // 
            // gstAviones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbCapacidad);
            Controls.Add(tbModelo);
            Controls.Add(tbMatricula);
            Controls.Add(btnAgregar);
            Name = "gstAviones";
            Text = "gstAviones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox tbMatricula;
        private TextBox tbModelo;
        private TextBox tbCapacidad;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}