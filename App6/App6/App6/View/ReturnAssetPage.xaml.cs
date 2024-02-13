using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using App6.Model;
using App6.ViewModel;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Diagnostics;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReturnAssetPage : ContentPage
    {

        public ReturnAssetViewModel _viewModel;

        
        public ReturnAssetPage(Transaction _transaction)
        {
            
            InitializeComponent();
            BindingContext =_viewModel= new ReturnAssetViewModel(returnData:_transaction);
            GetJsonData();
            _viewModel.ReturnData = _transaction;
            
            _viewModel.AssetName = _viewModel.ReturnData.assetName;
            _viewModel.StudentName = _viewModel.ReturnData.studentname;
            _viewModel.TransactionType = _viewModel.ReturnData.transactionType;
            _viewModel.LoanDate = _viewModel.ReturnData.loanDate;
            _viewModel.AssetId = _viewModel.ReturnData.assetId;
            _viewModel.Id = _viewModel.ReturnData.id;
        }
        
        void GetJsonData()  
        {  
            string jsonFileName = "sample-data.json";  
            
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;  
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");  
            using (var reader = new System.IO.StreamReader(stream))  
            {  
                var jsonString = reader.ReadToEnd();  
                _viewModel.ObjContactList = JsonConvert.DeserializeObject<FinalList>(jsonString);
            }  
            ReceivingSupervisor.ItemsSource = _viewModel.ObjContactList.users;
        }
        
    }
}