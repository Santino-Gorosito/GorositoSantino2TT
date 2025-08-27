namespace TP_2
{
    partial class GstCanales
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
            btnAgregar = new Button();
            clbSeries = new CheckedListBox();
            label2 = new Label();
            label1 = new Label();
            tbNombre = new TextBox();
            tabPage2 = new TabPage();
            btnListar = new Button();
            btnEliminar = new Button();
            dataEliminar = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            btnModificar = new Button();
            label4 = new Label();
            tbNombreModif = new TextBox();
            clbSeriesModif = new CheckedListBox();
            tbNombreCanal = new TextBox();
            label3 = new Label();
            btnCargarCanal = new Button();
            btnAtras = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataEliminar).BeginInit();
            tabPage3.SuspendLayout();
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
            tabControl1.Size = new Size(678, 387);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAgregar);
            tabPage1.Controls.Add(clbSeries);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(tbNombre);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(670, 359);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Alta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(28, 165);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(177, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // clbSeries
            // 
            clbSeries.FormattingEnabled = true;
            clbSeries.Location = new Point(85, 49);
            clbSeries.Name = "clbSeries";
            clbSeries.Size = new Size(120, 94);
            clbSeries.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 49);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Series";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 15);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(85, 7);
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
            tabPage2.Size = new Size(670, 359);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Baja";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(285, 23);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(285, 56);
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
            dataEliminar.Location = new Point(29, 23);
            dataEliminar.Name = "dataEliminar";
            dataEliminar.Size = new Size(240, 330);
            dataEliminar.TabIndex = 0;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre Canal";
            colNombre.Name = "colNombre";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnModificar);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(tbNombreModif);
            tabPage3.Controls.Add(clbSeriesModif);
            tabPage3.Controls.Add(tbNombreCanal);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(btnCargarCanal);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(670, 359);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Modificar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new Point(145, 102);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(203, 23);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 81);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 5;
            label4.Text = "Nuevo nombre";
            // 
            // tbNombreModif
            // 
            tbNombreModif.Enabled = false;
            tbNombreModif.Location = new Point(248, 73);
            tbNombreModif.Name = "tbNombreModif";
            tbNombreModif.Size = new Size(100, 23);
            tbNombreModif.TabIndex = 4;
            // 
            // clbSeriesModif
            // 
            clbSeriesModif.Enabled = false;
            clbSeriesModif.FormattingEnabled = true;
            clbSeriesModif.Location = new Point(6, 73);
            clbSeriesModif.Name = "clbSeriesModif";
            clbSeriesModif.Size = new Size(120, 274);
            clbSeriesModif.TabIndex = 3;
            // 
            // tbNombreCanal
            // 
            tbNombreCanal.Location = new Point(176, 23);
            tbNombreCanal.Name = "tbNombreCanal";
            tbNombreCanal.Size = new Size(100, 23);
            tbNombreCanal.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 31);
            label3.Name = "label3";
            label3.Size = new Size(164, 15);
            label3.TabIndex = 1;
            label3.Text = "Nombre del canal a modificar";
            // 
            // btnCargarCanal
            // 
            btnCargarCanal.Location = new Point(282, 23);
            btnCargarCanal.Name = "btnCargarCanal";
            btnCargarCanal.Size = new Size(75, 23);
            btnCargarCanal.TabIndex = 0;
            btnCargarCanal.Text = "Cargar";
            btnCargarCanal.UseVisualStyleBackColor = true;
            btnCargarCanal.Click += btnCargarCanal_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(713, 415);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // GstCanales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtras);
            Controls.Add(tabControl1);
            Name = "GstCanales";
            Text = "GstCanales";
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

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label2;
        private Label label1;
        private TextBox tbNombre;
        private CheckedListBox clbSeries;
        private Button btnAgregar;
        private Button btnAtras;
        private Button btnListar;
        private Button btnEliminar;
        private DataGridView dataEliminar;
        private DataGridViewTextBoxColumn colNombre;
        private TextBox tbNombreCanal;
        private Label label3;
        private Button btnCargarCanal;
        private CheckedListBox clbSeriesModif;
        private Button btnModificar;
        private Label label4;
        private TextBox tbNombreModif;
    }
}