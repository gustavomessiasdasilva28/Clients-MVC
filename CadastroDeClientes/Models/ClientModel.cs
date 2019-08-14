using CadastroDeClientes.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeClientes.Models
{
    public class ClientModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Nome obrigatório.", AllowEmptyStrings = false)]
        [StringLength(100)]
        [RegularExpression(@"^([a-zA-Z0-9 \.\&\'\-]+)$", ErrorMessage = "Nome Inválido")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Data de Aniversário obrigatória.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Birthdate { get; set; }

        //[StringLength(9)]
        //[RegularExpression("([0-9]+)", ErrorMessage = "Coloque somente números")]
        [Required(ErrorMessage = "CPF obrigatório.")]
        public string CPF { get; set; }

        [StringLength(15, MinimumLength = 5, ErrorMessage = "Seu RG deve possuir mais de 5 e menos de 15 numeros/letras")]
        [Required(ErrorMessage = "RG obrigatório.")]
        public string RG { get; set; }

        public AddressModel AdressesM { get; set; }
        public TelephoneModel TelephoneM { get; set; }

        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        
        public ClientModel()
        {
            this.TelephoneM = new TelephoneModel();
            this.AdressesM = new AddressModel();
        }

        public ClientModel(Client client) : this()
        {
            this.Name = client.Name;
            this.Birthdate = client.Birthdate;
            this.CPF = client.CPF;
            this.RG = client.RG;

            this.Facebook = client.Facebook;
            this.Twitter = client.Twitter;
            this.Instagram = client.Instagram;
            this.Linkedin = client.Linkedin;

            if (client.TelephoneM != null)
            {
                this.TelephoneM.CellPhone = client.TelephoneM.CellPhone;
                this.TelephoneM.CellPhoneDDD = client.TelephoneM.CellPhoneDDD;
                this.TelephoneM.ResidencialPhone = client.TelephoneM.ResidencialPhone;
                this.TelephoneM.ResidencialPhoneDDD = client.TelephoneM.ResidencialPhoneDDD;
                this.TelephoneM.ComercialPhone = client.TelephoneM.ComercialPhone;
                this.TelephoneM.ComercialPhoneDDD = client.TelephoneM.ComercialPhoneDDD;
            }

            this.AdressesM.ResStreetAddress = client.AdressesM.ResStreetAddress;
            this.AdressesM.ResNeighborhood = client.AdressesM.ResNeighborhood;
            this.AdressesM.ResCity = client.AdressesM.ResCity;
            this.AdressesM.ResState = client.AdressesM.ResState;
            this.AdressesM.ResZipCode = client.AdressesM.ResZipCode;

            if (client.AdressesM != null)
            {
                this.AdressesM.ComStreetAddress = client.AdressesM.ComStreetAddress;
                this.AdressesM.ComNeighborhood = client.AdressesM.ComNeighborhood;
                this.AdressesM.ComCity = client.AdressesM.ComCity;
                this.AdressesM.ComState = client.AdressesM.ComState;
                this.AdressesM.ComZipCode = client.AdressesM.ComZipCode;
            }



           


            //foreach (var telephone in client.Telephones)
            //{
            //    this.Telephones.Add(new TelephoneModel
            //    {
            //        TelephoneType = telephone.TelephoneType,
            //        DDD = telephone.DDD,
            //        TelephoneNumber = telephone.TelephoneNumber
            //    });
            //}

            //foreach (var address in client.Adresses)
            //{
            //    this.Adresses.Add(new AddressModel
            //    {
            //        StreetAddress = address.StreetAddress,
            //        Neighborhood = address.Neighborhood,
            //        City = address.City,
            //        State = address.State,
            //        ZipCode = address.ZipCode
            //    });
            //}
        }
    }
}