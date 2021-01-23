using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //birden fazla class açmamıza polimorfiziim denir
        //daha koılay olması için birden fazla class açtık
        static void Main(string[] args)
        {   
            //ikiside aynı
            //ConsumerLoanManager consumerLoanManager = new ConsumerLoanManager();
            //İnterface onu implemente eden classın referansını tutabilir
            //Bu bilgi biz işe sokacak bilgidir o yüzden bu çok önemli

            ILoanManager consumerLoanManager = new ConsumerLoanManager();
            ILoanManager carLoanManager = new CarLoanManager();
            ILoanManager houseLoanManager = new HouseLoanManager();



            ApplyManager applyManager = new ApplyManager();
            applyManager.Apply(carLoanManager, new FileLoggerService());

            List<ILoanManager> loans = new List<ILoanManager>() {consumerLoanManager, carLoanManager };
            //applyManager.LoanPreInformation(loans);          //şuan bankadaki görevli kredi bilgilendirmesi için kredileri yolladı
            



        }
    }
}
