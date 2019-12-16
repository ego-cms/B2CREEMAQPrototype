using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace B2CPrototype.ViewModels
{
    public class NativeViewModel: MvxNavigationViewModel
    {
        public NativeViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
        }

        public IMvxAsyncCommand CloseCommand
        {
            get
            {
                return new MvxAsyncCommand(async () =>
                {
                    await base.NavigationService.Close(this);
                });
            }
        }

    }
}
