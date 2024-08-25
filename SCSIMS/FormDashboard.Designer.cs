namespace ComputerStudent_SimpleManagementSystem
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            btnAdd = new Button();
            btnView = new Button();
            btnExit = new Button();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Turquoise;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(169, 108);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(555, 79);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.ButtonShadow;
            btnView.Cursor = Cursors.Hand;
            btnView.Location = new Point(169, 203);
            btnView.Name = "btnView";
            btnView.Size = new Size(555, 79);
            btnView.TabIndex = 1;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Location = new Point(169, 401);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(555, 79);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Yellow;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(169, 301);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(555, 79);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = SCSIMS.Properties.Resources.SCSIMS_Dashboard;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1380, 708);
            Controls.Add(btnSearch);
            Controls.Add(btnExit);
            Controls.Add(btnView);
            Controls.Add(btnAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDashboard";
            Text = "Simple Computer Student Information Management System";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnView;
        private Button btnExit;
        private Button btnSearch;
    }
}