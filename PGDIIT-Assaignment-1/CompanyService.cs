using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGDIIT_Assaignment_1
{
    class CompanyService
    {
        CompanyInfo com = new CompanyInfo();
        public CompanyInfo Get() {
            return com;
        }
        public bool addCompnay(CompanyInfo addcom) {
            if (addcom != null)
            {
                com = addcom;
                return true;
            }
            else {
                return false;
            }
        }
        public void Removecompany() {
            com = new CompanyInfo();
        }
    }
}
