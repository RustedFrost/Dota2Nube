using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Provider
{
    
    public class Tournament
    {
        public Dota2NubeEntities db = new Dota2NubeEntities();
        public List<Entities.Tournament> GetAllTournaments()
        {
            return db.Tournament.ToList();
        }
    }
}
