using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_ma_1187411
{
    class Program
    {
        static void Main(string[] args)
        {
            /* < LABORATORIO 4 - EJEMPLO 1>*/
            /*Sección de ingreso de datos para el problema 1 y 2*/
            int intOperando1 = 0;
            int intOperando2 = 0;

            try
            {
                Console.WriteLine("Ejercicio 1: Operaciones Aritméticas");
                Console.WriteLine("Ingrese el operando 1");
                intOperando1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el operando 2");
                intOperando2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e){
                Console.WriteLine("Error detectado: " + e.Message);
            }
            

            /*Sección de operación*/
            int intTotal = intOperando1 + intOperando2;
            int intDiferencia = intOperando1 - intOperando2;
            int intProducto = intOperando1 * intOperando2;
            int intCociente = 0;
            int intResiduo = 0;

            try
            {
                intCociente = intOperando1 / intOperando2;
                intResiduo = intOperando1 % intOperando2;
            }
            catch (Exception e) {
                Console.WriteLine("Error detectado: " + e.Message);
            }
            
            
            /*Sección de salida de datos*/
            Console.WriteLine(intOperando1 + " + " + intOperando2 + " = " + intTotal);
            Console.WriteLine(intOperando1 + " - " + intOperando2 + " = " + intDiferencia);
            Console.WriteLine(intOperando1 + " * " + intOperando2 + " = " + intProducto);
            Console.WriteLine(intOperando1 + " / " + intOperando2 + " = " + intCociente);
            Console.WriteLine(intOperando1 + " % " + intOperando2 + " = " + intResiduo);
            /* < LABORATORIO 4 - EJEMPLO 1/>*/


            /* < LABORATORIO 4 - EJEMPLO 2>*/
            Console.WriteLine("Ejercicio 2: Operaciones Booleanas (Logicas)");
            bool menorQue = intOperando1 < intOperando2;
            bool menorIgualQue = intOperando1 <= intOperando2;
            bool mayorQue = intOperando1 > intOperando2;
            bool MayorIgualQue = intOperando1 >= intOperando2;
            bool IgualQue = intOperando1 == intOperando2;

            Console.WriteLine(intOperando1 + " < " + intOperando2 + " = " + menorQue);
            Console.WriteLine(intOperando1 + " <= " + intOperando2 + " = " + menorIgualQue);
            Console.WriteLine(intOperando1 + " > " + intOperando2 + " = " + mayorQue);
            Console.WriteLine(intOperando1 + " >= " + intOperando2 + " = " + MayorIgualQue);
            Console.WriteLine(intOperando1 + " == " + intOperando2 + " = " + IgualQue);
            /* < LABORATORIO 4 - EJEMPLO 2/>*/

            /* < LABORATORIO 4 - EJEMPLO 3>*/
            int intOperandoA = 0;
            int intOperandoB = 0;
            int intOperandoC = 0;

            try {
                Console.WriteLine("Ingrese el operando a");
                intOperandoA = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el operando b");
                intOperandoB = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el operando c");
                intOperandoC = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e) {
                Console.WriteLine("Se detectó un error en la lectura de los datos " + e.Message);
            }

            int resultadoi = 0;
            int resultadoii = 0;
            int resultadoiii = 0;
            int resultadoiv = 0;

            try
            {
                /*<Operación inciso i>*/
                resultadoi = intOperandoA * intOperandoB + intOperandoC;
                /*<Operación inciso i/>*/

                /*<Operación inciso ii>*/
                resultadoii = intOperandoA * (intOperandoB + intOperandoC);
                /*<Operación inciso ii/>*/

                /*<Operación inciso iii>*/
                resultadoiii = intOperandoA / (intOperandoB * intOperandoC);
                /*<Operación inciso iii/>*/

                /*<Operación inciso iv>*/
                resultadoiv = (3 * intOperandoA + 2 * intOperandoB) / Convert.ToInt32(Math.Pow(intOperandoC, 2));
                /*<Operación inciso iv/>*/

            }
            catch (Exception e) {
                Console.WriteLine("Error encontrado al intentar realizar la operación: " + e.Message);
            }

            Console.WriteLine();

            Console.WriteLine("i. a * b + c = " + resultadoi);
            Console.WriteLine("ii. a * (b + c) = " + resultadoii);
            Console.WriteLine("iii. a / (b * c) = " + resultadoiii);
            Console.WriteLine("iii. (3a + 2b) / c^2 = " + resultadoiv);

            /* < LABORATORIO 4 - EJEMPLO 3/>*/


            /* < LABORATORIO 4 - EJEMPLO 4>*/
            int resultadoXpositivo = 0;
            int resultadoXnegativo = 0;

            try
            {
                //Forma de realizarlo 1: todo en una misma linea (No recomendado)
                resultadoXpositivo = (((-1) * intOperandoB) + Convert.ToInt32(Math.Sqrt((intOperandoB * intOperandoB) - 4 * intOperandoA * intOperandoC))) / (2 * intOperandoA);

                //Forma de realizarlo 2: por partes
                int tempOperacionDentroRaiz = (intOperandoB * intOperandoB) - 4 * intOperandoA * intOperandoC;
                int tempNumerador = (-1) * intOperandoB - Convert.ToInt32(Math.Sqrt(tempOperacionDentroRaiz));
                int tempDenominador = 2 * intOperandoA;
                resultadoXnegativo = tempNumerador / tempDenominador;

                Console.WriteLine("(-b + RAIZ((b^2) - 4 * a * c)) / ( 2 * a ) = " + resultadoXpositivo);
                Console.WriteLine("(-b - RAIZ((b^2) - 4 * a * c)) / ( 2 * a ) = " + resultadoXnegativo);
            }
            catch (Exception e) {
                Console.WriteLine("Error detectado: " + e.Message);

            }


            /* < LABORATORIO 4 - EJEMPLO 4/>*/
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
