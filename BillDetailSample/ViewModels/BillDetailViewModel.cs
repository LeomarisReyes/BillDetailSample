using System;
using System.Collections.ObjectModel;
using BillDetailSample.Models;

namespace BillDetailSample.ViewModels
{
    public class BillDetailViewModel
    {
        public ObservableCollection<Items> items { get; set; }

        public BillDetailViewModel()
        {
            items = new ObservableCollection<Items>
            {
                new Items
                {
                   Name="Men's Shoe",
                   Description="Nike DBreak SP",
                   Picture="Sniker",
                   Price="$110.27"
                },
                new Items
                {
                   Name="Men's Shoe",
                   Description="Nike Blazer Low",
                   Picture="Sniker",
                   Price="$75.38"
                },
                 new Items
                {
                   Name="Men's Shoe",
                   Description="Nike DBreak SP",
                   Picture="Sniker",
                   Price="$110.27"
                },
                new Items
                {
                   Name="Men's Shoe",
                   Description="Nike Blazer Low",
                   Picture="Sniker",
                   Price="$110.27"
                }
            };
        }
    }
}
