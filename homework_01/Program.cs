//Попытка понять проиходящее :)

// Console.Write("Введите первое число -> ");
// int first = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число -> ");
// int second = Convert.ToInt32(Console.ReadLine());
// int rezSum = SumNumbers(first,second);

// int SumNumbers (int firstNumber, int secondNumber)
// {
//     int sum = firstNumber + secondNumber;
//     return sum;
// }

// Console.WriteLine($"Сумма чисел ровняется -> {rezSum}");



// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// while (true)
// {
//     Console.Write("Введите число или символ q для выхода : ");
//     string text = Console.ReadLine();

//     if (text == "q")
//     {
//         Console.WriteLine("[STOP]");
//         break;
//     }

//     int number;
//     if (int.TryParse(text,out number))
//     {
//         int sum = 0;
//         while(number > 0)
//         {
//             sum = sum + number % 10;
//             number = number / 10 ;
//         }
//             if (sum % 2 == 0)
//     {
//         Console.WriteLine($"[STOP] -> Цифра четная, сумма которого ровняется [{sum}]");
//         break;
//     }
//     else
//     {
//         Console.WriteLine($"[STOP] -> Цифра нечетная, сумма которого ровняется [{sum}]\n-> Введите число сумма которого будет четным");
//     }
//     }
// }

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateArray(int size, int minRange, int maxRange)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array [i] = new Random().Next(minRange, maxRange + 1);
//     }
//     return array;
// }

// Console.Write("Введите размер массива ->");
// int sizeN = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите нижнюю границу массива > 99 -> ");
// int minRangeN = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите вернюю границу массива < 1000 -> ");
// int maxRangeN = Convert.ToInt32(Console.ReadLine());

// int[] rez = CreateArray(sizeN, minRangeN, maxRangeN);
// Console.WriteLine($"Массив: [{string.Join("; ", rez)}]");

// int GetCount (int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.WriteLine ($"Total {GetCount(rez)}");

// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

// int[] CreateArray(int size, int minRange, int maxRange)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(minRange, maxRange + 1);
//     }
//     return array;
// }

// Console.Write("\nВведите размер массива (четный) -> ");
// int size_array = Convert.ToInt32(Console.ReadLine());

// int[] rez_array = CreateArray(size_array, 10, 90);

// Console.WriteLine("\n");
// Console.WriteLine($"Массив начальный --------------> [{string.Join("; ", rez_array)}] ");

// int[] ReverseArray(int[] arr)
// {
//     int temp = 0;
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         temp = arr[arr.Length - i - 1];
//         arr[arr.Length - i - 1] = arr[i];
//         arr[i] = temp;
//     }
//     return arr;
// }

// int[] reverse_array = ReverseArray(rez_array);

// Console.WriteLine($"Массив конечный (развернутый) -> [{string.Join("; ", reverse_array)}] \n");