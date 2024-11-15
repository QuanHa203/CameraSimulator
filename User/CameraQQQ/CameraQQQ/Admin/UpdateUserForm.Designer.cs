namespace CameraQQQ.Admin
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
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(52, 207);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 13;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(52, 146);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(52, 84);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 11;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(205, 23);
            label1.Name = "label1";
            label1.Size = new Size(178, 38);
            label1.TabIndex = 10;
            label1.Text = "Update User";
            // 
            // txtUpdateEmail
            // 
            txtUpdateEmail.Location = new Point(175, 207);
            txtUpdateEmail.Name = "txtUpdateEmail";
            txtUpdateEmail.Size = new Size(330, 27);
            txtUpdateEmail.TabIndex = 9;
            // 
            // txtUpdatePass
            // 
            txtUpdatePass.Location = new Point(175, 146);
            txtUpdatePass.Name = "txtUpdatePass";
            txtUpdatePass.Size = new Size(330, 27);
            txtUpdatePass.TabIndex = 8;
            // 
            // txtUpdateUser
            // 
            txtUpdateUser.Location = new Point(175, 84);
            txtUpdateUser.Name = "txtUpdateUser";
            txtUpdateUser.Size = new Size(330, 27);
            txtUpdateUser.TabIndex = 7;
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(569, 281);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUpdateEmail);
            Controls.Add(txtUpdatePass);
            Controls.Add(txtUpdateUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateUserForm";
            Text = "UpdateUserForm";
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
    }
}