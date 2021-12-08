using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ2
{
    static class UniversityWithCanteen
    {
        public static decimal AddCanteen(this decimal income, ref int numberOfStaff)
        {
            income += income * 0.2m;
            numberOfStaff += 5;
            return income;
        }
    }
}
