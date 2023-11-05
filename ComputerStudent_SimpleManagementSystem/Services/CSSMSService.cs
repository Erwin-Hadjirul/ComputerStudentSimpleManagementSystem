using ComputerStudent_SimpleManagementSystem.Models;

namespace ComputerStudent_SimpleManagementSystem.Services
{
    public class CSSMSService
    {
        private static CSSMSService? _instance = null;
        private readonly static List<BSCS>? BSCSs = new List<BSCS>();
        private readonly static List<BSIT>? BSITs = new List<BSIT>();

        private CSSMSService()
        {
        }

        public static CSSMSService GetInstance()
        {
            if (_instance == null) _instance = new CSSMSService();

            return _instance;
        }

        private int GetDataCount(bool isBsit)
        {
            if (!isBsit)
            {
                return BSCSs.Count();
            }

            return BSITs.Count();
        }

        public IEnumerable<BSCS>? Read_BSCSs()
        {
            if (!(BSCSs.Count > 0))
            {
                BSCSs.AddRange(new List<BSCS>
                {
                    new BSCS { Id = 1, Name = "Erwin", Age = 24, YearLvl = 4, Specialization = "Computer Programmer" },
                    new BSCS { Id = 2, Name = "Abdilhakim", Age = 23, YearLvl = 4, Specialization = "Computer Hacking" },
                    new BSCS { Id = 3, Name = "Ajiver", Age = 24, YearLvl = 4, Specialization = "Web Frontend" }
                });
            }

            return BSCSs;
        }

        public IEnumerable<BSIT>? Read_BSITs()
        {
            if (!(BSITs.Count > 0))
            {
                BSITs.AddRange(new List<BSIT>
                {
                    new BSIT { Id = 1, Name = "Adjikir", Age = 23, YearLvl = 4, Specialization = "Computer Programmer" },
                    new BSIT { Id = 2, Name = "Solohom", Age = 23, YearLvl = 4, Specialization = "Computer Hacking" },
                    new BSIT { Id = 3, Name = "Ridzkir", Age = 24, YearLvl = 4, Specialization = "IT Stuff" },
                    new BSIT { Id = 4, Name = "Erwin", Age = 26, YearLvl = 4, Specialization = "Selling Computer" }
                });
            }

            return BSITs;
        }

        public BSCS? Read_BSCS(int id)
        {
            return BSCSs.Where(cs => cs.Id == id).SingleOrDefault();
        }

        public BSIT? Read_BSIT(int id)
        {
            return BSITs.Where(cs => cs.Id == id).SingleOrDefault();
        }

        public BSCS Write_BSCS(BSCS bscs)
        {
            bscs.Id = GetDataCount(false) + 1;

            BSCSs.Add(bscs);

            return bscs;
        }

        public BSIT Write_BSIT(BSIT bsit)
        {
            bsit.Id = GetDataCount(true) + 1;

            BSITs.Add(bsit);

            return bsit;
        }
    }
}
