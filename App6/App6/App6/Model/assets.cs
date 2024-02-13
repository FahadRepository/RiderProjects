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

   

    public class User
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string role { get; set; }
    }
}