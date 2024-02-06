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
        public MainPageViewModel _viewModel;
        public IssuedAssets(List<Transaction> _filterdata)
        {
            // bool Visible;
            // IEnumerable<Tuple<List<Transaction>, bool>> filterIenumerable;
            // if (_filterdata[0].receivingSupervisorname!=null)
            // {
            //     Visible = true;
            // }
            // filterIenumerable = new List<Tuple<List<Transaction>, bool>>
            //     {Tuple.Create(_filterdata, Visible)};
            InitializeComponent();
            BindingContext =_viewModel= new MainPageViewModel();
            // ReturnDateFrame.IsVisible = _filterdata != null;
            CardsView.ItemsSource = _filterdata;
        }

        private void OnImageTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReturnTheData());
        }
    }
}