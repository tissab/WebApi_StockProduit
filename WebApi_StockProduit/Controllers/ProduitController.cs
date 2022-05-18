using Contrat;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi_StockProduit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitController : ControllerBase
    {

        private readonly IRepositoryWrapper _repository;

        public ProduitController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        // GET: api/<ProduitController>
        [HttpGet]
        public IEnumerable<Produit> Get()
        {
           return _repository.Produit.FindAll();
        }

        // GET api/<ProduitController>/5
        [HttpGet("{id}")]
        public Produit Get(Guid id)
        {
            return _repository.Produit.FindID(id)
        }

        // POST api/<ProduitController>
        [HttpPost]
        public void Post([FromBody] Produit produit)
        {
            _repository.Produit.Save(produit);
        }

        [HttpPut]
        public void Put([FromBody] Produit produit)
        {
            _repository.Produit.Update(produit);
        }

        // DELETE api/<ProduitController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _repository.Produit.Delete(id);
        }
    }
}
