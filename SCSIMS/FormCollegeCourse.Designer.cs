namespace ComputerStudent_SimpleManagementSystem
{
    partial class FormCollegeCourse
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
            btnBSCS = new Button();
            btnBSIT = new Button();
            lblCCourse = new Label();
            SuspendLayout();
            // 
            // btnBSCS
            // 
            btnBSCS.BackColor = Color.Turquoise;
            btnBSCS.Cursor = Cursors.Hand;
            btnBSCS.Location = new Point(169, 108);
            btnBSCS.Name = "btnBSCS";
            btnBSCS.Size = new Size(555, 79);
            btnBSCS.TabIndex = 0;
            btnBSCS.Text = "BSCS";
            btnBSCS.UseVisualStyleBackColor = false;
            btnBSCS.Click += btnBSCS_Click;
            // 
            // btnBSIT
            // 
            btnBSIT.BackColor = SystemColors.ButtonShadow;
            btnBSIT.Cursor = Cursors.Hand;
            btnBSIT.Location = new Point(169, 203);
            btnBSIT.Name = "btnBSIT";
            btnBSIT.Size = new Size(555, 79);
            btnBSIT.TabIndex = 1;
            btnBSIT.Text = "BSIT";
            btnBSIT.UseVisualStyleBackColor = false;
            btnBSIT.Click += btnBSIT_Click;
            // 
            // lblCCourse
            // 
            lblCCourse.AutoSize = true;
            lblCCourse.BackColor = Color.Transparent;
            lblCCourse.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblCCourse.Location = new Point(319, 42);
            lblCCourse.Name = "lblCCourse";
            lblCCourse.Size = new Size(245, 46);
            lblCCourse.TabIndex = 3;
            lblCCourse.Text = "Choose Course";
            // 
            // FormCollegeCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1380, 708);
            Controls.Add(lblCCourse);
            Controls.Add(btnBSIT);
            Controls.Add(btnBSCS);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormCollegeCourse";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBSCS;
        private Button btnBSIT;
        private Label lblCCourse;
    }
}