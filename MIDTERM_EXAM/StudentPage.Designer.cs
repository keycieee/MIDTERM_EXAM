namespace StudentManagementSystem
{
    partial class StudentPage : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.Button ViewButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.ViewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(13, 11);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(207, 29);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Student Records";
            this.HeaderLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Location = new System.Drawing.Point(13, 44);
            this.studentsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.RowHeadersWidth = 51;
            this.studentsDataGridView.Size = new System.Drawing.Size(441, 320);
            this.studentsDataGridView.TabIndex = 1;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(12, 371);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(149, 33);
            this.ViewButton.TabIndex = 2;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // StudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 416);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.studentsDataGridView);
            this.Controls.Add(this.HeaderLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management System";
            this.Load += new System.EventHandler(this.StudentPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
    }
}
