namespace CameraQQQ.Admin
{
    partial class DashboardForm
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
            panel1 = new Panel();
            panelExit = new Panel();
            btnExit = new Button();
            labelExit = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelUser = new Panel();
            btnUser = new Button();
            labelUser = new Label();
            panelCamera = new Panel();
            btnCamera = new Button();
            labelCamera = new Label();
            panelShow = new Panel();
            panel1.SuspendLayout();
            panelExit.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelUser.SuspendLayout();
            panelCamera.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 56);
            panel1.Controls.Add(panelExit);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panelUser);
            panel1.Controls.Add(panelCamera);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 438);
            panel1.TabIndex = 0;
            // 
            // panelExit
            // 
            panelExit.Controls.Add(btnExit);
            panelExit.Controls.Add(labelExit);
            panelExit.Location = new Point(0, 393);
            panelExit.Margin = new Padding(3, 2, 3, 2);
            panelExit.Name = "panelExit";
            panelExit.Size = new Size(163, 45);
            panelExit.TabIndex = 7;
            panelExit.Click += Exit_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImage = Properties.Resources.logOut;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 30, 56);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 30, 56);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(115, 11);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(31, 26);
            btnExit.TabIndex = 3;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += Exit_Click;
            // 
            // labelExit
            // 
            labelExit.AutoSize = true;
            labelExit.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelExit.ForeColor = Color.FromArgb(0, 126, 249);
            labelExit.Location = new Point(4, 12);
            labelExit.Name = "labelExit";
            labelExit.Size = new Size(70, 21);
            labelExit.TabIndex = 2;
            labelExit.Text = "Log Out";
            labelExit.Click += Exit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(163, 113);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 156, 149);
            label1.Location = new Point(41, 74);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Admin1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.moon;
            pictureBox1.Location = new Point(30, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelUser
            // 
            panelUser.Controls.Add(btnUser);
            panelUser.Controls.Add(labelUser);
            panelUser.Location = new Point(0, 110);
            panelUser.Margin = new Padding(3, 2, 3, 2);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(163, 45);
            panelUser.TabIndex = 7;
            panelUser.Click += OpenUserTable_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.Transparent;
            btnUser.BackgroundImage = Properties.Resources.user;
            btnUser.BackgroundImageLayout = ImageLayout.Zoom;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 30, 56);
            btnUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 30, 56);
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Location = new Point(114, 11);
            btnUser.Margin = new Padding(3, 2, 3, 2);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(31, 26);
            btnUser.TabIndex = 3;
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += OpenUserTable_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUser.ForeColor = Color.FromArgb(0, 126, 249);
            labelUser.Location = new Point(4, 12);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(44, 21);
            labelUser.TabIndex = 2;
            labelUser.Text = "User";
            labelUser.Click += OpenUserTable_Click;
            // 
            // panelCamera
            // 
            panelCamera.Controls.Add(btnCamera);
            panelCamera.Controls.Add(labelCamera);
            panelCamera.Location = new Point(0, 152);
            panelCamera.Margin = new Padding(3, 2, 3, 2);
            panelCamera.Name = "panelCamera";
            panelCamera.Size = new Size(163, 45);
            panelCamera.TabIndex = 7;
            panelCamera.Click += OpenCameraTable_Click;
            // 
            // btnCamera
            // 
            btnCamera.BackColor = Color.Transparent;
            btnCamera.BackgroundImage = Properties.Resources.cameraSecurity;
            btnCamera.BackgroundImageLayout = ImageLayout.Zoom;
            btnCamera.FlatAppearance.BorderSize = 0;
            btnCamera.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 30, 56);
            btnCamera.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 30, 56);
            btnCamera.FlatStyle = FlatStyle.Flat;
            btnCamera.Location = new Point(115, 8);
            btnCamera.Margin = new Padding(3, 2, 3, 2);
            btnCamera.Name = "btnCamera";
            btnCamera.Size = new Size(31, 26);
            btnCamera.TabIndex = 3;
            btnCamera.UseVisualStyleBackColor = false;
            btnCamera.Click += OpenCameraTable_Click;
            // 
            // labelCamera
            // 
            labelCamera.AutoSize = true;
            labelCamera.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCamera.ForeColor = Color.FromArgb(0, 126, 249);
            labelCamera.Location = new Point(4, 12);
            labelCamera.Name = "labelCamera";
            labelCamera.Size = new Size(68, 21);
            labelCamera.TabIndex = 2;
            labelCamera.Text = "Camera";
            labelCamera.Click += OpenCameraTable_Click;
            // 
            // panelShow
            // 
            panelShow.Dock = DockStyle.Fill;
            panelShow.Location = new Point(163, 0);
            panelShow.Margin = new Padding(3, 2, 3, 2);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(668, 438);
            panelShow.TabIndex = 1;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(831, 438);
            Controls.Add(panelShow);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            panel1.ResumeLayout(false);
            panelExit.ResumeLayout(false);
            panelExit.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            panelCamera.ResumeLayout(false);
            panelCamera.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panelExit;
        private Button btnExit;
        private Label labelExit;
        private Panel panelUser;
        private Button btnUser;
        private Label labelUser;
        private Panel panelCamera;
        private Button btnCamera;
        private Label labelCamera;
        private Panel panelShow;
    }
}