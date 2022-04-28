using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SandpitWPF.Interfaces;
using SandpitWPF.Model;

namespace SandpitWPF.ViewModel
{
    public class UserDialogViewModel : BaseViewModel, IUserDialogViewModel
    {
        //private int _id;
        //private string _name;
        //private string _surname;
        //private int _age;
        //private UserModel _user;
        //private ObservableCollection<UserModel> _users;
        private UserModel _userModel;
        public UserModel UserModel
        {
            get => _userModel;
            set
            {
                _userModel = value;
                NotifyPropertyChanged(nameof(UserModel));
            }
        }
        public UserDialogViewModel()
        {
            UserModel = new UserModel();
        }

        //public int ID 
        //{
        //    get { return _id; }
        //    set
        //    {
        //        _id = value;
        //        NotifyPropertyChanged(nameof(ID));
        //    }
        //}

        //public string Name
        //{
        //    get { return _name; }
        //    set
        //    {
        //        _name = value;
        //        NotifyPropertyChanged(nameof(Name));
        //    }
        //}

        //public string Surname
        //{
        //    get { return _surname; }
        //    set
        //    {
        //        _surname = value;
        //        NotifyPropertyChanged(nameof(Surname));
        //    }
        //}

        //public int Age
        //{
        //    get { return _age; }
        //    set
        //    {
        //        _age = value;
        //        NotifyPropertyChanged(nameof(Age));
        //    }
        //}

        //public ObservableCollection<UserModel> Users
        //{
        //    get { return _users; }
        //    set
        //    {
        //        _users = value;
        //        NotifyPropertyChanged(nameof(Users));
        //    }
        //}

        //public UserModel User
        //{
        //    get { return _user; }
        //    set 
        //    { 
        //        _user = value;
        //        NotifyPropertyChanged(nameof(User));
        //    }
        //}


    }
}
