using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PesquisaCEP.DAL;
using PesquisaCEP.Models;

namespace PesquisaCEP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EndAPIController : ControllerBase
    {
        private readonly EndDAO _endDAO;
        public EndAPIController(EndDAO endDAO)
        {
            _endDAO = endDAO;
        }

        //GET: /api/Endereco/ListarEnderecos
        [HttpGet]
        [Route("ListarEnderecos")]
        public IActionResult List()
        {
            return Ok(_endDAO.List());
        }

        //GET: /api/Endereco/ListarEnderecos/{cep}
        [HttpGet]
        [Route("ListarEnderecos/{cep}")]
        public IActionResult List(string end)
        {
            return Ok(_endDAO.List(end));
        }

        //POST: /api/Endereco/CadastrarEndereco
        [HttpPost]
        [Route("CadastrarEndereco")]
        public IActionResult Create(End end)
        {
            _endDAO.Create(end);
            return Created("", end);
        }

        //PUT: /api/Endereco/AlterarEndereco
        [HttpPut]
        [Route("AlterarEndereco")]
        public IActionResult Update(End end)
        {
            return Ok(_endDAO.Update(end));
        }

        //DELETE: /api/Endereco/DeletarEndereco/{cepID}
        [HttpDelete]
        [Route("DeletarEndereco/{id}")]
        public IActionResult Delete(string endid)
        {
            return Ok(_endDAO.Delete(endid));
        }

    }
}
