using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons_Data
{
    public sealed class ValidationCollection : NameValueCollection
    {
        public Boolean HasAny => Count > 0;

        public void Add(NameValueCollection collection, String prefix)
        {
            if (String.IsNullOrWhiteSpace(prefix))
                Add(collection);
            else
            {
                foreach (var key in collection.AllKeys)
                    Add(key, collection[key], prefix);
            }
        }

        public void Add(String key, String value, String prefix)
        {
            Add(!String.IsNullOrEmpty(prefix) ? $"{prefix}.{key}" : key, value);
        }

        public Boolean ContainsKey(String key)
        {
            if (String.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(key);

            return AllKeys.Any(x => x == key || x.EndsWith("." + key));
        }

        public Boolean IsValidField(String key)
        {
            return !ContainsKey(key);
        }

        public new void Remove(String name)
        {
            var keys = AllKeys.Where(x => x == name || x.EndsWith("." + name));

            foreach (var key in keys)
                base.Remove(key);
        }

        public IEnumerable<String> GetErrors()
        {
            var errors = new List<String>();

            foreach (var key in AllKeys)
                errors.Add(this[key]);

            return errors;
        }

        public void AddRange(ValidationCollection validationCollection)
        {
            Add(validationCollection);
        }
    }
}
