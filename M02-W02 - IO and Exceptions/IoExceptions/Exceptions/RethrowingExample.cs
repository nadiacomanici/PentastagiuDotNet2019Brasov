using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class RethrowingExample
    {
        public void Run()
        {
            HighLevelComponent();
        }

        private void HighLevelComponent()
        {
            try
            {
                LowLevelComponentResetStacktrace();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in high level component: {0}", ex.Message);
            }

            try
            {
                LowLevelComponentPreserveStacktrace();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in high level component: {0}", ex.Message);
            }
        }

        private void LowLevelComponentPreserveStacktrace()
        {
            try
            {
                MethodThatThrows();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in low level component: {0}", ex.Message);
                throw;
            }
        }

        private void LowLevelComponentResetStacktrace()
        {
            try
            {
                MethodThatThrows();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in low level component: {0}", ex.Message);
                throw ex;
            }
        }

        private void MethodThatThrows()
        {
            throw new NotImplementedException();
        }
    }
}
