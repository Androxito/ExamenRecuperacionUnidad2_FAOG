using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ExamenRecuperacionUnidad2_FAOG
{
    public class Ejercicio
    {
        public void CalificacionesEstudiantes()
        {
            int item;
            int[] arreglo = new int[10];
            //Utilizamos la variable Ramdom
            Random random = new Random();

            for (int i = 0; i < arreglo.Length; i++)
            {
                int calificaciones = random.Next(101);
                arreglo[i] = calificaciones;
            }
            //Metodo Para ordenar las calificaciones
            Console.WriteLine("Estas calificaciones se encuentran Ordenadas");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();
            
            for (int i = 1; i < arreglo.Length; i++)
            {
                for (int j = arreglo.Length - 1; j >= i; j--)
                {
                    if (arreglo[j - 1] < arreglo[j])
                    {
                        item = arreglo[j - 1];
                        arreglo[j - 1] = arreglo[j];
                        arreglo[j] = item;
                    }
                }
            }
            //Metodo para obtener las calificaciones Desordenadas
            Console.WriteLine("Estas calificaciones se encuentran desordenadas");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();
            int numero = 75;
            int inicio = 0;
            int ultimo = arreglo.Length - 1;
            bool bandera = false;

            while (inicio <= ultimo)
            {
                int medio = (inicio + ultimo) / 2;
                if (arreglo[medio] == numero)
                {
                    //Aqui muestra si el numero 75 esta si se encuentra en las calificaciones
                    Console.WriteLine($"El numero {numero} se encuentra en la posicion:  {medio}");
                    bandera = true;
                    break;
                }
                else if (arreglo[medio] < numero)
                {
                    ultimo = medio - 1;
                    medio = (inicio + ultimo) / 2;

                }
                else
                {
                    inicio = medio + 1;
                    medio = (inicio + ultimo) / 2;
                }

            }
            if (!bandera)
            {
                Console.WriteLine($"Lo siento el {numero} no se encuentra en la lista");
            }
        }
        
        public void TablaVendedores()
        {
            Console.WriteLine("Mostrar La lista de los precios de los productos");
            int[,] Tabla = { { 500, 3000, 100, 400 }, { 1000, 150, 200, 500 }, { 250, 1800, 2900, 300 }, { 400, 130, 90, 2400 }, { 60, 20, 4000, 3600 } };
            
            for(int Filas = 0; Filas < Tabla.GetLength(0); Filas++)
            {
                for(int Columnas = 0; Columnas < Tabla.GetLength(1); Columnas++)
                {
                    Console.WriteLine(Tabla[Filas,Columnas] + " " + "\n");
                }
            }
            Console.WriteLine("Lista de Vendedores");
            Console.WriteLine($"\n El vendedor 1 Al finalizar el dia Obtuvo en total {Tabla[0,0]+ Tabla[1,0] + Tabla[2,0] + Tabla[3,0] + Tabla[4,0]}");
            Console.WriteLine($"\n El vendedor 2 Al  finalizar el dia Obtuvo en total {Tabla[0,1]+ Tabla[2,1] + Tabla[2,2] + Tabla[3,1] + Tabla[4,1]}");
            Console.WriteLine($"\n El vendedor 3 Al Finalizar el dia Obtuvo en total de ganancia {Tabla[0,2] + Tabla[1,2]+Tabla[2,2] + Tabla[3,2] + Tabla[4,2]}");
            Console.WriteLine($"\n El vendedor 4 Al Finalizar el dia Obtuvo en total de Ganancia {Tabla[0,3] + Tabla[1,3] + Tabla[2,3] + Tabla[3,3] + Tabla[4,3]}");

            Console.WriteLine("Lista de Valor total de lo que genereraron los productos");
            Console.WriteLine($"\n El Producto 1 Genero Un total de {Tabla[0,0] + Tabla[0,1] + Tabla[0,2] + Tabla[0,3]}");
            Console.WriteLine($"\n El producto 2 Genero Un total de: {Tabla[1,0] + Tabla[1,1] + Tabla[1,2] + Tabla[1,3]}");
            Console.WriteLine( $"\n El Producto 3 Genero Un total de: {Tabla[2,0] + Tabla[2,1] + Tabla[2,2] + Tabla[2,3]}");
            Console.WriteLine($"\n El producto 4 Genero Un total de: {Tabla[3,0] + Tabla[3,1] + Tabla[3,2] + Tabla[3,3]}");
            Console.WriteLine($"\n El producto 5 Genero Un total de: {Tabla[4,0] + Tabla[4,1] + Tabla[4,2] + Tabla[4,3]}");
        }

        public void VerificadorCurp()
        {
            Console.WriteLine("Ingresa Todos Los elementos de la CURP");
            string Curp = Console.ReadLine();

            if( Curp.Length >= 18)
            {
                string FechaNacimiento = Curp.Substring(4, 6);
                string Genero = Curp.Substring(10,1);

                string FechaNacimientoCompleto = FechaNacimiento.Substring(4, 2) + "/" + FechaNacimiento.Substring(2,2) + "/" + FechaNacimiento.Substring(0,2);
                string generoCompleto = (Genero == "H") ? "Hombre" : (Genero == "M") ? "Mujer" : "no identificado";

                       Console.WriteLine($"Sexo: {generoCompleto}");
                       Console.WriteLine($"Fecha De Nacimineto: {FechaNacimientoCompleto}");
                
            }
            else
            {
                Console.WriteLine($"Perdona Tu Curp No es Valida {Curp}");
            }

        }











       
































    }
}
