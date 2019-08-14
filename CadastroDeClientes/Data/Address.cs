using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroDeClientes.Data
{
    public class Address
    {
        public int ID { get; set; }
        public string ComStreetAddress { get; set; }
        public string ComNeighborhood { get; set; }
        public string ComCity { get; set; }
        public string ComState { get; set; }
        public string ComZipCode { get; set; }

        public string ResStreetAddress { get; set; }
        public string ResNeighborhood { get; set; }
        public string ResCity { get; set; }
        public string ResState { get; set; }
        public string ResZipCode { get; set; }
    }
}
