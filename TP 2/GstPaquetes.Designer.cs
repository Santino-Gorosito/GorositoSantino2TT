namespace TP_2
{
    partial class GstPaquetes
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
            btnAtras = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            clbCanales = new CheckedListBox();
            tbNombre = new TextBox();
            btnAgregar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnListar = new Button();
            btnEliminar = new Button();
            dataEliminar = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            btnCargar = new Button();
            tbNombrePaquete = new TextBox();
            label4 = new Label();
            clbCanalesModif = new CheckedListBox();
            label5 = new Label();
            tbNombreModif = new TextBox();
            btnModificar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataEliminar).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(713, 415);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 0;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(686, 373);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(radioButton2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Controls.Add(clbCanales);
            tabPage1.Controls.Add(tbNombre);
            tabPage1.Controls.Add(btnAgregar);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(678, 345);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Alta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(276, 88);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(74, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Premium";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(276, 63);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(53, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Silver";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // clbCanales
            // 
            clbCanales.FormattingEnabled = true;
            clbCanales.Location = new Point(35, 62);
            clbCanales.Name = "clbCanales";
            clbCanales.Size = new Size(120, 94);
            clbCanales.TabIndex = 5;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(138, 11);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(35, 194);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(361, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 45);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 44);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Canales ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 19);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Paquete";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnListar);
            tabPage2.Controls.Add(btnEliminar);
            tabPage2.Controls.Add(dataEliminar);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(678, 345);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Baja";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(166, 6);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(166, 34);
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
            dataEliminar.Columns.AddRange(new DataGridViewColumn[] { colNombre });
            dataEliminar.Location = new Point(6, 6);
            dataEliminar.Name = "dataEliminar";
            dataEliminar.Size = new Size(145, 333);
            dataEliminar.TabIndex = 0;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnModificar);
            tabPage3.Controls.Add(tbNombreModif);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(clbCanalesModif);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(tbNombrePaquete);
            tabPage3.Controls.Add(btnCargar);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(678, 345);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Modificar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(278, 20);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 0;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            // 
            // tbNombrePaquete
            // 
            tbNombrePaquete.Location = new Point(172, 20);
            tbNombrePaquete.Name = "tbNombrePaquete";
            tbNombrePaquete.Size = new Size(100, 23);
            tbNombrePaquete.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 28);
            label4.Name = "label4";
            label4.Size = new Size(160, 15);
            label4.TabIndex = 2;
            label4.Text = "Nombre Paquete a modificar";
            // 
            // clbCanalesModif
            // 
            clbCanalesModif.Enabled = false;
            clbCanalesModif.FormattingEnabled = true;
            clbCanalesModif.Location = new Point(25, 71);
            clbCanalesModif.Name = "clbCanalesModif";
            clbCanalesModif.Size = new Size(120, 94);
            clbCanalesModif.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 114);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 4;
            label5.Text = "Nombre Nuevo";
            // 
            // tbNombreModif
            // 
            tbNombreModif.Enabled = false;
            tbNombreModif.Location = new Point(292, 106);
            tbNombreModif.Name = "tbNombreModif";
            tbNombreModif.Size = new Size(100, 23);
            tbNombreModif.TabIndex = 5;
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new Point(197, 142);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(195, 23);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // GstPaquetes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(btnAtras);
            Name = "GstPaquetes";
            Text = "GstPaquetes";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataEliminar).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtras;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private CheckedListBox clbCanales;
        private TextBox tbNombre;
        private Button btnAgregar;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DataGridView dataEliminar;
        private Button btnListar;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn colNombre;
        private Label label4;
        private TextBox tbNombrePaquete;
        private Button btnCargar;
        private Button btnModificar;
        private TextBox tbNombreModif;
        private Label label5;
        private CheckedListBox clbCanalesModif;
    }
}