﻿using System.ComponentModel;

namespace DungeonsAndDragons_Data.Enums
{
    [TypeConverter(typeof(EnumNameTypeConverter))]
    public enum DataResultType
    {
        [Description("Unknown Error")]
        UnknownError = 0,

        [Description("Success")]
        Success,

        [Description("Invalid State")]
        InvalidState,

        [Description("Unknown State")]
        UnknownState,

        [Description("Unsupported State")]
        UnsupportedState,

        [Description("Unknown Record")]
        UnknownRecord,

        [Description("Unable to Create Record")]
        UnableToCreateRecord,

        [Description("Unable to Update Record")]
        UnableToUpdateRecord,

        [Description("Unable to Delete Record")]
        UnableToDeleteRecord,

        [Description("Old Version")]
        OldVersion,

        [Description("Not Required")]
        NotRequired,

        [Description("Validation Error")]
        ValidationError,

        [Description("Confirmation Required")]
        ConfirmationRequired,

        [Description("Unauthorised")]
        Unauthorised,

        [Description("Disabled")]
        Disabled
    }
}
