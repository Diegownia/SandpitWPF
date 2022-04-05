using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SandpitWPF.Model;

namespace SandpitWPF.ViewModel
{
    public class UserViewModel : BaseViewModel
    {
        private int _id;
        private string _name;
        private string _surname;
        private int _age;
        private UserModel _user;

        public int ID 
        {
            get { return _id; }
            set
            {
                _id = value;
                NotifyPropertyChanged(nameof(ID));
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                NotifyPropertyChanged(nameof(Surname));
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                NotifyPropertyChanged(nameof(Age));
            }
        }

        public UserModel User
        {
            get { return _user; }
            set 
            { 
                _user = value;
                NotifyPropertyChanged(nameof(User));
            }
        }


    }
}
