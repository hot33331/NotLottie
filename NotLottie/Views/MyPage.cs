using System;
using Lottie.Forms;
using Xamarin.Forms;

namespace NotLottie.Views
{
    public delegate object MyDel();
    public class MyPage : ContentPage
    {
        public event EventHandler _show;

        public MyPage()
        {
            Content = new AnimationView()
            {
                Animation = "LottieLogo1.json",
                AutoPlay = true,
                PlaybackFinishedCommand = new Command(_ => _show.Invoke(null, null))

            };

        }
                                                    
    }
}

