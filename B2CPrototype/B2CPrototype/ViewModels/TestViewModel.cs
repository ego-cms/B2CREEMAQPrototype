using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace B2CPrototype.ViewModels
{
    public class TestViewModel: MvxNavigationViewModel, IMvxViewModel<int>
    {
        public TestViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
        }

        public void Prepare(int parameter)
        {
            
        }
    }
}
