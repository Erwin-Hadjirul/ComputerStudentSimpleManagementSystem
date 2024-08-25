namespace ComputerStudent_SimpleManagementSystem
{
    partial class FormListOfCourses
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLStudents = new Label();
            btnBack = new Button();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // lblLStudents
            // 
            lblLStudents.AutoSize = true;
            lblLStudents.BackColor = Color.Transparent;
            lblLStudents.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblLStudents.Location = new Point(249, 41);
            lblLStudents.Name = "lblLStudents";
            lblLStudents.Size = new Size(267, 46);
            lblLStudents.TabIndex = 3;
            lblLStudents.Text = "Student records ";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaptionText;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(14, 15);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(62, 47);
            btnBack.TabIndex = 9;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // listBox
            // 
            listBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 28;
            listBox.Location = new Point(171, 112);
            listBox.Margin = new Padding(3, 4, 3, 4);
            listBox.Name = "listBox";
            listBox.Size = new Size(545, 536);
            listBox.TabIndex = 10;
            listBox.DoubleClick += listBox_DoubleClick;
            // 
            // FormListOfCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = SCSIMS.Properties.Resources.SCSIMS_View;
            ClientSize = new Size(1381, 708);
            Controls.Add(listBox);
            Controls.Add(btnBack);
            Controls.Add(lblLStudents);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormListOfCourses";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLStudents;
        private Button btnBack;
        private ListBox listBox;
    }
}