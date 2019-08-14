using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroDeClientes.Data
{
    public class Client
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime? Birthdate { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }

        public Address AdressesM { get; set; }
        public Telephone TelephoneM { get; set; }

        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }

 
    }
}