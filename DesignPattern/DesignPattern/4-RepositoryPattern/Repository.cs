using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern._4_RepositoryPattern
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DesignPatternsContext _context;
        private DbSet<TEntity> _dbSet;

        public Repository(DesignPatternsContext _context)
        {
            _context = _context;
            _dbSet = _context.Set<TEntity>();
        }

        public void Add(TEntity data) => _dbSet.Add(data);
        
        public IEnumerable<TEntity> GetAll() => _dbSet.ToList();
        public TEntity GetById(int id) => _dbSet.Find(id);        
        public void Save() => _context.SaveChanges();
        public void Update(TEntity data)
        {
            _dbSet.Attach(data);
            _context.Entry(data).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            var dataToDelete = _dbSet.Find(id);
            _dbSet.Remove(dataToDelete);
        }
    }
    
}
