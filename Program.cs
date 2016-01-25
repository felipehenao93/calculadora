using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que simula una calculadora
            Console.WriteLine("                               CALCULADORA            ");
            Console.WriteLine("                    ");
            Console.WriteLine(" Elija una opcion  ");
            Console.WriteLine("                    ");

            Console.WriteLine(" 1. SUMA  ");
            Console.WriteLine(" 2. RESTA  ");
            Console.WriteLine(" 3. MULTIPLICACION  ");
            Console.WriteLine(" 4. DIVISION  ");
            Console.WriteLine(" 5. RAIZ  ");
            Console.WriteLine(" 6. CUADRADO  ");
            Console.WriteLine(" 7. CUBO  ");
            Console.WriteLine(" 8. MODULO  ");
            int opci= int.Parse(Console.ReadLine());
            switch (opci) { 
             
                case 1:
                    Console.WriteLine("digite la cantidad de numeros que desea sumar");
                    int cant = int.Parse(Console.ReadLine());
                    Double suma=0;
                    for (int i = 1; i <= cant; i++) {
                        Console.WriteLine("ingrese numero ");
                        Double num=Double.Parse(Console.ReadLine());
                        suma = suma +num ;
                    }
                    Console.WriteLine("el total de la suma es: " + suma);
                        break;
                case 2:
                        Console.WriteLine("digite la cantidad de numeros que desea restar");
                        cant=int.Parse(Console.ReadLine());
                        Double rest = 0;
                        for (int i = 1; i <= cant; i++) {
                            Console.WriteLine("ingrese numero");
                          Double  num = Double.Parse(Console.ReadLine());
                          rest = rest - num;
                        
                        }
                        Console.WriteLine("el total de la resta es: " +rest);
                            break;
                case 3:
                            Console.WriteLine("digite la cantidad de numeros que desea multiplicar ");
                            cant = int.Parse(Console.ReadLine());
                            Double multi = 1;
                            for (int i = 1; i <= cant; i++) {
                                Console.WriteLine("ingrese numero");
                                Double num = Double.Parse(Console.ReadLine());
                                multi = multi * num;
                          }
                            Console.WriteLine("el resultado de la multiplicacion es: "+multi);
                                 break;
                case 4:
                                 Double div;
                                 Console.WriteLine("ingrese dividendo");
                                 Double num1=Double.Parse(Console.ReadLine());
                                 Console.WriteLine("ingrese divisor");
                                 Double num2=Double.Parse(Console.ReadLine());
                                 div = num1 / num2;
                                 Console.WriteLine("el resultado de la division es: " + div);         

                                 break;
                case 5:
                                 Console.WriteLine("ingrese el numero del que desea obtener la raiz cuadrada");
                                 Double n=Double.Parse(Console.ReadLine());
                                 n = Math.Sqrt(n);
                                 Console.WriteLine("la raiz(2) es: "+n);
                                 break;

                case 6:
                                 Console.WriteLine("ingrese el numero del que desea obtener el cuadrado");
                                 Double c=Double.Parse(Console.ReadLine());
                                c=(Math.Pow(c,2));
                                Console.WriteLine("el cuadrado es: " + c);
                                break;
                case 7:
                               Console.WriteLine("ingrese el numero del que desea obtener el cubo");
                                 Double cu=Double.Parse(Console.ReadLine());
                                c=(Math.Pow(cu,3));
                                Console.WriteLine("el cubo es: " + c);          
                               break;

                case 8:
                                 Console.WriteLine("ingrese numero");
                                 Double n1=Double.Parse(Console.ReadLine());
                                 Console.WriteLine("ingrese mod");
                                 Double n2=Double.Parse(Console.ReadLine());
                                 Double mod = n1 % n2;
                                 Console.WriteLine("el modulo es "+mod);
                                 break;


                   
            }



            Console.ReadLine();









        }
    }
}
