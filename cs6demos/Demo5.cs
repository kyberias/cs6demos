namespace cs6demos
{
    // String Interpolation
    public class Demo5
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        Demo5 demo;

        public string Name
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
