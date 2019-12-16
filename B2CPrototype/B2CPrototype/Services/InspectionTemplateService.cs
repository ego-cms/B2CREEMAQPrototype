using System.Collections.Generic;
using B2CPrototype.Models;

namespace B2CPrototype.Services
{
    public class InspectionTemplateService: IInspectionTemplateService
    {
        private List<TemplateModuleModel> _templateModules = new List<TemplateModuleModel>();
        public InspectionTemplateService()
        {
            //Initialize the templates
            //Should initialize before starting the inspection
            _templateModules = new List<TemplateModuleModel>()
            {
                new TemplateModuleModel()
                {
                    Id = 1,
                    TemplateControls = new List<TemplateControlBaseModel>
                    {
                        new TemplateControlModel<string>(1, FieldType.Numeric, 3.ToString(), "First"),
                        new TemplateControlModel<string>(2, FieldType.Text, "Text", "Second"),
                        new TemplateControlModel<int>(3, FieldType.Numeric, 13, "Third"),
                        new TemplateControlModel<int>(4, FieldType.Numeric, 19, "Fourth"),
                    }
                },
                new TemplateModuleModel()
                {
                    Id = 2,
                    TemplateControls = new List<TemplateControlBaseModel>
                    {
                        new TemplateControlModel<string>(5, FieldType.Text, string.Empty, "Test 1"),
                        new TemplateControlModel<string>(6, FieldType.Text, "Text", "Test 2"),
                    }
                },
                new TemplateModuleModel()
                {
                    Id = 3,
                    TemplateControls = new List<TemplateControlBaseModel>
                    {
                        new TemplateControlModel<string>(5, FieldType.Text, "Test", "Label 1"),
                        new TemplateControlModel<string>(6, FieldType.Text, "Text", "Label 2"),
                        new TemplateControlModel<int>(7, FieldType.Numeric, 4, "Label 3"),
                        new TemplateControlModel<int>(8, FieldType.Numeric, 19, "Label 4"),
                        new TemplateControlModel<string>(1, FieldType.Text, 333.ToString(), "Label 5"),
                        new TemplateControlModel<string>(2, FieldType.Text, "Text", "Label 6"),
                        new TemplateControlModel<int>(3, FieldType.Numeric, 0, "Label 7"),
                        new TemplateControlModel<int>(4, FieldType.Numeric, 0, "Label 8"),
                    }
                },
                new TemplateModuleModel()
                {
                    Id = 4,
                    TemplateControls = new List<TemplateControlBaseModel>
                    {
                        new TemplateControlModel<string>(5, FieldType.Text, "Test", "Name 1"),
                        new TemplateControlModel<string>(6, FieldType.Text, "Text", "Name 2"),
                        new TemplateControlModel<int>(7, FieldType.Text, 13, "Name 3"),
                        new TemplateControlModel<int>(8, FieldType.Text, 19, "Name 4"),
                        new TemplateControlModel<string>(5, FieldType.Text, "Test", "Name 5"),
                        new TemplateControlModel<string>(6, FieldType.Text, "Text", "Name 6"),
                        new TemplateControlModel<int>(7, FieldType.Text, 13, "Name 7"),
                        new TemplateControlModel<int>(8, FieldType.Text, 19, "Name 8"),
                        new TemplateControlModel<string>(1, FieldType.Numeric, 3.ToString(), "Name 9"),
                        new TemplateControlModel<string>(2, FieldType.Text, "Text", "Name 10"),
                        new TemplateControlModel<int>(3, FieldType.Numeric, 13, "Name 11"),
                        new TemplateControlModel<int>(4, FieldType.Numeric, 19, "Name 12"),
                    }
                }
            };
        }

        public bool CanMoveNext(int currentStep)
        {
            if(_templateModules == null)
                return false;

            return _templateModules.Count > currentStep;
        }

        public List<TemplateControlBaseModel> GetTemplatesControlFromViewTemplate(int viewTemplate)
        {
            if(CanMoveNext(viewTemplate - 1))
                return _templateModules[viewTemplate - 1].TemplateControls;
            else
                return new List<TemplateControlBaseModel>();
        }
    }
}
