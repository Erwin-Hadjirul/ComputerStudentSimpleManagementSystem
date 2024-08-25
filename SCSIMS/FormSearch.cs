using ComputerStudent_SimpleManagementSystem.Services;

namespace ComputerStudent_SimpleManagementSystem;

public partial class FormSearch : Form
{
    // If the search is already done
    private string _searched = string.Empty;
    // Forms
    private FormListOfCourses? _formList = null;
    // Services
    private readonly SCSIMSService _service;

    public FormSearch()
    {
        InitializeComponent();

        // The only way to get the instance of CSSMS Service
        _service = SCSIMSService.GetInstance();
    }

    // Set the search text if it has already exist
    public void SetSearched(string text)
    {
        _searched = text;

        // When the search text already exist
        txtSearch.Text = _searched;
    }

    // When the search button is clicked
    private void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            // Get the inputted text to search
            var search = txtSearch.Text;

            // Validation
            if (string.IsNullOrWhiteSpace(search))
            {
                MessageBox.Show("No text to search.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Searching
                var bscss = _service.Read_BSCSs()?
                    .Where(st => st.Name.ToLower().Contains(search.ToLower()));
                var bsits = _service.Read_BSITs()?
                    .Where(st => st.Name.ToLower().Contains(search.ToLower()));

                // Prepare the next form required
                _formList = new FormListOfCourses();
                _formList.SetKey("Search");
                _formList.SetSearched(search);

                // If both BSCS' and BSIT's data are on the result,
                // or only specific to BSCS or BSIT,
                // set the required metadata for the next
                // window to appear
                if (bscss == null && bsits == null)
                {
                    _formList.IsBSCS(null, null, null);
                }
                else if (bsits != null && bscss == null)
                {
                    if (bsits.Any())
                    {
                        _formList.IsBSCS(null, null, bsits);
                    }
                }
                else if (bscss != null && bsits == null)
                {
                    if (bscss.Any())
                    {
                        _formList.IsBSCS(null, bscss);
                    }
                }
                else if (bscss != null && bsits != null)
                {
                    if (bscss.Any() && bsits.Any())
                    {
                        _formList.IsBSCS(null, bscss, bsits);
                    }
                    else if (bscss.Any())
                    {
                        _formList.IsBSCS(null, bscss);
                    }
                    else if (bsits.Any())
                    {
                        _formList.IsBSCS(null, null, bsits);
                    }
                    else
                    {
                        _formList.IsBSCS(null, null, null);
                    }
                }

                _formList.Show();

                Hide();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}