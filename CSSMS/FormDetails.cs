using ComputerStudent_SimpleManagementSystem.Models;
using ComputerStudent_SimpleManagementSystem.Services;

namespace ComputerStudent_SimpleManagementSystem
{
    public partial class FormDetails : Form
    {
        private FormListOfCourses? _formLC = null;
        private readonly CSSMSService _service = null;
        private bool _isBSCS = true;
        private IEnumerable<BSCS>? _css = null;
        private IEnumerable<BSIT>? _its = null;
        private string _backPath = "FormListOfCourses";

        public FormDetails()
        {
            InitializeComponent();

            _service = CSSMSService.GetInstance();
        }

        public void SetData(int index, bool isBscs, string path, IEnumerable<BSCS>? css = null,
            IEnumerable<BSIT>? its = null)
        {
            _isBSCS = isBscs;
            _css = css;
            _its = its;
            _backPath = path;

            if (!_isBSCS)
            {
                var bsit = _service.Read_BSIT(index);

                lblTitle.Text = $"Details of {bsit.Name}";
                lblName.Text = $"Name: {bsit.Name}";
                lblAge.Text = $"Age: {bsit.Age}";
                lblYrLvl.Text = $"Year Level: {bsit.YearLvl}";
                lblCourse.Text = $"Course: BSIT";
                lblSpecial.Text = $"Specialization: {bsit.Specialization}";
            }
            else
            {
                var bscs = _service.Read_BSCS(index);

                lblTitle.Text = $"Details of {bscs.Name}";
                lblName.Text = $"Name: {bscs.Name}";
                lblAge.Text = $"Age: {bscs.Age}";
                lblYrLvl.Text = $"Year Level: {bscs.YearLvl}";
                lblCourse.Text = $"Course: BSCS";
                lblSpecial.Text = $"Specialization: {bscs.Specialization}";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _formLC = new FormListOfCourses();

            if (_backPath.Contains("Both"))
            {
                _formLC.IsBSCS(null, _css, _its);
            }
            else
            {
                _formLC.IsBSCS(_isBSCS);
            }

            _formLC.Show();
            Close();
        }
    }
}