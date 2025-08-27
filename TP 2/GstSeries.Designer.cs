namespace TP_2
{
    partial class GstSeries
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
            cbGenero = new ComboBox();
            tbRanking = new TextBox();
            tbDirector = new TextBox();
            tbDuracion = new TextBox();
            tbQEpisodios = new TextBox();
            tbQTemporadas = new TextBox();
            tbNombre = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnListar = new Button();
            btnEliminar = new Button();
            dataEliminar = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            btnListarModif = new Button();
            btnModificar = new Button();
            cbGeneroModif = new ComboBox();
            tbRankingModif = new TextBox();
            tbDirectorModif = new TextBox();
            tbDuracionModif = new TextBox();
            tbQEpisodiosModif = new TextBox();
            tbQTemporadasModif = new TextBox();
            tbNombreModif = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            dataModificar = new DataGridView();
            colNombreModif = new DataGridViewTextBoxColumn();
            colTemporadas = new DataGridViewTextBoxColumn();
            colEpisodios = new DataGridViewTextBoxColumn();
            colDuracion = new DataGridViewTextBoxColumn();
            colDirector = new DataGridViewTextBoxColumn();
            colGenero = new DataGridViewTextBoxColumn();
            colRanking = new DataGridViewTextBoxColumn();
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
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1293, 741);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAgregar);
            tabPage1.Controls.Add(cbGenero);
            tabPage1.Controls.Add(tbRanking);
            tabPage1.Controls.Add(tbDirector);
            tabPage1.Controls.Add(tbDuracion);
            tabPage1.Controls.Add(tbQEpisodios);
            tabPage1.Controls.Add(tbQTemporadas);
            tabPage1.Controls.Add(tbNombre);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1285, 713);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Alta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(27, 267);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(294, 23);
            btnAgregar.TabIndex = 29;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbGenero
            // 
            cbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(200, 229);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(121, 23);
            cbGenero.TabIndex = 28;
            // 
            // tbRanking
            // 
            tbRanking.Location = new Point(200, 187);
            tbRanking.Name = "tbRanking";
            tbRanking.Size = new Size(100, 23);
            tbRanking.TabIndex = 27;
            // 
            // tbDirector
            // 
            tbDirector.Location = new Point(200, 148);
            tbDirector.Name = "tbDirector";
            tbDirector.Size = new Size(100, 23);
            tbDirector.TabIndex = 26;
            // 
            // tbDuracion
            // 
            tbDuracion.Location = new Point(200, 107);
            tbDuracion.Name = "tbDuracion";
            tbDuracion.Size = new Size(100, 23);
            tbDuracion.TabIndex = 25;
            // 
            // tbQEpisodios
            // 
            tbQEpisodios.Location = new Point(200, 67);
            tbQEpisodios.Name = "tbQEpisodios";
            tbQEpisodios.Size = new Size(100, 23);
            tbQEpisodios.TabIndex = 24;
            // 
            // tbQTemporadas
            // 
            tbQTemporadas.Location = new Point(200, 38);
            tbQTemporadas.Name = "tbQTemporadas";
            tbQTemporadas.Size = new Size(100, 23);
            tbQTemporadas.TabIndex = 23;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(200, 9);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 237);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 21;
            label7.Text = "Genero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 195);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 20;
            label6.Text = "Ranking (1 a 10)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 156);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 19;
            label5.Text = "Director";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 115);
            label4.Name = "label4";
            label4.Size = new Size(158, 15);
            label4.TabIndex = 18;
            label4.Text = "Duracion episodio (minutos)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 81);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 17;
            label3.Text = "Episodios por temporada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 46);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 16;
            label2.Text = "Cantidad de temporadas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 17);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 15;
            label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnListar);
            tabPage2.Controls.Add(btnEliminar);
            tabPage2.Controls.Add(dataEliminar);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1285, 713);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Baja";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(276, 23);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(276, 63);
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
            dataEliminar.Location = new Point(17, 23);
            dataEliminar.Name = "dataEliminar";
            dataEliminar.Size = new Size(240, 307);
            dataEliminar.TabIndex = 0;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnListarModif);
            tabPage3.Controls.Add(btnModificar);
            tabPage3.Controls.Add(cbGeneroModif);
            tabPage3.Controls.Add(tbRankingModif);
            tabPage3.Controls.Add(tbDirectorModif);
            tabPage3.Controls.Add(tbDuracionModif);
            tabPage3.Controls.Add(tbQEpisodiosModif);
            tabPage3.Controls.Add(tbQTemporadasModif);
            tabPage3.Controls.Add(tbNombreModif);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(dataModificar);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1285, 713);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Modificar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnListarModif
            // 
            btnListarModif.Location = new Point(796, 30);
            btnListarModif.Name = "btnListarModif";
            btnListarModif.Size = new Size(75, 23);
            btnListarModif.TabIndex = 45;
            btnListarModif.Text = "Listar";
            btnListarModif.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(936, 282);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(294, 23);
            btnModificar.TabIndex = 44;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // cbGeneroModif
            // 
            cbGeneroModif.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGeneroModif.FormattingEnabled = true;
            cbGeneroModif.Location = new Point(1109, 244);
            cbGeneroModif.Name = "cbGeneroModif";
            cbGeneroModif.Size = new Size(121, 23);
            cbGeneroModif.TabIndex = 43;
            // 
            // tbRankingModif
            // 
            tbRankingModif.Location = new Point(1109, 202);
            tbRankingModif.Name = "tbRankingModif";
            tbRankingModif.Size = new Size(100, 23);
            tbRankingModif.TabIndex = 42;
            // 
            // tbDirectorModif
            // 
            tbDirectorModif.Location = new Point(1109, 163);
            tbDirectorModif.Name = "tbDirectorModif";
            tbDirectorModif.Size = new Size(100, 23);
            tbDirectorModif.TabIndex = 41;
            // 
            // tbDuracionModif
            // 
            tbDuracionModif.Location = new Point(1109, 122);
            tbDuracionModif.Name = "tbDuracionModif";
            tbDuracionModif.Size = new Size(100, 23);
            tbDuracionModif.TabIndex = 40;
            // 
            // tbQEpisodiosModif
            // 
            tbQEpisodiosModif.Location = new Point(1109, 82);
            tbQEpisodiosModif.Name = "tbQEpisodiosModif";
            tbQEpisodiosModif.Size = new Size(100, 23);
            tbQEpisodiosModif.TabIndex = 39;
            // 
            // tbQTemporadasModif
            // 
            tbQTemporadasModif.Location = new Point(1109, 53);
            tbQTemporadasModif.Name = "tbQTemporadasModif";
            tbQTemporadasModif.Size = new Size(100, 23);
            tbQTemporadasModif.TabIndex = 38;
            // 
            // tbNombreModif
            // 
            tbNombreModif.Location = new Point(1109, 24);
            tbNombreModif.Name = "tbNombreModif";
            tbNombreModif.Size = new Size(100, 23);
            tbNombreModif.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(936, 252);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 36;
            label8.Text = "Genero";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(936, 210);
            label9.Name = "label9";
            label9.Size = new Size(91, 15);
            label9.TabIndex = 35;
            label9.Text = "Ranking (1 a 10)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(936, 171);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 34;
            label10.Text = "Director";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(936, 130);
            label11.Name = "label11";
            label11.Size = new Size(158, 15);
            label11.TabIndex = 33;
            label11.Text = "Duracion episodio (minutos)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(936, 96);
            label12.Name = "label12";
            label12.Size = new Size(139, 15);
            label12.TabIndex = 32;
            label12.Text = "Episodios por temporada";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(936, 61);
            label13.Name = "label13";
            label13.Size = new Size(137, 15);
            label13.TabIndex = 31;
            label13.Text = "Cantidad de temporadas";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(936, 32);
            label14.Name = "label14";
            label14.Size = new Size(51, 15);
            label14.TabIndex = 30;
            label14.Text = "Nombre";
            // 
            // dataModificar
            // 
            dataModificar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataModificar.Columns.AddRange(new DataGridViewColumn[] { colNombreModif, colTemporadas, colEpisodios, colDuracion, colDirector, colGenero, colRanking });
            dataModificar.Location = new Point(25, 24);
            dataModificar.Name = "dataModificar";
            dataModificar.Size = new Size(748, 667);
            dataModificar.TabIndex = 0;
            // 
            // colNombreModif
            // 
            colNombreModif.HeaderText = "Nombre";
            colNombreModif.Name = "colNombreModif";
            // 
            // colTemporadas
            // 
            colTemporadas.HeaderText = "Temporadas";
            colTemporadas.Name = "colTemporadas";
            // 
            // colEpisodios
            // 
            colEpisodios.HeaderText = "Episodios";
            colEpisodios.Name = "colEpisodios";
            // 
            // colDuracion
            // 
            colDuracion.HeaderText = "Duracion";
            colDuracion.Name = "colDuracion";
            // 
            // colDirector
            // 
            colDirector.HeaderText = "Director";
            colDirector.Name = "colDirector";
            // 
            // colGenero
            // 
            colGenero.HeaderText = "Genero";
            colGenero.Name = "colGenero";
            // 
            // colRanking
            // 
            colRanking.HeaderText = "Ranking";
            colRanking.Name = "colRanking";
            // 
            // GstSeries
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 765);
            Controls.Add(tabControl1);
            Name = "GstSeries";
            Text = "GstSeries";
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
        private Button btnAgregar;
        private ComboBox cbGenero;
        private TextBox tbRanking;
        private TextBox tbDirector;
        private TextBox tbDuracion;
        private TextBox tbQEpisodios;
        private TextBox tbQTemporadas;
        private TextBox tbNombre;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataEliminar;
        private DataGridViewTextBoxColumn colNombre;
        private Button btnModificar;
        private ComboBox cbGeneroModif;
        private TextBox tbRankingModif;
        private TextBox tbDirectorModif;
        private TextBox tbDuracionModif;
        private TextBox tbQEpisodiosModif;
        private TextBox tbQTemporadasModif;
        private TextBox tbNombreModif;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridView dataModificar;
        private DataGridViewTextBoxColumn colNombreModif;
        private DataGridViewTextBoxColumn colTemporadas;
        private DataGridViewTextBoxColumn colEpisodios;
        private DataGridViewTextBoxColumn colDuracion;
        private DataGridViewTextBoxColumn colDirector;
        private DataGridViewTextBoxColumn colGenero;
        private DataGridViewTextBoxColumn colRanking;
        private Button btnListar;
        private Button btnEliminar;
        private Button btnListarModif;
    }
}