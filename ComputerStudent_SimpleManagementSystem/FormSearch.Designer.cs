namespace ComputerStudent_SimpleManagementSystem
{
    partial class FormSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            btnSearch = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ButtonShadow;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(148, 152);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(486, 59);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(297, 32);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(158, 37);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Search Here";
            // 
            // txtSearch
            // 
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(148, 94);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter the name";
            txtSearch.Size = new Size(486, 34);
            txtSearch.TabIndex = 4;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1208, 531);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(btnSearch);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormSearch";
            ShowIcon = false;
            Text = "Comp Student Simple Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Label lblSearch;
        private TextBox txtSearch;
    }
}