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
    public partial class LoanTheAsset : ContentPage
    {

        public LoanTheAssetViewModel _viewModel;
        public LoanTheAsset()
        {
            InitializeComponent();
            BindingContext = _viewModel = new LoanTheAssetViewModel();
            GetJsonData();
        }
        
        void GetJsonData()  
        {  
            string jsonFileName = "sample-data.json";  
            FinalList MyList = new FinalList();  
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;  
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");  
            using (var reader = new System.IO.StreamReader(stream))  
            {  
                var jsonString = reader.ReadToEnd();  
  
                //Converting JSON Array Objects into generic list    
                MyList = JsonConvert.DeserializeObject<FinalList>(jsonString);  
            }  
            //Binding listview with json string     
            SupervisorPicker.ItemsSource = MyList.transactions;
            StudentPicker.ItemsSource = MyList.transactions;
            AssetPicker.ItemsSource = MyList.transactions;
        }  

        
        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var data = new Loan()
            {
                Supervisor = SupervisorPicker.SelectedItem.ToString(),
                Student = StudentPicker.SelectedItem.ToString(),
                Asset = AssetPicker.SelectedItem.ToString(),
                Date = Convert.ToDateTime(DatePicker.Date.ToString("dd-MM-yyyy"))
            };

            SupervisorPicker.SelectedItem = null;
            StudentPicker.SelectedItem = null;
            AssetPicker.SelectedItem = null;
            DatePicker.Date = DateTime.Now;
            
            
            
            await DisplayAlert("Success", "Data has been saved in the database.", "OK");
            
        }
    }
}