using _2014139910_ENT;
using _2014139910_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139910_PER.Repositories
{
    public class TripulacionRepository : Repository<Tripulacion>, ITripulacionRepository
    {
        public TripulacionRepository(DbContext context) : base(context)
        {
        }

    }
}
