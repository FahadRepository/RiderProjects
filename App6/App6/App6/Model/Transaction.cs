using System;
using Xamarin.Forms;

namespace App6.Model
{
    public class Transaction
    
        {
            public string id { get; set; }
            public string transactionType { get; set; }
            public string loaningSupervisorId { get; set; }
            public string loaningSupervisorname { get; set; }
            public string studentId { get; set; }
            public string studentname { get; set; }
            public string assetId { get; set; }
            public string assetName { get; set; }
            public DateTime loanDate { get; set; }
            public string receivingSupervisorId { get; set; }
            public string receivingSupervisorname { get; set; }
            public DateTime? returnDate { get; set; }
        }
    }