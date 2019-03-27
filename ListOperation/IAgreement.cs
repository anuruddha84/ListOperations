using System;
using System.Collections.Generic;
using System.Text;

namespace ListOperation {
    public interface IAgreement {
 
        string Name { get; set; }

        DateTime DateTime { get; set; }

        decimal Period { get; set; }

        string ProductId { get; set; }

    }
}
