using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdo03.Service
{
    public interface ICrudDao<T>
    {
        //definir las firmas
        int create(T t);
        int update(T t);
        int delete(T t);
        T findForId(object t);
        List<T> readAll();
    }
}
