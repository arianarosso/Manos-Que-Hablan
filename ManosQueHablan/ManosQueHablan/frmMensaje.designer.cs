namespace ManosQueHablan
{
    partial class frmMensaje
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
            this.pcbMensaje = new System.Windows.Forms.PictureBox();
            this.pcbEmTer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMensaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEmTer)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbMensaje
            // 
            this.pcbMensaje.BackColor = System.Drawing.Color.Transparent;
            this.pcbMensaje.Location = new System.Drawing.Point(96, -5);
            this.pcbMensaje.Name = "pcbMensaje";
            this.pcbMensaje.Size = new System.Drawing.Size(593, 366);
            this.pcbMensaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMensaje.TabIndex = 25;
            this.pcbMensaje.TabStop = false;
            // 
            // pcbEmTer
            // 
            this.pcbEmTer.BackColor = System.Drawing.Color.Transparent;
            this.pcbEmTer.Location = new System.Drawing.Point(245, 367);
            this.pcbEmTer.Name = "pcbEmTer";
            this.pcbEmTer.Size = new System.Drawing.Size(291, 102);
            this.pcbEmTer.TabIndex = 26;
            this.pcbEmTer.TabStop = false;
            this.pcbEmTer.Click += new System.EventHandler(this.pcbEmTer_Click);
            // 
            // frmMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 472);
            this.ControlBox = false;
            this.Controls.Add(this.pcbEmTer);
            this.Controls.Add(this.pcbMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMensaje";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pcbMensaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEmTer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMensaje;
        private System.Windows.Forms.PictureBox pcbEmTer;
    }
}