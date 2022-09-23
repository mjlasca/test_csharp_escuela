using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace ETAPA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Escuela  escuela = new Escuela("Platzi School" , "Colombia");
            escuela.TipoEscuela = TiposEscuela.PreEscolar;
            
            escuela.Cursos  =  new Curso[]{
                new Curso(){
                    Nombre = "101"
                },
                new Curso(){
                    Nombre = "102"
                },
                new Curso(){
                    Nombre = "103"
                }
            };
            

            WriteLine(escuela.ToString());      
            WriteLine("---------------------------------------------------------------------------");

            ImprimirArreglo(escuela);
            
            
        }

        private static void ImprimirArreglo(Escuela escuela)
        {
            WriteLine("Cursos de la Escuela");
            WriteLine("-------------LISTA CURSOS--------------");

            if( escuela?.Cursos != null){
                foreach (var item in escuela.Cursos)
                {
                    WriteLine($"Nombre {item.Nombre} : {item.UniqueId} ");    
                }
            }else{
                WriteLine(" NO HAY CURSOS ");
            }
            
        }
    }
}
