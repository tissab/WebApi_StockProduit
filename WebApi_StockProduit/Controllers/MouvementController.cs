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
    public class MouvementController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;

        public MouvementController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        // GET: api/<MouvementController>
        [HttpGet]
        public IEnumerable<Mouvement> Get()
        {
            return _repository.Mouvement.FindAll();
        }

        // GET api/<MouvementController>/5
        [HttpGet("{id}")]
        public Mouvement Get(Guid id)
        {
            return _repository.Mouvement.FindID(id);
        }

        // POST api/<MouvementController>
        [HttpPost]
        public void Post([FromBody] Mouvement mouvement)
        {
            _repository.Mouvement.Save(mouvement);
        }

        [HttpPut]
        public void Put([FromBody] Mouvement mouvement)
        {
            _repository.Mouvement.Update(mouvement);
        }

        // DELETE api/<MouvementController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _repository.Mouvement.Delete(id);
        }
    }
}
