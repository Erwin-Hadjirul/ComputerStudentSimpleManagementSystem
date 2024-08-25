using ComputerStudent_SimpleManagementSystem.Models;

namespace ComputerStudent_SimpleManagementSystem
{
    partial class FormDetails
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
            lblTitle = new Label();
            btnBack = new Button();
            panel = new Panel();
            lblCourse = new Label();
            lblSpecial = new Label();
            lblYrLvl = new Label();
            lblAge = new Label();
            lblName = new Label();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(174, 47);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(170, 46);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Details of ";
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
            // panel
            // 
            panel.BackColor = Color.Silver;
            panel.Controls.Add(lblCourse);
            panel.Controls.Add(lblSpecial);
            panel.Controls.Add(lblYrLvl);
            panel.Controls.Add(lblAge);
            panel.Controls.Add(lblName);
            panel.Location = new Point(174, 116);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.Name = "panel";
            panel.Size = new Size(544, 523);
            panel.TabIndex = 10;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.BackColor = Color.Transparent;
            lblCourse.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblCourse.Location = new Point(29, 209);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(104, 35);
            lblCourse.TabIndex = 15;
            lblCourse.Text = "Course: ";
            // 
            // lblSpecial
            // 
            lblSpecial.AutoSize = true;
            lblSpecial.BackColor = Color.Transparent;
            lblSpecial.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpecial.Location = new Point(29, 266);
            lblSpecial.Name = "lblSpecial";
            lblSpecial.Size = new Size(178, 35);
            lblSpecial.TabIndex = 14;
            lblSpecial.Text = "Specialization: ";
            // 
            // lblYrLvl
            // 
            lblYrLvl.AutoSize = true;
            lblYrLvl.BackColor = Color.Transparent;
            lblYrLvl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblYrLvl.Location = new Point(29, 149);
            lblYrLvl.Name = "lblYrLvl";
            lblYrLvl.Size = new Size(137, 35);
            lblYrLvl.TabIndex = 13;
            lblYrLvl.Text = "Year Level: ";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.BackColor = Color.Transparent;
            lblAge.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblAge.Location = new Point(29, 88);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(71, 35);
            lblAge.TabIndex = 12;
            lblAge.Text = "Age: ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(29, 32);
            lblName.Name = "lblName";
            lblName.Size = new Size(94, 35);
            lblName.TabIndex = 11;
            lblName.Text = "Name: ";
            // 
            // FormDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = SCSIMS.Properties.Resources.SCSIMS_Search;
            ClientSize = new Size(1381, 708);
            Controls.Add(panel);
            Controls.Add(btnBack);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormDetails";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Button btnBack;
        private Panel panel;
        private Label lblName;
        private Label lblAge;
        private Label lblYrLvl;
        private Label lblSpecial;
        private Label lblCourse;
    }
}