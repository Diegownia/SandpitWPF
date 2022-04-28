using SandpitWPF.Model;
using System.Collections.ObjectModel;

namespace SandpitWPF.Interfaces
{
    public interface IUserDialogViewModel
    {
        //ObservableCollection<UserModel> Users { get; set; }
        UserModel UserModel { get; set; }
    }
}