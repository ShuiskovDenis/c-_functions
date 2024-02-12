// тип_метода ИмяМетода (пар1,пар2....парN)
// a,b - числа
// char ('+','-') - 1 символ обернутый в одинарыне ковычки

// int Calculate(int a, int b, char sign)
// {
//     if (sign == '+')
//     {
//         return a + b; // Суммы чисел
//     }
//     else if  (sign == '-')
//     {
//         return a - b; // Разность чисел
//     }
//         else if  (sign == '*')
//     {
//         return a * b; // Умножение чисел
//     }
//     else
//     {   
//         Console.WriteLine("Введен неизвестный знак арифм. операции");
//         return 0;
//     }
// }

// // Вызов метода 
// int rez = Calculate(10,7,'*');
// Console.WriteLine(Calculate(2,3,'+'));
// Console.WriteLine(Calculate(2,3,'-'));
// Console.WriteLine(Calculate(2,3,'*'));
// Console.WriteLine(Calculate(2,3,';'));
// Console.WriteLine($"rez -> {rez}");

// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

// minRange - нижняя граница рандома массива
// maxRange - верхняя граница рандома массива

// int[] CreateArray(int size, int minRange, int maxRange)
// {
//     int[] array = new int[size]; // массив на size элементов
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(minRange, maxRange + 1);
//     }
//     return array;
// }

// // Вызов метода

// Console.Write("Введите размер массива -> ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] rez = CreateArray(N, 10, 90);
// Console.WriteLine($"Массив: [{string.Join("; ", rez)}]");
// Console.WriteLine($"Total {GetCount(rez)}");

// int GetCount(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 7 == 0 && arr[i] % 10 == 1)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

int[] CreateArray(int size)
{
    int[] array = new int[size]; // массив на size элементов
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10);
    }
    return array;
}

int ConvertArrayToInteger(int[] array)
{
    int rezult = 0;
        for (int i = 0, j = array.Length - 1; i< array.Length; i++, j--)
        {
            rezult = rezult + array[i] * (int)Math.Pow(10, j);
        }
    return rezult;
}


Console.Write("Введите размер массива -> ");
int N = Convert.ToInt32(Console.ReadLine());
int[] rez = CreateArray(N);

if (N > 8)
{
    Console.WriteLine("Размер > 8 элементов");
    return;
}

Console.WriteLine($"Массив: [{string.Join("; ", rez)}]");
Console.WriteLine($"Число -> {ConvertArrayToInteger(rez)}");