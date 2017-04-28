namespace Manos_que_Hablan
{
    partial class KinectStream
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KinectStream));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblConectionID = new System.Windows.Forms.Label();
            this.btnStream = new System.Windows.Forms.Button();
            this.pbStream = new System.Windows.Forms.PictureBox();
            this.lblPosition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbStream)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            // 
            // lblConectionID
            // 
            resources.ApplyResources(this.lblConectionID, "lblConectionID");
            this.lblConectionID.Name = "lblConectionID";
            // 
            // btnStream
            // 
            resources.ApplyResources(this.btnStream, "btnStream");
            this.btnStream.Name = "btnStream";
            this.btnStream.UseVisualStyleBackColor = true;
            this.btnStream.Click += new System.EventHandler(this.btnStream_Click);
            // 
            // pbStream
            // 
            resources.ApplyResources(this.pbStream, "pbStream");
            this.pbStream.Name = "pbStream";
            this.pbStream.TabStop = false;
            // 
            // lblPosition
            // 
            resources.ApplyResources(this.lblPosition, "lblPosition");
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Click += new System.EventHandler(this.label3_Click);
            // 
            // KinectStream
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.pbStream);
            this.Controls.Add(this.btnStream);
            this.Controls.Add(this.lblConectionID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KinectStream";
            ((System.ComponentModel.ISupportInitialize)(this.pbStream)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblConectionID;
        private System.Windows.Forms.Button btnStream;
        private System.Windows.Forms.PictureBox pbStream;
        private System.Windows.Forms.Label lblPosition;
    }
}