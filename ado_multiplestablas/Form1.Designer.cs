namespace ado_multiplestablas
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
            dgvAviones = new DataGridView();
            btnAgregarAviones = new Button();
            btnEliminarAviones = new Button();
            Pasajeros = new TabControl();
            Aviones = new TabPage();
            btnModificar = new Button();
            btnRefrescarAviones = new Button();
            tabPage2 = new TabPage();
            btnModifPasajero = new Button();
            btnRefrescarPasajeros = new Button();
            btnEliminarPasajero = new Button();
            btnAgregarPasajeros = new Button();
            dgvPasajeros = new DataGridView();
            tabPage1 = new TabPage();
            btnRefrescarPasajes = new Button();
            btnEliminarPasaje = new Button();
            btnAgregarPasaje = new Button();
            dgvPasajes = new DataGridView();
            colIdPasaje = new DataGridViewTextBoxColumn();
            colNumAsiento = new DataGridViewTextBoxColumn();
            colIdPasajero = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colIdAvion = new DataGridViewTextBoxColumn();
            btnModifPasaje = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAviones).BeginInit();
            Pasajeros.SuspendLayout();
            Aviones.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPasajeros).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPasajes).BeginInit();
            SuspendLayout();
            // 
            // dgvAviones
            // 
            dgvAviones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAviones.Location = new Point(32, 65);
            dgvAviones.Name = "dgvAviones";
            dgvAviones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAviones.Size = new Size(446, 427);
            dgvAviones.TabIndex = 0;
            // 
            // btnAgregarAviones
            // 
            btnAgregarAviones.Location = new Point(32, 36);
            btnAgregarAviones.Name = "btnAgregarAviones";
            btnAgregarAviones.Size = new Size(75, 23);
            btnAgregarAviones.TabIndex = 1;
            btnAgregarAviones.Text = "Agregar";
            btnAgregarAviones.UseVisualStyleBackColor = true;
            btnAgregarAviones.Click += btnAgregarAviones_Click;
            // 
            // btnEliminarAviones
            // 
            btnEliminarAviones.Location = new Point(113, 36);
            btnEliminarAviones.Name = "btnEliminarAviones";
            btnEliminarAviones.Size = new Size(75, 23);
            btnEliminarAviones.TabIndex = 2;
            btnEliminarAviones.Text = "Eliminar";
            btnEliminarAviones.UseVisualStyleBackColor = true;
            btnEliminarAviones.Click += btnEliminarAviones_Click;
            // 
            // Pasajeros
            // 
            Pasajeros.Controls.Add(Aviones);
            Pasajeros.Controls.Add(tabPage2);
            Pasajeros.Controls.Add(tabPage1);
            Pasajeros.Location = new Point(30, 39);
            Pasajeros.Name = "Pasajeros";
            Pasajeros.SelectedIndex = 0;
            Pasajeros.Size = new Size(934, 639);
            Pasajeros.TabIndex = 3;
            // 
            // Aviones
            // 
            Aviones.Controls.Add(btnModificar);
            Aviones.Controls.Add(btnRefrescarAviones);
            Aviones.Controls.Add(dgvAviones);
            Aviones.Controls.Add(btnEliminarAviones);
            Aviones.Controls.Add(btnAgregarAviones);
            Aviones.Location = new Point(4, 24);
            Aviones.Name = "Aviones";
            Aviones.Padding = new Padding(3);
            Aviones.Size = new Size(926, 611);
            Aviones.TabIndex = 0;
            Aviones.Text = "Aviones";
            Aviones.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(275, 36);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnRefrescarAviones
            // 
            btnRefrescarAviones.Location = new Point(194, 36);
            btnRefrescarAviones.Name = "btnRefrescarAviones";
            btnRefrescarAviones.Size = new Size(75, 23);
            btnRefrescarAviones.TabIndex = 3;
            btnRefrescarAviones.Text = "Refrescar";
            btnRefrescarAviones.UseVisualStyleBackColor = true;
            btnRefrescarAviones.Click += btnRefrescarAviones_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnModifPasajero);
            tabPage2.Controls.Add(btnRefrescarPasajeros);
            tabPage2.Controls.Add(btnEliminarPasajero);
            tabPage2.Controls.Add(btnAgregarPasajeros);
            tabPage2.Controls.Add(dgvPasajeros);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(926, 611);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pasajeros";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnModifPasajero
            // 
            btnModifPasajero.Location = new Point(288, 31);
            btnModifPasajero.Name = "btnModifPasajero";
            btnModifPasajero.Size = new Size(75, 23);
            btnModifPasajero.TabIndex = 4;
            btnModifPasajero.Text = "Modificar";
            btnModifPasajero.UseVisualStyleBackColor = true;
            btnModifPasajero.Click += btnModifPasajero_Click;
            // 
            // btnRefrescarPasajeros
            // 
            btnRefrescarPasajeros.Location = new Point(207, 31);
            btnRefrescarPasajeros.Name = "btnRefrescarPasajeros";
            btnRefrescarPasajeros.Size = new Size(75, 23);
            btnRefrescarPasajeros.TabIndex = 3;
            btnRefrescarPasajeros.Text = "Refrescar";
            btnRefrescarPasajeros.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPasajero
            // 
            btnEliminarPasajero.Location = new Point(117, 31);
            btnEliminarPasajero.Name = "btnEliminarPasajero";
            btnEliminarPasajero.Size = new Size(75, 23);
            btnEliminarPasajero.TabIndex = 2;
            btnEliminarPasajero.Text = "Eliminar";
            btnEliminarPasajero.UseVisualStyleBackColor = true;
            btnEliminarPasajero.Click += btnEliminarPasajero_Click;
            // 
            // btnAgregarPasajeros
            // 
            btnAgregarPasajeros.Location = new Point(36, 31);
            btnAgregarPasajeros.Name = "btnAgregarPasajeros";
            btnAgregarPasajeros.Size = new Size(75, 23);
            btnAgregarPasajeros.TabIndex = 1;
            btnAgregarPasajeros.Text = "Agregar";
            btnAgregarPasajeros.UseVisualStyleBackColor = true;
            btnAgregarPasajeros.Click += btnAgregarPasajeros_Click;
            // 
            // dgvPasajeros
            // 
            dgvPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasajeros.Location = new Point(36, 60);
            dgvPasajeros.Name = "dgvPasajeros";
            dgvPasajeros.Size = new Size(864, 470);
            dgvPasajeros.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnModifPasaje);
            tabPage1.Controls.Add(btnRefrescarPasajes);
            tabPage1.Controls.Add(btnEliminarPasaje);
            tabPage1.Controls.Add(btnAgregarPasaje);
            tabPage1.Controls.Add(dgvPasajes);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(926, 611);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Pasajes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRefrescarPasajes
            // 
            btnRefrescarPasajes.Location = new Point(186, 28);
            btnRefrescarPasajes.Name = "btnRefrescarPasajes";
            btnRefrescarPasajes.Size = new Size(75, 23);
            btnRefrescarPasajes.TabIndex = 3;
            btnRefrescarPasajes.Text = "Refrescar";
            btnRefrescarPasajes.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPasaje
            // 
            btnEliminarPasaje.Location = new Point(105, 28);
            btnEliminarPasaje.Name = "btnEliminarPasaje";
            btnEliminarPasaje.Size = new Size(75, 23);
            btnEliminarPasaje.TabIndex = 2;
            btnEliminarPasaje.Text = "Eliminar";
            btnEliminarPasaje.UseVisualStyleBackColor = true;
            btnEliminarPasaje.Click += btnEliminarPasaje_Click;
            // 
            // btnAgregarPasaje
            // 
            btnAgregarPasaje.Location = new Point(24, 28);
            btnAgregarPasaje.Name = "btnAgregarPasaje";
            btnAgregarPasaje.Size = new Size(75, 23);
            btnAgregarPasaje.TabIndex = 1;
            btnAgregarPasaje.Text = "Agregar";
            btnAgregarPasaje.UseVisualStyleBackColor = true;
            btnAgregarPasaje.Click += btnAgregarPasaje_Click;
            // 
            // dgvPasajes
            // 
            dgvPasajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasajes.Columns.AddRange(new DataGridViewColumn[] { colIdPasaje, colNumAsiento, colIdPasajero, colFecha, colIdAvion });
            dgvPasajes.Location = new Point(24, 57);
            dgvPasajes.Name = "dgvPasajes";
            dgvPasajes.Size = new Size(873, 494);
            dgvPasajes.TabIndex = 0;
            // 
            // colIdPasaje
            // 
            colIdPasaje.HeaderText = "IdPasaje";
            colIdPasaje.Name = "colIdPasaje";
            // 
            // colNumAsiento
            // 
            colNumAsiento.HeaderText = "Asiento";
            colNumAsiento.Name = "colNumAsiento";
            // 
            // colIdPasajero
            // 
            colIdPasajero.HeaderText = "IdPasajero";
            colIdPasajero.Name = "colIdPasajero";
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha Vuelo";
            colFecha.Name = "colFecha";
            // 
            // colIdAvion
            // 
            colIdAvion.HeaderText = "IdAvion";
            colIdAvion.Name = "colIdAvion";
            // 
            // btnModifPasaje
            // 
            btnModifPasaje.Location = new Point(267, 28);
            btnModifPasaje.Name = "btnModifPasaje";
            btnModifPasaje.Size = new Size(75, 23);
            btnModifPasaje.TabIndex = 4;
            btnModifPasaje.Text = "Modificar";
            btnModifPasaje.UseVisualStyleBackColor = true;
            btnModifPasaje.Click += btnModifPasaje_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 690);
            Controls.Add(Pasajeros);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAviones).EndInit();
            Pasajeros.ResumeLayout(false);
            Aviones.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPasajeros).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPasajes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAviones;
        private Button btnAgregarAviones;
        private Button btnEliminarAviones;
        private TabControl Pasajeros;
        private TabPage Aviones;
        private TabPage tabPage2;
        private Button btnEliminarPasajero;
        private Button btnAgregarPasajeros;
        private DataGridView dgvPasajeros;
        private TabPage tabPage1;
        private Button btnRefrescarAviones;
        private Button btnRefrescarPasajeros;
        private Button btnRefrescarPasajes;
        private Button btnEliminarPasaje;
        private Button btnAgregarPasaje;
        private DataGridView dgvPasajes;
        private DataGridViewTextBoxColumn colIdPasaje;
        private DataGridViewTextBoxColumn colNumAsiento;
        private DataGridViewTextBoxColumn colIdPasajero;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colIdAvion;
        private Button btnModificar;
        private Button btnModifPasajero;
        private Button btnModifPasaje;
    }
}
