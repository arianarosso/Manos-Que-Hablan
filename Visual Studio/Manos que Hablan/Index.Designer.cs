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
            this.btnRegistrarse1 = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnIraKinect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manos Que Hablan";
            // 
            // btnRegistrarse1
            // 
            this.btnRegistrarse1.Location = new System.Drawing.Point(360, 347);
            this.btnRegistrarse1.Name = "btnRegistrarse1";
            this.btnRegistrarse1.Size = new System.Drawing.Size(200, 55);
            this.btnRegistrarse1.TabIndex = 1;
            this.btnRegistrarse1.Text = "Registrarse";
            this.btnRegistrarse1.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(360, 206);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(200, 55);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar Sesión";
            this.btnIniciar.UseVisualStyleBackColor = true;
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
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnIraKinect);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnRegistrarse1);
            this.Controls.Add(this.label1);
            this.Name = "Index";
            this.Text = "Manos Que Hablan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarse1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnIraKinect;
    }
}

