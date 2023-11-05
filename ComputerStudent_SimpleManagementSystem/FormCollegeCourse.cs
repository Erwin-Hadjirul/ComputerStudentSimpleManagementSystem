namespace ComputerStudent_SimpleManagementSystem
{
    public partial class FormCollegeCourse : System.Windows.Forms.Form
    {
        private string _key = "Add";
        private FormInput? _formInput = null;
        private FormListOfCourses? _listOfCourses = null;

        public FormCollegeCourse()
        {
            InitializeComponent();
        }

        public void SetKey(string key)
        {
            _key = key;
        }

        private void btnBSCS_Click(object sender, EventArgs e)
        {
            if (_key == "View")
            {
                _listOfCourses = new FormListOfCourses();
                _listOfCourses.IsBSCS(true);

                _listOfCourses.Show();
                Hide();

                return;
            }

            _formInput = new FormInput();
            _formInput.IsBSCS(true);

            _formInput.Show();
            Hide();
        }

        private void btnBSIT_Click(object sender, EventArgs e)
        {
            if (_key == "View")
            {
                _listOfCourses = new FormListOfCourses();
                _listOfCourses.IsBSCS(false);

                _listOfCourses.Show();
                Hide();

                return;
            }

            _formInput = new FormInput();
            _formInput.IsBSCS(false);

            _formInput.Show();
            Hide();
        }
    }
}