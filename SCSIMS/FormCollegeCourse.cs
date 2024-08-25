namespace ComputerStudent_SimpleManagementSystem;

public partial class FormCollegeCourse : Form
{
    // Key where the previous window points to
    private string _key = "Add";
    // Forms
    private FormInput? _formInput = null;
    private FormListOfCourses? _listOfCourses = null;

    public FormCollegeCourse()
    {
        InitializeComponent();
    }

    // Setting the key where the previous window points to
    public void SetKey(string key)
    {
        _key = key;
    }

    // When necessary to set background dynamically
    public void SetBackground(Bitmap bitmap)
    {
        BackgroundImage = bitmap;
    }

    // When the BSCS' button has been clicked
    private void btnBSCS_Click(object sender, EventArgs e)
    {
        try
        {
            // When the key is View go to list of courses window
            if (_key == "View")
            {
                _listOfCourses = new FormListOfCourses();
                _listOfCourses.IsBSCS(true);

                _listOfCourses.Show();
            }
            // When the key is Add go to input window
            else if (_key == "Add")
            {
                _formInput = new FormInput();
                _formInput.IsBSCS(true);

                _formInput.Show();
            }
            Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // When the BSIT's button has been clicked
    private void btnBSIT_Click(object sender, EventArgs e)
    {
        try
        {
            // When the key is View go to list of courses window
            if (_key == "View")
            {
                _listOfCourses = new FormListOfCourses();
                _listOfCourses.IsBSCS(false);

                _listOfCourses.Show();
            }
            // When the key is Add go to input window
            else if (_key == "Add")
            {
                _formInput = new FormInput();
                _formInput.IsBSCS(false);

                _formInput.Show();
            }
            Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}