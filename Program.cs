// See https://aka.ms/new-console-template for more information
using System;

namespace CoreEscuela{
    class Escuela{
        public string nombre;
        public string dirrecion;
        public int AñoFundacion;   
        public string ceo;
        public void Timbrar(){
            //Todo
            Console.Beep(2000, 3000);
        }
    }

    class Program
    {
        static void Main(string[] args){

            var miEscuela = new Escuela();
            miEscuela.nombre = "Hodwards";
            miEscuela.dirrecion = "Muy Lejos";
            miEscuela.AñoFundacion = 2000;
            Console.WriteLine("QUE SUENE PERROS");
            miEscuela.Timbrar();
            //Console.WriteLine("Hello world");
        }
    }
}