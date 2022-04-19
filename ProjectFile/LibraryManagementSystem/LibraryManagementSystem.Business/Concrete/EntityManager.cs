using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Concrete
{
    public class EntityManager<T> : IEntityManager<T> where T : class
    {
        private readonly IEntityRepository<T> _repository;
        public EntityManager(IEntityRepository<T> repository)
        {
            _repository = repository;
        }

        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException("item");

            _repository.Add(item);
        }

        public void Delete(int id)
        {
            if (id < 1)
                throw new ArgumentOutOfRangeException("id");

            T item = _repository.Get(id);
            if (item != null)
                _repository.Delete(id);
        }

        public List<T> Find(object item) => _repository.Find(item);

        public T Get(int id)
        {
            if (id < 1)
                throw new ArgumentOutOfRangeException("id");

            T item = _repository.Get(id);
            if (item != null)
                return _repository.Get(id);

            return null;
        }

        public List<T> GetAll(bool active = true) => _repository.GetAll(active);

        public void Update(T item)
        {
            if (item == null)
                throw new ArgumentNullException("item");

            int id = Convert.ToInt32(typeof(T).GetProperty("Id").GetValue(item));
            T data = _repository.Get(id);

            if (data != null)
                _repository.Update(item);
        }
    }
}
