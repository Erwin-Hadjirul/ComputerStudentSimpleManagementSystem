using ComputerStudent_SimpleManagementSystem.Models;
using ComputerStudent_SimpleManagementSystem.Services;

namespace ComputerStudent_SimpleManagementSystem;

public partial class FormListOfCourses : Form
{
    // Lists of data
    private IEnumerable<BSCS>? _css = null;
    private IEnumerable<BSIT>? _its = null;
    // Key from the previous window
    private string _key = "View";
    // If the previous window is search form,
    // get the text to be searched
    private string _searched = string.Empty;
    // Is the subject BSCS or BSIT
    private bool? _isBSCS = true;
    // Forms
    private FormCollegeCourse? _formCC = null;
    private FormDetails? _formDT = null;
    private FormSearch? _formS = null;
    // Services
    private readonly SCSIMSService _cssmss;
    
    public FormListOfCourses()
    {
        InitializeComponent();

        // The only way to get the only instance of CSSMS Service
        _cssmss = SCSIMSService.GetInstance();
    }

    // Setting the key from previous window
    public void SetKey(string key)
    {
        _key = key;
    }

    // Setting the text to be searched from previous window
    public void SetSearched(string text)
    {
        _searched = text;
    }

    // Displays all the data on a list box
    public void IsBSCS(bool? isBscs,
        IEnumerable<BSCS>? css = null, IEnumerable<BSIT>? its = null)
    {
        _isBSCS = isBscs;
        _css = css;
        _its = its;

        try
        {
            // If the _isBSCS is null, then display both BSCS' and BSIT's data
            if (_isBSCS == null)
            {
                lblLStudents.Text += "(Both)";

                listBox.Items.Clear();

                if (css == null && its == null)
                {
                    listBox.Items.Add("\"No data\"");
                }
                else
                {
                    if (css != null)
                    {
                        listBox.Items.Add("BSCS");

                        foreach (BSCS cs in css)
                        {
                            listBox.Items.Add($"{cs.Id}. {cs.Name} (BSCS)");
                        }
                    }

                    if (its != null)
                    {
                        listBox.Items.Add("BSIT");

                        foreach (BSIT it in its)
                        {
                            listBox.Items.Add($"{it.Id}. {it.Name} (BSIT)");
                        }
                    }
                }
            }
            // Otherwise, display only one list of data
            else
            {
                lblLStudents.Text += $"({(_isBSCS.Value == true? "BSCS" : "BSIT")})";

                listBox.Items.Clear();

                // BSIT
                if (!_isBSCS.Value)
                {
                    IEnumerable<BSIT>? bsits = _cssmss.Read_BSITs();

                    if (bsits != null && bsits.Any())
                    {
                        foreach (BSIT bsit in bsits)
                        {
                            listBox.Items.Add($"{bsit.Id}. {bsit.Name}");
                        }
                    }
                    else
                    {
                        listBox.Items.Add("\"No data\"");
                    }
                }
                // BSCS
                else
                {
                    IEnumerable<BSCS>? bscss = _cssmss.Read_BSCSs();

                    if (bscss != null && bscss.Any())
                    {
                        foreach (BSCS bscs in bscss)
                        {
                            listBox.Items.Add($"{bscs.Id}. {bscs.Name}");
                        }
                    }
                    else
                    {
                        listBox.Items.Add("\"No data\"");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // When the back button is clicked
    private void btnBack_Click(object sender, EventArgs e)
    {
        if (_key == "View")
        {
            _formCC = new FormCollegeCourse();
            _formCC.SetKey(_key);
            // Change also its background image
            _formCC.SetBackground(SCSIMS.Properties.Resources.SCSIMS_Enter_View);

            _formCC.Show();
        }
        else if (_key == "Search")
        {
            _formS = new FormSearch();
            _formS.SetSearched(_searched);
            _formS.Show();

        }
        Close();
    }

    // When the user double clicked a listbox item
    private void listBox_DoubleClick(object sender, EventArgs e)
    {
        // Get the selected item and stored it into integer variable
        if (listBox.SelectedItem != null)
        {
            int selected;

            try
            {
                selected = Convert.ToInt32(((string)listBox.SelectedItem).ElementAt(0).ToString());

                // Prepare the details form
                _formDT = new FormDetails();
                _formDT.SetKey(_key);
                _formDT.SetSearched(_searched);

                // If the BSCS is null,
                // means both BSCS' and BSIT's data are needed
                if (_isBSCS == null)
                {
                    if (((string)listBox.SelectedItem).Contains("BSCS"))
                    {
                        _formDT.SetData(selected, true, "FormListOfCourses:Both", _css, _its);
                    }
                    else
                    {
                        _formDT.SetData(selected, false, "FormListOfCourses:Both", _css, _its);
                    }
                }
                // Otherwise, specific data
                else
                {
                    if (!_isBSCS.Value)
                    {
                        _formDT.SetData(selected, false, "FormListOfCourses");
                    }
                    else
                    {
                        _formDT.SetData(selected, true, "FormListOfCourses");
                    }
                }

                _formDT.Show();

                Hide();
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}