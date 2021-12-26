int n = 10; // количество элементов массива
int [] arrayNumbers = new int[n];


void FillArray(int [] inputArray)
{
    for (int i=0; i<inputArray.Length; i++)
    {
        inputArray[i] = new Random().Next(50);
    }
}


int [] GetEvenNumbers(int [] inputArray)
{
    int [] outArray = new int[inputArray.Length];
    int indexOutArray = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] % 2 == 0) 
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
int [] arrayEven = GetEvenNumbers(arrayNumbers);


Console.Write("Первоначальный массив: ");
foreach (int item in arrayNumbers)
{
    Console.Write(item + " ");
}
Console.WriteLine();

Console.Write("Массив из четных чисел: ");
foreach (int item in arrayEven)
{
    Console.Write(item+" ");
}


