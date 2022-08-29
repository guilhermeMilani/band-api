using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Context;
using Data.Model;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual string Create(T entity)
        {
            using (BandaContext bandaContext = new BandaContext())
            {
                bandaContext.Add(entity);
                bandaContext.SaveChanges();
            }
            return "Criado";
        }

        public virtual string Delete(int id)
        {
            using (BandaContext bandaContext = new BandaContext())
            {
                bandaContext.Entry<T>(GetById(id)).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                bandaContext.SaveChanges();
            }
            return "Deletado";
        }

        public virtual List<T> GetAll()
        {
            List<T> bandas = new List<T>();
            using (BandaContext bandaContext = new BandaContext())
            {
                bandas = bandaContext.Set<T>().ToList();
            }
            return bandas;

        }

        public virtual T GetById(int id)
        {
            T entity = null;
            using (BandaContext bandaContext = new BandaContext())
            {
                entity = bandaContext.Set<T>().Find(id);
            }
            return entity;
        }

        public virtual string Update(T entity)
        {
            using (BandaContext bandaContext = new BandaContext())
            {
                bandaContext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                bandaContext.SaveChanges();
            }
            return "Atualizado";
        }
    }
}
