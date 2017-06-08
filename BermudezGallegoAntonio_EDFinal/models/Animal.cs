using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BermudezGallegoAntonio_EDFinal.interfaces;

namespace BermudezGallegoAntonio_EDFinal.models
{
    abstract class Animal : interfaces.IPesable
    {
        private string _nombre;
        private string _Fnac;
        private double _peso;
        private string _comentario;

        public string Nombre{
            get{
                return _nombre;
            }

            
        }

        public string Fnac {
            get {
                return _Fnac;
            }

            
        }

        public double Peso{
            get{
                return _peso;
            }

            
        }

        public string Comentario {
            get{
                return _comentario;
            }

            set{
                _comentario = value;
            }
        }

        //constructor
        public Animal(string _nombre, string _Fnac, double _peso, string _comentario){
            this._nombre = _nombre;
            this._Fnac = _Fnac;
            Pesar(_peso);
            this.Comentario = _comentario;
        }

        public Animal(string _nombre, string _Fnac, double _peso)
        {
            this._nombre = _nombre;
            this._Fnac = _Fnac;
            this._peso = _peso;
        }

        //metodo validacion
        public void Pesar(double pes) {

            if (pes < 0){
                throw new Exception("[ERROR].-No puede pesar menos de 0");
            }
            
            _peso =  pes;
            Console.WriteLine(">Pesado<");
        }

        void IPesable.Pesar(double ps){
            this._peso = ps;
        }
    }
}
