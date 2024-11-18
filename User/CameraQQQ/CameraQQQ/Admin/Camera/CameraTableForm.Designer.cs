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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCamera).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCamera
            // 
            dataGridViewCamera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCamera.Location = new Point(10, 87);
            dataGridViewCamera.Name = "dataGridViewCamera";
            dataGridViewCamera.RowHeadersWidth = 51;
            dataGridViewCamera.Size = new Size(648, 324);
            dataGridViewCamera.TabIndex = 0;
            dataGridViewCamera.CellDoubleClick += dataGridViewCamera_CellDoubleClick;
            // 
            // labelCreateCamera
            // 
            labelCreateCamera.AutoSize = true;
            labelCreateCamera.Cursor = Cursors.Hand;
            labelCreateCamera.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreateCamera.ForeColor = Color.FromArgb(0, 126, 249);
            labelCreateCamera.Location = new Point(10, 55);
            labelCreateCamera.Name = "labelCreateCamera";
            labelCreateCamera.Size = new Size(168, 21);
            labelCreateCamera.TabIndex = 1;
            labelCreateCamera.Text = "Create a new camera";
            labelCreateCamera.Click += labelCreateCamera_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(247, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 2;
            label1.Text = "Camera list";
            // 
            // button1
            // 
            button1.Location = new Point(460, 397);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // CameraTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(669, 438);
            Controls.Add(button1);
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
        private Button button1;
    }
}