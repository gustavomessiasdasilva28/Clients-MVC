using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroDeClientes.Models
{
    public class AddressModel
    {
        [Required(ErrorMessage = "O Logradouro é obrigatório.")]
        public string ResStreetAddress { get; set; }

        [Required(ErrorMessage = "O Bairro é obrigatório.")]
        public string ResNeighborhood { get; set; }

        [Required(ErrorMessage = "A Cidade é obrigatória.")]
        public string ResCity { get; set; }

        [Required(ErrorMessage = "O Estado é obrigatório.")]
        public string ResState { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório.")]
        public string ResZipCode { get; set; }



        public string ComStreetAddress { get; set; }
        public string ComNeighborhood { get; set; }
        public string ComCity { get; set; }
        public string ComState { get; set; }
        public string ComZipCode { get; set; }
    }
}
