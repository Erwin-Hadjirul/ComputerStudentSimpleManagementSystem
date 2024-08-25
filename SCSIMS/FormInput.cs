using ComputerStudent_SimpleManagementSystem.Models;
using ComputerStudent_SimpleManagementSystem.Services;

namespace ComputerStudent_SimpleManagementSystem;

public partial class FormInput : Form
{
    // If the subject is BSCS or BSIT
    private bool _isBSCS = true;
    // Forms
    private FormCollegeCourse? _formCC = null;
    // Services
    private readonly SCSIMSService _cssmss;

    public FormInput()
    {
        InitializeComponent();

        // Get the only instance of our service
        _cssmss = SCSIMSService.GetInstance();
    }

    // Setting if the user choses BSCS or BSIT
    public void IsBSCS(bool bscs)
    {
        _isBSCS = bscs;

        // If the user choice is not BSCS, change the default text
        // of the lblForm to BSIT based
        lblForm.Text = $"Fill out the ({(_isBSCS == true? "BSCS" : "BSIT")}) form";
    }

    // When the submit button is clicked
    private void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            // All textboxes must be filled up first
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtYrLvl.Text) ||
                string.IsNullOrWhiteSpace(txtSpecial.Text))
            {
                throw new Exception("Please fill out all the required information.");
            }

            // Write data to the CSSMS service
            // The CSSMS service is the responsible for directing the data
            // to the DB
            if (!_isBSCS)
            {
                // BSIT
                _cssmss.Write_BSIT(new BSIT
                {
                    Name = txtName.Text,
                    Age = Convert.ToInt32(txtAge.Text),
                    YearLvl = Convert.ToInt32(txtYrLvl.Text),
                    Specialization = txtSpecial.Text
                });
            }
            else
            {
                // BSCS
                _cssmss.Write_BSCS(new BSCS
                {
                    Name = txtName.Text,
                    Age = Convert.ToInt32(txtAge.Text),
                    YearLvl = Convert.ToInt32(txtYrLvl.Text),
                    Specialization = txtSpecial.Text
                });
            }

            // Then, clear all of the input controls
            ClearControls();

            // Then, tell the user that it is success
            MessageBox.Show("You have successfully recorded.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        _formCC = new FormCollegeCourse();
        // The only way to access this window is through add key button
        // from dashboard
        _formCC.SetKey("Add");
        _formCC.SetBackground(SCSIMS.Properties.Resources.SCSIMS_Add);

        _formCC.Show();
        Close();
    }

    // Clears all the input controls
    private void ClearControls()
    {
        txtName.Clear();
        txtAge.Clear();
        txtYrLvl.Clear();
        txtSpecial.Clear();
    }
}