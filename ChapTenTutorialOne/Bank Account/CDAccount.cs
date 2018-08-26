using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class CDAccount : SavingsAccount
    {
        private string maturityDate;

        public CDAccount()
        {
            maturityDate = "";
        }

        public string MaturityDate
        {
            get { return maturityDate; }
            set { maturityDate = value; }
        }
    }
}
