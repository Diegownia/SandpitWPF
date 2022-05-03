using SandpitWPF.Interfaces;
using SandpitWPF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SandpitWPF.Services
{
    public class DialogService : IDialogService
    {
        private const string _postFix = "DialogViewModel";
        private Dictionary<string, Window> _views;

        public DialogService()
        {
            _views = new Dictionary<string, Window>();
            _views.Add("User", new UserAddView());
            //_views.Add("About", new AbaoutDialog());
            _views.Add("2", new Dialog2View());
        }

        private string GetKey(object viewModel)
        {
            var fullName = viewModel?.GetType()?.Name;
            if (string.IsNullOrEmpty(fullName))
            {
                throw new InvalidOperationException("Parameter empty");
            }
            if (!fullName.Contains(_postFix))
            {
                throw new InvalidOperationException("Parameter not a ViewModel");
            }
            return fullName.Replace(_postFix, "");
        }

        public bool? ShowDialog(object vm)
        {
            if (vm == null)
            {
                return null;
            }
            var key = GetKey(vm);
            bool? value = null;
            if (_views.ContainsKey(key))
            {
                Window dialog = _views[key];
                dialog.DataContext = vm;
                value = dialog.ShowDialog();
                
            }
            return value;
        }
    }
}
