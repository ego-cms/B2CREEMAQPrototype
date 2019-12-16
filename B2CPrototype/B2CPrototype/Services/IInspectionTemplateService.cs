using B2CPrototype.Models;
using System.Collections.Generic;

namespace B2CPrototype.Services
{
    public interface IInspectionTemplateService
    {
        bool CanMoveNext(int currentStep);
        List<TemplateControlBaseModel> GetTemplatesControlFromViewTemplate(int viewTemplate);
    }
}
