using Microsoft.AspNetCore.Mvc;
using SportsX.Domain.Entities;
using SportsX.Domain.Interfaces;
using SportsX.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SportsX.Mvc.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IRepositoryBase<Cliente> _clienteRepository;

        public ClienteController(IRepositoryBase<Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;

        }

        /// <summary>
        /// Listagem de clientes
        /// </summary>
        /// <returns>Lista de Clientes</returns>
        public ActionResult Index()
        {
            IEnumerable<Cliente> clientes = _clienteRepository.GetAll();

            return View(clientes);
        }


        /// <summary>
        /// Obtem um cliente pelo Id
        /// </summary>
        /// <param name="id">Id do cliente</param>
        /// <returns>Cliente</returns>
        public ActionResult Details(Guid id)
        {
            var cliente = _clienteRepository.GetById(id);

            if (cliente == null)
                return NotFound("Cliente não encontrado");

            return View(cliente);
        }

        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Cria um cliente
        /// </summary>
        /// <param name="model">Modelo de um cliente</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(ClienteRequestModel model)
        {
            model.Endereco.Cep = Regex.Replace(model.Endereco.Cep, "[^0-9a-zA-Z]+", "");

            model.PessoaFisica.Cpf = Regex.Replace(model.PessoaFisica.Cpf, "[^0-9a-zA-Z]+", "");

            var pessoaFisica = new PessoaFisica(model.Nome, model.PessoaFisica.Cpf);

            var endereco = new Endereco(model.Endereco.Cep, model.Endereco.Rua, model.Endereco.Bairro, model.Endereco.Cidade,
                model.Endereco.Numero, model.Endereco.Complemento);

            List<Telefone> telefones = new List<Telefone>();

            foreach (var item in model.Telefones)
            {
                if (item.Numero != null)
                {
                    var telefone = new Telefone(item.Numero, item.TipoTelefone);
                    telefones.Add(telefone);
                }
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

            return RedirectToAction("Index");
        }


        public ActionResult CreatePJ()
        {
            return View();
        }


        /// <summary>
        /// Cria um cliente PJ
        /// </summary>
        /// <param name="model">Modelo de um cliente PJ</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CreatePJ(ClientePJRequestModel model)
        {
            model.Endereco.Cep = Regex.Replace(model.Endereco.Cep, "[^0-9a-zA-Z]+", "");

            model.PessoaJuridica.Cnpj = Regex.Replace(model.PessoaJuridica.Cnpj, "[^0-9a-zA-Z]+", "");

            var pessoaFisica = new PessoaJuridica(model.PessoaJuridica.Cnpj, model.PessoaJuridica.RazaoSocial);

            var endereco = new Endereco(model.Endereco.Cep, model.Endereco.Rua, model.Endereco.Bairro, model.Endereco.Cidade,
                model.Endereco.Numero, model.Endereco.Complemento);

            List<Telefone> telefones = new List<Telefone>();

            foreach (var item in model.Telefones)
            {
                if (item.Numero != null)
                {
                    var telefone = new Telefone(item.Numero, item.TipoTelefone);
                    telefones.Add(telefone);
                }
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

            return RedirectToAction("Index");
        }


        public ActionResult Deletar(Guid id)
        {
            var cliente = _clienteRepository.GetById(id);

            if (cliente == null)
                return NotFound("Cliente não encontrado");

            _clienteRepository.Remove(id);

            return RedirectToAction("Index");

        }
    }
}