using System;
using System.Windows.Input;
using NotLottie.Models;
using Xamarin.Forms;

namespace NotLottie.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {

        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
