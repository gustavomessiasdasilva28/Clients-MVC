using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroDeClientes.Data
{
    public class Telephone
    {
        public int ID { get; set; }
        public string CellPhone { get; set; }
        public string ResidencialPhone { get; set; }
        public string ComercialPhone { get; set; }
        public string CellPhoneDDD { get; set; }
        public string ResidencialPhoneDDD { get; set; }
        public string ComercialPhoneDDD { get; set; }
        //public string TelephoneNumber { get; set; }
    }
}
