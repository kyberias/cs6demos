using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace cs5demos
{
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

                NotifyPropertyChanged(() => Address);
            }
        }

        protected void NotifyPropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(GetPropertyName(propertyExpression)));
            }
        }

        protected string GetPropertyName<T>(Expression<Func<T>> propertyExpression)
        {
            var memberExpression = (MemberExpression)propertyExpression.Body;
            return memberExpression.Member.Name;
        }
    }
}
