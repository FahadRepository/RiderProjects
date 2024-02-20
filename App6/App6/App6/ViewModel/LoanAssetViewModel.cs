using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using App6.Model;
using App6.Services;
using App6.ViewModel;
using Xamarin.Forms;

public class LoanAssetViewModel : BaseViewModel
{

    public LoanAssetViewModel()
    {
        
    }
    
    private string supervisorsName;
    private string studentsName;
    private string assetsName;
    private DateTime Date;
    
    
    private FinalList _objContactList= new FinalList(); 
    public FinalList ObjContactList
    {
        get => _objContactList;
        set => SetField(ref _objContactList, value);
    }

    private Transaction _transaction = new Transaction();
    
    
    private Transaction _onSupervisorSelect;
    public Transaction OnSelectedSupervisor
    {
        get => _onSupervisorSelect;
        set
        {
            SetField( ref _onSupervisorSelect, value);

            if (_onSupervisorSelect != null)
                supervisorsName=_onSupervisorSelect.loaningSupervisorname;
        }
            
    }
    
    
    private Transaction _OnStudentSelect;
    public Transaction OnSelectedStudent
    {
        get => _OnStudentSelect;
        set
        {
            SetField( ref _OnStudentSelect, value);

            if (_OnStudentSelect != null)
                studentsName=_OnStudentSelect.studentname;
        }
            
    }
    
    
    private Transaction _onAssetSelected;
    public Transaction OnSelectedAsset
    {
        get => _onAssetSelected;
        set
        {
            SetField( ref _onAssetSelected, value);

            if (_onAssetSelected != null)
                assetsName=_onAssetSelected.assetName;
        }
            
    }

    private DateTime _selectedDate;

    public DateTime OnSelectedDate
    {
        get => _selectedDate;
        set
        {
            SetField(ref _selectedDate, value);
            Date = _selectedDate.Date;
        }
    }
    
    public bool AddedTransaction { get; set; }
    
    public async void AddTransaction()
    {
        var transactionService = new TransactionService(fileName:"sample-data.json");

        
        // Set the transaction properties from the picker selections
        _transaction.loaningSupervisorname = supervisorsName;
        _transaction.studentname = studentsName;
        _transaction.assetName = assetsName;
        _transaction.loanDate = Date;
        _transaction.receivingSupervisorname = null;
        _transaction.transactionType = "Loan";
        _transaction.returnDate = null;
        _transaction.receivingSupervisorId = null;
        _transaction.id = Guid.NewGuid().ToString();
        _transaction.studentId = null;
        _transaction.assetId = null;
        _transaction.loaningSupervisorId = null;
        
        try
        {

            await transactionService.AddTransaction(_transaction);
            AddedTransaction = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        // Add the transaction to the list
        

        // Create a new transaction object
        //Transaction = new Transaction();
    }
    
}