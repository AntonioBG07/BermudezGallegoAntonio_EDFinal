using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BermudezGallegoAntonio_EDFinal.models
{
    class Gato:Animal
    {
        private string _raza;
        private string _microChip;

        public string Raza{
            get{
                return _raza;
            }
        }

        public string MicroChip{
            get {
                return _microChip;
            }
        }

        public Gato(string _raza, string _microChip, string _nombre, string _Fnac, double _peso)
                    :base(_nombre, _Fnac, _peso)
        {
            this._raza = _raza;
            this._microChip = _microChip;
        }

        public override string ToString()
        {
            string cadena = "Ficha de Gato\n";

            cadena += "Nombre: " + Nombre + "\n";
            cadena += "Raza: " + _raza + "\n";
            cadena += "Fecha Nacimiento: " + Fnac + "\n";
            cadena += "Peso: " + Peso + "\n";
            cadena += "Microchip: " + _microChip + "\n";
            cadena += "Comentarios: " + Comentario + "\n";

            return cadena;
        }
    }
}
