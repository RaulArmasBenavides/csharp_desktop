using Alumnos.Entity;
using Alumnos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alumnos.Controller
{
    public class Cursobll
    {

        //variable de la clase MODEL
        CursoDao dao;
        // constructor
        public Cursobll()
        {
            dao = new CursoDao();
        }

        // metodos de negocio
        public void CursoAdicionar(Curso pro)
        {
            dao.create(pro);
        }

        public void CursoActualizar(Curso pro)
        {
            dao.update(pro);
        }

        public void CursoEliminar(Curso pro)
        {
            dao.delete(pro);
        }

        public Curso[] CursoListar()
        {
            return dao.readAll();
        }

        public Curso CursoBuscar(int id)
        {
            return dao.findForId(id);
        }
    }
}
