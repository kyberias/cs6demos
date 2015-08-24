using System;

namespace cs5demos
{
    class Demo2
    {
        Guid id = Guid.NewGuid();

        public Guid Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }
}
