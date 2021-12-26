int n = 10; // количество элементов массива
int [] arrayNumbers = new int[n];


void FillArray(int [] inputArray)
{
    for (int i=0; i<inputArray.Length; i++)
    {
        inputArray[i] = new Random().Next(50);
    }
}


int [] MoreEight(int [] inputArray)
{
    int [] outArray = new int[inputArray.Length];
    int indexOutArray = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] > 8) 
        {
            outArray[indexOutArray] = inputArray[i];
            indexOutArray++;
        }
    }
    
    int [] outArrayWithoutZero = new int[indexOutArray];

    for (int i = 0; i < indexOutArray; i++)
    {
        outArrayWithoutZero[i] = outArray[i];
    }

    return outArrayWithoutZero;
}


FillArray(arrayNumbers);
int [] arrayMoreEight = MoreEight(arrayNumbers);


Console.Write("Первоначальный массив: ");
foreach (int item in arrayNumbers)
{
    Console.Write(item + " ");
}
Console.WriteLine();

Console.Write("Числа больше восьми: ");
foreach (int item in arrayMoreEight)
{
    Console.Write(item+" ");
}


