using System;

namespace cs5demos
{
    class Demo2
    {
        public Demo2()
        {
            Name = "Default Name";
        }

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

        public string Name { get; set; }
    }
}
