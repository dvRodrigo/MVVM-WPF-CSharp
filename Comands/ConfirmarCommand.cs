using System;
using System.Windows.Input;
using TesteMvvm.Models;
using TesteMvvm.ViewModels;

namespace TesteMvvm.Comands
{
    public class ConfirmarCommand : ICommand
    {
        ViewModelDetalhe _vm { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }

        public ConfirmarCommand(ViewModelDetalhe vm)
        {
            _vm = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _vm.Confirmar(parameter);
        }
    }
}
