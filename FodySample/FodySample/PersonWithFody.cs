using System.ComponentModel;

namespace FodySample
{
    public class PersonWithFody : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int Age { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        private void OnLastNameChanged()
        {
            if (LastName == "Chauhan")
            {
                Age = 22;
            }
        }
    }
}