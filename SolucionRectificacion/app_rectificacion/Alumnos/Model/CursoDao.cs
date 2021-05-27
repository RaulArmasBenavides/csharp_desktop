using Alumnos.Entity;
using Alumnos.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alumnos.Model
{
    public class CursoDao: Service<Curso>
    {
        //variables
        Curso[] lista = new Curso[100];
        static int n = 0, cont = 0;

        //METODOS DE PERSISTENCIA DE DATOS EN MEMORIA
   
        public Curso findForId(int o)
        {
            for (int i = 0; i < n; i++)
            {
                if (lista[i].codigocurso == o)
                {
                    return lista[i];
                }
            }
            return null;
        }

        public void update(Curso o)
        {
            int index = 0;
            foreach (var item in lista)
            {
                if (item.codigocurso == o.codigocurso)
                {
                    lista[index] = o; // aqui actualiza
                    break;
                }
                index++;
            }
        }

        public void create(Curso o)
        {
            cont++;
            o.codigocurso = cont;  // genera codigo de producto
            lista[n] = o; // aqui guarda producto en el arreglo lista
            n++;
        }


      public void delete(Curso o)
        {
            for (int i = 0; i < n; i++)
            {
                if (lista[i].codigocurso == o.codigocurso)
                {
                    //aqui elimina
                    for (int j = i; j < n; j++)
                    {
                        lista[j] = lista[j + 1];
                    }
                    n--;
                    break;
                }
            }
        }
    
       public Curso[]  readAll()
        {
            Curso[] temp;
            if (n == 100)
            {
                temp = lista;
            }
            else
            {
                temp = new Curso[n];
                Array.Copy(lista, temp, n);
            }
            return temp;
        }
    }
}
