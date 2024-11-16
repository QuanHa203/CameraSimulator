namespace CameraQQQ.Client
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
            panel1 = new Panel();
            panelWeb = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelCameraName
            // 
            labelCameraName.AutoSize = true;
            labelCameraName.BackColor = Color.Transparent;
            labelCameraName.FlatStyle = FlatStyle.Flat;
            labelCameraName.ForeColor = Color.Black;
            labelCameraName.Location = new Point(319, 21);
            labelCameraName.Name = "labelCameraName";
            labelCameraName.Size = new Size(101, 20);
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
            btnMic.Location = new Point(294, 67);
            btnMic.Margin = new Padding(3, 4, 3, 4);
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
            btnVolume.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolume.Cursor = Cursors.Hand;
            btnVolume.FlatAppearance.BorderSize = 0;
            btnVolume.FlatAppearance.MouseDownBackColor = Color.White;
            btnVolume.FlatAppearance.MouseOverBackColor = Color.White;
            btnVolume.FlatStyle = FlatStyle.Flat;
            btnVolume.Location = new Point(397, 67);
            btnVolume.Margin = new Padding(3, 4, 3, 4);
            btnVolume.Name = "btnVolume";
            btnVolume.Padding = new Padding(34, 0, 34, 0);
            btnVolume.Size = new Size(40, 40);
            btnVolume.TabIndex = 2;
            btnVolume.UseVisualStyleBackColor = false;
            btnVolume.Click += btnVolume_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVolume);
            panel1.Controls.Add(labelCameraName);
            panel1.Controls.Add(btnMic);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 451);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 133);
            panel1.TabIndex = 3;
            // 
            // panelWeb
            // 
            panelWeb.Dock = DockStyle.Fill;
            panelWeb.Location = new Point(0, 0);
            panelWeb.Margin = new Padding(3, 4, 3, 4);
            panelWeb.Name = "panelWeb";
            panelWeb.Size = new Size(765, 451);
            panelWeb.TabIndex = 4;
            // 
            // WatchCameraForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(765, 584);
            Controls.Add(panelWeb);
            Controls.Add(panel1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "WatchCameraForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WatchCameraForm";
            FormClosed += WatchCameraForm_FormClosed;
            Load += WatchCameraForm_Load;
            SizeChanged += WatchCameraForm_SizeChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelCameraName;
        private Button btnMic;
        private Button btnVolume;
        private Panel panel1;
        private Panel panelWeb;
    }
}