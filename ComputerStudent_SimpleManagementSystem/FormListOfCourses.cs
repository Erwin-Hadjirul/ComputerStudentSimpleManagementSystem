using ComputerStudent_SimpleManagementSystem.Models;
using ComputerStudent_SimpleManagementSystem.Services;
using static System.Windows.Forms.DataFormats;

namespace ComputerStudent_SimpleManagementSystem
{
    public partial class FormListOfCourses : Form
    {
        private bool? _isBSCS = true;
        private FormCollegeCourse? _formCC = null;
        private FormDetails? _formDT = null;
        private readonly CSSMSService? _cssmss = null;
        private IEnumerable<BSCS>? _css = null;
        private IEnumerable<BSIT>? _its = null;

        public FormListOfCourses()
        {
            InitializeComponent();

            _cssmss = CSSMSService.GetInstance();
        }

        public void IsBSCS(bool? isBscs,
            IEnumerable<BSCS>? css = null, IEnumerable<BSIT>? its = null)
        {
            _isBSCS = isBscs;
            _css = css;
            _its = its;

            if (_isBSCS == null)
            {
                lblLStudents.Text = "Records of Students (Both)";

                listBox.Items.Clear();

                if (css != null)
                {
                    listBox.Items.Add("BSCS");

                    foreach (BSCS cs in css)
                    {
                        listBox.Items.Add($"{cs.Id}. {cs.Name} (BSCS)");
                    }
                }

                listBox.Items.Add("");

                if (its != null)
                {
                    listBox.Items.Add("BSIT");

                    foreach (BSIT it in its)
                    {
                        listBox.Items.Add($"{it.Id}. {it.Name} (BSIT)");
                    }
                }
            }
            else
            {
                if (!_isBSCS.Value)
                {
                    lblLStudents.Text = $"Records of Students (BSIT)";

                    IEnumerable<BSIT>? bsits = _cssmss.Read_BSITs();

                    if (bsits != null)
                    {
                        listBox.Items.Clear();

                        foreach (BSIT bsit in bsits)
                        {
                            listBox.Items.Add($"{bsit.Id}. {bsit.Name}");
                        }
                    }
                }
                else
                {
                    IEnumerable<BSCS>? bscss = _cssmss.Read_BSCSs();

                    if (bscss != null)
                    {
                        listBox.Items.Clear();

                        foreach (BSCS bscs in bscss)
                        {
                            listBox.Items.Add($"{bscs.Id}. {bscs.Name}");
                        }
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _formCC = new FormCollegeCourse();
            _formCC.SetKey("View");

            _formCC.Show();
            Close();
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                int selected;

                try
                {
                    selected = Convert.ToInt32(((string)listBox.SelectedItem).ElementAt(0).ToString());
                }
                catch (Exception)
                {
                    return;
                }
                
                _formDT = new FormDetails();

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
        }
    }
}