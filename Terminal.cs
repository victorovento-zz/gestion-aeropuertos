using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aeropuerto
{
    class Terminal
    {
        private string numeroTerminal;
        private string nombreTerminal;

        public Terminal(string numeroTerminal, string nombreTerminal)
        {
            this.NumeroTerminal = numeroTerminal;
            this.NombreTerminal = nombreTerminal;
        }

        public string NumeroTerminal { get => numeroTerminal; set => numeroTerminal = value; }
        public string NombreTerminal { get => nombreTerminal; set => nombreTerminal = value; }
    }
}
