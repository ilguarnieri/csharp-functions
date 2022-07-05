void StampaArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }

    Console.WriteLine("]");
}


int NumeroQuadrato(int num)
{
    return num * num;
}


int[] ElevaArrayQuadrato(int[] array)
{
    int[] arrayQuadrato = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        arrayQuadrato[i] = NumeroQuadrato(array[i]);
    }

    return arrayQuadrato;
}


int SommaElementi(int[] array)
{
    int somma = 0;

    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }

    return somma;
}


// Programma principale

//int[] array = { 2, 6, 7, 5, 3, 9 };

Console.Write($"\nInserisci la lunghezza dell'array: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrayLength];

Console.WriteLine($"\nInserisci {arrayLength} numeri:");
for (int i = 0; i < arrayLength; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("\nArray originale:");
StampaArray(array);
Console.Write("\nSomma array originale: ");
Console.WriteLine(SommaElementi(array));


int[] arrayQuadrato = ElevaArrayQuadrato(array);
Console.WriteLine("\nArray al quadrato:");
StampaArray(arrayQuadrato);
Console.Write("\nSomma array al quadrato: ");
Console.WriteLine(SommaElementi(arrayQuadrato));