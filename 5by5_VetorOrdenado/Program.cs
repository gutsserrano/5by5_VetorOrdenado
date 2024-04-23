/* Faça um programa que leia 5 numeros guarde-os num vetor e ordene-os 
    de forma crescente em um novo vetor
*/
int size = 20;
int sizeOrdenado;
int[] vetor =  new int[size];
int[] ordenado = new int[size];
int[] invertido;
int[] repetidos = new int[size];
bool achou;
int aux;
int option;

do
{
    sizeOrdenado = 0;

    for (int i = 0; i < size; i++)
    {

        vetor[i] = new Random().Next(0, 100);

        if (i == 0)
        {
            ordenado[sizeOrdenado] = vetor[i];
            sizeOrdenado++;
        }
        else
        {
            achou = false;
            for (int j = 0; j < sizeOrdenado; j++)
            {
                if (ordenado[j] == vetor[i])
                {
                    achou = true;
                }
            }

            if (achou == false)
            {
                ordenado[sizeOrdenado] = vetor[i];
                sizeOrdenado++;
            }
        }
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
    for (int i = 0; i < sizeOrdenado; i++)
    {
        for (int j = i+ 1; j < sizeOrdenado; j++)
        {
            if (ordenado[i] > ordenado[j])
            {
                aux = ordenado[i];
                ordenado[i] = ordenado[j];
                ordenado[j] = aux;
            }
        }
    }

    invertido = new int[sizeOrdenado];
    int x = 0;
    for(int i = sizeOrdenado-1; i >= 0; i--)
    {
        invertido[x] = ordenado[i];
        x++;
    }

    Console.WriteLine("\nVetor lido:");
    for (int i = 0; i < size; i++)
    {
        Console.Write(vetor[i] + " ");
    }

    Console.WriteLine("\nVetor ordenado:");
    for (int i = 0; i < sizeOrdenado; i++)
    {
        Console.Write(ordenado[i] + " ");
    }

    Console.WriteLine("\nVetor invertido:");
    for (int i = 0; i < sizeOrdenado; i++)
    {
        Console.Write(invertido[i] + " ");
    }

    do
    {
        Console.WriteLine("\n\nDeseja sair do programa?");
        Console.WriteLine("1 - Sair");
        Console.WriteLine("2 - Continuar");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);
} while (option == 2);