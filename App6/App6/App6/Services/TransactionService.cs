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
        private string _fileName;
        private List<Transaction> _transactions;

        public TransactionService(string fileName)
        {
            _fileName = fileName;
            LoadTransactionsAsync();
        }

        async public Task LoadTransactionsAsync()
        {
            try
            {
                var transaction = await SecureStorage.GetAsync("transaction");

                if (transaction == null)
                {
                    var assembly = typeof(LoanAssetViewModel).GetTypeInfo().Assembly;
                    var stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{_fileName}");

                    using (var reader = new System.IO.StreamReader(stream))
                    {
                        var json = reader.ReadToEnd();
                        _transactions = JsonConvert.DeserializeObject<FinalList>(json).transactions;
                        //await SecureStorage.SetAsync("transaction", json);
                        var transactionjson = JsonConvert.SerializeObject(_transactions, Formatting.Indented);

                        await SecureStorage.SetAsync("transaction", transactionjson);

                    }
                }
                else
                {
                    _transactions = JsonConvert.DeserializeObject<List<Model.Transaction>>(transaction);
                }

            }
            catch (Exception ex)
            {
                // Possible that device doesn't support secure storage on device.
            }

        }

        async public Task<List<Transaction>> GetTransaction()
        {
            await LoadTransactionsAsync();
            return _transactions;
        }

        async public Task AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
            await SaveTransactions(_transactions);
        }

        async public Task UpdateTransaction(Transaction ReturnData, string transId)
        {
            Transaction TransactionToRemove = _transactions.Find(x => x.id == transId);
            _transactions.Remove(TransactionToRemove);
            _transactions.Add(ReturnData);
            await SaveTransactions(_transactions);
        }


        async public Task SaveTransactions(List<Transaction> transactions)
        {
            try
            {
                var json = JsonConvert.SerializeObject(transactions, Formatting.Indented);

                await SecureStorage.SetAsync("transaction", json);
                //var assembly = typeof(LoanAssetViewModel).GetTypeInfo().Assembly;
                //var fileName = $"{assembly.GetName().Name}.{_fileName}";

                //var localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                //var filePath = Path.Combine(localAppDataPath, fileName);
                //File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {

            }

        }


    }

}