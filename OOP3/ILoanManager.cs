using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // All kind of loans have the same functions. They all have to calculate credit related things but in different ways. So that ve use interface to implemented by other class to write related versions of functions.
    interface ILoanManager  // interface- has common rules for classes, Classes that implement this interface write the inner side of functions.
    {
        public void Calculate();    // Credit calculation
        public void DoSomething();
    }

    // Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
}
