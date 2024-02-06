using System.Collections.Generic;
using System.Collections.ObjectModel;
using App6.Model;

namespace App6
{
    public class APIViewModel
    {
        public List<Transaction> Data { get; set; }
        public APIViewModel()
        {
            loadddata();
        }

        public void loadddata()
        {
            Data = MainPage.DataHold;
        }
    }
}