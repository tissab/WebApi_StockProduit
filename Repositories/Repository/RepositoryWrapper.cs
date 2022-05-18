using Contrat;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private IProduitRepository _produit;
        private IMouvementRepository _mouvement;

        public IProduitRepository Produit
        {
            get
            {
                if(_produit is null)
                {
                    _produit = new ProduitRepository();
                }
                return _produit;
            }
        }

        public IMouvementRepository Mouvement
        {
            get
            {
                if (_mouvement is null)
                {
                    _mouvement = new MouvementRepository();
                }
                return _mouvement;
            }
        }
    }
}
