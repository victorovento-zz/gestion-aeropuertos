using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aeropuerto
{
    class Aviones
    {
        private string numeroMatricula;
        private string modelo;
        private int cantAsientosTotales;
        private string nombreFabricante;
        private string paisFabricante;

        public Aviones(string numeroMatricula, string modelo, int cantAsientosTotales, string nombreFabricante, string paisFabricante)
        {
            this.NumeroMatricula = numeroMatricula;
            this.Modelo = modelo;
            this.CantAsientosTotales = cantAsientosTotales;
            this.NombreFabricante = nombreFabricante;
            this.PaisFabricante = paisFabricante;
        }

        public string NumeroMatricula { get => numeroMatricula; set => numeroMatricula = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int CantAsientosTotales { get => cantAsientosTotales; set => cantAsientosTotales = value; }
        public string NombreFabricante { get => nombreFabricante; set => nombreFabricante = value; }
        public string PaisFabricante { get => paisFabricante; set => paisFabricante = value; }
    }
}
