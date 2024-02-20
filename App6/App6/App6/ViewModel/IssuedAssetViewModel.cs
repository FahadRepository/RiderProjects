using System.Collections.Generic;
using System.Linq;
using App6.Model;
using Xamarin.Forms;

namespace App6.ViewModel
{
    public class IssuedAssetViewModel: BaseViewModel
    {
        public List<Transaction> AnotherFilterItem= new List<Transaction>();
        
        private Brush _colour;

        public bool IsDataAvailable { get; set; }
        
        public bool CanDataReturn { get; set; }
        public IssuedAssetViewModel()
        {
            
        }

        
        public Brush Colour
        {
            get => _colour;
            set
            {
                _colour = value;
                OnPropertyChanged();
            }
        } 
    }
}