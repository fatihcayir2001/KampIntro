using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HouseLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");

        }

        public void DoSth()
        {
            throw new NotImplementedException();
        }
    }
}
