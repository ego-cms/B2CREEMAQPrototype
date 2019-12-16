using System.Collections.Generic;

namespace B2CPrototype.Models
{
    public class TemplateModuleModel
    {
        public int Id { get; set; }
        public List<TemplateControlBaseModel> TemplateControls { get; set; }

    }
}
