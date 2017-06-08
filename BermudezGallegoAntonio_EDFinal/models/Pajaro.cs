using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BermudezGallegoAntonio_EDFinal.models
{
    class Pajaro:Animal
    {
        private string _especie;
        private Boolean _cantor;

        public string Especie{
            get{
                return _especie;
            }
        }

        public Boolean Cantor{
            get {
                return _cantor;
            }
        }

        public Pajaro(string _especie, Boolean _cantor, string _nombre, string _Fnac, double _peso)
                    :base(_nombre, _Fnac, _peso)
        {
            this._especie = _especie;
            this._cantor = _cantor;
        }

        public override string ToString()
        {
            string cadena = "Ficha de Pájaro\n";

            cadena += "Nombre: " + Nombre + "\n";
            cadena += "Especie: " + _especie + "\n";
            cadena += "Fecha Nacimiento: " + Fnac + "\n";
            cadena += "Peso: " + Peso + "\n";
            cadena += "Cantor: " + _cantor + "\n";
            cadena += "Comentarios: " + Comentario + "\n";

            return cadena;
        }
    }
}
