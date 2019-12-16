using B2CPrototype.ViewModels;
using MvvmCross.Forms.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B2CPrototype.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InspectionView: MvxContentPage<InspectionViewModel>
    {
        public InspectionView()
        {
            InitializeComponent();
            SetBinding(TitleProperty, new Binding(nameof(InspectionViewModel.Title)));
        }
    }
}