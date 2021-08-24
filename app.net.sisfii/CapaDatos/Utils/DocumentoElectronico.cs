using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appcongreso.Utils
{
    public class DocumentoElectronico
    {

        public DocumentoElectronico()
        {
            archivoFisico = new byte[0];
            nombreArchivo = "";
      
        }

        public byte[] archivoFisico { get; set; }
        public string nombreArchivo { get; set; }
    }
}
