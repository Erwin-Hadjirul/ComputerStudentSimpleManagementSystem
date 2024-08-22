using ComputerStudent_SimpleManagementSystem.Services;

namespace ComputerStudent_SimpleManagementSystem
{
    public partial class FormSearch : Form
    {
        private readonly CSSMSService? _service = null;
        private FormListOfCourses? _formList = null;

        public FormSearch()
        {
            InitializeComponent();

            _service = CSSMSService.GetInstance();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = txtSearch.Text;

            var bscss = _service.Read_BSCSs().Where(st => st.Name == search);
            var bsits = _service.Read_BSITs().Where(st => st.Name == search);

            _formList = new FormListOfCourses();

            if (bscss.Any() && bsits.Any())
            {
                _formList.IsBSCS(null, bscss, bsits);
            }
            else if (bscss.Any())
            {
                _formList.IsBSCS(null, bscss);
            }
            else
            {
                _formList.IsBSCS(null, null, bsits);
            }

            _formList.Show();

            Hide();
        }
    }
}