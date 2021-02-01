using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TesteMvvm.Models;
using TesteMvvm.ViewModels;

namespace TesteMvvm.Comands
{
    public class EditarCommand : ICommand
    {
        ViewModelList _vm { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }

        public EditarCommand(ViewModelList vm)
        {
            _vm = vm;
        }

        public bool CanExecute(object parameter)
        {

            return _vm.ClienteAtual != null;
        }

        public void Execute(object parameter)
        {
          
            _vm.Editar();
        }
    }
}
