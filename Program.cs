// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"



Console.WriteLine("Ведите число M");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число N");
int num2 = Convert.ToInt32(Console.ReadLine());


// void GetNum(int m, int n)
// {
//     if (m <= n)
//     {
//         Console.Write(m + " ");
//         GetNum(m + 1, n);
//     }


// }
// GetNum(num1, num2);


// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int Ack(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return Ack(m - 1, 1);
//     else return Ack(m - 1, Ack(m, n - 1));
// }

// int functionAkkerman = Ack(num1, num2);
// Console.Write($"Функция Аккермана = {functionAkkerman} ");

// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

int[] array = { 1, 2, 5, 0, 10, 34 };

string PrintArray(int[] array)
{
    return string.Join(", ", array);
}

Console.WriteLine($"Произвольный массив => {PrintArray(array)}");
Console.WriteLine($"Перевернутый массив => {PrintArray(ReversArr(array, array.Length - 1))}");

int[] ReversArr(int[] array, int i)
{

    if (i <= 0)
    {
        return array;
    }
    int numRevers = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = numRevers;
    return ReversArr(array, i -= 2);
}