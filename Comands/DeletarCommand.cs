using System;
using System.Windows.Input;
using TesteMvvm.Models;
using TesteMvvm.ViewModels;

namespace TesteMvvm.Comands
{
    public class DeletarCommand : ICommand
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

        public DeletarCommand(ViewModelList vm)
        {
            _vm = vm;
        }

        public bool CanExecute(object parameter)
        {
            return _vm.ClienteAtual != null;
        }

        public void Execute(object parameter)
        {
           
            _vm.Remover();
        }
    }
}
