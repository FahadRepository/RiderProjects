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
    public partial class IssuedAssets : ContentPage
    {
        public IssueAssetViewModel _viewModel;
        public IssuedAssets(List<Transaction> _filterdata)
        {
            
            InitializeComponent();
            BindingContext =_viewModel= new IssueAssetViewModel();
            _viewModel.AnotherFilterItem = _filterdata;
            CardsView.ItemsSource = _viewModel.AnotherFilterItem;
        }

        private void OnImageTapped(object sender, EventArgs e)
        {
            if (!(e is TappedEventArgs trans) || !(trans.Parameter is Transaction transaction))
            {
                return;
            }
            {
                Navigation.PushAsync(new ReturnTheData(transaction));
            }
        }
    }
}