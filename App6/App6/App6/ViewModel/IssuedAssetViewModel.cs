using System.Collections.Generic;
using System.Linq;
using App6.Model;

namespace App6.ViewModel
{
    public class IssuedAssetViewModel
    {
        public List<Transaction> AnotherFilterItem= new List<Transaction>();
        
        public bool IsDataAvailable { get; set; }
        public IssuedAssetViewModel()
        {
            
        }
    }
}