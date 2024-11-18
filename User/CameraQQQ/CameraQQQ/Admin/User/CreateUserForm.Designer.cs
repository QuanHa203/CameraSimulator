namespace CameraQQQ.Admin.User
{
    partial class CreateUserForm
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
            txtCreateUser = new TextBox();
            txtCreatePass = new TextBox();
            txtCreateEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // txtCreateUser
            // 
            txtCreateUser.Location = new Point(163, 115);
            txtCreateUser.Margin = new Padding(3, 2, 3, 2);
            txtCreateUser.Name = "txtCreateUser";
            txtCreateUser.Size = new Size(456, 23);
            txtCreateUser.TabIndex = 0;
            // 
            // txtCreatePass
            // 
            txtCreatePass.Location = new Point(163, 176);
            txtCreatePass.Margin = new Padding(3, 2, 3, 2);
            txtCreatePass.Name = "txtCreatePass";
            txtCreatePass.Size = new Size(456, 23);
            txtCreatePass.TabIndex = 1;
            // 
            // txtCreateEmail
            // 
            txtCreateEmail.Location = new Point(163, 250);
            txtCreateEmail.Margin = new Padding(3, 2, 3, 2);
            txtCreateEmail.Name = "txtCreateEmail";
            txtCreateEmail.Size = new Size(456, 23);
            txtCreateEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(256, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 3;
            label1.Text = "Create User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 4;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 126, 249);
            label3.Location = new Point(12, 176);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 126, 249);
            label4.Location = new Point(12, 248);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(0, 156, 149);
            btnCreate.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(511, 328);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(108, 40);
            btnCreate.TabIndex = 24;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(669, 438);
            Controls.Add(btnCreate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCreateEmail);
            Controls.Add(txtCreatePass);
            Controls.Add(txtCreateUser);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CreateUserForm";
            Text = "CreateUserForm";
            Load += CreateUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCreateUser;
        private TextBox txtCreatePass;
        private TextBox txtCreateEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCreate;
    }
}