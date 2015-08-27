using System;

namespace cs6demos
{
    class ExceptionWithInformation : Exception
    {
        public int Information { get; set; }
    }

    // Exception Filters
    class Demo8
    {
        public void DoSomething(int a)
        {
            try
            {
                SomethingThatMightThrow(a);
            }
            catch (ExceptionWithInformation ei) when (ei.Information > 42)
            {
                // This is ok
            }
        }

        void SomethingThatMightThrow(int a)
        {
            throw new ExceptionWithInformation { Information = a };
        }
    }
}
