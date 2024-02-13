using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using App6.Model;
using App6.ViewModel;
using Newtonsoft.Json;
using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Essentials;

namespace App6.Services
{
    public class TransactionService

    {
    private  string _fileName;
    private List<Transaction> _transactions;

    public TransactionService(string fileName)
    {
        _fileName = fileName;
        LoadTransactionsAsync();
    }

    public void LoadTransactionsAsync()
    {
        var assembly = typeof(LoanAssetViewModel).GetTypeInfo().Assembly;
        var stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{_fileName}");

        using (var reader = new System.IO.StreamReader(stream))
        {
            var json =  reader.ReadToEnd();
            var testList = JsonConvert.DeserializeObject<FinalList>(json);
            _transactions = testList.transactions;
        }
    }

    public void AddTransaction(Transaction transaction)
    {
        _transactions.Add(transaction);
        SaveTransactions(_transactions);
    }

    public void UpdateTransaction(Transaction ReturnData, string transId)
    {
        Transaction TransactionToRemove = _transactions.Find(x => x.id == transId);
        _transactions.Remove(TransactionToRemove);
        _transactions.Add(ReturnData);
        SaveTransactions(_transactions);
    }
    

    public void SaveTransactions(List<Transaction> transactions)
    {
        var json = JsonConvert.SerializeObject(transactions, Formatting.Indented);

        var assembly = typeof(LoanAssetViewModel).GetTypeInfo().Assembly;
        var fileName = $"{assembly.GetName().Name}.{_fileName}";
        
        var localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        var filePath = Path.Combine(localAppDataPath, fileName);
        File.WriteAllText(filePath, json);
        
    }

    
    }
    
}