using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using App6.Database;
using App6.Model;
using App6.ViewModel;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoanAssetPage : ContentPage
    {

        public LoanAssetViewModel _viewModel;
        public LoanAssetPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new LoanAssetViewModel();
            GetJsonData();
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

            SupervisorPicker.ItemsSource = _viewModel.ObjContactList.transactions;
            AssetPicker.ItemsSource = _viewModel.ObjContactList.transactions;
            StudentPicker.ItemsSource = _viewModel.ObjContactList.transactions;
        }  

        
        // private async void SaveButton_Clicked(object sender, EventArgs e)
        // {
        //
        //     SupervisorPicker.SelectedItem = null;
        //     StudentPicker.SelectedItem = null;
        //     AssetPicker.SelectedItem = null;
        //     DatePicker.Date = DateTime.Now;
        //     _viewModel.AddTransactionCommand.Execute(_viewModel.Transaction);
        //     await DisplayAlert("Success", "Data has been saved in the database.", "OK");
        //     
        // }
    }
}