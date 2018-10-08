using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using NotLottie.Models;
using NotLottie.ViewModels;
using System.Windows.Input;

namespace NotLottie.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {


        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {

            InitializeComponent();

            BindingContext = this.viewModel = viewModel;

        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        void Handle_OnClick(object sender, System.EventArgs e)
        {
            if(animationView.IsPlaying){
                animationView.Pause();
            }else{
                animationView.Play();
            }

        }
    }
}