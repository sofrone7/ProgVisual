using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1
{
    [Serializable()]
    public class ZonaHoraria
    {
        private string m_Nombre = "";
        private TimeSpan m_Diferencia = new TimeSpan(); //Diferencia horaria en segundos
        private bool m_Positivo = true;

        public string Nombre
        {
            get { return m_Nombre; }
            set
            {
                m_Nombre = value;
            }
        }
        public TimeSpan Diferencia
        {
            get { return m_Diferencia; }
            set
            {
                m_Diferencia = value;
            }
        }

        public bool Positivo
        {
            get { return m_Positivo; }
            set
            {
                m_Positivo = value;
            }
        }
    }

}
