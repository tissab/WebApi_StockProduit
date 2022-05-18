using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrat
{
    public interface IProduitRepository
    {
        IEnumerable<Produit> FindAll();
        Produit FindID(Guid id);
        void Save(Produit produit);
        void Update(Produit produit);
        void Delete(Guid Id);
    }
}
