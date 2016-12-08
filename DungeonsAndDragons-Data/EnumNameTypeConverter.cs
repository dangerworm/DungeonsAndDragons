using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons_Data
{
    public sealed class EnumNameTypeConverter : EnumConverter
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.ComponentModel.EnumConverter"/> class for the given type.
        /// </summary>
        /// <param name="type">
        ///     A <see cref="T:System.Type"/> that represents the type of enumeration to associate with this
        ///     enumeration converter.
        /// </param>
        public EnumNameTypeConverter(Type type)
            : base(type)
        {
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType.IsEnum || sourceType == typeof(string);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType.IsEnum || destinationType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value,
            Type destinationType)
        {
            if (!CanConvertFrom(context, value.GetType()))
            {
                throw new ArgumentException("Can only convert from enums");
            }

            if (!CanConvertTo(context, destinationType))
            {
                throw new ArgumentException("Can only convert to strings");
            }

            var valueType = value.GetType();
            if (valueType.IsEnum && destinationType == typeof(string))
            {
                if (!Enum.IsDefined(valueType, value))
                {
                    return "Unknown";
                }

                var name = value.ToString();
                if (value.GetType().GetField(name) != null)
                {
                    var attr = value.GetType().GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), false);
                    if (attr.Any())
                    {
                        name = (attr[0] as DescriptionAttribute).Description;
                    }
                }

                return name;
            }

            if (valueType == typeof(string) && destinationType.IsEnum)
            {
                return GetEnumValue(value, destinationType);
            }

            throw new InvalidOperationException("Can only convert from enum to string or vice versa.");
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (!CanConvertFrom(context, value.GetType()))
            {
                throw new ArgumentException("Can only convert from enums or strings");
            }

            return GetEnumValue(value, EnumType);
        }

        private static object GetEnumValue(object value, Type destinationType)
        {
            if (value.IsNumeric())
            {
                string enumName = Enum.GetName(destinationType, Convert.ToInt32(value));
                if (enumName == null)
                {
                    return Activator.CreateInstance(destinationType);
                }
                return Enum.Parse(destinationType, enumName);
            }

            var name = value.ToString();
            var fields = destinationType.GetFields();

            foreach (var field in fields)
            {
                if (field.Name == name)
                {
                    return Enum.Parse(destinationType, name);
                }

                var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes.Length > 0 && name == attributes[0].Description)
                {
                    return field.GetValue(null);
                }
            }

            throw new InvalidOperationException($"Could not find enum value that matches string '{name}'.");
        }
    }
}
