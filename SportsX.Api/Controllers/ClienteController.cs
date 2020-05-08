using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportsX.Api.Models;
using SportsX.Domain.Entities;
using SportsX.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace SportsX.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IRepositoryBase<Cliente> _clienteRepository;

        public ClienteController(IRepositoryBase<Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;

        }

        /// <summary>
        /// Obtem todos os cliente cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        [Route("getall")]
        public IActionResult GetAll()
        {
            IEnumerable<Cliente> clientes = _clienteRepository.GetAll();

            return Ok(clientes);
        }

        /// <summary>
        /// Obtem um cliente pelo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Cliente</returns>
        [HttpGet("{id}", Name = "Get")]
        [AllowAnonymous]
        public IActionResult Get(Guid id)
        {
            var cliente = _clienteRepository.GetById(id);

            if (cliente == null)
                return NotFound("Cliente não encontrado");

            return Ok(cliente);
        }

        /// <summary>
        /// Adiciona um novo cliente
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Post(ClienteRequestModel model)
        {
            var pessoaFisica = new PessoaFisica(model.PessoaFisica.Nome, model.PessoaFisica.Cpf);

            var endereco = new Endereco(model.Endereco.Cep, model.Endereco.Rua, model.Endereco.Bairro, model.Endereco.Cidade,
                model.Endereco.Numero, model.Endereco.Complemento);

            List<Telefone> telefones = new List<Telefone>();

            foreach (var item in model.Telefones)
            {
                var telefone = new Telefone(item.Numero, item.TipoTelefone);
                telefones.Add(telefone);
            }

            var cliente = new Cliente(model.Nome, pessoaFisica, model.Classificacao, model.Email, endereco, telefones);

            try
            {
                _clienteRepository.Add(cliente);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

            return CreatedAtRoute(
                  "Get",
                  new { Id = cliente.Id },
                  cliente);

        }

        /// <summary>
        /// Altera um cliente existente no sistema
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [AllowAnonymous]
        public IActionResult Put(ClientePutRequestModel model)
        {
            if (model == null)
            {
                return BadRequest("Cliente não pode ser vazio");
            }

            var pessoaFisica = new PessoaFisica(model.PessoaFisica.Id,model.PessoaFisica.Nome, model.PessoaFisica.Cpf);

            var endereco = new Endereco(model.Endereco.Id,model.Endereco.Cep, model.Endereco.Rua, model.Endereco.Bairro, model.Endereco.Cidade,
                model.Endereco.Numero, model.Endereco.Complemento);

            List<Telefone> telefones = new List<Telefone>();

            foreach (var item in model.Telefones)
            {
                var telefone = new Telefone(item.Id,item.Numero, item.TipoTelefone);
                telefones.Add(telefone);
            }

            var cliente = new Cliente(model.Id,model.Nome, pessoaFisica, model.Classificacao, model.Email, endereco, telefones);

            _clienteRepository.Update(cliente);

            return NoContent();
        }



        /// <summary>
        /// Remove um cliente pelo identificador
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public IActionResult Delete(Guid id)
        {
            var cliente = _clienteRepository.GetById(id);

            if (cliente == null)
                return NotFound("Cliente não encontrado");

            _clienteRepository.Remove(id);

            return NoContent();

        }
    }
}