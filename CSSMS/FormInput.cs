using ComputerStudent_SimpleManagementSystem.Models;
using ComputerStudent_SimpleManagementSystem.Services;

namespace ComputerStudent_SimpleManagementSystem
{
    public partial class FormInput : Form
    {
        private bool _isBSCS = true;
        private FormCollegeCourse? _formCC = null;
        private readonly CSSMSService? _cssmss = null;

        public FormInput()
        {
            InitializeComponent();

            _cssmss = CSSMSService.GetInstance();
        }

        public void IsBSCS(bool bscs)
        {
            _isBSCS = bscs;

            if (!_isBSCS)
            {
                lblForm.Text = $"Fill Up the Form (BSIT)";
            }
        }

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
                    throw new Exception("Please complete the filling up of the form!");
                }

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

                ClearControls();

                MessageBox.Show("You have successfully recorded.", "Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _formCC = new FormCollegeCourse();
            _formCC.SetKey("Add");

            _formCC.Show();
            Close();
        }

        private void ClearControls()
        {
            txtName.Clear();
            txtAge.Clear();
            txtYrLvl.Clear();
            txtSpecial.Clear();
        }
    }
}