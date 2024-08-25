using ComputerStudent_SimpleManagementSystem.Models;
using ComputerStudent_SimpleManagementSystem.Services;
using System;

namespace ComputerStudent_SimpleManagementSystem;

public partial class FormDetails : Form
{
    // Lists for storing of data
    private IEnumerable<BSCS>? _css = null;
    private IEnumerable<BSIT>? _its = null;
    // Where previous window key is stored
    private string _backPath = "FormListOfCourses";
    // Where the previous key is stored
    private string _key = string.Empty;
    // Where the searched data stored
    private string _searched = string.Empty;
    // If the subject is BSCS or BSIT
    private bool _isBSCS = true;
    // Forms
    private FormListOfCourses? _formLC = null;
    // Services
    private readonly SCSIMSService _service;

    public FormDetails()
    {
        InitializeComponent();

        // Get the only instance of our service
        _service = SCSIMSService.GetInstance();
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

    // Setting all of the required data to display the details of the DB data
    public void SetData(int index, bool isBscs, string path, IEnumerable<BSCS>? css = null,
        IEnumerable<BSIT>? its = null)
    {
        _isBSCS = isBscs;
        _css = css;
        _its = its;
        _backPath = path;

        // Displaying details of a specific data from DB
        DisplayData(index);
    }

    // Displaying details of a specific data from DB
    private void DisplayData(int index)
    {
        try
        {
            if (!_isBSCS)
            {
                var bsit = _service.Read_BSIT(index);

                if (bsit != null)
                {
                    lblTitle.Text += bsit.Name;
                    lblName.Text += bsit.Name;
                    lblAge.Text += bsit.Age;
                    lblYrLvl.Text += bsit.YearLvl;
                    lblCourse.Text += "BSIT";
                    lblSpecial.Text += bsit.Specialization;
                }
            }
            else
            {
                var bscs = _service.Read_BSCS(index);

                if (bscs != null)
                {
                    lblTitle.Text += bscs.Name;
                    lblName.Text += bscs.Name;
                    lblAge.Text += bscs.Age;
                    lblYrLvl.Text += bscs.YearLvl;
                    lblCourse.Text += "BSCS";
                    lblSpecial.Text += bscs.Specialization;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // When back is clicked
    private void btnBack_Click(object sender, EventArgs e)
    {
        _formLC = new FormListOfCourses();
        _formLC.SetKey(_key);
        _formLC.SetSearched(_searched);

        // When the previous path given has 'Both' on its end,
        // means the previous window has both BSCS' and BSIT's data displayed
        if (_backPath.Contains("Both"))
        {
            _formLC.IsBSCS(null, _css, _its);
        }
        else
        {
            // When the _isBSCS is true,
            // means the previous window is displaying BSCS' data
            // else otherwise (BSIT)
            _formLC.IsBSCS(_isBSCS);
        }

        // Go to the previous window
        _formLC.Show();
        Close();
    }
}