using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDFamosos
{
    public class CFamosoBLL
    {
        private CFamosoDAL bd = new CFamosoDAL();
        public ColCFamosos ObtenerFilasFamosos()
        {
            ColCFamosos coTfnos = bd.ObtenerFilasFamosos();
            return coTfnos;
        }
        public void ActualizarFamosos(CFamosoBO bo)
        {
            bd.ActualizarFamosos(bo);
        }
    }

}
