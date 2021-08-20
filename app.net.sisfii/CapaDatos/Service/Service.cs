using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Service
{
    interface Service <T>
    {  //definir la funciones
        void create(T t);
        void update(T t);
        void delete(T t);
        T find(T t);
        List<T> readAll();
    }
}
