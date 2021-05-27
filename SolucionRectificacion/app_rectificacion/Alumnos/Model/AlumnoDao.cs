using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alumnos.Service;
using Alumnos.Entity;
namespace Alumnos.Model
{
    public class AlumnoDao:Service<Alumno>
    {
        //variables
        Alumno[] lista = new Alumno[100];
        static int n = 0, cont = 0;

        //METODOS DE PERSISTENCIA DE DATOS EN MEMORIA
        public void create(Alumno o)
        {
            cont++;
            o.codigo = cont;  // genera codigo de producto
            lista[n] = o; // aqui guarda producto en el arreglo lista
            n++;
        }

        public void delete(Alumno o)
        {
            for (int i = 0; i < n; i++)
            {
                if (lista[i].codigo == o.codigo)
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

        public Alumno findForId(int o)
        {
            for (int i = 0; i < n; i++)
            {
                if (lista[i].codigo == o)
                {
                    return lista[i];
                }
            }
            return null;
        }

        public Alumno[] readAll()
        {
            Alumno[] temp;
            if (n ==100)
            {
                temp = lista;
            }
            else
            {
                temp = new Alumno[n];
                Array.Copy(lista, temp, n);
            }
            return temp;
        }

        public void update(Alumno o)
        {
            int index = 0;
            foreach (var item in lista)
            {
                if (item.codigo == o.codigo)
                {
                    lista[index] = o; // aqui actualiza
                    break;
                }
                index++;
            }
        }


    }
}
