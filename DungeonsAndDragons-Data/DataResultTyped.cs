using System;

namespace DungeonsAndDragons_Data
{
    public class DataResult<T> : DataResult
    {
        public T Value { get; set; }

        public int? ValueId { get; private set; }

        public DataResult(DataResultType type, string friendlyMessage, string internalMessage)
            : base(type, friendlyMessage, internalMessage)
        {
        }

        public DataResult(DataResultType type, string message)
            : this(type, message, message)
        {
        }

        public DataResult(DataResultType type, string friendlyMessage, string internalMessage, Exception exception)
            : base(type, friendlyMessage, internalMessage, exception)
        {
        }

        public DataResult(DataResultType type, string message, Exception exception)
            : this(type, message, message, exception)
        {
        }

        public DataResult(T value, DataResultType type, string friendlyMessage, string internalMessage)
            : base(type, friendlyMessage, internalMessage)
        {
            Value = value;
        }

        public DataResult(T value, DataResultType type, string message)
            : this(value, type, message, message)
        {
        }

        public DataResult(int valueId, DataResultType type, string friendlyMessage, string internalMessage)
            : base(type, friendlyMessage, internalMessage)
        {
            ValueId = valueId;
        }

        public DataResult(int valueId, DataResultType type, string message)
            : this(valueId, type, message, message)
        {
        }

        public DataResult(T value, int valueId, DataResultType type, string friendlyMessage, string internalMessage)
            : base(type, friendlyMessage, internalMessage)
        {
            Value = value;
            ValueId = valueId;
        }

        public DataResult(T value, int valueId, DataResultType type, string message)
            : this(value, valueId, type, message, message)
        {
        }

        public DataResult(T value, DataResultType type, string friendlyMessage, string internalMessage, Exception exception)
            : base(type, friendlyMessage, internalMessage, exception)
        {
            Value = value;
        }

        public DataResult(T value, DataResultType type, string message, Exception exception)
            : this(value, type, message, message, exception)
        {
        }

        public DataResult(T value, DataResult result)
            : base(result.Type, result.FriendlyMessage, result.InternalMessage, result.Exception)
        {
            Value = value;
            Validation.Add(result.Validation);

            foreach (var item in result.Data)
            {
                Data.Add(item);
            }
        }

        public static implicit operator T(DataResult<T> dataResult)
        {
            return dataResult.Value;
        }
    }
}
