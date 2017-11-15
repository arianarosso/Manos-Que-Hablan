namespace ManosQueHablan
{
    partial class Escribir
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
            this.txtEscribir = new System.Windows.Forms.TextBox();
            this.lblEscribirLetra = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pcbPista = new System.Windows.Forms.PictureBox();
            this.pcbPasar = new System.Windows.Forms.PictureBox();
            this.pcb1EL = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPasar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1EL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEscribir
            // 
            this.txtEscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.txtEscribir.Location = new System.Drawing.Point(509, 210);
            this.txtEscribir.Name = "txtEscribir";
            this.txtEscribir.Size = new System.Drawing.Size(259, 30);
            this.txtEscribir.TabIndex = 25;
            this.txtEscribir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEscribir_KeyPress);
            // 
            // lblEscribirLetra
            // 
            this.lblEscribirLetra.AutoSize = true;
            this.lblEscribirLetra.BackColor = System.Drawing.Color.Transparent;
            this.lblEscribirLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscribirLetra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEscribirLetra.Location = new System.Drawing.Point(240, 308);
            this.lblEscribirLetra.Name = "lblEscribirLetra";
            this.lblEscribirLetra.Size = new System.Drawing.Size(0, 24);
            this.lblEscribirLetra.TabIndex = 26;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Myriad Pro Light", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(249, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(29, 45);
            this.lblTitulo.TabIndex = 27;
            this.lblTitulo.Text = ".";
            // 
            // pcbPista
            // 
            this.pcbPista.BackColor = System.Drawing.Color.Transparent;
            this.pcbPista.Location = new System.Drawing.Point(167, 386);
            this.pcbPista.Name = "pcbPista";
            this.pcbPista.Size = new System.Drawing.Size(267, 110);
            this.pcbPista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbPista.TabIndex = 30;
            this.pcbPista.TabStop = false;
            this.pcbPista.Click += new System.EventHandler(this.pcbPista_Click);
            // 
            // pcbPasar
            // 
            this.pcbPasar.BackColor = System.Drawing.Color.Transparent;
            this.pcbPasar.Location = new System.Drawing.Point(925, 354);
            this.pcbPasar.Name = "pcbPasar";
            this.pcbPasar.Size = new System.Drawing.Size(251, 99);
            this.pcbPasar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbPasar.TabIndex = 28;
            this.pcbPasar.TabStop = false;
            this.pcbPasar.Click += new System.EventHandler(this.pcbPasar_Click);
            // 
            // pcb1EL
            // 
            this.pcb1EL.BackColor = System.Drawing.Color.Transparent;
            this.pcb1EL.Location = new System.Drawing.Point(167, 104);
            this.pcb1EL.Name = "pcb1EL";
            this.pcb1EL.Size = new System.Drawing.Size(223, 201);
            this.pcb1EL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb1EL.TabIndex = 24;
            this.pcb1EL.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Location = new System.Drawing.Point(509, 370);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(314, 140);
            this.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Location = new System.Drawing.Point(925, 459);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(251, 106);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.Font = new System.Drawing.Font("Myriad Pro Light", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblProgress.Location = new System.Drawing.Point(224, 544);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(29, 45);
            this.lblProgress.TabIndex = 31;
            this.lblProgress.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(880, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 116);
            this.label1.TabIndex = 36;
            this.label1.Text = "Escriba en el campo de texto la\r\nseña mostrada en la foto. Luego,\r\nhaga clic en e" +
    "l botón \"Aceptar\"\r\npara comprobar su respuesta!";
            // 
            // Escribir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pcbPista);
            this.Controls.Add(this.pcbPasar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblEscribirLetra);
            this.Controls.Add(this.txtEscribir);
            this.Controls.Add(this.pcb1EL);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnVolver);
            this.Name = "Escribir";
            this.Text = "Escribir";
            this.Load += new System.EventHandler(this.Escribir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPasar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1EL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEscribir;
        private System.Windows.Forms.PictureBox pcb1EL;
        private System.Windows.Forms.PictureBox btnAceptar;
        private System.Windows.Forms.PictureBox btnVolver;
        private System.Windows.Forms.Label lblEscribirLetra;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pcbPasar;
        private System.Windows.Forms.PictureBox pcbPista;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label label1;
    }
}