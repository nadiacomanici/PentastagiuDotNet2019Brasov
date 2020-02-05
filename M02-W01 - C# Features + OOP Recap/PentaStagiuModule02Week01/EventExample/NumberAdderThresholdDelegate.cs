using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    class NumberAdderThresholdDelegate
    {
        private int sum = 0;
        private int threshold;

        public delegate void ThresholdReachedDelegate();
        public event ThresholdReachedDelegate ThresholdReached;

        public delegate void SumModifiedDelegate(int sum);
        public event SumModifiedDelegate SumModified;

        public NumberAdderThresholdDelegate(int threshold)
        {
            this.threshold = threshold;
        }

        public void Add(int number)
        {
            sum += number;
            OnSumModified();
            if (sum > threshold)
            {
                OnThresholdReached();
            }
        }

        private void OnSumModified()
        {
            if (SumModified != null)
            {
                SumModified(sum);
            }
        }

        private void OnThresholdReached()
        {
            if (ThresholdReached != null)
            {
                ThresholdReached();
            }
        }
    }
}
