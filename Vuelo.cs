using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aeropuerto
{
    class Vuelo
    {
        private bool isInternacional;
        private bool isArribo;
        private string fecha;
        private string numeroTerminal;
        private string pais;
        private string ciudad;
        private string cantKM;
        private int CAO;
        private string numeroMatricula;
        public float precio;

        public Vuelo(bool isInternacional, bool isArribo, string fecha, string numeroTerminal, string pais, string ciudad, string cantKM, int cAO, string numeroMatricula, float precio)
        {
            this.isInternacional = isInternacional;
            this.isArribo = isArribo;
            this.fecha = fecha;
            this.numeroTerminal = numeroTerminal;
            this.pais = pais;
            this.ciudad = ciudad;
            this.cantKM = cantKM;
            CAO = cAO;
            this.numeroMatricula = numeroMatricula;
            this.precio = precio;
        }


    }
}
