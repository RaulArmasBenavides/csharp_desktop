using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AppRegistroClientes
{
    class Program
    {

        //Método que valida documento DNI o RUC
        public static bool ValidacionDocumentoIdentidad(string documento, string tipo , ref string mensaje)
        {
            try
            {
                if (!string.IsNullOrEmpty(documento))
                {
                    //(1) para DNI
                    if (tipo.Equals("1"))
                    {
                        //el dni debe tener 8 dígitos
                        if(documento.Length != 8)
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
        public static bool ValidarMailDNS(string email, ref string mensaje)
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
                mensaje ="Correo incorrecto. No existe el dominio de este correo " + address + " " + ex.Message;
                return false;
            }

        }
        

        //método para obtener el signo zodiacal de una persona
        public static string ObtenerSignoZodiacal(int dia, int mes)
        {
            string signo = string.Empty; 
            switch (mes)
            {
                case 1:
                    if (dia > 21)
                    {
                        signo = "ACUARIO";
                    }
                    else
                    {
                        signo = "CAPRICORNIO";
                    }
                    break;
                case 2:
                    if (dia > 19)
                    {
                        signo = "PISCIS";
                    }
                    else
                    {
                        signo = "ACUARIO";
                    }
                    break;
                case 3:
                    if (dia > 20)
                    {
                        signo = "ARIES";
                    }
                    else
                    {
                        signo = "PISCIS";
                    }
                    break;
                case 4:
                    if (dia > 20)
                    {
                        signo = "TAURO";
                    }
                    else
                    {
                        signo = "ARIES";
                    }
                    break;
                case 5:
                    if (dia > 21)
                    {
                        signo = "GEMINIS";
                    }
                    else
                    {
                        signo = "TAURO";
                    }
                    break;
                case 6:
                    if (dia > 20)
                    {
                        signo = "CANCER";
                    }
                    else
                    {
                        signo = "GEMINIS";
                    }
                    break;
                case 7:
                    if (dia > 22)
                    {
                        signo = "LEO";
                    }
                    else
                    {
                        signo = "CANCER";
                    }
                    break;
                case 8:
                    if (dia > 21)
                    {
                        signo = "VIRGO";
                    }
                    else
                    {
                        signo = "LEO";
                    }
                    break;
                case 9:
                    if (dia > 22)
                    {
                        signo = "LIBRA";
                    }
                    else
                    {
                        signo = "VIRGO";
                    }
                    break;
                case 10:
                    if (dia > 22)
                    {
                        signo = "ESCORPION";
                    }
                    else
                    {
                        signo = "LIBRA";
                    }
                    break;
                case 11:
                    if (dia > 21)
                    {
                        signo = "SAGITARIO";
                    }
                    else
                    {
                        signo = "ESCORPION";
                    }
                    break;
                case 12:
                    if (dia > 21)
                    {
                        signo = "CAPRICORNIO";
                    }
                    else
                    {
                        signo = "SAGITARIO";
                    }
                    break;
            }

            return signo;
         }


        //APLICACIÓN DE REGISTRO DE DATOS DE CLIENTES
        //Función Principal 
        //Registro de datos de un cliente 
        static void Main(string[] args)
        {
            try
            {
                #region Declaración de variables
                string nombre_cliente = string.Empty;
                string documento = string.Empty;
                string mensaje = string.Empty;
                string mail = string.Empty;
                string tipo_documento = string.Empty;
                string signo_zodiaco = string.Empty;
                string fec_nacimiento = string.Empty;

                int dia = 0;
                int mes = 0;
                int ano = 0;

                bool resultado_ok = true;
                #endregion



                #region Ingreso de datos de Clientes
                Console.WriteLine("Ingresa nombre del cliente");
                nombre_cliente = Console.ReadLine();


                //fecha de nacimiento
                Console.WriteLine("Ingrese su fecha de nacimiento");
                fec_nacimiento = Console.ReadLine();
                DateTime fecha = DateTime.ParseExact(fec_nacimiento, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dia = fecha.Day;
                mes = fecha.Month;
                ano = fecha.Year;

             
                //bucle
                for(;;)
                {
                    //dni o ruc
                    Console.WriteLine("Ingrese documento de identidad: (1) para DNI , (2) para RUC");
                    tipo_documento = Console.ReadLine();

                    if (tipo_documento.Equals("1"))
                    {
                        Console.WriteLine("Ingrese DNI:");
                        documento = Console.ReadLine();
                        break;
                    }
                    else if (tipo_documento.Equals("2"))
                    {
                        Console.WriteLine("Ingrese RUC:");
                        documento = Console.ReadLine();
                        break;

                    }
                    else
                    {
                        Console.WriteLine("No existe el tipo de documento registrado.  Por favor ingrese un tipo de documento válido");
                    }
                  
               }


                //correo
                Console.WriteLine("Ingrese correo electrónico");
                mail = Console.ReadLine();
                #endregion

                #region Validaciones

                if (!ValidacionDocumentoIdentidad(documento, tipo_documento, ref mensaje))
                {
                    Console.WriteLine(" Hubo el siguiente error en la validación del número de documento" + mensaje);
                    resultado_ok = false;
                }

                if (!ValidarMailDNS(mail, ref mensaje))
                {
                    Console.WriteLine(" Hubo el siguiente error en la validación del correo electrónico" + mensaje);
                    resultado_ok = false;
                }

                signo_zodiaco = ObtenerSignoZodiacal(dia, mes);

                #endregion

                //si el resultado es ok , imprimirá los datos
                if(resultado_ok == true)
                {
                    #region Impresión de datos 
                    Console.WriteLine(" Bienvenido :" + nombre_cliente);
                    Console.WriteLine(" Fecha de nacimiento :" + fec_nacimiento);
                    Console.WriteLine(" Número de documento :" + documento);
                    Console.WriteLine(" Correo :" + documento);
                    Console.WriteLine(" Su signo zodiacal es :" + signo_zodiaco);
                    #endregion
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo el siguiente error en la validación del correo electrónico: " + ex.Message);
                Console.ReadLine();
                return;
            }

            Console.ReadLine();
        
        }
    }
}
