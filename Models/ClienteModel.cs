using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMvvm.Models
{
    

    public class ClienteModel : ModelBase
    {
      
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; OnPropertyChanged("Nome"); }
        }

         private string _cpf;
         public string Cpf
         {
             get { return _cpf; }
             set { _cpf = value; OnPropertyChanged("Cpf"); }
         }


         private string _dataNasci;
         public string DataNasci
         {
             get { return _dataNasci; }
             set { _dataNasci = value; OnPropertyChanged("DataNasci"); }
         }

         private string _email;




         public string Email
         {
             get { return _email; }
             set { _email = value; OnPropertyChanged("Email"); }
         }


         

        public override string ToString()
        {
            return $"Nome: {Nome}         CPF: {Cpf} " +
        $"\nData Nascimento: {DataNasci}  Email: {Email}" ;
        }

    }
}
