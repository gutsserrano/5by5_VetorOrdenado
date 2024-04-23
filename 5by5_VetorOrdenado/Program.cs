/* Faça um programa que leia 5 numeros guarde-os num vetor e ordene-os 
    de forma crescente em um novo vetor
*/

int[] vetor =  new int[5];
int[] ordenado = new int[5];
int aux;
int option;

do
{
    Console.WriteLine("Digite 5 número:");
    for (int i = 0; i < 5; i++)
    {
        Console.Write($"Valor {i + 1}: ");
        vetor[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < 5; i++)
    {
        ordenado[i] = vetor[i];
    }

    // implementação de Bubble Sort
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (ordenado[j] > ordenado[j + 1])
            {
                aux = ordenado[j + 1];
                ordenado[j + 1] = ordenado[j];
                ordenado[j] = aux;
            }
        }
    }

    Console.WriteLine("\nVetor lido:");
    for (int i = 0; i < 5; i++)
    {
        Console.Write(vetor[i] + " ");
    }

    Console.WriteLine("\nVetor ordenado:");
    for (int i = 0; i < 5; i++)
    {
        Console.Write(ordenado[i] + " ");
    }

    do
    {
        Console.WriteLine("\n\nDeseja sair do programa?");
        Console.WriteLine("1 - Sair");
        Console.WriteLine("2 - Continuar");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);
} while (option == 2);