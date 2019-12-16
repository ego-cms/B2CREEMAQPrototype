using B2CPrototype.Models;
using B2CPrototype.Services;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Collections.Generic;
using System.Diagnostics;

namespace B2CPrototype.ViewModels
{
    public class InspectionViewModel: MvxNavigationViewModel, IMvxViewModel<int>
    {
        private IInspectionTemplateService _inspectionTemplateService;

        private int _templatePanel;
        public int TemplatePanel 
        {
            get => _templatePanel;
            private set
            {
                _templatePanel = value;
                RaisePropertyChanged(() => TemplatePanel);
                RaisePropertyChanged(() => Title);
            } 
        }

        public string Title => $"Step {TemplatePanel}";

        private List<TemplateControlBaseModel> _templateControls;
        public List<TemplateControlBaseModel> TemplateControls 
        {
            get => _templateControls;
            private set
            {
                _templateControls = value;
                RaisePropertyChanged(() => TemplateControls);
            }
        }

        public IMvxAsyncCommand GoToNextStepCommand
        {
            get
            {
                return new MvxAsyncCommand(async () =>
                {
                    if(_inspectionTemplateService.CanMoveNext(TemplatePanel))
                        await NavigationService.Navigate<InspectionViewModel, int>(TemplatePanel + 1);
                });
            }
        }

        public InspectionViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IInspectionTemplateService inspectionTemplateService) : base(logProvider, navigationService)
        {
            _inspectionTemplateService = inspectionTemplateService;
        }

        public void Prepare(int parameter)
        {
            TemplatePanel = parameter;
            TemplateControls = _inspectionTemplateService.GetTemplatesControlFromViewTemplate(TemplatePanel);
        }

        public override void ViewDisappearing()
        {
            foreach(var template in TemplateControls)
            {
                Debug.WriteLine($"Panel: {Title}");

                if(template is TemplateControlModel<int> numericModel)
                    Debug.WriteLine($"Name: {template.Label} - value: {numericModel.Value}");
                else if(template is TemplateControlModel<string> textModel)
                    Debug.WriteLine($"Name: {template.Label} - value: {textModel.Value}");
            }
            base.ViewDisappearing();
        }
    }
}
