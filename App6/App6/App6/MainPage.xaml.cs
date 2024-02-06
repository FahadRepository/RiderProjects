using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using App6.Model;
using App6.ViewModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    public partial class MainPage : TabbedPage
    {
        public MainPageViewModel _viewModel;
        public MainPage()
        {
            InitializeComponent();

            BindingContext =_viewModel= new MainPageViewModel();
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
                // DateTime date = _viewModel.ObjContactList.transactions.Date;
                // string formattedDate = date.ToString("dd-MM-yyyy");
                // date.ToString();
            }  
            AssetPicker.ItemsSource = _viewModel.ObjContactList.transactions;
            UserName.ItemsSource = _viewModel.ObjContactList.transactions;
        }

        private void SearchButton_OnClicked(object sender, EventArgs e)
        {
           _viewModel.Filterdata();
           if (_viewModel.FilterDataItems.transactions.Any())
           {
               Navigation.PushAsync(new IssuedAssets(_filterdata:_viewModel.FilterDataItems.transactions));
           }
           else
           {
               Navigation.PushAsync(new DataNotFound());
           }
            
        }
    }
}
