namespace Manos_que_Hablan
{
    partial class Index
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
            this.btnIraKinect = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.PictureBox();
            this.btnRegistrarte = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIraKinect
            // 
            this.btnIraKinect.Location = new System.Drawing.Point(693, 397);
            this.btnIraKinect.Name = "btnIraKinect";
            this.btnIraKinect.Size = new System.Drawing.Size(124, 55);
            this.btnIraKinect.TabIndex = 3;
            this.btnIraKinect.Text = "Ir a Kinect Stream";
            this.btnIraKinect.UseVisualStyleBackColor = true;
            this.btnIraKinect.Click += new System.EventHandler(this.btnIraKinect_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.Image = global::Manos_que_Hablan.Properties.Resources.iniciar_sesión;
            this.btnIniciarSesion.Location = new System.Drawing.Point(337, 232);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(251, 113);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.TabStop = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnRegistrarte
            // 
            this.btnRegistrarte.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarte.Image = global::Manos_que_Hablan.Properties.Resources.registrarse;
            this.btnRegistrarte.Location = new System.Drawing.Point(337, 351);
            this.btnRegistrarte.Name = "btnRegistrarte";
            this.btnRegistrarte.Size = new System.Drawing.Size(251, 113);
            this.btnRegistrarte.TabIndex = 5;
            this.btnRegistrarte.TabStop = false;
            this.btnRegistrarte.Click += new System.EventHandler(this.btnRegistrarte_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Manos_que_Hablan.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(334, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Manos_que_Hablan.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnRegistrarte);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnIraKinect);
            this.Name = "Index";
            this.Text = "Manos Que Hablan";
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIraKinect;
        private System.Windows.Forms.PictureBox btnIniciarSesion;
        private System.Windows.Forms.PictureBox btnRegistrarte;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

