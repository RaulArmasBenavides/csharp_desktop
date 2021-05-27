using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alumnos.Service
{
    public interface Service<T>
    {
        //definir las firmas
        void create(T o);
        void update(T o);
        void delete(T o);
        T findForId(int o);
        T[] readAll();
    }
}
