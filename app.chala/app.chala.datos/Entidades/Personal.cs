using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.cochachi.datos.Entidades
{
    public class Personal
    {

        //constructor , inicializa los datos miembro del objeto 
        public Personal()
        {//inicializar por defecto las variables 

            this.IdEmpleado = 0;
            this.Nombre1 = string.Empty;
            this.Nombre2 = string.Empty;
            this.Nombre3 = string.Empty;
            this.ApeMat = string.Empty;
            this.ApePat = string.Empty;
            this.Correo = string.Empty;
            this.CtaAbono = string.Empty;
            this.Domicilio = string.Empty;
            this.Telf1 = string.Empty;
            this.Telf2 = string.Empty;
            this.Telf3 = string.Empty;

        }

        //datos miembros del objeto 
        public int IdEmpleado { get; set; }
        public string ApePat { get; set; }

        public string ApeMat { get; set; }

        public string Nombre1 { get; set; }

        public string Nombre2 { get; set; }

        public string Nombre3 { get; set; }

        public string Domicilio { get; set; }

        public string CtaAbono { get; set; }

        public string Correo { get; set; }

        public string Telf1 { get; set; }

        public string Telf2 { get; set; }

        public string Telf3 { get; set; }


    }


 }

