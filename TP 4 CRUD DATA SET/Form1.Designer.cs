namespace TP_4_CRUD_DATA_SET
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataSQL = new System.Windows.Forms.DataGridView();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnNuev = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSQL
            // 
            this.dataSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSQL.Location = new System.Drawing.Point(12, 99);
            this.dataSQL.MultiSelect = false;
            this.dataSQL.Name = "dataSQL";
            this.dataSQL.ReadOnly = true;
            this.dataSQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSQL.Size = new System.Drawing.Size(776, 339);
            this.dataSQL.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(713, 70);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 1;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnNuev
            // 
            this.btnNuev.Location = new System.Drawing.Point(12, 70);
            this.btnNuev.Name = "btnNuev";
            this.btnNuev.Size = new System.Drawing.Size(75, 23);
            this.btnNuev.TabIndex = 2;
            this.btnNuev.Text = "Nuevo";
            this.btnNuev.UseVisualStyleBackColor = true;
            this.btnNuev.Click += new System.EventHandler(this.btnNuev_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(102, 70);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(194, 70);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.TabIndex = 4;
            this.btnModif.Text = "Modificar";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuev);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.dataSQL);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataSQL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSQL;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnNuev;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModif;
    }
}

