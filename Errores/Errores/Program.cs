using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errores
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos una lista de tipo estudiante
            var estudiante = new List<Estudiante>();

            var agregar = true;

            while(agregar)
            {
                

                try
                {
                    //creamos varibles para utilizarlas mas adelantes
                    var E = new Estudiante();
                    int Ma = E.Matricula;

                    //El ususario apartir de aqui introducira sus datos
                    Console.WriteLine("Ingrese Matricula");
                    int Matricula = 0;
                    bool result;
                    //aqui hacemos que al ingresar la matricula pueda ingresar letras pero salga un aviso de que  no puedo si no con puros numeros
                    result = int.TryParse(Console.ReadLine(), out Matricula);

                    if (result == false)
                    {
                        Console.WriteLine("Ingrese un numero");
                        result = int.TryParse(Console.ReadLine(), out Matricula);
                    }
                    //ingresa los demas datos
                    Console.WriteLine("Ingrese Nombre:");
                    E.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese Carrera:");
                    E.Carrera = Console.ReadLine();
                    Console.WriteLine("Ingrese Semestre:");
                    E.Semestre = Convert.ToInt32(Console.ReadLine());
                    estudiante.Add(E);

                   //se evalua si se escriben datos string dentro de una variable int
                    if (Ma == 0)
                    {
                        Console.WriteLine("Ingrese un numero.");
                    }
                    Console.WriteLine("Desea agregar un estudiante mas? Y/N");
                    if(Console.ReadLine( ) != "Y")
                    {
                        agregar = false;
                    }


                }//sale de que los datos ingreso mal y tiene que ponerlos correctamente
                catch(Exception E)
                {
                    Console.WriteLine("Intente nuevamente");
                }
               

            }
            
            Console.ReadKey();

        }
    }
}
