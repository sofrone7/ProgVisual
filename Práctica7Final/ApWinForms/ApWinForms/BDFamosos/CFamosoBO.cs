using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BDFamosos
{
    public class CFamosoBO //: INotifyPropertyChanged
    {
        // Propiedades relacionadas con la tabla famoso
        private int ID;
        public int Id
        {
            get { return ID; }
            set
            {
                ID = value;
                modificado = true;
                //OnPropertyChanged(new PropertyChangedEventArgs("Id"));
            }
        }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                modificado = true;
                //OnPropertyChanged(new PropertyChangedEventArgs("Nombre"));
            }
        }
        private string apellidos;
        public string Apellidos
        {
            get { return apellidos; }
            set
            {
                apellidos = value;
                modificado = true;
                //OnPropertyChanged(new PropertyChangedEventArgs("Apellidos"));
            }
        }
        private DateTime cumple;
        public DateTime Cumple
        {
            get { return cumple; }
            set
            {
                cumple = value;
                modificado = true;
                //OnPropertyChanged(new PropertyChangedEventArgs("Cumple"));
            }
        }
        private string imagen;
        public string Imagen
        {
            get { return imagen; }
            set
            {
                imagen = value;
                modificado = true;
                //OnPropertyChanged(new PropertyChangedEventArgs("Imagen"));
            }
        }
        // Añadir el resto de las propiedades
        // Constructores
        public CFamosoBO() { }
        public CFamosoBO(int id, string nom, string ape, DateTime cum, string ima = null)
        {
            Id = id; Nombre = nom; Apellidos = ape; Cumple = cum; Imagen = ima;
        }
        // Otras propiedades
        private bool modificado;
        public bool Modificado
        {
            get { return modificado; }
            set { modificado = value; }
        }
        public string Edad
        {
            get // complete el código
            {
                DateTime hoy = DateTime.Today;
                int edad = hoy.Year - cumple.Year;
                if (cumple.Date > hoy.AddYears(-edad)) --edad;
                return String.Format("{0}", edad);
            }
        }
        public string NombreAprellidosEdad
        {
            get
            {
                return String.Format("{0}, {1} ({2})", apellidos, nombre, Edad);
                // Devolver un string de la forma, p.ej.: Lawrence, Jennifer (22)
            }
        }
        // Implementación de la interfaz INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e); // generar evento
            }
        }
    }

}
