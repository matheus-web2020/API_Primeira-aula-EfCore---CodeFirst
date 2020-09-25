﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_EfCore.Domains;
using EfCore.Interfaces;
using EfCore.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EfCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;   
        public ProdutosController()
        {
            _produtoRepository = new ProdutoRepository();
        }

        // GET: api/<ProdutosController>
        [HttpGet]
        public List<Produto> Get()
        {
            return _produtoRepository.Listar();
        }

        // GET api/<ProdutosController>/5
        [HttpGet("{id}")]
        public Produto Get(Guid id)
        {
            return _produtoRepository.BuscarPorId(id);
        }

        // POST api/<ProdutosController>
        [HttpPost]
        public void Post(Produto produto)
        {
             _produtoRepository.Adicionar(produto);
        }

        // PUT api/<ProdutosController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, Produto produto)
        {
            produto.Id = id;
             _produtoRepository.Editar(produto);
        }

        // DELETE api/<ProdutosController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _produtoRepository.Remover(id);
        }
    }
}
