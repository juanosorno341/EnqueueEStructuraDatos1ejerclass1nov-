
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnqueueEStructuraDatos1ejerclass1nov_
{
        class Program // este ejercicio solo tiene la clase program
        {
            static void Main(string[] args)  //metodo

            {

                Queue Pila = new Queue();   // aca nos esta diciendo que vamos a crear una pila  CREA la pila

                int opcion;//opcion del menu

                do  // hasta que cumpla la condicion va a ejecutar
                {
                    Console.Clear();//se limpia consola
                    opcion = menu();//muestra menu y espera opción
                    int valor;

                    switch (opcion) //
                    {
                        case 1:
                            Console.Write("\n Ingrese valor: ");
                            valor = int.Parse(Console.ReadLine());
                            try  // este hace la exepcion, sino cumple arroja el catch
                            {
                                if (valor > 99 || valor <= 0)
                                {
                                    Console.WriteLine("\n=======================================================");
                                    Console.WriteLine("Solo números del 1 al 99");
                                    Console.WriteLine("=======================================================");
                                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                    Console.ReadKey();
                                }

                                else
                                {
                                    Pila.Enqueue(valor); // el Push permite ingresar los datos a la pila
                                    if (Pila.Count > 0)
                                    {
                                        Console.WriteLine("");
                                        foreach (int dato in Pila)
                                        {
                                            Console.WriteLine(" |  	|");
                                            if (dato < 10)
                                                Console.WriteLine(" |   {0}  |", dato);
                                            else
                                                Console.WriteLine(" |  {0}  |", dato);
                                            Console.WriteLine(" |______|");
                                        }
                                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine("La Pila esta vacia"); //este es por si la pila esta vacia arroje la informacion
                                    }

                                }
                            }
                            catch
                            {
                                Console.WriteLine("Error: Solo números del 1 al 99");
                            }
                            break; // hace el descanso

                        case 2:
                            if (Pila.Count > 0)
                            {
                                Pila.Dequeue();   // elimina dato de la pila
                                Console.WriteLine("\n=======================================================");
                                Console.WriteLine("Elemento eliminado");                     /*En este Case: 2. Agregue mostrar la Pila para visualizar los elementos almacenados.
                                                                                          * Ademas de usar el Case: 5 al momento de vaciarse la pila nos arrojara el mensaje
                                                                                          * de despedida y con cualquier tecla se finalizara el programa.*/
                                if (Pila.Count > 0)
                                {
                                    Console.WriteLine("");
                                    foreach (int dato in Pila)
                                    {
                                        Console.WriteLine(" |  	|");
                                        if (dato < 10)
                                            Console.WriteLine(" |   {0}  |", dato);
                                        else
                                            Console.WriteLine(" |  {0}  |", dato);
                                        Console.WriteLine(" |______|");
                                    }
                                }
                                Console.WriteLine("=======================================================");
                                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                Console.ReadKey();

                            }
                            else
                            {
                                Console.WriteLine("\n=======================================================");
                                Console.WriteLine("La Pila está vacía");
                                Console.WriteLine("=======================================================");
                                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                Console.WriteLine("                 \n\n\n                      hasta la vista bebe!");
                                Console.ReadKey();

                                // Aquí ejecutamos el "case 5" si no hay elementos en la pila
                                opcion = 5;
                            }
                            break;


                        case 3:
                            if (Pila.Count != 0)
                            {
                                Pila.Clear();  // limpia
                                Console.WriteLine("\n=======================================================");
                                Console.WriteLine("La Pila esta vacia");
                                Console.WriteLine("=======================================================");
                                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("\n=======================================================");
                                Console.WriteLine("La Pila esta vacia");
                                Console.WriteLine("=======================================================");
                                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                Console.ReadKey();
                            }
                            break;

                        case 4:
                            if (Pila.Count > 0)  //Muestra la pila
                            {
                                Console.WriteLine("");
                                foreach (int dato in Pila)
                                {
                                    Console.WriteLine(" |  	|");
                                    if (dato < 10)
                                        Console.WriteLine(" |   {0}  |", dato);
                                    else
                                        Console.WriteLine(" |  {0}  |", dato);
                                    Console.WriteLine(" |______|");
                                }

                            }
                            else
                            {
                                Console.WriteLine("\n=======================================================");
                                Console.WriteLine("La Pila esta vacia");
                                Console.WriteLine("=======================================================");
                                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                            }
                            Console.WriteLine("\nPresione cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;

                        case 5: break;
                        default:
                            Console.WriteLine("ERROR: la opción no es valida. Intente de nuevo.");
                            break;
                    }
                }

                while (opcion != 5);
                {
                    Console.WriteLine("El programa a finalizado.");
                }
            }




            // Metodo para crear Menu 
            static int menu()
            {
                Console.Clear();
                Console.WriteLine("\n           Menu Pila\n");
                Console.WriteLine(" 1. Agregar elemento");
                Console.WriteLine(" 2. Eliminar elemento");
                Console.WriteLine(" 3. Vaciar Pila");
                Console.WriteLine(" 4. Ver pila");
                Console.WriteLine(" 5. Termina programa");
                Console.WriteLine("\n");
                Console.Write(" 	Ingresa tu opción: ");
                try
                {
                    int valor = Convert.ToInt32(Console.ReadLine());
                    return valor;
                }
                catch
                {
                    return 0;
                }

            }

        }
    

}
