using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class CarLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }

        public void DoSth()
        {
            throw new NotImplementedException();
        }
    }
}
