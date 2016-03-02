// Copyright (c) 2013-2015 Cemalettin Dervis, MIT License.
// https://github.com/cemdervis/SharpConfig

using System;
using System.Collections.Generic;
using System.Text;

namespace SharpConfig
{
    [Serializable]
    internal sealed class SettingValueCastException : Exception
    {
        public SettingValueCastException(string stringValue, Type destType) :
            base(string.Format("Failed to convert value '{0}' to type {1}.", stringValue, destType.FullName))
        { }
    }
}