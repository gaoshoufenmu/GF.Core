// Copyright (c) 2013-2015 Cemalettin Dervis, MIT License.
// https://github.com/cemdervis/SharpConfig

using System;
using System.Collections.Generic;
using System.Text;

namespace SharpConfig
{
    /// <summary>
    /// Represents a comment in a configuration.
    /// </summary>
    public sealed class Comment
    {
        private string mValue;
        private char mSymbol;

        /// <summary>
        /// Initializes a new instance of the <see cref="Comment"/> class.
        /// </summary>
        /// <param name="value"> The string value of the comment.</param>
        /// <param name="symbol">The delimiting symbol of the comment.</param>
        public Comment(string value, char symbol)
        {
            if (symbol == '\0')
                throw new ArgumentNullException("symbol");

            mValue = value;
            mSymbol = symbol;
        }

        /// <summary>
        /// Gets or sets the value of the comment.
        /// </summary>
        public string Value
        {
            get { return mValue; }
            set { mValue = value; }
        }

        /// <summary>
        /// Gets or sets the delimiting symbol of the comment.
        /// </summary>
        public char Symbol
        {
            get { return mSymbol; }
            set
            {
                if (value == '\0')
                    throw new ArgumentNullException("value");

                mSymbol = value;
            }
        }

        /// <summary>
        /// Returns the fully qualified type name of this instance.
        /// </summary>
        ///
        /// <returns>
        /// A <see cref="T:System.String" /> containing a fully qualified type name.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0} {1}", Symbol, Value ?? string.Empty);
        }

        // Used by Setting and Section in ToString().
        internal static string ConvertToString(Comment comment)
        {
            return comment.ToString();
        }

    }
}