using System;
using System.Collections.Generic;
using System.Text;

namespace ListOperation {
    public static class Store {

        public static List<IAgreement> GetAgreements() {
            List<IAgreement> agreements = new List<IAgreement>();

            NormalCustomerAgreement normalCustomerAgreement1 = new NormalCustomerAgreement() {
                DateTime = DateTime.Now,
                Name = "Normal 1",
                Period = 8,
                ProductId = "1"
            };
            agreements.Add(normalCustomerAgreement1);

            NormalCustomerAgreement normalCustomerAgreement2 = new NormalCustomerAgreement() {
                DateTime = DateTime.Now,
                Name = "Normal 2",
                Period = 12,
                ProductId = "2"
            };
            agreements.Add(normalCustomerAgreement2);

            SpecialCustomerAgreement specialCustomerAgreement1 = new SpecialCustomerAgreement() {
                DateTime = DateTime.Now,
                Name = "Special 1",
                Period = 12,
                ProductId = "1",
                MaxPeriod = 24,
                MinPeriod = 14
            };
            agreements.Add(specialCustomerAgreement1);

            SpecialCustomerAgreement specialCustomerAgreement2 = new SpecialCustomerAgreement() {
                DateTime = DateTime.Now,
                Name = "Special 2",
                Period = 24,
                ProductId = "1",
                MaxPeriod = 36,
                MinPeriod = 3
            };
            agreements.Add(specialCustomerAgreement2);

            return agreements;
        }

    }
}
