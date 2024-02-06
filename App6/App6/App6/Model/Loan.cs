using System;
using SQLite;

namespace App6.Model
{
    public class Loan
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Supervisor { get; set; }
        
        public string Student { get; set; }
        
        public string Asset { get; set; }
        public DateTime Date { get; set; }
    }
}