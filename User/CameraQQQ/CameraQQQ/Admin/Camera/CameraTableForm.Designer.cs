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
            btnExit = new Button();
            button1 = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCamera).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCamera
            // 
            dataGridViewCamera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCamera.Location = new Point(12, 116);
            dataGridViewCamera.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCamera.Name = "dataGridViewCamera";
            dataGridViewCamera.RowHeadersWidth = 51;
            dataGridViewCamera.Size = new Size(741, 406);
            dataGridViewCamera.TabIndex = 0;
            dataGridViewCamera.CellClick += dataGridViewCamera_CellClick;
            // 
            // labelCreateCamera
            // 
            labelCreateCamera.AutoSize = true;
            labelCreateCamera.Cursor = Cursors.Hand;
            labelCreateCamera.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreateCamera.ForeColor = Color.FromArgb(0, 126, 249);
            labelCreateCamera.Location = new Point(12, 73);
            labelCreateCamera.Name = "labelCreateCamera";
            labelCreateCamera.Size = new Size(210, 28);
            labelCreateCamera.TabIndex = 1;
            labelCreateCamera.Text = "Create a new camera";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(288, 20);
            label1.Name = "label1";
            label1.Size = new Size(175, 41);
            label1.TabIndex = 2;
            label1.Text = "Camera list";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(0, 156, 149);
            btnExit.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(652, 529);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(101, 43);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(526, 529);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 156, 149);
            btnAdd.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(545, 529);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 43);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Create";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // CameraTableForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(765, 584);
            Controls.Add(btnAdd);
            Controls.Add(button1);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(labelCreateCamera);
            Controls.Add(dataGridViewCamera);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnExit;
        private Button button1;
        private Button btnAdd;
    }
}