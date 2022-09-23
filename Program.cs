using System;
using CoreEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;

namespace ETAPA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Escuela  escuela = new Escuela("Platzi School" , "Colombia");
            escuela.TipoEscuela = TiposEscuela.PreEscolar;

            escuela.Cursos = new List<Curso>(){
                new Curso(){
                    Nombre = "101",
                    Jornada = TiposJornada.Mañana
                },
                new Curso(){
                    Nombre = "201",
                    Jornada = TiposJornada.Tarde
                },
                new Curso(){
                    Nombre = "301",
                    Jornada = TiposJornada.Noche
                }
            };

            escuela.Cursos.Add(
                new Curso(){
                    Nombre = "102",
                    Jornada = TiposJornada.Mañana
                }
            );

            var masCursos =  new List<Curso>(){
                new Curso(){
                    Nombre = "103",
                    Jornada = TiposJornada.Mañana
                },
                new Curso(){
                    Nombre = "302",
                    Jornada = TiposJornada.Tarde
                },
                new Curso(){
                    Nombre = "302",
                    Jornada = TiposJornada.Noche
                }
            };


            escuela.Cursos.AddRange(masCursos);
            
            ImprimirCursos(escuela);

            escuela.Cursos.RemoveAll( (cur) => cur.Nombre == "302"  && cur.Jornada == TiposJornada.Tarde );
            

            WriteLine("\n----------------------------------------\n");
            ImprimirCursos(escuela);

            

            
            
        }

        private static void ImprimirCursos(Escuela escuela)
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
