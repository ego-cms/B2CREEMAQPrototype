using B2CPrototype.ViewModels;
using MvvmCross.Forms.Views;
using System.ComponentModel;
using Xamarin.Forms;

namespace B2CPrototype
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage: MvxContentPage<MainViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
            SetBinding(TitleProperty, new Binding(nameof(MainViewModel.Label)));
        }
    }
}
