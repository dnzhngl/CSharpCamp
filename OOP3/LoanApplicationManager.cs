using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class LoanApplicationManager
    {
        // Using ILoanManager as a parameter, we can send all types of loans and use their functions that are specific to that type of loan.
        public void Apply(ILoanManager loanManager, List<ILoggerService> loggerServices)
        {
            // Evaluate the applicants info 
            loanManager.Calculate();    // all types of loan's have different calculation methods, by using the ILoanManager we'll be able to use calculate method that is specific to incoming loan type.
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log(); // log based on the sent type of loggerService.It can ben database logger or file logger.
            }
        }
        
        public void Apply(ILoanManager loanManager, ILoggerService loggerService)
        {
            loanManager.Calculate();   
            loggerService.Log(); 
        }
        //Kredi ön bilgilendirmesi yap
        public void GiveCreditPreInformation(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}
