/* Faça um programa que leia 5 numeros guarde-os num vetor e ordene-os 
    de forma crescente em um novo vetor
*/
int size = 20;
int[] vetor =  new int[size];
int[] ordenado = new int[size];
int aux;
int option;

do
{
    for(int i = 0; i < size; i++)
    {
        vetor[i] = new Random().Next(0, 100);
    }

    /*Console.WriteLine("Digite size número:");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Valor {i + 1}: ");
        vetor[i] = int.Parse(Console.ReadLine());
    }*/

    for (int i = 0; i < size; i++)
    {
        ordenado[i] = vetor[i];
    }

    // implementação de Bubble Sort
    /*for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size - 1; j++)
        {
            if (ordenado[j] > ordenado[j + 1])
            {
                aux = ordenado[j + 1];
                ordenado[j + 1] = ordenado[j];
                ordenado[j] = aux;
            }
        }
    }*/

    // Bubble sort verificando de forma diferente
    for (int i = 0; i < size; i++)
    {
        for (int j = i+ 1; j < size; j++)
        {
            if (ordenado[i] > ordenado[j])
            {
                aux = ordenado[i];
                ordenado[i] = ordenado[j];
                ordenado[j] = aux;
            }
        }
    }

    Console.WriteLine("\nVetor lido:");
    for (int i = 0; i < size; i++)
    {
        Console.Write(vetor[i] + " ");
    }

    Console.WriteLine("\nVetor ordenado:");
    for (int i = 0; i < size; i++)
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