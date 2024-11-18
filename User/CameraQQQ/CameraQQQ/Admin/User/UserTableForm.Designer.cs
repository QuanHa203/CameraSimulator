namespace CameraQQQ.Admin.User
{
    partial class UserTableForm
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
            dataGridViewUser = new DataGridView();
            label1 = new Label();
            labelCreateUser = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Location = new Point(10, 87);
            dataGridViewUser.Margin = new Padding(3, 2, 3, 2);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowHeadersWidth = 51;
            dataGridViewUser.Size = new Size(648, 324);
            dataGridViewUser.TabIndex = 0;
            dataGridViewUser.CellDoubleClick += dataGridViewUser_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(270, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 1;
            label1.Text = "User list";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelCreateUser
            // 
            labelCreateUser.AutoSize = true;
            labelCreateUser.Cursor = Cursors.Hand;
            labelCreateUser.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreateUser.ForeColor = Color.FromArgb(0, 126, 249);
            labelCreateUser.Location = new Point(10, 55);
            labelCreateUser.Name = "labelCreateUser";
            labelCreateUser.Size = new Size(144, 21);
            labelCreateUser.TabIndex = 6;
            labelCreateUser.Text = "Create a new user";
            labelCreateUser.Click += labelCreateUser_Click;
            // 
            // UserTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(668, 438);
            Controls.Add(labelCreateUser);
            Controls.Add(label1);
            Controls.Add(dataGridViewUser);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserTableForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserTableForm";
            Load += UserTableForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUser;
        private Label label1;
        private Label labelCreateUser;
    }
}