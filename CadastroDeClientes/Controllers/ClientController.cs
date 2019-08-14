using CadastroDeClientes.Data;
using CadastroDeClientes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CadastroDeClientes.Controllers
{
    public class ClientController : Controller
    {
        private readonly DatabaseContext _dbc;

        public ClientController(DatabaseContext dbc)
        {
            _dbc = dbc;
        }

        // GET: Client
        public IActionResult Index()
        {
            var clientsModel = _dbc.Clients.Select(cli => new ClientModel { Name = cli.Name, RG = cli.RG, CPF = cli.CPF, ID = cli.ID }).ToList();

            return View(clientsModel);
        }

        // GET: Client/Create
        [HttpGet]
        public IActionResult Create()
        {
            ClientModel model;

            model = new ClientModel();

            return View(model);
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(ClientModel model)
        {
            try
            {
                var newClient = new Client
                {
                    Name = model.Name,
                    Birthdate = model.Birthdate,
                    CPF = model.CPF,
                    RG = model.RG,
                    Facebook = model.Facebook,
                    Twitter = model.Twitter,
                    Instagram = model.Instagram,
                    Linkedin = model.Linkedin
                };

                newClient.TelephoneM = new Telephone
                {
                    CellPhone = model.TelephoneM.CellPhone,
                    ComercialPhone = model.TelephoneM.ComercialPhone,
                    ResidencialPhone = model.TelephoneM.ResidencialPhone,
                    CellPhoneDDD = model.TelephoneM.CellPhoneDDD,
                    ResidencialPhoneDDD = model.TelephoneM.ResidencialPhoneDDD,
                    ComercialPhoneDDD = model.TelephoneM.ComercialPhoneDDD
                };

                newClient.AdressesM = new Address
                {
                    ComStreetAddress = model.AdressesM.ComStreetAddress,
                    ComNeighborhood = model.AdressesM.ComNeighborhood,
                    ComCity = model.AdressesM.ComCity,
                    ComState = model.AdressesM.ComState,
                    ComZipCode = model.AdressesM.ComZipCode,

                    ResStreetAddress = model.AdressesM.ResStreetAddress,
                    ResNeighborhood = model.AdressesM.ResNeighborhood,
                    ResCity = model.AdressesM.ResCity,
                    ResState = model.AdressesM.ResState,
                    ResZipCode = model.AdressesM.ResZipCode
                };
                _dbc.Clients.Add(newClient);
                _dbc.SaveChanges();

            }
            catch (Exception)
            {
                //throw new ArgumentException("Houve algum erro, contate o administrador!");
                return View();
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Client/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ClientModel clientModel;

            try
            {
                var client = _dbc.Clients.Include(x => x.AdressesM).Include(x => x.TelephoneM).FirstOrDefault(x => x.ID == id);
                clientModel = new ClientModel(client);
            }
            catch
            {
                return View();
            }

            return View(clientModel);
        }

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(ClientModel model)
        {
            //Todo:
            //Colocar o validationSumary na tela - olhar projeto j4s
            //Colocar validação de modelstate - olhar projeto j4s
            //Antes de exibir a viewbag o html, colocar um if != null
            //Validaçoes
            try
            {
                if (ModelState.IsValid)
                {
                    var client = _dbc.Clients.Include(x => x.AdressesM).Include(x => x.TelephoneM).FirstOrDefault(x => x.ID == model.ID);
                    client.Name = model.Name;
                    client.Birthdate = model.Birthdate;
                    client.CPF = model.CPF;
                    client.RG = model.RG;
                    client.Facebook = model.Facebook;
                    client.Twitter = model.Twitter;
                    client.Instagram = model.Instagram;
                    client.Linkedin = model.Linkedin;

                    client.TelephoneM.CellPhone = model.TelephoneM.CellPhone;
                    client.TelephoneM.ComercialPhone = model.TelephoneM.ComercialPhone;
                    client.TelephoneM.ResidencialPhone = model.TelephoneM.ResidencialPhone;

                    client.TelephoneM.CellPhoneDDD = model.TelephoneM.CellPhoneDDD;
                    client.TelephoneM.ResidencialPhoneDDD = model.TelephoneM.ResidencialPhoneDDD;
                    client.TelephoneM.ComercialPhoneDDD = model.TelephoneM.ComercialPhoneDDD;

                    client.AdressesM.ComStreetAddress = model.AdressesM.ComStreetAddress;
                    client.AdressesM.ComNeighborhood = model.AdressesM.ComNeighborhood;
                    client.AdressesM.ComCity = model.AdressesM.ComCity;
                    client.AdressesM.ComState = model.AdressesM.ComState;
                    client.AdressesM.ComZipCode = model.AdressesM.ComZipCode;

                    client.AdressesM.ResStreetAddress = model.AdressesM.ResStreetAddress;
                    client.AdressesM.ResNeighborhood = model.AdressesM.ResNeighborhood;
                    client.AdressesM.ResCity = model.AdressesM.ResCity;
                    client.AdressesM.ResState = model.AdressesM.ResState;
                    client.AdressesM.ResZipCode = model.AdressesM.ResZipCode;

                    _dbc.Clients.Update(client);
                    _dbc.SaveChanges();
                }
                else
                {
                    var errors = ModelState
.Where(x => x.Value.Errors.Count > 0)
.Select(x => new { x.Key, x.Value.Errors })
.ToArray();
                }
            }
            catch (Exception)
            {
                //throw new ArgumentException("Houve algum erro, contate o administrador!");
                return View();
            }
            return RedirectToAction(nameof(Index));
        }


    }
}