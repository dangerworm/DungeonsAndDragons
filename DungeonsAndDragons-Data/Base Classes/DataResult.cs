using System;
using System.Collections.Generic;

namespace DungeonsAndDragons_Data
{
    public class DataResult
    {
        private string _friendlyMessage;

        public DataResultType Type { get; set; }

        public string FriendlyMessage
        {
            get
            {
                if (string.IsNullOrEmpty(_friendlyMessage) && Type != DataResultType.Success)
                {
                    return "An error has occurred. Please try again. If the problem persists please get in touch.";
                }
                return _friendlyMessage;
            }

            set { _friendlyMessage = value; }
        }

        public string InternalMessage { get; set; }

        public Exception Exception { get; set; }

        public ValidationCollection Validation { get; private set; }

        public IDictionary<string, object> Data { get; private set; }

        public DataResult(DataResultType type, string friendlyMessage, string internalMessage)
        {
            Verify.ValidEnumValue(type, nameof(type));
            Verify.ValidString(friendlyMessage, nameof(friendlyMessage));
            Verify.ValidString(internalMessage, nameof(internalMessage));

            Type = type;
            FriendlyMessage = friendlyMessage;
            InternalMessage = internalMessage;
            Validation = new ValidationCollection();
            Data = new Dictionary<string, object>();
        }

        public DataResult(DataResultType type, string message)
            : this(type, message, message)
        {
        }

        public DataResult(DataResultType type, string friendlyMessage, string internalMessage, Exception exception)
            : this(type, friendlyMessage, internalMessage)
        {
            Exception = exception;
        }

        public DataResult(DataResultType type, string message, Exception exception)
            : this(type, message, message, exception)
        {
        }
    }
}
