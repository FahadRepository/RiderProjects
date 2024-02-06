using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using App6.Model;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace App6.ViewModel
{
    public class MainPageViewModel:BaseViewModel
    {
        public MainPageViewModel()
        {
                
        }

        #region  Property

        private string assetsName;
        private string studentName;
        private DateTime Date;
        private DateTime _selectedDate;


        public FinalList FilterDataItems= new FinalList();
        private FinalList _objContactList= new FinalList();

        public FinalList ObjContactList
        {
            get => _objContactList;
            set => SetField(ref _objContactList, value);
        }
        public DateTime SelectedDate
        {
            get => _selectedDate;
            set
            {
                SetField( ref _selectedDate, value);
                Date = SelectedDate.Date;
            }
            
        }
        private Transaction _onAssetsSelect;

        public Transaction OnAssetsSelect
        {
            get => _onAssetsSelect;
            set
            {
                SetField( ref _onAssetsSelect, value);

                if (_onAssetsSelect != null)
                    assetsName=_onAssetsSelect.assetName;
            }
            
        }
        
        private Transaction _userNameSelect;

        public Transaction UserNameSelect
        {
            get => _userNameSelect;
            set
            {
                SetField(ref _userNameSelect, value);
                if (_userNameSelect !=null)
                {
                    studentName=_userNameSelect.studentname;
                }
                
            }
        }
        
        

        #endregion

        #region Methods

        public void Filterdata()
        {
            try
            {
                var Data = ObjContactList.transactions.Where(x =>
                    (x.assetName.Equals(this.assetsName) && (x.studentname.Equals(this.studentName) &&
                                                             (x.loanDate == this.Date)))).ToList();
                    FilterDataItems.transactions = Data;
            }
            catch (Exception ex)
            {
                
            }
        }


        #endregion
        
    }
}