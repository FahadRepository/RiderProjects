using System;
using System.Collections.Generic;
using System.Windows.Input;
using App6.Model;
using App6.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App6.ViewModel
{
    public class ReturnAssetViewModel : BaseViewModel
    {

        public ReturnAssetViewModel _ViewModel;
        
        private Transaction _returnData ;
        public Transaction ReturnData
        {
            get => _returnData;
            set
            {
                _returnData = value;
                OnPropertyChanged();
            }
        } 
        public ReturnAssetViewModel(Transaction returnData)
        {
            ReturnData = returnData;
            // UpdateTransactionCommand = new Command(UpdateTransaction);
        }

        #region MyRegion
        
        private DateTime Date;
        private DateTime _selectedDate;
        private string supervisorsName;
        private FinalList _objContactList= new FinalList();
        private string _assetName;
        private string _studentName;
        private string _transactionType;
        private DateTime _loanDate;
        private string _assetId;
        private string _id;
        private string _loaningsupervisorName;
        

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
        
        public string Loaningsupervisorname
        {
            get => _loaningsupervisorName;
            set
            {
                _loaningsupervisorName = value;
                OnPropertyChanged();
            }
        }
        

        
        public DateTime OnSelectedDate
        {
            get => _selectedDate;
            set
            {
                SetField(ref _selectedDate, value);
                Date = _selectedDate.Date;
            }
        }
        

        private Transaction _onsupervisorSelect;

        public string supervisorName;
        public Transaction OnSelectedSupervisor
        {
            get => _onsupervisorSelect;
            set
            {
                SetField( ref _onsupervisorSelect, value);

                if (_onsupervisorSelect != null)
                    supervisorName=_onsupervisorSelect.loaningSupervisorname;
            }
            
        }
        
        

        public FinalList ObjContactList
                {
                    get => _objContactList;
                    set => SetField(ref _objContactList, value);
                }


        private Transaction _transaction = new Transaction();
        public bool UpdatedTransaction { get; set; }

        // public ICommand UpdateTransactionCommand { get; set; }
        public async void UpdateTransaction()
        {
            var transactionService = new TransactionService(fileName:"sample-data.json");
            var transId = ReturnData.id;
            
            _transaction.id = Guid.NewGuid().ToString();
            _transaction.studentname = _studentName;
            _transaction.assetName = _assetName;
            _transaction.assetId = _assetId;
            _transaction.loanDate = LoanDate;
            _transaction.loaningSupervisorname = _loaningsupervisorName;
            _transaction.transactionType = "Received";
            _transaction.receivingSupervisorname = supervisorName;
            _transaction.returnDate = Date;

            try
            {

                await transactionService.UpdateTransaction(_transaction, transId: transId);
                UpdatedTransaction = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
        

        #endregion
    }
}