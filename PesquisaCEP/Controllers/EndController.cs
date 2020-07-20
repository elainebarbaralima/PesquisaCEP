// Elaine Barbara de Lima

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using PesquisaCEP.DAL;
using PesquisaCEP.Models;

namespace ViaCepAPI.Controllers
{
    public class EndController : Controller 
    {
        private readonly EndDAO _endDAO;

        public EndController(EndDAO endDAO) 
        {
            _endDAO = endDAO;
        }

        public IActionResult Index()
        {
            if (TempData["Cep"] != null)
            {
                string result = TempData["Cep"].ToString();
                End end = JsonConvert.DeserializeObject<End>(result);

                _endDAO.Create(end);

                return View(_endDAO.List());

            }
            return View(_endDAO.List());
        }


        [HttpPost]
        public IActionResult PesquisarCep(string txtCep) 
        {
            string url = $@"https://viacep.com.br/ws/{txtCep}/json/";
            WebClient endereco = new WebClient(); 
            TempData["Cep"] = endereco.DownloadString(url); 
            return RedirectToAction("Index");
        }
    }
}
