namespace CameraQQQ.Admin.User
{
    partial class UpdateUserForm
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtUpdateEmail = new TextBox();
            txtUpdatePass = new TextBox();
            txtUpdateUser = new TextBox();
            label5 = new Label();
            comboBoxIsBan = new ComboBox();
            btnDelete = new Button();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 126, 249);
            label4.Location = new Point(12, 220);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 13;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 126, 249);
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 11;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(259, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 10;
            label1.Text = "Update User";
            // 
            // txtUpdateEmail
            // 
            txtUpdateEmail.Location = new Point(163, 222);
            txtUpdateEmail.Margin = new Padding(3, 2, 3, 2);
            txtUpdateEmail.Name = "txtUpdateEmail";
            txtUpdateEmail.Size = new Size(456, 23);
            txtUpdateEmail.TabIndex = 9;
            // 
            // txtUpdatePass
            // 
            txtUpdatePass.Location = new Point(163, 163);
            txtUpdatePass.Margin = new Padding(3, 2, 3, 2);
            txtUpdatePass.Name = "txtUpdatePass";
            txtUpdatePass.Size = new Size(456, 23);
            txtUpdatePass.TabIndex = 8;
            // 
            // txtUpdateUser
            // 
            txtUpdateUser.Location = new Point(163, 99);
            txtUpdateUser.Margin = new Padding(3, 2, 3, 2);
            txtUpdateUser.Name = "txtUpdateUser";
            txtUpdateUser.Size = new Size(456, 23);
            txtUpdateUser.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 126, 249);
            label5.Location = new Point(12, 278);
            label5.Name = "label5";
            label5.Size = new Size(39, 21);
            label5.TabIndex = 14;
            label5.Text = "Ban";
            // 
            // comboBoxIsBan
            // 
            comboBoxIsBan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIsBan.FormattingEnabled = true;
            comboBoxIsBan.Location = new Point(163, 280);
            comboBoxIsBan.Name = "comboBoxIsBan";
            comboBoxIsBan.Size = new Size(456, 23);
            comboBoxIsBan.TabIndex = 17;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(0, 156, 149);
            btnDelete.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(511, 343);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 40);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 156, 149);
            btnEdit.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(342, 343);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(108, 40);
            btnEdit.TabIndex = 18;
            btnEdit.Text = "Modify";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(669, 438);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(comboBoxIsBan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUpdateEmail);
            Controls.Add(txtUpdatePass);
            Controls.Add(txtUpdateUser);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UpdateUserForm";
            Text = "UpdateUserForm";
            Load += UpdateUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtUpdateEmail;
        private TextBox txtUpdatePass;
        private TextBox txtUpdateUser;
        private Label label5;
        private ComboBox comboBoxIsBan;
        private Button btnDelete;
        private Button btnEdit;
    }
}