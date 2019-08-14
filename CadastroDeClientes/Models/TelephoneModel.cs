using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroDeClientes.Models
{
    public class TelephoneModel
    {
        //[RegularExpression("([0-9]+)", ErrorMessage = "Coloque somente números")]
        //[StringLength(9, MinimumLength = 9)]
        public string CellPhone { get; set; }

        //[RegularExpression("([0-9]+)", ErrorMessage = "Coloque somente números")]
        [StringLength(8, MinimumLength = 8)]
        public string ResidencialPhone { get; set; }

        //[RegularExpression("([0-9]+)", ErrorMessage = "Coloque somente números")]
        //[StringLength(9, MinimumLength = 9)]
        public string ComercialPhone { get; set; }

        //[RegularExpression("([0-9]+)", ErrorMessage = "Coloque somente números")]
        //[StringLength(2, MinimumLength = 2)]
        public string CellPhoneDDD { get; set; }

        //[RegularExpression("([0-9]+)", ErrorMessage = "Coloque somente números")]
        //[StringLength(2, MinimumLength = 2)]
        public string ResidencialPhoneDDD { get; set; }

        //[RegularExpression("([0-9]+)", ErrorMessage = "Coloque somente números")]
        //[StringLength(2, MinimumLength = 2)]
        public string ComercialPhoneDDD { get; set; }

        //public string TelephoneNumber { get; set; }
    }
}
