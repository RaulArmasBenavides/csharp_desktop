using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdo06.Service
{
    public interface ICrudDao<T>
    {
        void create(T t);
        void update(T t);
        void delete(T t);
        T find(T t);
        List<T> readAll();
    }
}
