//-----------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="Telerik">
//     Copyright (c) Telerik. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Static class that provides string extension methods.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// A string extension method that converts the input string in a hashed with MD5 algorithm hexadecimal string.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>A hexadecimal string.</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// A string extension method that checks if the input string contains predefined true-like values.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns true only if the input string has one of the predefined true-like value,
        /// in all other cases returns false</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// A string extension method that tries to parse the input string to short and returns the result.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns variable of type short in case the input string is a number, otherwise-returns null.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// A string extension method that tries to parse the input string to integer and returns the result.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns variable of type integer in case the input string is a number, otherwise-returns null.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// A string extension method that tries to parse the input string to long and returns the result.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns variable of type long in case the input string is a number, otherwise-returns null.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// A string extension method that tries to parse the input string to DateTime format and returns the result.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns variable of type DateTime in case the input string can be parsed, otherwise-returns null.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// A string extension method that capitalizes the first letter of the input string.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns the string with its first letter capitalized.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// A string extension method that returns a substring between two given strings.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <param name="startString">The start of the substring.</param>
        /// <param name="endString">The end of the substring.</param>
        /// <param name="startFrom">Index to start from (optional).</param>
        /// <returns>Returns the substring between <paramref name="startString"/> and <paramref name="endString"/>. If not found,
        /// returns an empty string.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// A string extension method that converts Cyrillic letters to their Latin equivalents.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>New string containing only Latin letters.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// A string extension method that converts Latin letters to their Cyrillic equivalents.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>New string containing only Cyrillic letters.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// A string extension method that replaces all the invalid symbols in the input string with an empty string
        /// and converts the input string to a valid username.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns the string with converted all Cyrillic letters to Latin and all not alpha-numeric values, "." or "_"  being removed. </returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// A string extension method that replaces all the invalid symbols in the input string with an empty string 
        /// and converts the input string to a valid filename.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns the string with converted all Cyrillic letters to Latin, all not alpha-numeric values, "." or "_"  being removed and all spaces being replaced with "-".</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// A string extension method that gets the first <paramref name="charsCount"/> characters from the input string.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <param name="charsCount">The count of the characters to be returned.</param>
        /// <returns>Returns the first <paramref name="charsCount"/> characters of <paramref name="input"/> or <paramref name="input"/> if <paramref name="charsCount"/> is greater than <paramref name="input"/> length.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// A string extension method that returns the file extension of a given string with filename.
        /// </summary>
        /// <param name="fileName">The string(filename) on which the method is invoked.</param>
        /// <returns>Returns the file extension or empty string when no extension is found.</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// A string extension method that returns the content type of a file based on its extension.
        /// </summary>
        /// <param name="fileExtension">The extension of a filename represented as a string on which the method is invoked.</param>
        /// <returns>Returns the content type associated with the given file extension.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// A string extension method that converts a string to a byte array.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns a byte array from conversion of every character in the input string to its binary representation.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}