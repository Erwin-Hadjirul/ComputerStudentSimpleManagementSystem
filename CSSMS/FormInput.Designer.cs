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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInput));
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
            btnSubmit.Location = new Point(148, 303);
            btnSubmit.Margin = new Padding(3, 2, 3, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(486, 59);
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
            lblForm.Location = new Point(238, 33);
            lblForm.Name = "lblForm";
            lblForm.Size = new Size(289, 37);
            lblForm.TabIndex = 3;
            lblForm.Text = "Fill Up the Form (BSCS)";
            // 
            // txtName
            // 
            txtName.Cursor = Cursors.IBeam;
            txtName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(148, 94);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(486, 34);
            txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Cursor = Cursors.IBeam;
            txtAge.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(148, 148);
            txtAge.Margin = new Padding(3, 2, 3, 2);
            txtAge.MaxLength = 2;
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "Age";
            txtAge.Size = new Size(486, 34);
            txtAge.TabIndex = 5;
            // 
            // txtYrLvl
            // 
            txtYrLvl.Cursor = Cursors.IBeam;
            txtYrLvl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtYrLvl.Location = new Point(148, 201);
            txtYrLvl.Margin = new Padding(3, 2, 3, 2);
            txtYrLvl.MaxLength = 1;
            txtYrLvl.Name = "txtYrLvl";
            txtYrLvl.PlaceholderText = "Year Level";
            txtYrLvl.Size = new Size(486, 34);
            txtYrLvl.TabIndex = 6;
            // 
            // txtSpecial
            // 
            txtSpecial.Cursor = Cursors.IBeam;
            txtSpecial.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtSpecial.Location = new Point(148, 252);
            txtSpecial.Margin = new Padding(3, 2, 3, 2);
            txtSpecial.Name = "txtSpecial";
            txtSpecial.PlaceholderText = "Specialization";
            txtSpecial.Size = new Size(486, 34);
            txtSpecial.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaptionText;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(10, 9);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(54, 35);
            btnBack.TabIndex = 8;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FormInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1208, 531);
            Controls.Add(btnBack);
            Controls.Add(txtSpecial);
            Controls.Add(txtYrLvl);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(lblForm);
            Controls.Add(btnSubmit);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormInput";
            ShowIcon = false;
            Text = "Comp Student Simple Management System";
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