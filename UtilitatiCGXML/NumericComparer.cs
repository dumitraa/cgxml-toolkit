using System;
using System.Collections; // required for NumericComparer : IComparer only

namespace nc
{

    public class NumericComparer : IComparer
    {
        public NumericComparer()
        { }

        public int Compare(object x, object y)
        {
            if ((x is string) && (y is string))
            {
                return StringLogicalComparer.Compare((string)x, (string)y);
            }
            return -1;
        }
    }//EOC

}