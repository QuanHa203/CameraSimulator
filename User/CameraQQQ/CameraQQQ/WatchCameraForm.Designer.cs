namespace CameraQQQ
{
    partial class WatchCameraForm
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
            btnMic = new Button();
            btnVolume = new Button();
            SuspendLayout();
            // 
            // labelCameraName
            // 
            labelCameraName.AutoSize = true;
            labelCameraName.BackColor = Color.SkyBlue;
            labelCameraName.FlatStyle = FlatStyle.Flat;
            labelCameraName.Location = new Point(382, 9);
            labelCameraName.Name = "labelCameraName";
            labelCameraName.Size = new Size(81, 15);
            labelCameraName.TabIndex = 0;
            labelCameraName.Text = "Camera name";
            // 
            // btnMic
            // 
            btnMic.BackColor = Color.Transparent;
            btnMic.BackgroundImage = Properties.Resources.micOff;
            btnMic.BackgroundImageLayout = ImageLayout.Zoom;
            btnMic.Cursor = Cursors.Hand;
            btnMic.FlatAppearance.BorderSize = 0;
            btnMic.FlatAppearance.MouseDownBackColor = Color.White;
            btnMic.FlatAppearance.MouseOverBackColor = Color.White;
            btnMic.FlatStyle = FlatStyle.Flat;
            btnMic.Location = new Point(344, 377);
            btnMic.Name = "btnMic";
            btnMic.Size = new Size(40, 40);
            btnMic.TabIndex = 1;
            btnMic.UseVisualStyleBackColor = false;
            btnMic.Click += btnMic_Click;
            // 
            // btnVolume
            // 
            btnVolume.BackColor = Color.Transparent;
            btnVolume.BackgroundImage = Properties.Resources.volumeOn;
            btnVolume.BackgroundImageLayout = ImageLayout.Zoom;
            btnVolume.Cursor = Cursors.Hand;
            btnVolume.FlatAppearance.BorderSize = 0;
            btnVolume.FlatAppearance.MouseDownBackColor = Color.White;
            btnVolume.FlatAppearance.MouseOverBackColor = Color.White;
            btnVolume.FlatStyle = FlatStyle.Flat;
            btnVolume.Location = new Point(434, 377);
            btnVolume.Name = "btnVolume";
            btnVolume.Padding = new Padding(30, 0, 30, 0);
            btnVolume.Size = new Size(40, 40);
            btnVolume.TabIndex = 2;
            btnVolume.UseVisualStyleBackColor = false;
            btnVolume.Click += btnVolume_Click;
            // 
            // WatchCameraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolume);
            Controls.Add(btnMic);
            Controls.Add(labelCameraName);
            Name = "WatchCameraForm";
            Text = "WatchCameraForm";
            Load += WatchCameraForm_Load;
            SizeChanged += WatchCameraForm_SizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCameraName;
        private Button btnMic;
        private Button btnVolume;
    }
}