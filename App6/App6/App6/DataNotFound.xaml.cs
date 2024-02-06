using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataNotFound : ContentPage
    {
        public DataNotFound()
        {
            InitializeComponent();
        }
        public class SocialMediaAppModel
        {
            public string Title {get; set;}
 
            public string Image {get; set;}
        }
        public class SocialMediaAppViewModel
        {
            public IEnumerable< SocialMediaAppModel > Items { get; set; }
 
            public SocialMediaAppViewModel ()
            {
                Items = new SocialMediaAppModel []
                {
                    new SocialMediaAppModel (){ Title = "Facebook" , Image = "FacebookFill.png"},
                    new SocialMediaAppModel (){ Title = "Gmail" , Image = "GmailFill.png"},
                    new SocialMediaAppModel (){ Title = "Instagram" , Image = "InstagramFill.png"},
                    new SocialMediaAppModel (){ Title = "WhatsApp" , Image = "WhatsappFill.png"},
                };
            }
        }
    }
}