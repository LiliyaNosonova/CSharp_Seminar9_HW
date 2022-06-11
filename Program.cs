// ДЗ . Есть два массива info и data.
// Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей.
// Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.
// Составить массив десятичных представлений чисел массива data с учётом информации из массива info.
// Пример:
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1
// Максимально подробно описать, какие ошибки могут возникнуть при обработке наборов данных?

void Array(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] arr2)
{
    for (int n = 0; n < arr2.Length; n++)
    {
        System.Console.Write(arr2[n] + " ");
    }
}

int SumOddArray(int[] res)
{
    int Sum = 0;
    for (int index = 0; index < res.Length; index++)
    {
        Sum = Sum + res[index];
    }
    return Sum;
}

void ArrayBinary(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int run = new Random().Next(0, 10);
        if (run > 4) arr[i] = 1;
        else arr[i] = 0;
    }
}

int size = 3;
int[] info = new int[size];
Array(info);
System.Console.Write("info = ");
PrintArray(info);
int Sum = SumOddArray(info);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов равна {Sum}");

int[] data = new int[Sum];
ArrayBinary(data);
System.Console.WriteLine();
System.Console.Write("data = ");
PrintArray(data);
System.Console.WriteLine();
System.Console.WriteLine($"Длина массива - {data.Length}");

int j = 0;
int[] total = new int[size];
for (int i = 0; i < info.Length; i++)
{
    total[i] = 0;
    for (int z = 1; z <= info[i]; z++)
    {
        int bl = data[j];
        if (bl != 0)
        {
            int y = info[i] - z;
            total[i] = total[i] + (int)Math.Pow(2, y);
        }
        j++;
    }
}

System.Console.WriteLine();
System.Console.Write("total = ");
PrintArray(total);
