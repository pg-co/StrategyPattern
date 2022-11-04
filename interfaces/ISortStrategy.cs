using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.interfaces
{
    public interface ISortStrategy
    {
        public interface Strategy
        {
            public int[] Sort(int[] arr, bool asc);
        }
    }
}
