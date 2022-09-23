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
            
            Curso [] arrC  =  new Curso[3];

            arrC[0] = new Curso(){
                Nombre = "101",
            };
            arrC[1] = new Curso(){
                Nombre = "102",
            };
            arrC[2] = new Curso(){
                Nombre = "103",
            };

            Console.WriteLine(escuela.ToString());      
            Console.WriteLine("---------------------------------------------------------------------------");      
            ImprimirArreglo(arrC);
            
            
        }

        private static void ImprimirArreglo(Curso[] arrC)
        {
            foreach (var item in arrC)
            {
                Console.WriteLine($" Curso 1 : {item.Nombre} ID : {item.UniqueId} " );    
            }
        }
    }
}
