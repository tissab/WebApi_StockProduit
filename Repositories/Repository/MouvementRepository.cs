using Contrat;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class MouvementRepository : IMouvementRepository
    {
        private readonly List<Mouvement> mouvements = new()
        {
            new Mouvement { Id = Guid.NewGuid(),Libelle = "",Date = DateTime.Now },
            new Mouvement { Id = Guid.NewGuid(),Libelle = "",Date = DateTime.Now },
            new Mouvement { Id = Guid.NewGuid(),Libelle = "",Date = DateTime.Now },
            new Mouvement { Id = Guid.NewGuid(),Libelle = "",Date = DateTime.Now }
        };

        public void Delete(Guid Id)
        {
            var index = mouvements.FindIndex(exist => exist.Id == Id);
            mouvements.RemoveAt(index);
        }

        public IEnumerable<Mouvement> FindAll()
        {
            return mouvements;
        }

        public Mouvement FindID(Guid id)
        {
            return mouvements.Where(x => x.Id == id).SingleOrDefault();
        }

        public void Save(Mouvement t)
        {
            mouvements.Add(t);
        }

        public void Update(Mouvement t)
        {
            var index = mouvements.FindIndex(exist => exist.Id == t.Id);
            mouvements[index] = t;
        }

        IEnumerable<Mouvement> IMouvementRepository.FindAll()
        {
            throw new NotImplementedException();
        }

        Mouvement IMouvementRepository.FindID(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
