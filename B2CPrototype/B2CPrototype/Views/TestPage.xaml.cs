using B2CPrototype.ViewModels;
using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;

namespace B2CPrototype.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage: MvxContentPage<TestViewModel>
    {
        public TestPage()
        {
            InitializeComponent();
        }
    }
}