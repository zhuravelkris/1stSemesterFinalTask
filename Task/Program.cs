// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int length = 20;
int[] Array = new int[length];

int CreateArray(int length) 
{
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        Array[i] = new Random().Next(-50, 51);
        if (Array[i] % 2 == 0) 
        count++;
    }
    return count; 
}

int[] CreateEvenArray(int arg, int length) 
{
    int[] evenNumbersArray = new int[arg];
    for (int i = 0, j = 0; i < length; i++)
    {
        if (Array[i] % 2 == 0)
        {
            evenNumbersArray[j] = Array[i];
            j++;
        }
    }
    return evenNumbersArray;
}

int count = CreateArray(length);
int[] evenNumbersArray = CreateEvenArray(count, length);

Console.Clear(); 
Console.WriteLine(String.Join(' ', Array));   //вывод в консоль первоначального массива
Console.WriteLine(String.Join(' ', evenNumbersArray)); //вывод в консоль массива, состоящего из четных чисел


