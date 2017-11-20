using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGDIIT_Assaignment_1
{
    class TransectionService
    {
        TransectionLogs tlogs = new TransectionLogs();
        List<TransectionLogs> tloglist = new List<TransectionLogs>();
        public TransectionLogs Get() {
            return tlogs;
        }

        public List<TransectionLogs> Getlist() {
            return tloglist;
        }

        public bool Deposit(TransectionLogs tlog) {
            bool result =false;
            if (tlog != null)
            {
                tlogs.Tamount = tlog.Tamount;
                tlogs.BalanceAmount = tlogs.BalanceAmount + tlog.Tamount;
                result = AddToList(tlogs);
                return result;
            }
            else {
                return result;
            }
        }
        public bool WithDraw(TransectionLogs tlog)
        {
            bool result = false;
            if (tlog != null)
            {
                tlogs.Tamount = tlog.Tamount;
                tlogs.BalanceAmount = tlogs.BalanceAmount + tlog.Tamount;
                result = AddToList(tlogs);
                return result;
            }
            else
            {
                return result;
            }
        }
        public bool AddToList(TransectionLogs tlog)
        {
            tloglist.Add(tlog);
            return true;
        }
    }
}
