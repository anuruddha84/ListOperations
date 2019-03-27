using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperation {
    class Program {
        static void Main(string[] args) {

            List<IAgreement> Agreements = Store.GetAgreements();

            // 1. Find NormalCustomerAgreement Count
            var NormalCustomerAgreementList = Agreements.Where(i => i is NormalCustomerAgreement).ToList();
            Console.WriteLine($"NormalCustomerAgreement Count :{ NormalCustomerAgreementList.Count()}");

            // 2. Find SpecialCustomerAgreement that has MaxPeriod 
            var SpecialCustomerAgreementList = Agreements.Where(i => i is SpecialCustomerAgreement).Cast<SpecialCustomerAgreement>().ToList();
            Console.WriteLine($"SpecialCustomerAgreement Name that has MaxPeriod :{ SpecialCustomerAgreementList.OrderByDescending(i => i.MaxPeriod).FirstOrDefault().Name }");
            



            Console.ReadLine();
        }
    }
}
