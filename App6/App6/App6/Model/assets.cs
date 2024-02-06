using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace App6.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Asset
    {
        public string id { get; set; }
        public string name { get; set; }
        public string serialNumber { get; set; }
        public string model { get; set; }
    }

    public class FinalList
    {
        public List<User> users { get; set; } 
        public List<Asset> assets { get; set; }
        public List<Transaction> transactions { get; set; }
        public List<DateTime> DateOnlyTransactions { get; set; }
    }

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

        public bool isFrameVisible
        {
            get
            {
                if (string.IsNullOrEmpty(returnDate.ToString()))
                    return false;
                else
                {
                    return true;
                }
            }
        }
     }

    public class User
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string role { get; set; }
    }
}