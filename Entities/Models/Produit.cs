using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public record Produit
    {
        public Guid Id { get; init; }
        [StringLength(8, ErrorMessage ="Code EAN doit être de taille 8")]
        public string CodeEan { get; init; }
        public string Libelle { get; init; }
        public int Quantite { get; init; }

    }
}
