using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrat
{
    public interface IRepositoryWrapper
    {
        IMouvementRepository Mouvement { get; }
        IProduitRepository Produit { get; }
    }
}
