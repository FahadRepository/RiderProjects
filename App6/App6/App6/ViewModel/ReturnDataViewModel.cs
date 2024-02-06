using System;
using System.Collections.Generic;
using App6.Model;

namespace App6.ViewModel
{
    public class ReturnDataViewModel : BaseViewModel
    {
        public ReturnDataViewModel()
        {
                
        }

        #region MyRegion

        private string supervisorName;
        private DateTime Date;
        private DateTime _selectedDate;
        
        private FinalList _objContactList= new FinalList();
        

        public FinalList ObjContactList
        {
            get => _objContactList;
            set => SetField(ref _objContactList, value);
        }
        
        
        private Transaction _onSupervisorSelect;

        public Transaction OnSupervisorSelect
        {
            get => _onSupervisorSelect;
            set
            {
                SetField( ref _onSupervisorSelect, value);

                if (_onSupervisorSelect != null)
                    supervisorName=_onSupervisorSelect.assetName;
            }
            
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


        #endregion
    }
}