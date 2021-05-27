using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appcongreso.Service
{
    interface Service <T>
    {
        void create(T t);
        void update(T t);
        void delete(T t);
        T find(T t);
        List<T> readAll();
    }
}
