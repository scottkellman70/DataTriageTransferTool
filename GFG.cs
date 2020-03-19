﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTriageTransferTool
{
    class GFG : IComparer<double>
    {
        public int Compare(double x, double y)
        {
            if (x == 0 || y == 0)
            {
                return 0;
            }

            return x.CompareTo(y);
        }
    }
}
