using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BermudezGallegoAntonio_EDFinal.models
{
    class Reptil :Animal
    {
        private string _especie;
        private Boolean _venenoso;

        public string Especie{
            get{
                return _especie;
            }
        }

        public Boolean Venenoso{
            get
            {
                return _venenoso;
            }
        }

        public Reptil(string _especie, Boolean _venenoso, string _nombre, string _Fnac, double _peso)
                    :base(_nombre, _Fnac, _peso)
        {
            this._especie = _especie;
            this._venenoso = _venenoso;
        }

        public override string ToString()
        {
            string cadena = "Ficha de Reptil\n";

            cadena += "Nombre: " + Nombre + "\n";
            cadena += "Especie: " + _especie + "\n";
            cadena += "Fecha Nacimiento: " + Fnac + "\n";
            cadena += "Peso: " + Peso + "\n";
            cadena += "Venenoso: " + _venenoso + "\n";
            cadena += "Comentarios: " + Comentario + "\n";

            return cadena;
        }
    }
}
