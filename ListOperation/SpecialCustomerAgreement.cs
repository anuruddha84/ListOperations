using System;
using System.Collections.Generic;
using System.Text;

namespace ListOperation {
    public class SpecialCustomerAgreement : IAgreement {

        public string Name { get; set; }

        public DateTime DateTime { get; set; }

        public decimal Period { get; set; }

        public string ProductId { get; set; }

        public decimal MinPeriod { get; set; }

        public decimal MaxPeriod { get; set; }


    }
}
