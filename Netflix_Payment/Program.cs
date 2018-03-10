using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Netflix_Payment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime payDate;
            DateTime today;
            Netflix nf = new Netflix();
            Paypal_GMail pp = new Paypal_GMail();
            Data data = new Data();
            String[] paymentList;
            Console.WriteLine("PayPal-Payment-Check");
            Console.WriteLine("==========================\n");

            //Open Excel
            data.OpenExcel();
            //Read Data to List
            paymentList = data.ReadExcel();
            //Read Date
            today = DateTime.Now.Date;
            payDate = nf.GetPayDate(today);
            #if DEBUG
            Console.WriteLine(payDate);
            #endif
            //Read PayPal


            //Close
            data.CloseExcel();
            Console.ReadKey();
        }
    }
}
