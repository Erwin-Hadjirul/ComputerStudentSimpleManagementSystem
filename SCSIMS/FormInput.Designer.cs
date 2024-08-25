namespace ComputerStudent_SimpleManagementSystem
{
    partial class FormInput
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
            btnSubmit = new Button();
            lblForm = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtYrLvl = new TextBox();
            txtSpecial = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Lime;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Location = new Point(169, 404);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(555, 79);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblForm
            // 
            lblForm.AutoSize = true;
            lblForm.BackColor = Color.Transparent;
            lblForm.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblForm.Location = new Point(263, 47);
            lblForm.Name = "lblForm";
            lblForm.Size = new Size(0, 46);
            lblForm.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Cursor = Cursors.IBeam;
            txtName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(169, 125);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(555, 41);
            txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Cursor = Cursors.IBeam;
            txtAge.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(169, 197);
            txtAge.MaxLength = 2;
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "Age";
            txtAge.Size = new Size(555, 41);
            txtAge.TabIndex = 5;
            // 
            // txtYrLvl
            // 
            txtYrLvl.Cursor = Cursors.IBeam;
            txtYrLvl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtYrLvl.Location = new Point(169, 268);
            txtYrLvl.MaxLength = 1;
            txtYrLvl.Name = "txtYrLvl";
            txtYrLvl.PlaceholderText = "Year Level";
            txtYrLvl.Size = new Size(555, 41);
            txtYrLvl.TabIndex = 6;
            // 
            // txtSpecial
            // 
            txtSpecial.Cursor = Cursors.IBeam;
            txtSpecial.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtSpecial.Location = new Point(169, 336);
            txtSpecial.Name = "txtSpecial";
            txtSpecial.PlaceholderText = "Specialization";
            txtSpecial.Size = new Size(555, 41);
            txtSpecial.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaptionText;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(11, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(62, 47);
            btnBack.TabIndex = 8;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FormInput
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = SCSIMS.Properties.Resources.SCSIMS_Add;
            ClientSize = new Size(1381, 708);
            Controls.Add(btnBack);
            Controls.Add(txtSpecial);
            Controls.Add(txtYrLvl);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(lblForm);
            Controls.Add(btnSubmit);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormInput";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label lblForm;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtYrLvl;
        private TextBox txtSpecial;
        private Button btnBack;
    }
}