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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(310, 34);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 7;
            label1.Text = "Modify camera";
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 12F);
            btnEdit.Location = new Point(483, 305);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(108, 40);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Modify";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(633, 305);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 40);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // textBoxConnectionCode
            // 
            textBoxConnectionCode.Location = new Point(163, 250);
            textBoxConnectionCode.Name = "textBoxConnectionCode";
            textBoxConnectionCode.Size = new Size(578, 23);
            textBoxConnectionCode.TabIndex = 27;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(163, 178);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(578, 23);
            textBoxPassword.TabIndex = 26;
            // 
            // textBoxCameraName
            // 
            textBoxCameraName.Location = new Point(163, 115);
            textBoxCameraName.Name = "textBoxCameraName";
            textBoxCameraName.Size = new Size(578, 23);
            textBoxCameraName.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 248);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 24;
            label4.Text = "Connection code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 176);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 23;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 22;
            label2.Text = "Camera name";
            // 
            // UpdateCameraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 584);
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
    }
}