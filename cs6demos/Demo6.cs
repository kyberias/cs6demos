using System.Collections.Generic;

namespace cs6demos
{
    class ClassWithTwoIndexers
    {
        public string this[int key]
        {
            get
            {
                return "";
            }
            set
            {

            }
        }

        public string this[string key]
        {
            get
            {
                return "";
            }
            set
            {

            }
        }
    }

    class Demo6
    {
        // Index Initializers
        public Demo6()
        {
            var obj = new ClassWithTwoIndexers
            {
                [1] = "joo",
                ["joo"] = "joo",
            };

            // Calls placesByZip[index] = "value" ?
        }
    }
}
