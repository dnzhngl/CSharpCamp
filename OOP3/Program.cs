using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanManager consumerLoanManager = new ConsumerLoanManager();
            ILoanManager vehicleLoanManager = new VehicleLoanManager();
            ILoanManager mortgageLoanManager = new MortgageLoanManager();
            ILoanManager artisanLoanManager = new ArtisanLoanManager();

            LoanApplicationManager loanApplicationManager = new LoanApplicationManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            //loanApplicationManager.Apply(vehicleLoanManager);
            //loanApplicationManager.Apply(mortgageLoanManager);
            loanApplicationManager.Apply(consumerLoanManager, new List<ILoggerService> { databaseLoggerService, smsLoggerService });
            loanApplicationManager.Apply(artisanLoanManager, new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() });
            loanApplicationManager.Apply(vehicleLoanManager, smsLoggerService);


            List<ILoanManager> loans = new List<ILoanManager>()
            { consumerLoanManager, vehicleLoanManager, mortgageLoanManager };
            //loanApplicationManager.GiveCreditPreInformation(loans);
        }
    }
}
