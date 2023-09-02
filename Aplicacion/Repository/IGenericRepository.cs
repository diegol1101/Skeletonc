using System.Collections;
using System.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Aplicacion.Repository;

    public class IGenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly DbAppContext _context;

        public GenericRepository(DbAppContext context)
        {
            _context = context;
        }

        public virtual void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public virtual void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public virtual IEnumerable<T> Find(Expression<Func<T,bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImpplementedException();
        }

        public virtual void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public virtual void Update(T entity)
        {
            _context.Set<T>()
                .Update(entity);
        }
    }
