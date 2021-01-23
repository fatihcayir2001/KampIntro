using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplyManager
    {
        public void Apply(ILoanManager loanManager, ILoggerService loggerService)//Hangi krediyi istediğini aldık
        {
            //Başvuran bilgilerini değerlendirme
            //Başvuran adı soyadı varlığı vs

            //Böyle yaparsak tüm başvurular konut kredisi üzerinden hesaplarız
            //HouseLoanManager houseLoanManager = new HouseLoanManager();
            //houseLoanManager.Calculate();

            loanManager.Calculate();                    //işte burda gönderilen krediyi hesapladık
            loggerService.Log();

        }

        public void LoanPreInformation(List<ILoanManager> loans) //Bana ILoanManager türünde liste ver
        {
            foreach (var loan in loans)
            {
                loan.Calculate();                   //listedeki her bir kredinin hesabını yaptık
            }

        }

    }
}
