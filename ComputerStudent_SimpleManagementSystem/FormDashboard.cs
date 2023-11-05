namespace ComputerStudent_SimpleManagementSystem
{
    public partial class FormDashboard : System.Windows.Forms.Form
    {
        private FormCollegeCourse? _formCCourse = null;
        private FormSearch? _formSearch = null;

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _formCCourse = new FormCollegeCourse();
            _formCCourse.SetKey("Add");

            _formCCourse.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            _formCCourse = new FormCollegeCourse();
            _formCCourse.SetKey("View");

            _formCCourse.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _formSearch = new FormSearch();

            _formSearch.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to stop the application?", "Alert!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}