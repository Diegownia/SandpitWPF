using SandpitWPF.Model;
using System.Collections.ObjectModel;

namespace SandpitWPF.Interfaces
{
    public interface IUserViewModel
    {
        ObservableCollection<UserModel> Users { get; set; }
    }
}