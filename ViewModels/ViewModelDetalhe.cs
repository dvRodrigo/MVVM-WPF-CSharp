using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;
using TesteMvvm.Comands;
using TesteMvvm.Models;

namespace TesteMvvm.ViewModels
{
   public class ViewModelDetalhe : ViewModelBase
    {
        public ClienteModel Cliente { get; set; }
        
       
        public ConfirmarCommand ConfirmarCommand { get; set; }

        public ViewModelDetalhe()
        {
            Cliente = new ClienteModel();
            ConfirmarCommand = new ConfirmarCommand(this);
        }

        public void Confirmar( object parameter)
        {
            var obj = parameter as Window;

            obj.Close();
        }

        public void BindCliente(ClienteModel model)
        {
            Cliente.Nome = model.Nome;
            Cliente.Cpf = model.Cpf;
            Cliente.DataNasci = model.DataNasci;
            Cliente.Email = model.Email;
        }
       
       
    }
}
