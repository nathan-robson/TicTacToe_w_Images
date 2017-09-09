using ExtentionMethods;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
 * Nathan Robson
 */

namespace ExtentionMethods
{
    /// <summary>
    /// Various extension methods for int maipulation
    /// </summary>
    public static class NumericExtentions
    {

        ///<summary>
        ///     Converts an object into a standard int, if possible
        ///</summary>
        ///<author> Nathan Robson </author>
        ///<param name="content"> extended object variable </param>
        ///<param name="defaultValue"> value to return if not convertable </param>
        ///<returns> resulting value - either the converted value or the default </returns>
        ///
        public static int toInt(this object content, int defaultValue)
        {
            try
            {
                if (content == null) { return defaultValue; }
                if (content.Equals(DBNull.Value)) { return defaultValue; }

                int result = 0;
                return int.TryParse(content.ToString(), out result) ? result : defaultValue;
            }
            catch
            {
                return defaultValue;
            }
        }

        ///<summary>
        ///     Converts an object into a nullable int
        ///</summary>
        ///<author> Nathan Robson </author>
        ///<param name="content"> extended object variable </param>
        ///<returns> resulting value - either the integer value provided, or null if TryParse fails  </returns>
        ///
        public static int? toInt(this object content)
        {
            try
            {
                if (content == null) { return null; }
                if (content.Equals(DBNull.Value)) { return null; }

                int result;
                if (int.TryParse(content.ToString(), out result)) { return result; }

                return null;
            }
            catch
            {
                return null;
            }
        }

        ///<summary>
        ///     Converts an object into a nullable string
        ///</summary>
        ///<author> Nathan Robson </author>
        ///<param name="content"> extended object variable </param>
        ///<returns> resulting value - either the string value provided, null if value is null, or null if ToString fails  </returns>
        ///
        public static string ToString(this int? content)
        {
            try
            {
                if (!content.HasValue) { return string.Empty; }
                if (content.Equals(DBNull.Value)) { return string.Empty; }

                // culture gets the standard formats for certain areas (found in locale within the computer filesystem)
                // InvariantCulture is the getter for the CultureInfo object
                return content.Value.ToString(CultureInfo.InvariantCulture);                
            }
            catch
            {
                return string.Empty;
            }
        }

        ///<summary>
        ///     Converts an object into a standard string, if possible
        ///</summary>
        ///<author> Nathan Robson </author>
        ///<param name="content"> extended object variable </param>
        ///<param name="defaultValue"> value to return if not convertable </param>
        ///<returns> resulting value - either the converted string or the default </returns>
        ///
        public static string ToString(this int? content, string format)
        {
            try
            {
                if (!content.HasValue) { return string.Empty; }
                if (content.Equals(DBNull.Value)) { return string.Empty; }

                return content.Value.ToString(format);
            }
            catch
            {
                return string.Empty;
            }
        }
    }


    /// <summary>
    /// Various extension methods for string maipulation
    /// </summary>

    public static class StringExtentions
    {
        private const string EMAIL_REG_EX = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

        ///<summary>
        ///     Checks whether a value is null or empty
        ///</summary>
        ///<author> Nathan Robson </author>
        ///<param name="content"> extended object variable </param>
        ///<returns> resulting value - Boolean true if null or empty  </returns>
        ///
        public static bool IsNullOrEmpty(this string content)
        {
            return string.IsNullOrEmpty(content);
        }

        ///<summary>
        ///     Examines string value to determine if it is a valid email
        ///</summary>
        ///<author> Nathan Robson </author>
        ///<param name="content"> extended object variable </param>
        ///<returns> resulting value - Boolean true if email is valid  </returns>
        ///
        public static bool IsValidEmail(this string content)
        {
            if (string.IsNullOrEmpty(content)) { return false; }

            return Regex.IsMatch(content, EMAIL_REG_EX);
        }

        ///<summary>
        ///     Check that a string contains numbers only
        ///</summary>
        ///<author> Nathan Robson </author>
        ///<param name="content"> extended object variable </param>
        ///<returns> resulting value - Boolean true if the string only contains numbers  </returns>
        ///
        public static bool IsNumeric(this string content)
        {
            if (string.IsNullOrEmpty(content)) { return false; }

            return Regex.IsMatch(content, @"^[0-9]*.?[0-9]*$");
        }

        ///<summary>
        ///     Compares string with RegEx to determine if the string is a match
        ///</summary>
        ///<author> Nathan Robson </author>
        ///<param name="content"> extended object variable </param>
        ///<returns> resulting value - Boolean true if the match is valid  </returns>
        ///
        public static bool IsMatch(this string content, string regEx)
        {
            if (string.IsNullOrEmpty(content)) { return false; }

            return Regex.IsMatch(content, regEx);
        }

        ///<summary>
        ///     Returns the number of characters specified, starting from the left side of the string
        ///</summary>
        ///<author> Nathan Robson </author>
        ///<param name="content"> extended object variable </param>
        ///<returns> resulting value - String, but only contains numbers </returns>
        ///
        public static string Left(this string content, int numCharacters)
        {
            if (content == null) { return null; }

            if (content.Length < numCharacters) { return content; }

            else { return "0"; }
        }

        ///<summary>
        ///     Returns the number of characters specified, starting from the right side of the string
        ///</summary>
        ///<author> Nathan Robson </author>
        ///<param name="content"> extended object variable </param>
        ///<returns> resulting value - String, contains only numbers  </returns>
        ///
        public static string Right(this string content, int numCharacters)
        {
            if (content == null) { return null; }

            if (content.Length < numCharacters) { return content; }

            return content.Substring(content.Length - numCharacters, numCharacters);
        }

        ///<summary>
        ///     Returns a string representation of the provided value. Returns an empty string if the value is null
        ///</summary>
        ///<author> Nathan Robson </author>
        ///<param name="content"> extended object variable </param>
        ///<returns> resulting value - String, or empty string </returns>
        ///
        public static string ToStringSafe(this object value)
        {
            try
            {
                if (value == null) { return string.Empty; }

                var formattableValue = value as IFormattable;
                if (formattableValue != null) return formattableValue.ToString(null, CultureInfo.InvariantCulture);

                return value.ToString();
            }
            catch(Exception)
            {
                return string.Empty;
            }
        }
    }
}
