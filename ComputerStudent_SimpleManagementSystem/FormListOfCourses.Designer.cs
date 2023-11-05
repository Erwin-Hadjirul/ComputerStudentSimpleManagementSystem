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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListOfCourses));
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
            lblLStudents.Location = new Point(211, 34);
            lblLStudents.Name = "lblLStudents";
            lblLStudents.Size = new Size(333, 37);
            lblLStudents.TabIndex = 3;
            lblLStudents.Text = "Records of Students (BSCS)";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaptionText;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(12, 11);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(54, 35);
            btnBack.TabIndex = 9;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // listBox
            // 
            listBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 21;
            listBox.Location = new Point(150, 84);
            listBox.Name = "listBox";
            listBox.Size = new Size(477, 403);
            listBox.TabIndex = 10;
            listBox.DoubleClick += listBox_DoubleClick;
            // 
            // FormListOfCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1208, 531);
            Controls.Add(listBox);
            Controls.Add(btnBack);
            Controls.Add(lblLStudents);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormListOfCourses";
            ShowIcon = false;
            Text = "Comp Student Simple Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLStudents;
        private Button btnBack;
        private ListBox listBox;
    }
}