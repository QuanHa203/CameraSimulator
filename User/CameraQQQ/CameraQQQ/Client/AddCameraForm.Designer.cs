namespace CameraQQQ.Client
{
    partial class AddCameraForm
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
            label2 = new Label();
            textBoxConnectionCode = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(241, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 4;
            label1.Text = "Add new camera";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(12, 120);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 6;
            label2.Text = "Connection code";
            // 
            // textBoxConnectionCode
            // 
            textBoxConnectionCode.Location = new Point(201, 122);
            textBoxConnectionCode.Margin = new Padding(3, 2, 3, 2);
            textBoxConnectionCode.Name = "textBoxConnectionCode";
            textBoxConnectionCode.Size = new Size(456, 23);
            textBoxConnectionCode.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 156, 149);
            btnAdd.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(538, 190);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 40);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add camera";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddCameraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(669, 438);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(textBoxConnectionCode);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCameraForm";
            Text = "AddCameraForm";
            Load += AddCameraForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxConnectionCode;
        private Button btnAdd;
    }
}