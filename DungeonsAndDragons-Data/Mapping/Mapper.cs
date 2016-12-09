
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DungeonsAndDragons_Data.Mapping
{
    public static class Mapper
    {
        public static T2 Map<T1, T2>(this T1 source) where T2 : new()
        {
            var target = new T2();
            var targetProperties = target?.GetType().GetProperties();

            foreach (var sourceProperty in source.GetType().GetProperties())
            {
                var targetProperty = targetProperties?.SingleOrDefault(x => x.Name == sourceProperty.Name);

                if (targetProperty == null ||
                    targetProperty.PropertyType != sourceProperty.PropertyType ||
                    !targetProperty.CanWrite)
                {
                    continue;
                }

                var sourceGetter = sourceProperty.GetGetMethod();
                var targetSetter = targetProperty.GetSetMethod();
                var valueToSet = sourceGetter.Invoke(source, null);
                targetSetter.Invoke(target, new[] { valueToSet });
            }

            return target;
        }

        public static T2[] MapAll<T1, T2>(this T1[] sources) where T2 : new()
        {
            var targets = new List<T2>();
            foreach (var item in sources)
            {
                targets.Add(Map<T1, T2>(item));
            }

            return targets.ToArray();
        }
    }
}
