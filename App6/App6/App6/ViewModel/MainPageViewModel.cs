using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using App6.Model;
using App6.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace App6.ViewModel
{
    public class MainPageViewModel:BaseViewModel
    {
        public MainPageViewModel()
        {
            transactionService = new TransactionService(fileName: "sample-data.json");
        }

        #region  Property

        private string assetsName;
        private string studentName;
        private DateTime? Date;
        private DateTime _selectedDate;
        private TransactionService transactionService;

        public FinalList FilterDataItems= new FinalList();
        private FinalList _objContactList= new FinalList();
        
        
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

        public List<DateTime> DateOnlyTransactions { get; set; }
        

        #endregion

        #region Methods

        async public Task  Filterdata()
        {
            try
            {
                var listData = await transactionService.GetTransaction();

                if (this.assetsName != null && this.studentName != null)
                {
                    var Data = listData.Where(x =>
                        (x.assetName.Equals(this.assetsName) && (x.studentname.Equals(this.studentName) &&
                                                                 (x.loanDate.Date == this.Date)))).ToList();
                    FilterDataItems.transactions = Data;
                }
                else if (this.assetsName == null && this.studentName != null)
                {
                    var Data = listData.Where(x =>
                        ((x.studentname.Equals(this.studentName) &&
                                                                 (x.loanDate.Date == this.Date)))).ToList();
                    FilterDataItems.transactions = Data;
                }
                else if (this.assetsName!=null && this.studentName==null)
                {
                    var Data = listData.Where(x =>
                        (x.assetName.Equals(this.assetsName) &&
                                                                 (x.loanDate.Date == this.Date))).ToList();
                    FilterDataItems.transactions = Data;
                }
                else if (this.assetsName == null && this.studentName == null)
                {
                    var Data = listData.Where(x => (x.loanDate.Date == this.Date)).ToList();
                    FilterDataItems.transactions = Data;
                }
                else if(this.assetsName != null && this.studentName != null && this.Date == null)
                {
                    var Data = listData.Where(x =>
                        (x.assetName.Equals(this.assetsName) && (x.studentname.Equals(this.studentName)))).ToList();
                    FilterDataItems.transactions = Data;
                }
                else
                {
                    FilterDataItems.transactions = listData;
                }
            }
            catch (Exception ex)
            {
                
            }
            
        }


        #endregion
        
    }
}