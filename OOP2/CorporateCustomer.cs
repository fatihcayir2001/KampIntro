using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{

    class CorporateCustomer:Customer  //inheritance yani miras demek bu yaptığımıza
    {                                 //soldakinde olan her şey sağdakinde de var kabul edilir
        public string CompanyName { get; set; }
        
        public string TaxNo { get; set; }

    }
}
