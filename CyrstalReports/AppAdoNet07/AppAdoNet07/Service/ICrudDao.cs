using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdoNet07.Service
{
    public interface ICrudDao<T>
    {
        //definir las firmas
        bool create(T t);
        bool update(T t);
        bool delete(T t);
        List<T> readAll();
        T findForId(object t);
    }
}
