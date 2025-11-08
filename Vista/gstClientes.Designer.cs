namespace Vista
{
    partial class gstClientes
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
            btnAlta = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbDniAlta = new TextBox();
            tbTelefonoAlta = new TextBox();
            tbApellidoAlta = new TextBox();
            tbNombreAlta = new TextBox();
            tabPage2 = new TabPage();
            dtClientesElim = new DataGridView();
            colNombreElim = new DataGridViewTextBoxColumn();
            colApellidoElim = new DataGridViewTextBoxColumn();
            colTelefonoElim = new DataGridViewTextBoxColumn();
            colDniElim = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            tabPage3 = new TabPage();
            dtClientesModif = new DataGridView();
            colNombreModif = new DataGridViewTextBoxColumn();
            colApellidoModif = new DataGridViewTextBoxColumn();
            colTelefonoModif = new DataGridViewTextBoxColumn();
            colDniModif = new DataGridViewTextBoxColumn();
            btnModif = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbDniModif = new TextBox();
            tbTelefonoModif = new TextBox();
            tbApellidoModif = new TextBox();
            tbNombreModif = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtClientesElim).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtClientesModif).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(32, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(851, 668);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAlta);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(tbDniAlta);
            tabPage1.Controls.Add(tbTelefonoAlta);
            tabPage1.Controls.Add(tbApellidoAlta);
            tabPage1.Controls.Add(tbNombreAlta);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(843, 640);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Alta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(61, 149);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(170, 23);
            btnAlta.TabIndex = 8;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 128);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 7;
            label4.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 99);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 6;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 65);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 41);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // tbDniAlta
            // 
            tbDniAlta.Location = new Point(131, 120);
            tbDniAlta.Name = "tbDniAlta";
            tbDniAlta.Size = new Size(100, 23);
            tbDniAlta.TabIndex = 3;
            // 
            // tbTelefonoAlta
            // 
            tbTelefonoAlta.Location = new Point(131, 91);
            tbTelefonoAlta.Name = "tbTelefonoAlta";
            tbTelefonoAlta.Size = new Size(100, 23);
            tbTelefonoAlta.TabIndex = 2;
            // 
            // tbApellidoAlta
            // 
            tbApellidoAlta.Location = new Point(131, 62);
            tbApellidoAlta.Name = "tbApellidoAlta";
            tbApellidoAlta.Size = new Size(100, 23);
            tbApellidoAlta.TabIndex = 1;
            // 
            // tbNombreAlta
            // 
            tbNombreAlta.Location = new Point(131, 33);
            tbNombreAlta.Name = "tbNombreAlta";
            tbNombreAlta.Size = new Size(100, 23);
            tbNombreAlta.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dtClientesElim);
            tabPage2.Controls.Add(btnEliminar);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(843, 640);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Baja";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtClientesElim
            // 
            dtClientesElim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtClientesElim.Columns.AddRange(new DataGridViewColumn[] { colNombreElim, colApellidoElim, colTelefonoElim, colDniElim });
            dtClientesElim.Location = new Point(118, 17);
            dtClientesElim.Name = "dtClientesElim";
            dtClientesElim.ReadOnly = true;
            dtClientesElim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtClientesElim.Size = new Size(503, 584);
            dtClientesElim.TabIndex = 1;
            // 
            // colNombreElim
            // 
            colNombreElim.HeaderText = "Nombre";
            colNombreElim.Name = "colNombreElim";
            colNombreElim.ReadOnly = true;
            // 
            // colApellidoElim
            // 
            colApellidoElim.HeaderText = "Apellido";
            colApellidoElim.Name = "colApellidoElim";
            colApellidoElim.ReadOnly = true;
            // 
            // colTelefonoElim
            // 
            colTelefonoElim.HeaderText = "Telefono";
            colTelefonoElim.Name = "colTelefonoElim";
            colTelefonoElim.ReadOnly = true;
            // 
            // colDniElim
            // 
            colDniElim.HeaderText = "DNI";
            colDniElim.Name = "colDniElim";
            colDniElim.ReadOnly = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(22, 17);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dtClientesModif);
            tabPage3.Controls.Add(btnModif);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(tbDniModif);
            tabPage3.Controls.Add(tbTelefonoModif);
            tabPage3.Controls.Add(tbApellidoModif);
            tabPage3.Controls.Add(tbNombreModif);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(843, 640);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Modificacion";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtClientesModif
            // 
            dtClientesModif.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtClientesModif.Columns.AddRange(new DataGridViewColumn[] { colNombreModif, colApellidoModif, colTelefonoModif, colDniModif });
            dtClientesModif.Location = new Point(250, 21);
            dtClientesModif.Name = "dtClientesModif";
            dtClientesModif.Size = new Size(485, 576);
            dtClientesModif.TabIndex = 18;
            // 
            // colNombreModif
            // 
            colNombreModif.HeaderText = "Nombre";
            colNombreModif.Name = "colNombreModif";
            // 
            // colApellidoModif
            // 
            colApellidoModif.HeaderText = "Apellido";
            colApellidoModif.Name = "colApellidoModif";
            // 
            // colTelefonoModif
            // 
            colTelefonoModif.HeaderText = "Telefono";
            colTelefonoModif.Name = "colTelefonoModif";
            // 
            // colDniModif
            // 
            colDniModif.HeaderText = "DNI";
            colDniModif.Name = "colDniModif";
            // 
            // btnModif
            // 
            btnModif.Location = new Point(35, 137);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(170, 23);
            btnModif.TabIndex = 17;
            btnModif.Text = "Modif";
            btnModif.UseVisualStyleBackColor = true;
            btnModif.Click += btnModif_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 116);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 16;
            label5.Text = "DNI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 87);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 15;
            label6.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 53);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 14;
            label7.Text = "Apellido";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 29);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 13;
            label8.Text = "Nombre";
            // 
            // tbDniModif
            // 
            tbDniModif.Location = new Point(105, 108);
            tbDniModif.Name = "tbDniModif";
            tbDniModif.Size = new Size(100, 23);
            tbDniModif.TabIndex = 12;
            // 
            // tbTelefonoModif
            // 
            tbTelefonoModif.Location = new Point(105, 79);
            tbTelefonoModif.Name = "tbTelefonoModif";
            tbTelefonoModif.Size = new Size(100, 23);
            tbTelefonoModif.TabIndex = 11;
            // 
            // tbApellidoModif
            // 
            tbApellidoModif.Location = new Point(105, 50);
            tbApellidoModif.Name = "tbApellidoModif";
            tbApellidoModif.Size = new Size(100, 23);
            tbApellidoModif.TabIndex = 10;
            // 
            // tbNombreModif
            // 
            tbNombreModif.Location = new Point(105, 21);
            tbNombreModif.Name = "tbNombreModif";
            tbNombreModif.Size = new Size(100, 23);
            tbNombreModif.TabIndex = 9;
            // 
            // gstClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 740);
            Controls.Add(tabControl1);
            Name = "gstClientes";
            Text = "gstClientes";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtClientesElim).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtClientesModif).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox tbNombreAlta;
        private TextBox tbDniAlta;
        private TextBox tbTelefonoAlta;
        private TextBox tbApellidoAlta;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAlta;
        private Label label4;
        private Button btnModif;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbDniModif;
        private TextBox tbTelefonoModif;
        private TextBox tbApellidoModif;
        private TextBox tbNombreModif;
        private DataGridView dtClientesModif;
        private DataGridView dtClientesElim;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn colNombreElim;
        private DataGridViewTextBoxColumn colApellidoElim;
        private DataGridViewTextBoxColumn colTelefonoElim;
        private DataGridViewTextBoxColumn colDniElim;
        private DataGridViewTextBoxColumn colNombreModif;
        private DataGridViewTextBoxColumn colApellidoModif;
        private DataGridViewTextBoxColumn colTelefonoModif;
        private DataGridViewTextBoxColumn colDniModif;
    }
}