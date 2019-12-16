using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace B2CPrototype.ViewModels
{
    public class MainViewModel: MvxNavigationViewModel
    {
        public MainViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {

        }

        public string Label { get; set; } = "Main";

        private MvxObservableCollection<int> _stepTemplates;
        public MvxObservableCollection<int> StepTemplates
        {
            get
            {
                return _stepTemplates;
            }
            set
            {
                _stepTemplates = value;
                RaisePropertyChanged(() => StepTemplates);
            }
        }

        public IMvxAsyncCommand ShowNativeViewCommand
        {
            get
            {
                return new MvxAsyncCommand(async () =>
                {
                    await NavigationService.Navigate<InspectionViewModel>();
                });
            }
        }

        public IMvxAsyncCommand StartInspectionCommand
        {
            get
            {
                return new MvxAsyncCommand(async () =>
                {
                    await DoStartInspection();
                });
            }
        }

        private Task DoStartInspection()
        {
            return NavigationService.Navigate<InspectionViewModel, int>(1);
        }
    }
}
