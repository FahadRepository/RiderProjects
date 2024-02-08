using System;
using System.Collections.Generic;
using App6.Model;

namespace App6.ViewModel
{
    public class ReturnDataViewModel : BaseViewModel
    {

        public ReturnDataViewModel _ViewModel;
        public ReturnDataViewModel()
        {
            
        }

        #region MyRegion
        
        private DateTime Date;
        private DateTime _selectedDate;
        
        private Transaction _returnData ;
        public Transaction ReturnData
        {
            get => _returnData;
            set => SetField(ref _returnData, value);
        }

        public string AssetName
        {
            get => _assetName;
            set
            {
                _assetName = value;
                OnPropertyChanged();
            }
        }
        
        public string StudentName
        {
            get => _studentName;
            set
            {
                _studentName = value;
                OnPropertyChanged();
            }
        }
        
        public string TransactionType
        {
            get => _transactionType;
            set
            {
                _transactionType = value;
                OnPropertyChanged();
            }
        }
        
        
        public DateTime LoanDate
        {
            get => _loanDate;
            set
            {
                _loanDate = value;
                OnPropertyChanged();
            }
        }
        
        public string AssetId
        {
            get => _assetId;
            set
            {
                _assetId = value;
                OnPropertyChanged();
            }
        }
        
        public string Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        
        
        private FinalList _objContactList= new FinalList();
        private string _assetName;
        private string _studentName;
        private string _transactionType;
        private DateTime _loanDate;
        private string _assetId;
        private string _id;

        public FinalList ObjContactList
                {
                    get => _objContactList;
                    set => SetField(ref _objContactList, value);
                }
        
        
        

        
        
        
        
        // private Transaction _onSupervisorSelect;
        //
        // public Transaction OnSupervisorSelect
        // {
        //     get => _onSupervisorSelect;
        //     set
        //     {
        //         SetField( ref _onSupervisorSelect, value);
        //
        //         if (_onSupervisorSelect != null)
        //             _supervisorName=_onSupervisorSelect.receivingSupervisorname;
        //     }
        //     
        // }
        public DateTime SelectedDate
        {
            get => _selectedDate;
            set
            {
                SetField( ref _selectedDate, value);
                Date = SelectedDate.Date;
            }
            
        }


        #endregion
    }
}