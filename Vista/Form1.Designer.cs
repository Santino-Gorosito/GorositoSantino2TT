namespace Vista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnClientes = new Button();
            btnCuentas = new Button();
            btnInformes = new Button();
            s = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(36, 32);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(132, 50);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Gestion de Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnCuentas
            // 
            btnCuentas.Location = new Point(231, 32);
            btnCuentas.Name = "btnCuentas";
            btnCuentas.Size = new Size(132, 50);
            btnCuentas.TabIndex = 1;
            btnCuentas.Text = "Gestion de Cuentas";
            btnCuentas.UseVisualStyleBackColor = true;
            btnCuentas.Click += btnCuentas_Click;
            // 
            // btnInformes
            // 
            btnInformes.Location = new Point(434, 32);
            btnInformes.Name = "btnInformes";
            btnInformes.Size = new Size(132, 50);
            btnInformes.TabIndex = 2;
            btnInformes.Text = "Informes";
            btnInformes.UseVisualStyleBackColor = true;
            btnInformes.Click += btnInformes_Click;
            // 
            // s
            // 
            s.Location = new Point(537, 477);
            s.Name = "s";
            s.Size = new Size(75, 23);
            s.TabIndex = 3;
            s.Text = "Salir";
            s.UseVisualStyleBackColor = true;
            s.Click += s_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(194, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 220);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 512);
            Controls.Add(pictureBox1);
            Controls.Add(s);
            Controls.Add(btnInformes);
            Controls.Add(btnCuentas);
            Controls.Add(btnClientes);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnCuentas;
        private Button btnInformes;
        private Button s;
        private PictureBox pictureBox1;
    }
}
