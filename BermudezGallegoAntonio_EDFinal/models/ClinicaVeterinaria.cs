using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BermudezGallegoAntonio_EDFinal.models
{
    class ClinicaVeterinaria
    {
        IList<Animal> miVeterinaria;

        public ClinicaVeterinaria()
        {
            miVeterinaria = new List<Animal>();
        }

        public void insertAnimal(Animal a) {
            miVeterinaria.Add(a);
            Console.WriteLine(">Añadido<");
        }

        public Animal buscarAnimal(string nom) {

            Animal wanted = null;

            foreach (Animal aux in miVeterinaria) {
                if (aux.Nombre.Equals(nom)) {
                    wanted = aux;
                }
            }

            if(wanted == null){
                throw new Exception("[ERROR].-No se ha encontrado");
            }

            return wanted;
        }

        public void ModificarComentarioAnimal(string nom, string comen) {

            foreach (Animal aux in miVeterinaria){
                if (aux.Nombre.Equals(nom)){
                    aux.Comentario = comen;
                }
            }
            Console.WriteLine(">Modificado<");
        }

        public override string ToString(){
            string cadena = ">Lista Animales<\n";
            int i = 1;

            foreach (Animal aux in miVeterinaria){
                cadena += i+ ".- " +aux +".\n";
                i += 1;
            }

            return cadena;
        }

        }
}
