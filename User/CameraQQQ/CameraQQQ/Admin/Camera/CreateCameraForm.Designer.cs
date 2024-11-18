namespace CameraQQQ.Admin.Camera
{
    partial class CreateCameraForm
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
            label1 = new Label();
            btnCreate = new Button();
            textBoxConnectionCode = new TextBox();
            textBoxPassword = new TextBox();
            textBoxCameraName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(252, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 0;
            label1.Text = "Create camera";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(0, 156, 149);
            btnCreate.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(511, 328);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(108, 40);
            btnCreate.TabIndex = 23;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // textBoxConnectionCode
            // 
            textBoxConnectionCode.Location = new Point(163, 250);
            textBoxConnectionCode.Name = "textBoxConnectionCode";
            textBoxConnectionCode.Size = new Size(456, 23);
            textBoxConnectionCode.TabIndex = 21;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(163, 176);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(456, 23);
            textBoxPassword.TabIndex = 20;
            // 
            // textBoxCameraName
            // 
            textBoxCameraName.Location = new Point(163, 115);
            textBoxCameraName.Name = "textBoxCameraName";
            textBoxCameraName.Size = new Size(456, 23);
            textBoxCameraName.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 126, 249);
            label4.Location = new Point(12, 248);
            label4.Name = "label4";
            label4.Size = new Size(139, 21);
            label4.TabIndex = 18;
            label4.Text = "Connection code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 126, 249);
            label3.Location = new Point(12, 176);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 16;
            label2.Text = "Camera name";
            // 
            // CreateCameraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(669, 438);
            Controls.Add(btnCreate);
            Controls.Add(textBoxConnectionCode);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxCameraName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateCameraForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateCameraForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCreate;
        private TextBox textBoxConnectionCode;
        private TextBox textBoxPassword;
        private TextBox textBoxCameraName;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}