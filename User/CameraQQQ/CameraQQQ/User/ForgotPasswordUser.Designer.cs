namespace CameraQQQ.User
{
    partial class ForgotPasswordUser
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
            label2 = new Label();
            txtEmail = new TextBox();
            btnClick = new Button();
            label1 = new Label();
            lbLogin = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 181);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(230, 231, 233);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(42, 207);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 28);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // btnClick
            // 
            btnClick.BackColor = Color.FromArgb(116, 36, 174);
            btnClick.Cursor = Cursors.Hand;
            btnClick.FlatAppearance.BorderSize = 0;
            btnClick.ForeColor = Color.White;
            btnClick.Location = new Point(42, 289);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(216, 35);
            btnClick.TabIndex = 5;
            btnClick.Text = "Click";
            btnClick.UseVisualStyleBackColor = false;
            btnClick.Click += btnClick_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(70, 66);
            label1.Name = "label1";
            label1.Size = new Size(160, 68);
            label1.TabIndex = 9;
            label1.Text = "  Forgot \r\nPassword";
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Cursor = Cursors.Hand;
            lbLogin.ForeColor = Color.FromArgb(116, 86, 174);
            lbLogin.Location = new Point(101, 375);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(98, 23);
            lbLogin.TabIndex = 10;
            lbLogin.Text = "Back Login";
            lbLogin.Click += lbLogin_Click;
            // 
            // ForgotPasswordUser
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(300, 489);
            Controls.Add(lbLogin);
            Controls.Add(label1);
            Controls.Add(btnClick);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ForgotPasswordUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtEmail;
        private Button btnClick;
        private Label lb;
        private Label label1;
        private Label lbLogin;
    }
}