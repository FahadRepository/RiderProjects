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

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReturnTheData : ContentPage
    {
        
        public ReturnDataViewModel _viewModel;
        public ReturnTheData()
        {
            InitializeComponent();
            BindingContext =_viewModel= new ReturnDataViewModel();
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
            ReceivingSupervisor.ItemsSource = _viewModel.ObjContactList.users;
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var loanData = new
            {
                SupervisorName = ReceivingSupervisor.SelectedItem,
                LoanDate = PickeTheDate.Date.ToString("dd-MM-yyyy")
            };

            var json = JsonConvert.SerializeObject(loanData);
            var filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "sample-data.json");
            File.WriteAllText(filename, json);
            
            ReceivingSupervisor.SelectedItem = null;
            PickeTheDate.Date = DateTime.Now;
            
            await DisplayAlert("Success", "Data saved successfully", "OK");
        }
    }
}