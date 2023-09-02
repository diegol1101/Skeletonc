using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;

namespace Dominio.Interfaces
{
    public interface IPaisRepository : IGenericRepository<Pais>, IPaisRepository
    {
        public IPaisRepository(DbAppContext context) : base(context)
        {

        }
    }
}