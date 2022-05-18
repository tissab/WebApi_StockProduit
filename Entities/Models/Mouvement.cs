using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public record Mouvement
    {
        public Guid Id { get; init; }
        public string Libelle { get; init; }
        public DateTime Date { get; init; }
        public ICollection<Produit>? Produits { get; init; }
    }
}
