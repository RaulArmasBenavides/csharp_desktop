using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace appcongreso.Utils
{
    public class Validator
    {


        //Método que valida documento DNI o RUC
        public  bool ValidacionDocumentoIdentidad(string documento, string tipo, ref string mensaje)
        {
            try
            {
                if (!string.IsNullOrEmpty(documento))
                {
                    //(1) para DNI
                    if (tipo.Equals("1"))
                    {
                        //el dni debe tener 8 dígitos
                        if (documento.Length != 8)
                        {
                            mensaje = "El DNI debe tener 8 dígitos";
                            return false;
                        }
                    }
                    //(2) para RUC
                    else if (tipo.Equals("2"))
                    {
                        //el ruc debe tener 11 dígitos
                        if (documento.Length != 11)
                        {
                            mensaje = "El RUC debe tener 11 dígitos";
                            return false;
                        }
                    }
                    else
                    {
                        mensaje = "Solo puede registrar o DNI o RUC. Por favor ingrese un tipo de documento válido";
                        return false;
                    }

                }
                else
                {
                    mensaje = "Debe ingresar un documento no nulo o vacío";
                }
                return true;
            }
            catch (Exception ex)
            {
                //en caso exista algún error
                mensaje = ex.Message;
                return false;
            }
        }


        //validación del dominio del correo  
        public bool ValidarMailDNS(string email, ref string mensaje)
        {
            string address = string.Empty;
            try
            {
                address = email;
                //extraemos el dominio
                var domain = address.Split('@')[1];
                var server = Dns.Resolve(domain);
                //Console.WriteLine("Validación email OK");
                return true;
            }
            catch (Exception ex)
            {
                //si hubiera un error, en caso no encontrase el dominio del correo
                mensaje = "Correo incorrecto. No existe el dominio de este correo " + address + " " + ex.Message;
                return false;
            }

        }


    }
}
