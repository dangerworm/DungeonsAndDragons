using System;
using System.Collections.Generic;
using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualBasic;

namespace DungeonsAndDragons_Data
{
    public static class StringExtensions
    {
        private static readonly Regex PascalizeRegex =
            new Regex(@"(?:[^a-zA-Z0-9]*)(?<first>[a-zA-Z0-9])(?<remainder>[a-zA-Z0-9]*)(?:[^a-zA-Z0-9]*)");

        private static readonly MatchEvaluator PascalizeMatchEvaluater =
            m => m.Groups["first"].ToString().ToUpper() + m.Groups["remainder"].ToString().ToLower();

        private static readonly Regex IsSpinalCaseRegex = new Regex(@"^[a-z][a-z0-9]+([\-][a-z0-9]+)*$");

        public static bool IsNumeric(this string @string)
        {
            return Information.IsNumeric(@string);
        }

        public static bool IsSpinalCase(this string value)
        {
            Verify.NotNull(value, nameof(value));

            return IsSpinalCaseRegex.IsMatch(value);
        }
      
        public static string ToSpinalCase(this string value)
        {
            Verify.NotNull(value, nameof(value));

            string modifiedString = value.Replace("'s", "s");
            modifiedString = Regex.Replace(modifiedString, @"[^a-zA-Z0-9\s]", "");

            var words = Regex.Split(modifiedString, "[^a-zA-Z0-9]");

            return String.Join("-", words.Select(x => x.ToLower()));
        }

        public static string Pascalize(this string value)
        {
            Verify.NotNull(value, "value");

            string modifiedString = value.Replace("'s", "s").Replace("#", "");

            return PascalizeRegex
                .Replace(modifiedString, PascalizeMatchEvaluater)
                .Replace("Mymax", "MyMax");
        }

        public static string ToTitleCase(this string value)
        {
            return string.IsNullOrWhiteSpace(value) ? value : Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());
        }

        public static string ToValidFileName(this string value)
        {
            var invalidCharacters = Path.GetInvalidFileNameChars();

            string result = value;
            foreach (char invalidCharacter in invalidCharacters)
            {
                result = result.Replace(invalidCharacter, '_');
            }

            return result;
        }

        public static string ToInitial(this string value)
        {
            string initials = "";
            var words = value.Trim().Split(' ');

            foreach (string word in words)
            {
                string trimmed = word.Trim();
                if (!string.IsNullOrWhiteSpace(trimmed) && trimmed.Length > 0)
                {
                    string initial = trimmed.Substring(0, 1);
                    initials += initial;
                }
            }

            return initials;
        }

        public static string AppendText(this string value, string text, string separator)
        {
            return (string.IsNullOrWhiteSpace(value)
                ? string.Empty
                : (value + (string.IsNullOrWhiteSpace(text) ? "" : separator)))
                   + (string.IsNullOrWhiteSpace(text)
                       ? ""
                       : text);
        }

        public static string ToMatchedOn(this string title, List<int> matchPoints)
        {
            var splitTitle = new List<string>();

            if (matchPoints.Count >= 2)
            {
                const string openBoldSpan = "<strong>";
                const string endBoldSpan = "</strong>";

                int start1 = matchPoints[0] - 1;
                int end1 = matchPoints[1] - 1;

                splitTitle.Add(title.Substr(0, start1 - 1));
                splitTitle.Add(openBoldSpan);
                splitTitle.Add(title.Substr(start1, end1));
                splitTitle.Add(endBoldSpan);

                if (matchPoints.Count >= 4)
                {
                    int start2 = matchPoints[2] - 1;
                    int end2 = matchPoints[3] - 1;

                    splitTitle.Add(title.Substr(end1 + 1, start2 - 1));
                    splitTitle.Add(openBoldSpan);
                    splitTitle.Add(title.Substr(start2, end2));
                    splitTitle.Add(endBoldSpan);
                    splitTitle.Add(title.Substr(end2 + 1, title.Length - 1));
                }
                else
                {
                    splitTitle.Add(title.Substr(end1 + 1, title.Length - 1));
                }
            }

            return string.Join("", splitTitle);
        }

        public static string Substr(this string text, int startIndex, int endIndex)
        {
            int length = endIndex - startIndex + 1;
            return text.Substring(startIndex, length);
        }

        public static byte[] FromBase64String(this string value)
        {
            return Convert.FromBase64String(value);
        }

        public static string CorrectWordPerCount(this string word, int count)
        {
            if (count == 1)
            {
                return word;
            }

            return PluralizationService
                .CreateService(new CultureInfo("en-US"))
                .Pluralize(word);
        }
    }
}
