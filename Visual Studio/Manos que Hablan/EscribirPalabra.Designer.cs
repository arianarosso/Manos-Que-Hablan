namespace Manos_que_Hablan
{
    partial class EscribirPalabra
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pcbEscribirSeña = new System.Windows.Forms.PictureBox();
            this.txtEscribirSeña = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEscribirSeña)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Light", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(107, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Escribí cuál seña es";
            // 
            // pcbEscribirSeña
            // 
            this.pcbEscribirSeña.Location = new System.Drawing.Point(152, 100);
            this.pcbEscribirSeña.Name = "pcbEscribirSeña";
            this.pcbEscribirSeña.Size = new System.Drawing.Size(232, 194);
            this.pcbEscribirSeña.TabIndex = 8;
            this.pcbEscribirSeña.TabStop = false;
            // 
            // txtEscribirSeña
            // 
            this.txtEscribirSeña.Location = new System.Drawing.Point(183, 347);
            this.txtEscribirSeña.Name = "txtEscribirSeña";
            this.txtEscribirSeña.Size = new System.Drawing.Size(163, 20);
            this.txtEscribirSeña.TabIndex = 9;
            // 
            // EscribirPalabra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEscribirSeña);
            this.Controls.Add(this.pcbEscribirSeña);
            this.Controls.Add(this.label1);
            this.Name = "EscribirPalabra";
            this.Size = new System.Drawing.Size(568, 438);
            ((System.ComponentModel.ISupportInitialize)(this.pcbEscribirSeña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbEscribirSeña;
        private System.Windows.Forms.TextBox txtEscribirSeña;
    }
}
