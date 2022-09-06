using System;
using CoreEscuela.Entidades;

namespace ETAPA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Escuela  escuela = new Escuela("Platzi School" , "Colombia");
            escuela.TipoEscuela = TiposEscuela.PreEscolar;

            Curso curso1 = new Curso(){
                Nombre = "101",
            };
            Curso curso2 = new Curso(){
                Nombre = "102",
            };
            Curso curso3 = new Curso(){
                Nombre = "103",
            };
            

            Console.WriteLine(escuela.ToString());      
            Console.WriteLine("---------------------------------------------------------------------------");      
            Console.WriteLine($" Curso 1 : {curso1.Nombre} ID : {curso1.UniqueId} " );
            Console.WriteLine($" Curso 2 : {curso2.Nombre} ID : {curso2.UniqueId} " );
        }
    }
}
