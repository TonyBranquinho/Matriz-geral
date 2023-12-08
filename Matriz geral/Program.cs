using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_geral {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, i, j;
            double soma, linha, coluna, alterada;

            Console.Write("Qual a ordem da matriz? ");
            n = int.Parse(Console.ReadLine(), CI);

            double[,] matriz = new double[n, n];

            for (i = 0; i < n; i++) { /////////////////////// ATRIBUIÇOES MATRIZ A
                for (j = 0; j < n; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    matriz[i, j] = double.Parse(Console.ReadLine(), CI);
                }
            }

            Console.WriteLine();
            soma = 0;
            for (i = 0; i < n; i++) { /////////////////////// SOMA POSITIVOS
                for (j = 0; j < n; j++) {
                    if (matriz[i, j] > 0) {
                        soma = soma + matriz[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS : " + soma.ToString("F1", CI));
            Console.WriteLine();

            Console.Write("Escolha uma linha: ");/////////////// ESCOLHE A LINHA
            linha = double.Parse(Console.ReadLine());
            Console.Write("LINHA ESCOLIDA: ");
            for (j = 0; j < n; j++) { 
                Console.Write(matriz[(int)linha, j].ToString("F1", CI) + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Escolha uma coluna: "); ///////////// ESCOLHE A COLUNA
            coluna = double.Parse(Console.ReadLine());
            Console.Write("COLUNA ESCOLIDA: ");
            for (i = 0; i < n; i++) { 
                Console.Write(matriz[i, (int)coluna].ToString("F1", CI) + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("DIAGONAL PRINCIPAL: "); //////////// DIAGONAL PRINCIPAL
            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    if (i == j) {
                        Console.Write(matriz[i, j].ToString("F1", CI) + " ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("MATRIZ ALTERADA: "); ///////////// MATRIZ ALTERADA
            for (i = 0; i < n; i++) { 
                for (j = 0; j < n; j++) {
                    if (matriz[i, j] < 0) {
                        alterada = matriz[i, j] * matriz[i, j];
                        Console.Write(alterada.ToString("F1", CI) + " ");
                    }
                    else {
                        Console.Write(matriz[i, j].ToString("F1", CI) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
