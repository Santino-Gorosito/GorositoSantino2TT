namespace TP_2
{
    partial class GstUsuarios
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
            btnRegistrar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtFechaNac = new DateTimePicker();
            tbDni = new TextBox();
            tbNombre = new TextBox();
            tabPage2 = new TabPage();
            btnListar = new Button();
            btnEliminar = new Button();
            dataEliminar = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colDni = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            btnModificar = new Button();
            btnListarModif = new Button();
            dataModificar = new DataGridView();
            colNombreModif = new DataGridViewTextBoxColumn();
            colDniModif = new DataGridViewTextBoxColumn();
            colFechaNacModif = new DataGridViewTextBoxColumn();
            tbDniModif = new TextBox();
            tbNombreModif = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataEliminar).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataModificar).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(21, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(767, 380);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRegistrar);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dtFechaNac);
            tabPage1.Controls.Add(tbDni);
            tabPage1.Controls.Add(tbNombre);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(759, 352);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Alta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(14, 144);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(325, 23);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 112);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 85);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 4;
            label2.Text = "DNI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 56);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre completo";
            // 
            // dtFechaNac
            // 
            dtFechaNac.Location = new Point(139, 106);
            dtFechaNac.Name = "dtFechaNac";
            dtFechaNac.Size = new Size(200, 23);
            dtFechaNac.TabIndex = 2;
            // 
            // tbDni
            // 
            tbDni.Location = new Point(139, 77);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(100, 23);
            tbDni.TabIndex = 1;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(139, 48);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnListar);
            tabPage2.Controls.Add(btnEliminar);
            tabPage2.Controls.Add(dataEliminar);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(759, 352);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Baja";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(289, 12);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(289, 41);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataEliminar
            // 
            dataEliminar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataEliminar.Columns.AddRange(new DataGridViewColumn[] { colNombre, colDni });
            dataEliminar.Location = new Point(22, 20);
            dataEliminar.Name = "dataEliminar";
            dataEliminar.Size = new Size(244, 312);
            dataEliminar.TabIndex = 0;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            // 
            // colDni
            // 
            colDni.HeaderText = "DNI";
            colDni.Name = "colDni";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(btnModificar);
            tabPage3.Controls.Add(btnListarModif);
            tabPage3.Controls.Add(dataModificar);
            tabPage3.Controls.Add(tbDniModif);
            tabPage3.Controls.Add(tbNombreModif);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(759, 352);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Modificar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(470, 53);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 7;
            label5.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(470, 19);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Nombre";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(470, 74);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(168, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnListarModif
            // 
            btnListarModif.Location = new Point(373, 16);
            btnListarModif.Name = "btnListarModif";
            btnListarModif.Size = new Size(75, 23);
            btnListarModif.TabIndex = 4;
            btnListarModif.Text = "Listar";
            btnListarModif.UseVisualStyleBackColor = true;
            btnListarModif.Click += btnListarModif_Click;
            // 
            // dataModificar
            // 
            dataModificar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataModificar.Columns.AddRange(new DataGridViewColumn[] { colNombreModif, colDniModif, colFechaNacModif });
            dataModificar.Location = new Point(6, 16);
            dataModificar.Name = "dataModificar";
            dataModificar.Size = new Size(344, 317);
            dataModificar.TabIndex = 3;
            // 
            // colNombreModif
            // 
            colNombreModif.HeaderText = "Nombre";
            colNombreModif.Name = "colNombreModif";
            // 
            // colDniModif
            // 
            colDniModif.HeaderText = "DNI";
            colDniModif.Name = "colDniModif";
            // 
            // colFechaNacModif
            // 
            colFechaNacModif.HeaderText = "Fecha de Nacimiento";
            colFechaNacModif.Name = "colFechaNacModif";
            // 
            // tbDniModif
            // 
            tbDniModif.Location = new Point(538, 45);
            tbDniModif.Name = "tbDniModif";
            tbDniModif.Size = new Size(100, 23);
            tbDniModif.TabIndex = 1;
            // 
            // tbNombreModif
            // 
            tbNombreModif.Location = new Point(538, 16);
            tbNombreModif.Name = "tbNombreModif";
            tbNombreModif.Size = new Size(100, 23);
            tbNombreModif.TabIndex = 0;
            // 
            // GstUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "GstUsuarios";
            Text = "GstUsuarios";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataEliminar).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataModificar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtFechaNac;
        private TextBox tbDni;
        private TextBox tbNombre;
        private Button btnRegistrar;
        private DataGridView dataEliminar;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colDni;
        private Button btnEliminar;
        private Button btnListar;
        private DataGridView dataModificar;
        private TextBox tbDniModif;
        private TextBox tbNombreModif;
        private Button btnModificar;
        private Button btnListarModif;
        private DataGridViewTextBoxColumn colNombreModif;
        private DataGridViewTextBoxColumn colDniModif;
        private DataGridViewTextBoxColumn colFechaNacModif;
        private Label label5;
        private Label label4;
    }
}