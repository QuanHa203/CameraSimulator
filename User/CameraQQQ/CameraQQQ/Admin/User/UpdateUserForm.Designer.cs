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
            btnIsBan = new CheckBox();
            btnSaveUpdate = new Button();
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(86, 259);
            label5.Name = "label5";
            label5.Size = new Size(40, 23);
            label5.TabIndex = 14;
            label5.Text = "Ban";
            // 
            // btnIsBan
            // 
            btnIsBan.AutoSize = true;
            btnIsBan.Location = new Point(62, 264);
            btnIsBan.Name = "btnIsBan";
            btnIsBan.Size = new Size(18, 17);
            btnIsBan.TabIndex = 15;
            btnIsBan.UseVisualStyleBackColor = true;
            // 
            // btnSaveUpdate
            // 
            btnSaveUpdate.BackColor = Color.LightSeaGreen;
            btnSaveUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSaveUpdate.ForeColor = SystemColors.ButtonFace;
            btnSaveUpdate.Location = new Point(247, 293);
            btnSaveUpdate.Name = "btnSaveUpdate";
            btnSaveUpdate.Size = new Size(98, 38);
            btnSaveUpdate.TabIndex = 16;
            btnSaveUpdate.Text = "Save";
            btnSaveUpdate.UseVisualStyleBackColor = false;
            btnSaveUpdate.Click += btnSaveUpdate_Click;
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(569, 343);
            Controls.Add(btnSaveUpdate);
            Controls.Add(btnIsBan);
            Controls.Add(label5);
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
        private Label label5;
        private CheckBox btnIsBan;
        private Button btnSaveUpdate;
    }
}