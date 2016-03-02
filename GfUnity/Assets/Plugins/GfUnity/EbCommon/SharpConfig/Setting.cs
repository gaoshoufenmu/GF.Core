// Copyright (c) 2013-2015 Cemalettin Dervis, MIT License.
// https://github.com/cemdervis/SharpConfig

using System;
using System.Collections.Generic;
using System.Text;

namespace SharpConfig
{
    /// <summary>
    /// Represents a setting in a <see cref="Configuration"/>.
    /// Settings are always stored in a <see cref="Section"/>.
    /// </summary>
    public sealed class Setting : ConfigurationElement
    {
        #region Fields

        private string mRawValue;

        #endregion

        #region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="Setting"/> class.
        /// </summary>
        public Setting(string name) :
            this(name, string.Empty)
        {
            mRawValue = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Setting"/> class.
        /// </summary>
        ///
        /// <param name="name"> The name of the setting.</param>
        /// <param name="value">The value of the setting.</param>
        public Setting(string name, string value) :
            base(name)
        {
            mRawValue = value;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the raw string value of this setting.
        /// </summary>
        public string StringValue
        {
            get { return mRawValue; }
            set { mRawValue = value; }
        }

        /// <summary>
        /// Gets or sets the value of this setting as an int.
        /// Note: this is a shortcut to GetValue and SetValue.
        /// </summary>
        public int IntValue
        {
            get { return GetValueTyped<int>(); }
            set { SetValue(value); }
        }

        /// <summary>
        /// Gets or sets the value of this setting as a float.
        /// Note: this is a shortcut to GetValue and SetValue.
        /// </summary>
        public float FloatValue
        {
            get { return GetValueTyped<float>(); }
            set { SetValue(value); }
        }

        /// <summary>
        /// Gets or sets the value of this setting as a double.
        /// Note: this is a shortcut to GetValue and SetValue.
        /// </summary>
        public double DoubleValue
        {
            get { return GetValueTyped<double>(); }
            set { SetValue(value); }
        }

        /// <summary>
        /// Gets or sets the value of this setting as a bool.
        /// Note: this is a shortcut to GetValue and SetValue.
        /// </summary>
        public bool BoolValue
        {
            get { return GetValueTyped<bool>(); }
            set { SetValue(value); }
        }

        /// <summary>
        /// Gets or sets the raw string value of this setting.
        /// </summary>
        [Obsolete("The Setting.Value property is obsolete. Please use Setting.StringValue instead.", false)]
        public string Value
        {
            get { return mRawValue; }
            set { mRawValue = value; }
        }

        /// <summary>
        /// Gets a value indicating whether this setting is an array.
        /// </summary>
        public bool IsArray
        {
            get { return ArraySize >= 0; }
        }

        /// <summary>
        /// Gets the size of the array that this setting represents.
        /// If this setting is not an array, -1 is returned.
        /// </summary>
        public int ArraySize
        {
            get
            {
                if (string.IsNullOrEmpty(mRawValue))
                {
                    return -1;
                }

                string value = mRawValue.Trim();

                if (value[0] != '{')
                {
                    return -1;
                }

                int arraySize = 0;
                bool isInArrayBrackets = false;
                int lastCommaIdx = 0;

                for (int pos = 0; pos < value.Length; ++pos)
                {
                    char ch = value[pos];
                    
                    if (ch == '{')
                    {
                        if (isInArrayBrackets)
                        {
                            return -1;
                        }

                        isInArrayBrackets = true;
                    }
                    else if (ch == '}')
                    {
                        if (pos != value.Length - 1)
                        {
                            return -1;
                        }

                        isInArrayBrackets = false;
                        break;
                    }
                    else if (ch == ',')
                    {
                        bool isElementEmpty = true;

                        for (int e = lastCommaIdx + 1; e < pos; ++e)
                        {
                            if (value[e] != ' ')
                            {
                                // Okay, this is a value.
                                isElementEmpty = false;
                                break;
                            }
                        }

                        if (isElementEmpty)
                        {
                            return -1;
                        }

                        lastCommaIdx = pos;
                        ++arraySize;
                    }
                }

                // Check the last element value for emptiness, since our loop
                // only considered n-1 elements.
                if (lastCommaIdx + 1 < value.Length-1)
                {
                    bool isElementEmpty = true;

                    for (int e = lastCommaIdx + 1; e < value.Length - 1; ++e)
                    {
                        if (value[e] != ' ')
                        {
                            isElementEmpty = false;
                            break;
                        }
                    }

                    if (isElementEmpty)
                    {
                        return -1;
                    }
                }
                else
                {
                    return -1;
                }

                return arraySize + 1;
            }
        }

        #endregion

        #region GetValueTyped

        /// <summary>
        /// Gets this setting's value as a specific type.
        /// </summary>
        ///
        /// <typeparam name="T">The type of the object to retrieve.</typeparam>
        public T GetValueTyped<T>()
        {
            Type type = typeof(T);

            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            if (type.IsArray)
            {
                throw new InvalidOperationException(
                    "To obtain an array value, use GetValueArray instead of GetValueTyped.");
            }

            if (this.IsArray)
            {
                throw new InvalidOperationException(
                    "The setting represents an array. Use GetValueArray to obtain its value.");
            }

            return (T)ConvertValue(mRawValue, type);
        }

        /// <summary>
        /// Gets this setting's value as a specific type.
        /// </summary>
        ///
        /// <param name="type">The type of the object to retrieve.</param>
        public object GetValueTyped(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            if (type.IsArray)
            {
                throw new InvalidOperationException(
                    "To obtain an array value, use GetValueArray instead of GetValueTyped.");
            }

            if (this.IsArray)
            {
                throw new InvalidOperationException(
                    "The setting represents an array. Use GetValueArray to obtain its value.");
            }

            return ConvertValue(mRawValue, type);
        }

        /// <summary>
        /// Gets this setting's value as an array of a specific type.
        /// Note: this only works if the setting represents an array.
        /// </summary>
        /// <typeparam name="T">
        ///     The type of elements in the array. All values in the array are going to be converted to objects of this type.
        ///     If the conversion of an element fails, an exception is thrown.
        /// </typeparam>
        /// <returns></returns>
        public T[] GetValueArray<T>()
        {
            int myArraySize = this.ArraySize;

            var values = new T[myArraySize];
            int i = 0;

            int elemIndex = 1;
            int commaIndex = mRawValue.IndexOf(',');

            while (commaIndex >= 0)
            {
                string sub = mRawValue.Substring(elemIndex, commaIndex - elemIndex);
                sub = sub.Trim();

                values[i] = (T)ConvertValue(sub, typeof(T));

                elemIndex = commaIndex + 1;
                commaIndex = mRawValue.IndexOf(',', elemIndex + 1);

                i++;
            }

            if (myArraySize > 0)
            {
                // Read the last element.
                values[i] = (T)ConvertValue(
                    mRawValue.Substring(elemIndex, mRawValue.Length - elemIndex - 1),
                    typeof(T));
            }

            return values;
        }

        /// <summary>
        /// Gets this setting's value as an array of a specific type.
        /// Note: this only works if the setting represents an array.
        /// </summary>
        /// <param name="elementType">
        ///     The type of elements in the array. All values in the array are going to be converted to objects of this type.
        ///     If the conversion of an element fails, an exception is thrown.
        /// </param>
        /// <returns></returns>
        public object[] GetValueArray(Type elementType)
        {
            int myArraySize = this.ArraySize;

            var values = new object[myArraySize];
            int i = 0;

            int elemIndex = 1;
            int commaIndex = mRawValue.IndexOf(',');

            while (commaIndex >= 0)
            {
                string sub = mRawValue.Substring(elemIndex, commaIndex - elemIndex);
                sub = sub.Trim();

                values[i] = ConvertValue(sub, elementType);

                elemIndex = commaIndex + 1;
                commaIndex = mRawValue.IndexOf(',', elemIndex + 1);

                i++;
            }

            if (myArraySize > 0)
            {
                // Read the last element.
                values[i] = ConvertValue(
                    mRawValue.Substring(elemIndex, mRawValue.Length - elemIndex - 1),
                    elementType);
            }

            return values;
        }

        /// <summary>
        /// Gets this setting's value as a specific type.
        /// </summary>
        ///
        /// <typeparam name="T">The type of the object to retrieve.</typeparam>
        [Obsolete("The Setting.GetValue<T> method is obsolete. Please use Setting.GetValueTyped<T> instead.", false)]
        public T GetValue<T>()
        {
            return GetValueTyped<T>();
        }

        /// <summary>
        /// Gets this setting's value as a specific type.
        /// </summary>
        ///
        /// <param name="type">The type of the object to retrieve.</param>
        [Obsolete("The Setting.GetValue method is obsolete. Please use Setting.GetValueTyped instead.", false)]
        public object GetValue(Type type)
        {
            return GetValueTyped(type);
        }

        // Converts the value of a single element to a desired type.
        private static object ConvertValue(string value, Type type)
        {
            if (type == typeof(bool))
            {
                switch (value.ToLowerInvariant())
                {
                    case "off":
                    case "no":
                    case "0":
                        value = bool.FalseString;
                        break;
                    case "on":
                    case "yes":
                    case "1":
                        value = bool.TrueString;
                        break;
                }
            }
            else if (type.BaseType == typeof(Enum))
            {
                // It's possible that the value is something like:
                // UriFormat.Unescaped
                // We, and especially Enum.Parse do not want this format.
                // Instead, it wants the clean name like:
                // Unescaped
                //
                // Because of that, let's get rid of unwanted type names.
                int indexOfLastDot = value.LastIndexOf('.');

                if (indexOfLastDot >= 0)
                {
                    value = value.Substring(indexOfLastDot + 1, value.Length - indexOfLastDot - 1).Trim();
                }

                try
                {
                    return Enum.Parse(type, value);
                }
                catch
                {
                    throw new SettingValueCastException(value, type);
                }
            }

            try
            {
                return Convert.ChangeType(value, type, Configuration.NumberFormat);
            }
            catch
            {
                throw new SettingValueCastException(value, type);
            }
        }

        #endregion

        #region SetValue

        /// <summary>
        /// Sets the value of this setting via an object.
        /// </summary>
        /// 
        /// <param name="value">The value to set.</param>
        public void SetValue<T>(T value)
        {
            mRawValue = (value == null) ? string.Empty : value.ToString();
        }

        /// <summary>
        /// Sets the value of this setting via an array object.
        /// </summary>
        /// 
        /// <param name="values">The values to set.</param>
        public void SetValue<T>(T[] values)
        {
            if (values == null)
            {
                mRawValue = string.Empty;
            }
            else
            {
                var strings = new string[values.Length];

                for (int i = 0; i < values.Length; i++)
                {
                    strings[i] = values[i].ToString();
                }

                mRawValue = string.Format("{{{0}}}", string.Join(",", strings));
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets a string that represents the setting, not including comments.
        /// </summary>
        public override string ToString()
        {
            return ToString(false);
        }

        /// <summary>
        /// Gets a string that represents the setting.
        /// </summary>
        ///
        /// <param name="includeComment">Specify true to include the comments in the string; false otherwise.</param>
        public string ToString(bool includeComment)
        {
            if (includeComment)
            {
                bool hasPreComments = mPreComments != null && mPreComments.Count > 0;

                string[] preCommentStrings = hasPreComments ?
                    mPreComments.ConvertAll<string>(Comment.ConvertToString).ToArray() : null;

                if (Comment != null && hasPreComments)
                {
                    // Include inline comment and pre-comments.
                    return string.Format("{0}\n{1}={2} {3}",
                        string.Join(Environment.NewLine, preCommentStrings),
                        Name, mRawValue, Comment.ToString());
                }
                else if (Comment != null)
                {
                    // Include only the inline comment.
                    return string.Format("{0}={1} {2}", Name, mRawValue, Comment.ToString());
                }
                else if (hasPreComments)
                {
                    // Include only the pre-comments.
                    return string.Format("{0}\n{1}={2}",
                        string.Join(Environment.NewLine, preCommentStrings),
                        Name, mRawValue);
                }
            }

            // In every other case, include just the assignment in the string.
            return string.Format("{0}={1}", Name, mRawValue);
        }

        #endregion
    }
}
