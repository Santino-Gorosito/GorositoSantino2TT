namespace ado_multiplestablas
{
    partial class gstPasajes
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
            tbNumeroAsiento = new TextBox();
            dtFechaVuelo = new DateTimePicker();
            tbIdAvion = new TextBox();
            tbIdPasajero = new TextBox();
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // tbNumeroAsiento
            // 
            tbNumeroAsiento.Location = new Point(105, 61);
            tbNumeroAsiento.Name = "tbNumeroAsiento";
            tbNumeroAsiento.Size = new Size(200, 23);
            tbNumeroAsiento.TabIndex = 0;
            // 
            // dtFechaVuelo
            // 
            dtFechaVuelo.Location = new Point(105, 90);
            dtFechaVuelo.Name = "dtFechaVuelo";
            dtFechaVuelo.Size = new Size(200, 23);
            dtFechaVuelo.TabIndex = 1;
            // 
            // tbIdAvion
            // 
            tbIdAvion.Location = new Point(105, 119);
            tbIdAvion.Name = "tbIdAvion";
            tbIdAvion.Size = new Size(200, 23);
            tbIdAvion.TabIndex = 2;
            // 
            // tbIdPasajero
            // 
            tbIdPasajero.Location = new Point(105, 148);
            tbIdPasajero.Name = "tbIdPasajero";
            tbIdPasajero.Size = new Size(200, 23);
            tbIdPasajero.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(105, 177);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(200, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 5;
            label1.Text = "Numero Asiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 96);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 6;
            label2.Text = "Fecha de vuelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 127);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Id Avion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 156);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 8;
            label4.Text = "Id Pasajero";
            // 
            // gstPasajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(tbIdPasajero);
            Controls.Add(tbIdAvion);
            Controls.Add(dtFechaVuelo);
            Controls.Add(tbNumeroAsiento);
            Name = "gstPasajes";
            Text = "gstPasajes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNumeroAsiento;
        private DateTimePicker dtFechaVuelo;
        private TextBox tbIdAvion;
        private TextBox tbIdPasajero;
        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}