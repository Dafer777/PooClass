using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOClass
{
    class Patient
    {
        //definir miembros de la clase
        //propiedades,atributos datos
        private string _name;
        private string _NumberPhone;
        private string _Years;
        private string _sickNess;

        
        public Patient()
        { }
        public Patient(string name, string numberPhone, string years, string sick) //Metodo contructor
        {
            _name = name;
            _NumberPhone = numberPhone;
            _Years = years;
            _sickNess = sick;

        }

        //Nombre
        public void setName(string name)
        {
            _name = name;
        }

        public string getName()
        {
            return _name;
        }

        //NumberPhone
        public void setNumber(string numberPhone)
        {
            _NumberPhone = numberPhone;
        }

        public string getNumber()
        {
            return _NumberPhone;
        }

        // Años
        public void setYears(string years)
        {
            _Years = years;
        }

        public string getYears()
        {
            return _Years;
        }

        //Enfermedad
        public void setSick(string sick)
        {
            _sickNess = sick;
        }

        public string getSick()
        {
            return _sickNess;
        }

        //Metodo
        public string getDates()
        {
            return "Nombre: " + _name +"Años: "+_Years+"Numero de telefono"+_NumberPhone+"Enfermedad"+_sickNess;
        }
        
        

    }
}
