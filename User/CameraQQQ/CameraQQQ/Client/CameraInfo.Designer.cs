namespace CameraQQQ.Client
{
    partial class CameraInfo
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
            labelCameraName = new Label();
            panel1 = new Panel();
            pictureBoxPlay = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBoxDeleteCamera = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeleteCamera).BeginInit();
            SuspendLayout();
            // 
            // labelCameraName
            // 
            labelCameraName.AutoSize = true;
            labelCameraName.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            labelCameraName.ForeColor = Color.White;
            labelCameraName.Location = new Point(58, 18);
            labelCameraName.Name = "labelCameraName";
            labelCameraName.Size = new Size(101, 19);
            labelCameraName.TabIndex = 0;
            labelCameraName.Text = "CameraName";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(pictureBoxPlay);
            panel1.Location = new Point(12, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 150);
            panel1.TabIndex = 1;
            // 
            // pictureBoxPlay
            // 
            pictureBoxPlay.BackgroundImage = Properties.Resources.play2;
            pictureBoxPlay.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxPlay.Cursor = Cursors.Hand;
            pictureBoxPlay.Location = new Point(263, 43);
            pictureBoxPlay.Name = "pictureBoxPlay";
            pictureBoxPlay.Size = new Size(60, 60);
            pictureBoxPlay.TabIndex = 0;
            pictureBoxPlay.TabStop = false;
            pictureBoxPlay.Click += pictureBoxPlay_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.wifi;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxDeleteCamera
            // 
            pictureBoxDeleteCamera.BackgroundImage = Properties.Resources.trash;
            pictureBoxDeleteCamera.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxDeleteCamera.Location = new Point(581, 12);
            pictureBoxDeleteCamera.Name = "pictureBoxDeleteCamera";
            pictureBoxDeleteCamera.Size = new Size(30, 30);
            pictureBoxDeleteCamera.TabIndex = 2;
            pictureBoxDeleteCamera.TabStop = false;
            pictureBoxDeleteCamera.Click += pictureBoxDeleteCamera_Click;
            // 
            // CameraInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(623, 220);
            Controls.Add(pictureBoxDeleteCamera);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(labelCameraName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CameraInfo";
            Text = "CameraInfo";
            Load += CameraInfo_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeleteCamera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCameraName;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxPlay;
        private PictureBox pictureBoxDeleteCamera;
    }
}