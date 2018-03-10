using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Netflix_Payment
{
    class Netflix
    {
        private DateTime lastpay = new DateTime(2018, 2, 12);
        private DateTime nextpay = new DateTime(2018, 3, 12);
        public DateTime GetPayDate(DateTime currDate)
        {
            if (currDate == nextpay)
                return currDate;
            if (currDate < nextpay)
                return nextpay;
            if (currDate > nextpay)
                return currDate.AddYears(-1);
            return currDate.AddYears(-1);
        }
    }
}
