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
            pictureBox1 = new PictureBox();
            labelUserName = new Label();
            panel1 = new Panel();
            panelWatchCamera = new Panel();
            btnWatchCamera = new Button();
            labelWatchCamera = new Label();
            panelLogOut = new Panel();
            button4 = new Button();
            label4 = new Label();
            panelAddCamera = new Panel();
            btnAddCamera = new Button();
            labelAddCamera = new Label();
            panelShow = new Panel();
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
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(labelUserName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(163, 133);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.userImg;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(40, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // labelUserName
            // 
            labelUserName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.ForeColor = Color.FromArgb(0, 156, 149);
            labelUserName.Location = new Point(4, 108);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(153, 20);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "UserName";
            labelUserName.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 438);
            panel1.TabIndex = 0;
            // 
            // panelWatchCamera
            // 
            panelWatchCamera.Controls.Add(btnWatchCamera);
            panelWatchCamera.Controls.Add(labelWatchCamera);
            panelWatchCamera.Cursor = Cursors.Hand;
            panelWatchCamera.Location = new Point(0, 137);
            panelWatchCamera.Margin = new Padding(3, 2, 3, 2);
            panelWatchCamera.Name = "panelWatchCamera";
            panelWatchCamera.Size = new Size(163, 45);
            panelWatchCamera.TabIndex = 6;
            panelWatchCamera.Click += OpenCameraListForm_Click;
            // 
            // btnWatchCamera
            // 
            btnWatchCamera.BackColor = Color.Transparent;
            btnWatchCamera.BackgroundImage = Properties.Resources.cameraSecurity;
            btnWatchCamera.BackgroundImageLayout = ImageLayout.Zoom;
            btnWatchCamera.Cursor = Cursors.Hand;
            btnWatchCamera.FlatAppearance.BorderSize = 0;
            btnWatchCamera.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 30, 56);
            btnWatchCamera.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 30, 56);
            btnWatchCamera.FlatStyle = FlatStyle.Flat;
            btnWatchCamera.Location = new Point(119, 8);
            btnWatchCamera.Margin = new Padding(3, 2, 3, 2);
            btnWatchCamera.Name = "btnWatchCamera";
            btnWatchCamera.Size = new Size(31, 26);
            btnWatchCamera.TabIndex = 3;
            btnWatchCamera.UseVisualStyleBackColor = false;
            btnWatchCamera.Click += OpenCameraListForm_Click;
            // 
            // labelWatchCamera
            // 
            labelWatchCamera.AutoSize = true;
            labelWatchCamera.Cursor = Cursors.Hand;
            labelWatchCamera.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWatchCamera.ForeColor = Color.FromArgb(0, 126, 249);
            labelWatchCamera.Location = new Point(2, 14);
            labelWatchCamera.Name = "labelWatchCamera";
            labelWatchCamera.Size = new Size(106, 19);
            labelWatchCamera.TabIndex = 2;
            labelWatchCamera.Text = "Watch Camera";
            labelWatchCamera.Click += OpenCameraListForm_Click;
            // 
            // panelLogOut
            // 
            panelLogOut.Controls.Add(button4);
            panelLogOut.Controls.Add(label4);
            panelLogOut.Cursor = Cursors.Hand;
            panelLogOut.Location = new Point(0, 375);
            panelLogOut.Margin = new Padding(3, 2, 3, 2);
            panelLogOut.Name = "panelLogOut";
            panelLogOut.Size = new Size(163, 45);
            panelLogOut.TabIndex = 6;
            panelLogOut.Click += Exit_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = Properties.Resources.logOut;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 30, 56);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 30, 56);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(114, 10);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(31, 26);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += Exit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 126, 249);
            label4.Location = new Point(4, 12);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 2;
            label4.Text = "Log Out";
            label4.Click += Exit_Click;
            // 
            // panelAddCamera
            // 
            panelAddCamera.Controls.Add(btnAddCamera);
            panelAddCamera.Controls.Add(labelAddCamera);
            panelAddCamera.Cursor = Cursors.Hand;
            panelAddCamera.Location = new Point(0, 186);
            panelAddCamera.Margin = new Padding(3, 2, 3, 2);
            panelAddCamera.Name = "panelAddCamera";
            panelAddCamera.Size = new Size(163, 45);
            panelAddCamera.TabIndex = 9;
            panelAddCamera.Click += OpenAddCameraForm_Click;
            // 
            // btnAddCamera
            // 
            btnAddCamera.BackColor = Color.Transparent;
            btnAddCamera.BackgroundImage = Properties.Resources.cctvCreate1;
            btnAddCamera.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddCamera.Cursor = Cursors.Hand;
            btnAddCamera.FlatAppearance.BorderSize = 0;
            btnAddCamera.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 30, 56);
            btnAddCamera.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 30, 56);
            btnAddCamera.FlatStyle = FlatStyle.Flat;
            btnAddCamera.Location = new Point(121, 8);
            btnAddCamera.Margin = new Padding(3, 2, 3, 2);
            btnAddCamera.Name = "btnAddCamera";
            btnAddCamera.Size = new Size(31, 26);
            btnAddCamera.TabIndex = 3;
            btnAddCamera.UseVisualStyleBackColor = false;
            btnAddCamera.Click += OpenAddCameraForm_Click;
            // 
            // labelAddCamera
            // 
            labelAddCamera.AutoSize = true;
            labelAddCamera.Cursor = Cursors.Hand;
            labelAddCamera.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddCamera.ForeColor = Color.FromArgb(0, 126, 249);
            labelAddCamera.Location = new Point(4, 14);
            labelAddCamera.Name = "labelAddCamera";
            labelAddCamera.Size = new Size(93, 19);
            labelAddCamera.TabIndex = 2;
            labelAddCamera.Text = "Add Camera";
            labelAddCamera.Click += OpenAddCameraForm_Click;
            // 
            // panelShow
            // 
            panelShow.Dock = DockStyle.Bottom;
            panelShow.Location = new Point(163, 0);
            panelShow.Margin = new Padding(3, 2, 3, 2);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(669, 438);
            panelShow.TabIndex = 1;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(832, 438);
            Controls.Add(panelShow);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            panel2.ResumeLayout(false);
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
        private Label labelUserName;
        private Panel panel1;
        private Panel panelWatchCamera;
        private Button btnWatchCamera;
        private Label labelWatchCamera;
        private Panel panelLogOut;
        private Button button4;
        private Label label4;
        private Panel panelAddCamera;
        private Button btnAddCamera;
        private Label labelAddCamera;
        private Panel panelShow;
        private PictureBox pictureBox1;
    }
}