namespace CameraQQQ.Admin.Camera
{
    partial class UpdateCameraForm
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
            btnEdit = new Button();
            btnDelete = new Button();
            textBoxConnectionCode = new TextBox();
            textBoxPassword = new TextBox();
            textBoxCameraName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxId = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(244, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 7;
            label1.Text = "Modify camera";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 156, 149);
            btnEdit.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(342, 322);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(108, 40);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Modify";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(0, 156, 149);
            btnDelete.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(511, 322);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 40);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // textBoxConnectionCode
            // 
            textBoxConnectionCode.Location = new Point(163, 268);
            textBoxConnectionCode.Name = "textBoxConnectionCode";
            textBoxConnectionCode.Size = new Size(456, 23);
            textBoxConnectionCode.TabIndex = 27;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(163, 196);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(456, 23);
            textBoxPassword.TabIndex = 26;
            // 
            // textBoxCameraName
            // 
            textBoxCameraName.Location = new Point(163, 134);
            textBoxCameraName.Name = "textBoxCameraName";
            textBoxCameraName.Size = new Size(456, 23);
            textBoxCameraName.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 126, 249);
            label4.Location = new Point(12, 267);
            label4.Name = "label4";
            label4.Size = new Size(139, 21);
            label4.TabIndex = 24;
            label4.Text = "Connection code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 126, 249);
            label3.Location = new Point(12, 195);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 23;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(12, 130);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 22;
            label2.Text = "Camera name";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(163, 73);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(456, 23);
            textBoxId.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 126, 249);
            label5.Location = new Point(12, 70);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 28;
            label5.Text = "ID Camera";
            // 
            // UpdateCameraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(669, 438);
            Controls.Add(textBoxId);
            Controls.Add(label5);
            Controls.Add(textBoxConnectionCode);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxCameraName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateCameraForm";
            Text = "UpdateCameraForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox textBoxConnectionCode;
        private TextBox textBoxPassword;
        private TextBox textBoxCameraName;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxId;
        private Label label5;
    }
}