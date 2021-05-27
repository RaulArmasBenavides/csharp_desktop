using Alumnos.Entity;
using Alumnos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alumnos.Controller
{
    public class Alumnobll
    { 
        //variable de la clase MODEL
        AlumnoDao dao;
        // constructor
        public Alumnobll()
        {
            dao = new AlumnoDao();
        }

        // metodos de negocio
        public void AlumnoAdicionar(Alumno pro)
        {
            dao.create(pro);
        }

        public void AlumnoActualizar(Alumno pro)
        {
            dao.update(pro);
        }

        public void AlumnoEliminar(Alumno pro)
        {
            dao.delete(pro);
        }

        public Alumno[] AlumnoListar()
        {
            return dao.readAll();
        }

        public Alumno AlumnoBuscar(int id)
        {
            return dao.findForId(id);
        }

    }
}
