using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrat
{
    public interface IMouvementRepository
    {
        IEnumerable<Mouvement> FindAll();
        Mouvement FindID(Guid id);
        void Save(Mouvement mouvement);
        void Update(Mouvement mouvement);
        void Delete(Guid Id);
    }
}
