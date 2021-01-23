using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interface bizim şablon görevini görür
    //base LoanManagerimize interface dedik
    //bir interface şunu anlatır eğer ki birisi bu interfaceyi kullanırsa içindeki metotu kullanmak zorunda
    //okunurluğu arttırmak için I harfiyle başlattık
    //Biz interface bizim için şablona uymak demektir
    //interfaceler genelde operasyonel metotlarda kullanılır
    //interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız
    //burada kreditürlerinin hepsinde geri ödeme planı vardır yani ortaktır ama kodları farklıdır

    interface ILoanManager
    {
        public void Calculate();
        public void DoSth();
    }


}
