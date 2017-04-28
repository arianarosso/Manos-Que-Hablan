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
            this.label1 = new System.Windows.Forms.Label();
            this.btnIraKinect = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.PictureBox();
            this.btnRegistrarte = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrarte)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Light", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manos Que Hablan";
            // 
            // btnIraKinect
            // 
            this.btnIraKinect.Location = new System.Drawing.Point(691, 347);
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
            this.btnIniciarSesion.Location = new System.Drawing.Point(335, 182);
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
            this.btnRegistrarte.Location = new System.Drawing.Point(335, 329);
            this.btnRegistrarte.Name = "btnRegistrarte";
            this.btnRegistrarte.Size = new System.Drawing.Size(251, 113);
            this.btnRegistrarte.TabIndex = 5;
            this.btnRegistrarte.TabStop = false;
            this.btnRegistrarte.Click += new System.EventHandler(this.btnRegistrarte_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Manos_que_Hablan.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnRegistrarte);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnIraKinect);
            this.Controls.Add(this.label1);
            this.Name = "Index";
            this.Text = "Manos Que Hablan";
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIraKinect;
        private System.Windows.Forms.PictureBox btnIniciarSesion;
        private System.Windows.Forms.PictureBox btnRegistrarte;
    }
}

