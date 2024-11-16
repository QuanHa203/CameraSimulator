using System.Windows.Forms;

namespace CameraQQQ.Client
{
    partial class HomeForm
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
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panelWatchCamera = new Panel();
            button13 = new Button();
            label16 = new Label();
            panelLogOut = new Panel();
            button4 = new Button();
            label4 = new Label();
            panelAddCamera = new Panel();
            button7 = new Button();
            label8 = new Label();
            pnlShow = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panelWatchCamera.SuspendLayout();
            panelLogOut.SuspendLayout();
            panelAddCamera.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 151);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 156, 149);
            label1.Location = new Point(58, 98);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 1;
            label1.Text = "User1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.moon;
            pictureBox1.Location = new Point(34, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 56);
            panel1.Controls.Add(panelWatchCamera);
            panel1.Controls.Add(panelLogOut);
            panel1.Controls.Add(panelAddCamera);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 584);
            panel1.TabIndex = 0;
            // 
            // panelWatchCamera
            // 
            panelWatchCamera.Controls.Add(button13);
            panelWatchCamera.Controls.Add(label16);
            panelWatchCamera.Location = new Point(0, 207);
            panelWatchCamera.Name = "panelWatchCamera";
            panelWatchCamera.Size = new Size(186, 60);
            panelWatchCamera.TabIndex = 6;
            panelWatchCamera.Click += panelWatchCamera_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Transparent;
            button13.BackgroundImage = Properties.Resources.cameraSecurity;
            button13.BackgroundImageLayout = ImageLayout.Zoom;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Location = new Point(136, 11);
            button13.Name = "button13";
            button13.Size = new Size(35, 35);
            button13.TabIndex = 3;
            button13.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(0, 126, 249);
            label16.Location = new Point(2, 18);
            label16.Name = "label16";
            label16.Size = new Size(126, 23);
            label16.TabIndex = 2;
            label16.Text = "Watch Camera";
            // 
            // panelLogOut
            // 
            panelLogOut.Controls.Add(button4);
            panelLogOut.Controls.Add(label4);
            panelLogOut.Location = new Point(0, 524);
            panelLogOut.Name = "panelLogOut";
            panelLogOut.Size = new Size(186, 60);
            panelLogOut.TabIndex = 6;
            panelLogOut.Click += panelLogOut_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = Properties.Resources.logOut;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(130, 14);
            button4.Name = "button4";
            button4.Size = new Size(35, 35);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 126, 249);
            label4.Location = new Point(4, 16);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 2;
            label4.Text = "Log Out";
            // 
            // panelAddCamera
            // 
            panelAddCamera.Controls.Add(button7);
            panelAddCamera.Controls.Add(label8);
            panelAddCamera.Dock = DockStyle.Top;
            panelAddCamera.Location = new Point(0, 151);
            panelAddCamera.Name = "panelAddCamera";
            panelAddCamera.Size = new Size(186, 60);
            panelAddCamera.TabIndex = 9;
            panelAddCamera.Click += panelAddCamera_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = Properties.Resources.cameraSecurity;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(138, 10);
            button7.Name = "button7";
            button7.Size = new Size(35, 35);
            button7.TabIndex = 3;
            button7.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 126, 249);
            label8.Location = new Point(4, 18);
            label8.Name = "label8";
            label8.Size = new Size(110, 23);
            label8.TabIndex = 2;
            label8.Text = "Add Camera";
            // 
            // pnlShow
            // 
            pnlShow.Dock = DockStyle.Bottom;
            pnlShow.Location = new Point(186, 0);
            pnlShow.Name = "pnlShow";
            pnlShow.Size = new Size(765, 584);
            pnlShow.TabIndex = 1;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 584);
            Controls.Add(pnlShow);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panelWatchCamera.ResumeLayout(false);
            panelWatchCamera.PerformLayout();
            panelLogOut.ResumeLayout(false);
            panelLogOut.PerformLayout();
            panelAddCamera.ResumeLayout(false);
            panelAddCamera.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panelWatchCamera;
        private Button button13;
        private Label label16;
        private Panel panelLogOut;
        private Button button4;
        private Label label4;
        private Panel panelAddCamera;
        private Button button7;
        private Label label8;
        private Panel pnlShow;
    }
}