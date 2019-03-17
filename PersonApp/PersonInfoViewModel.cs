using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class PersonInfoViewModel : INotifyPropertyChanged
    {
        private readonly Person _person;

        public string Name => $"NAME:\n{_person.Name}";
        public string Surname => $"SURNAME:\n{_person.Surname}";
        public string Email => $"EMAIL:\n{_person.Email}";
        public string BirthDate => $"BIRTHDAY:\n{_person.Birthday.ToShortDateString()}";
        public string SunSign => $"SUN SIGN:\n{_person.SunSign}";
        public string ChineseSign => $"CHINESE SIGN:\n{_person.ChineseSign}";
        public string IsBirthday => $"Today is {(_person.IsBirthday ? "" : "not ")}your birthday";
        public string IsAdult => $"You are {(_person.IsAdult ? "" : "not ")}adult";

        public PersonInfoViewModel(Person person)
        {
            _person = person;
        }

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
