using B2CPrototype.Controls;
using B2CPrototype.Models;
using System;
using Xamarin.Forms;

namespace B2CPrototype
{
    public class TemplateControlSelector: DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if(item is TemplateControlModel<int> numericModel)
            {
                return new DataTemplate(() => new NumericDataTemplateView());
            }
            else if(item is TemplateControlModel<string> textModel)
            {
                return new DataTemplate(() => new TextDataTemplateView());
            }

            throw new NotImplementedException();
        }
    }
}
