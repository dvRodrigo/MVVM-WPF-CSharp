using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
   public class ViewModelList : ViewModelBase
    {
        public ObservableCollection<ClienteModel> Clientes { get; set; }
        public ClienteModel ClienteAtual { get; set; }
        public AdicionarCommand AdicionarCommand { get; set; }
        public EditarCommand EditarCommand { get; set; }
        public DeletarCommand RemoverCommand { get; set; }

        public ViewModelList()
        {
            Clientes = new ObservableCollection<ClienteModel>();
            ClienteAtual = new ClienteModel();

            AdicionarCommand = new AdicionarCommand(this);
            EditarCommand = new EditarCommand(this);
            RemoverCommand = new DeletarCommand(this);

            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                Clientes.Add(new ClienteModel
                {
                    Nome = "Daniel",
                    Cpf = "1231323",
                    DataNasci = DateTime.Now.ToString(),
                    Email = "daniel@dada.copm"
                });

                Clientes.Add(new ClienteModel
                {
                    Nome = "Rodrigo",
                    Cpf = "12313434323",
                    DataNasci = DateTime.Now.AddYears(1).ToString(),
                    Email = "da32424niel@dada.copm"
                });

                ClienteAtual = Clientes.First();
            }
        }
        public void Remover()
        {
            Clientes.Remove(ClienteAtual);
        }

        public void Editar()
        {

            var view = new AdicionarView();
            var vm = view.FindResource(nameof(ViewModelDetalhe)) as ViewModelDetalhe;
            vm.BindCliente(ClienteAtual);

            view.ShowDialog();      

            ClienteAtual.Nome = vm.Cliente.Nome;
            ClienteAtual.Cpf = vm.Cliente.Cpf;
            ClienteAtual.DataNasci = vm.Cliente.DataNasci;
            ClienteAtual.Email = vm.Cliente.Email;
    
        }

        public void Adicionar()
        {
            var view = new AdicionarView();
            var vm = view.FindResource(nameof(ViewModelDetalhe)) as ViewModelDetalhe;
            view.ShowDialog();

            Clientes.Add(new ClienteModel 
            { 
                Nome = vm.Cliente.Nome,
                Cpf = vm.Cliente.Cpf,
                DataNasci = vm.Cliente.DataNasci,
                Email = vm.Cliente.Email
            });
        }
  
    }
}
