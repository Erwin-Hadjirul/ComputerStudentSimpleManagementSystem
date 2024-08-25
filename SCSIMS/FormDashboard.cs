namespace ComputerStudent_SimpleManagementSystem;

public partial class FormDashboard : Form
{
    // Forms
    private FormCollegeCourse? _formCCourse = null;
    private FormSearch? _formSearch = null;

    public FormDashboard()
    {
        InitializeComponent();
    }

    // When the add or add data button is clicked
    // Tell the next window that the user choice is add
    private void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _formCCourse = new FormCollegeCourse();
            _formCCourse.SetKey("Add");
            // Change also its background image
            _formCCourse.SetBackground(SCSIMS.Properties.Resources.SCSIMS_Add);

            _formCCourse.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // When the view or view data button is clicked
    // Tell the next window that the user choice is view
    private void btnView_Click(object sender, EventArgs e)
    {
        try
        {
            _formCCourse = new FormCollegeCourse();
            _formCCourse.SetKey("View");
            // Change also its background image
            _formCCourse.SetBackground(SCSIMS.Properties.Resources.SCSIMS_Enter_View);

            _formCCourse.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // When the search or search data button is clicked
    private void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            _formSearch = new FormSearch();

            _formSearch.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // When the exit is clicked
    private void btnExit_Click(object sender, EventArgs e)
    {
        DialogResult dialog = MessageBox.Show("Do you want to stop the application?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (dialog == DialogResult.Yes)
        {
            Application.Exit();
        }
    }
}