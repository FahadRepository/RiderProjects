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
    public partial class ReturnTheData : ContentPage
    {

        public ReturnDataViewModel _viewModel;

        
        public ReturnTheData(Transaction _transaction)
        {
            
            InitializeComponent();
            BindingContext =_viewModel= new ReturnDataViewModel();
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
        
        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var loanData = new Transaction
            {
                // SupervisorName = ReceivingSupervisor.SelectedItem,
                // LoanDate = PickeTheDate.Date.ToString("dd-MM-yyyy")
            };
        
            var json = JsonConvert.SerializeObject(loanData);
            var filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "sample-data.json");
            File.WriteAllText(filename, json);
            
            // ReceivingSupervisor.SelectedItem = null;
            // PickeTheDate.Date = DateTime.Now;
            
            await DisplayAlert("Success", "Data saved successfully", "OK");
        }
    }
}