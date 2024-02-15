﻿using System;
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
                _viewModel.DateOnlyTransactions = _viewModel.ObjContactList.transactions
                    .Select(t => t.loanDate.Date)
                    .ToList();
            }  
            AssetPicker.ItemsSource = _viewModel.ObjContactList.transactions;
            UserName.ItemsSource = _viewModel.ObjContactList.transactions;
        }

        async private void SearchButton_OnClicked(object sender, EventArgs e)
        {
           await _viewModel.Filterdata();
           if (_viewModel.FilterDataItems.transactions.Any())
           {
               await Navigation.PushAsync(new IssuedAssetsPage(_filterdata:_viewModel.FilterDataItems.transactions));
           }
           else
           {
               await Navigation.PushAsync(new DataNotFoundPage());
           }
           UserName.SelectedItem = null;
           AssetPicker.SelectedItem = null;
        }
    }
}
