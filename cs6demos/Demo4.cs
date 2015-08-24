using System.ComponentModel;

namespace cs6demos
{
    // NameOf Operator
    class Demo4 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string address;

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                NotifyPropertyChanged(nameof(Address));
            }
        }

        protected void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
