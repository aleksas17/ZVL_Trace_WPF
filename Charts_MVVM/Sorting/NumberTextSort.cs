using System;
using System.Collections.Generic;
using System.IO;

namespace Charts_MVVM
{
    /// <summary>
    /// Custom comparer that sort string with numbers
    /// </summary>
    public class NumberTextSort : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            // split filename
            string[] parts1 = Path.GetFileNameWithoutExtension(x.Name).Split('_');
            string[] parts2 = Path.GetFileNameWithoutExtension(y.Name).Split('_');

            // calculate how much leading zeros we need
            int toPad1 = 10 - parts1[1].Length;
            int toPad2 = 10 - parts2[1].Length;

            // add the zeros, only for sorting
            parts1[1] = parts1[1].Insert(0, new String('0', toPad1));
            parts2[1] = parts2[1].Insert(0, new String('0', toPad2));

            // create the comparable string
            string toCompare1 = string.Join("", parts1);
            string toCompare2 = string.Join("", parts2);

            // compare
            return toCompare1.CompareTo(toCompare2);
        }
    }
}
