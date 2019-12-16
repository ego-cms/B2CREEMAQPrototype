using System.Collections.Generic;

namespace B2CPrototype.Models
{
    public class TemplateControlModel<T>: TemplateControlBaseModel
    {
        public T Value { get; set; }
        public List<T> SourceData { get; set; } = new List<T>();

        public TemplateControlModel(int id, FieldType fieldType, T value, string label = null, List<T> sourceData = null)
        {
            Id = id;
            FieldType = fieldType;
            Value = value;

            if(label != null)
                Label = label;

            if(sourceData != null)
                SourceData = sourceData;
        }
    }
}
