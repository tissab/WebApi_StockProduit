using Contrat;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class ProduitRepository : IProduitRepository
    {
        private readonly List<Produit> produits = new()
        {
            new Produit { Id = Guid.NewGuid(), CodeEan = "", Libelle = "", Quantite = 0 },
            new Produit { Id = Guid.NewGuid(), CodeEan = "", Libelle = "", Quantite = 0 },
            new Produit { Id = Guid.NewGuid(), CodeEan = "", Libelle = "", Quantite = 0 },
            new Produit { Id = Guid.NewGuid(), CodeEan = "", Libelle = "", Quantite = 0 }
        };

        public IEnumerable<Produit> FindAll()
        {
            return produits;
        }

        public Produit FindID(Guid id)
        {
            return produits.Where(x => x.Id == id).SingleOrDefault();
        }

        public void Save(Produit produit)
        {
            produits.Add(produit);
        }

        public void Update(Produit produit)
        {
            var index = produits.FindIndex(exist => exist.Id == produit.Id);
            produits[index] = produit;
        }

        public void Delete(Guid Id)
        {
            var index = produits.FindIndex(exist => exist.Id == Id);
            produits.RemoveAt(index);
        }
    }
}
