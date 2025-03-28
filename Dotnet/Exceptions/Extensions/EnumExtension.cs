// classe statica per la gestione degli enum
using System.ComponentModel;
using System.Reflection;

namespace ProgettoAmbiente.Exceptions.Exstensions;

public static class EnumExtension {

    public static string GetDescription(this Enum value) {
        FieldInfo? field = value.GetType().GetField(value.ToString());
        if (field == null) {
            return value.ToString();
        }

        DescriptionAttribute? attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
        return attribute == null ? value.ToString() : attribute.Description;
    }
}