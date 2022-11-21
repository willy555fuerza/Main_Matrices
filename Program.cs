using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MENU DE OPCIONES
            int opcion;
            Random aleatorio = new Random();
            int n, m ,aux;
            int[,] matriz = new int[100, 100];
            Random rnd = new Random();

            do
            {
                Console.Clear();
                Console.WriteLine("**********************************************************************************************************");
                Console.WriteLine("MENU DE OPCIONES                                              THE BEST COMPANY WILLSTARS                 *");
                Console.WriteLine("**********************************************************************************************************");
                Console.WriteLine("1 MATRIZ CARGADO AL AZAR                       ***********************************************************");
                Console.WriteLine("2 MATRIZ FOBONACCI                             *******   ***************   *****   ***********************");
                Console.WriteLine("3 MATRIZ CERO                                  ********   *************   ******   ***********************");//mal
                Console.WriteLine("4 MATRIZ CARACOL                               *********   ***********   *******   ***********************");
                Console.WriteLine("5 MATRIZ SIMETRICA                             **********   *********   ********   ***********************");
                Console.WriteLine("6 MATRIZ CON 0 ALREDEDOR                       ***********   *******   *********   ***********************");
                Console.WriteLine("7 MATRIZ DIAGONAL                              ************   *****   **********   ***********************");
                Console.WriteLine("8 MATRIZ DIAGONAL 1, ARRIBA AL AZAR Y ABAJO 0  *************   ***   ***********   ***********************");
                Console.WriteLine("0 SALIR                                        **************   *   ****    ****   ***********************");
                Console.WriteLine("DIGITE UNA OPCION DEL MENU:                    ***************     *****    ****             *************");
                Console.WriteLine("**********************************************************************************************************");

                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("**********************************************************************************************************");
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("MATRIZ CARGADO AL AZAR");

                        Console.Write("Ingresa las filas :  ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingresa las columnas :  ");
                        m = Convert.ToInt32(Console.ReadLine());
                        int[,] matriz1 = new int[n, m];
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                matriz1[i, j] = aleatorio.Next(10, 99);
                            }
                        }
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                Console.Write("[" + matriz1[i, j] + "]");
                            }
                            Console.WriteLine(" ");
                        }
                      
                        break;

                    case 2:
                        Console.WriteLine("MATRIZ FOBONACCI");

                        Console.Write("DIGITA CUANTAS FILAS DESEAS TENER:  ");
                        m = Convert.ToInt32(Console.ReadLine());
                        Console.Write("DIGITA CUANTAS COLUMNAS DESEAS TENER:  ");
                        n = Convert.ToInt32(Console.ReadLine());
                        int num1 = 0, num2 = 1, siguiente;
                        int[,] matriz2 = new int[n, m];
                        for (int i = 0; i < n ; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                if (i <= 1 && j <= 1)
                                {
                                    siguiente = matriz2[i, j];
                                }
                                else
                                {
                                    siguiente = num1 + num2;
                                    num1 = num2;
                                    num2 = siguiente;
                                }
                            }
                        }
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                Console.Write("[" + matriz2[i, j] + "]");
                            }
                            Console.WriteLine(" ");
                        }
                        
                        break;

                    case 3:
                        Console.WriteLine("MATRIZ CERO");

                                
                        Console.Write("Ingrese las dimenciones de las filas: ");
                        n = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese las dimenciones de las columnas: ");
                        m = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                if (i == j)
                                {
                                    matriz[i, j] = 1;
                                }
                                else
                                {
                                    matriz[i, j] = rnd.Next(0, 9);
                                }
                            }
                        }

                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                Console.Write("[" + matriz[i, j] + "]");
                            }
                            Console.WriteLine("");
                        }

                        break;

                        
                    case 4:
                        Console.WriteLine("MATRIZ CARACOL");
              
                        Console.Write("INGRESE NUMEROS DE FILAS: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("INGRESE NUMEROS DE COLUMNAS: ");
                        m = Convert.ToInt32(Console.ReadLine());
                        int num, filainicio, filafinal, colinicio, colfinal, fila, col;
                        num = 1;
                        filainicio = 0;
                        filafinal = n - 1;
                        colinicio = 0;
                        colfinal = m - 1;

                        while (filainicio <= filafinal && colinicio <= colfinal)
                        {
                            //izquierda a derecha
                            for (int j = colinicio; j <= colfinal; j++)
                            {
                                matriz[filainicio, j] = num;
                                num++;
                            }
                            //arriba abajo
                            for (int i = filainicio + 1; i <= filafinal; i++)
                            {
                                matriz[i, colfinal] = num;
                                num++;
                            }
                            //derecha a izquierda
                            for (int j = colfinal - 1; j >= colinicio; j--)
                            {
                                matriz[filafinal, j] = num;
                                num++;
                            }
                            //abajo hacia arriba
                            for (int i = filafinal - 1; i >= filainicio + 1; i--)
                            {
                                matriz[i, colinicio] = num;
                                num++;
                            }
                            filainicio++;
                            filafinal--;
                            colinicio++;
                            colfinal--;
                        }

                        for (int i = 0; i <= n - 1; i++)
                        {
                            for (int j = 0; j <= m - 1; j++)
                            {
                                Console.Write("[" + matriz[i, j] + "]");
                            }
                            Console.WriteLine(" ");
                        }

                        break;


                    case 5:
                        Console.WriteLine("MATRIZ SIMETRICA");

                        Console.Write("Ingrese las dimenciones de filas y columnas: ");
                        n = int.Parse(Console.ReadLine());
                        aux = 1;
                        for (int i = 1; i < n; i++)
                        {
                            for (int j = 1; j < n; j++)
                            {
                                if (aux < i)
                                {
                                    matriz[i, j] = aux;
                                    aux = aux + 1;
                                }
                                else
                                {
                                    matriz[i, j] = i;
                                }
                            }
                            aux = 1;
                        }

                        for (int i = 1; i < n; i++)
                        {
                            for (int j = 1; j < n; j++)
                            {
                                Console.Write("[" + matriz[i, j] + "]");
                            }
                            Console.WriteLine("");
                        }

                        break;

                    case 6:
                        Console.WriteLine("MATRIZ CON 0 ALREDEDOR");

                        Console.Write("ingresa las filas :  ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingresa las columnas :  ");
                        m = Convert.ToInt32(Console.ReadLine());
                        int[,] vec = new int[n, m];
                        for (int f = 0; f < n; f++)
                        {
                            for (int c = 0; c < m; c++)
                            {
                                if (f == 0 || c == 0 || f == n - 1 || c == m - 1)
                                {
                                    vec[f, c] = 0;
                                }
                                else
                                {
                                    vec[f, c] = aleatorio.Next(1, 9);
                                }
                            }
                        }
                        Console.WriteLine();
                        for (int f = 0; f < n; f++)
                        {
                            for (int c = 0; c < m; c++)
                            {
                                Console.Write("[" + vec[f, c] + "]");
                            }
                            Console.WriteLine();
                        }
                       

                        break;
                   
                    case 7:
                        Console.WriteLine("MATRIZ DIAGONAL");

                        Console.Write("Ingresa las filas :  ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingresa las columnas :  ");
                        m = Convert.ToInt32(Console.ReadLine());
                        int[,] matriz8 = new int[n, m];
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                if (i == j)
                                {
                                    matriz8[i, j] = i;
                                }
                                else
                                {
                                    matriz8[i, j] = 5;
                                }
                            }
                        }
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                Console.Write("[" + matriz8[i, j] + "]");
                            }
                            Console.WriteLine(" ");
                        }
                       
                        break;
                    case 8:
                        Console.WriteLine("MATRIZ DIAGONAL 1, ARRIBA AL AZAR Y ABAJO 0");

                        Console.Write("Ingresa las filas :  ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingresa las columnas :  ");
                        m = Convert.ToInt32(Console.ReadLine());
                        int[,] matriz9 = new int[n, m];
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                if (i == j)
                                {
                                    matriz9[i, j] = 1;
                                }
                                else
                                {
                                    matriz9[i, j] = 0;
                                }
                                if (i < j)
                                {
                                    matriz9[i, j] = aleatorio.Next(2, 9);
                                }
                            }
                        }
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                Console.Write("[" + matriz9[i, j] + "]");
                            }
                            Console.WriteLine(" ");
                        }
                      
                        break;


                    
                    case 0:
                        Console.Clear();

                        Console.WriteLine("**********************************************************************************************************");


                        Console.Write("NOS VEMOS AL AÑO");
                        break;
                    default:
                        Console.WriteLine("VALOR INCORECTO");
                        break;
                }
                Console.ReadKey();

            } while (opcion != 0);
        }
    }
}
