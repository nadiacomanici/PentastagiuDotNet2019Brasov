using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    class NumberAdderThresholdEventHandler
    {
        private int sum = 0;
        private int threshold;

        public event EventHandler ThresholdReached;
        public event EventHandler<int> SumModified;

        public NumberAdderThresholdEventHandler(int threshold)
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
                SumModified(this, sum);
            }
        }

        private void OnThresholdReached()
        {
            if (ThresholdReached != null)
            {
                ThresholdReached(this, EventArgs.Empty);
            }
        }
    }
}
