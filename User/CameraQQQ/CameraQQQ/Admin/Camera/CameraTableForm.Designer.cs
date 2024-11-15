namespace CameraQQQ.Admin.Camera
{
    partial class CameraTableForm
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
            dataGridViewCamera = new DataGridView();
            labelCreateCamera = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCamera).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCamera
            // 
            dataGridViewCamera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCamera.Location = new Point(12, 116);
            dataGridViewCamera.Name = "dataGridViewCamera";
            dataGridViewCamera.Size = new Size(776, 322);
            dataGridViewCamera.TabIndex = 0;
            // 
            // labelCreateCamera
            // 
            labelCreateCamera.AutoSize = true;
            labelCreateCamera.Cursor = Cursors.Hand;
            labelCreateCamera.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelCreateCamera.Location = new Point(12, 84);
            labelCreateCamera.Name = "labelCreateCamera";
            labelCreateCamera.Size = new Size(155, 21);
            labelCreateCamera.TabIndex = 1;
            labelCreateCamera.Text = "Create a new camera";
            labelCreateCamera.Click += labelCreateCamera_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(316, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 2;
            label1.Text = "Camera list";
            // 
            // CameraTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 584);
            Controls.Add(label1);
            Controls.Add(labelCreateCamera);
            Controls.Add(dataGridViewCamera);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CameraTableForm";
            Text = "CameraTableForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCamera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCamera;
        private Label labelCreateCamera;
        private Label label1;
    }
}