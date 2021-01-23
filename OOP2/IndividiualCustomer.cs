using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class IndividiualCustomer:Customer
    {
        //public int Id { get; set; }
        //public string CustomerNo { get; set; }  //Customer dan miras aldığı için gerek yok
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
