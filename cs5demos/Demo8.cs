using System;

namespace cs6demos
{
    class ExceptionWithInformation : Exception
    {
        public int Information { get; set; }
    }

    class Demo8
    {
        public void DoSomething(int a)
        {
            try
            {
                SomethingThatMightThrow(a);
            }
            catch (ExceptionWithInformation ei)
            {
                if (ei.Information > 42)
                {
                    // This is ok
                }
                else
                {
                    throw;
                }
            }
        }

        void SomethingThatMightThrow(int a)
        {
            throw new ExceptionWithInformation { Information = a };
        }
    }
}
