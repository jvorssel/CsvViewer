using System;
using System.Collections;

namespace CsvViewer.Utility.Comparators
{
    public class AlphaNumericComparator : IComparer
    {
        public int Compare(object x, object y)
        {
            var s1 = x as string;
            if (s1 == null)
                return 0;

            var s2 = y as string;
            if (s2 == null)
                return 0;

            var lengthX = s1.Length;
            var lengthY = s2.Length;
            var marker1 = 0;
            var marker2 = 0;

            // Walk through two the strings with two markers.
            while (marker1 < lengthX && marker2 < lengthY)
            {
                var ch1 = s1[marker1];
                var ch2 = s2[marker2];

                // Some buffers we can build up characters in for each chunk.
                var space1 = new char[lengthX];
                var loc1 = 0;
                var space2 = new char[lengthY];
                var loc2 = 0;

                // Walk through all following characters that are digits or
                // characters in BOTH strings starting at the appropriate marker.
                // Collect char arrays.
                do
                {
                    space1[loc1++] = ch1;
                    marker1++;

                    if (marker1 < lengthX)
                    {
                        ch1 = s1[marker1];
                    }
                    else break;

                } while (char.IsDigit(ch1) == char.IsDigit(space1[0]));

                do
                {
                    space2[loc2++] = ch2;
                    marker2++;

                    if (marker2 < lengthY)
                    {
                        ch2 = s2[marker2];
                    }
                    else break;

                } while (char.IsDigit(ch2) == char.IsDigit(space2[0]));

                // If we have collected numbers, compare them numerically.
                // Otherwise, if we have strings, compare them alphabetically.
                var str1 = new string(space1);
                var str2 = new string(space2);

                int result;

                if (char.IsDigit(space1[0]) && char.IsDigit(space2[0]))
                {
                    var thisNumericChunk = int.Parse(str1);
                    var thatNumericChunk = int.Parse(str2);
                    result = thisNumericChunk.CompareTo(thatNumericChunk);
                }
                else result = string.Compare(str1, str2, StringComparison.InvariantCulture);

                if (result != 0)
                    return result;
            }

            return lengthX - lengthY;
        }
    }
}
