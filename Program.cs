//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// int FindSum(int number)
// {
//     int sum = 0;//объявляем переменную, хранилище для промежуточного результата
//     for(int current = 1; current <= number; current++) //объявили переменную, которая существует только в цикле for
//         sum += current; // краткая форма увеличения левого значения на правое, присваиваем sum  значение current
//     return sum;
// }
// Console.Write("Input a number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Sum of numbers from 1 to {a} is {FindSum(a)}");

//Напишите программу, которая принимает число и выдает количество цифр в числе 
// int CountDigit(int number)
// {
//     int count = 0;
//     if (number == 0)
//     {
//         count = 1;
//     }    
//     while (number != 0)
//     {
//         number /= 10; //a/=b это деление с присваиванием, является сокращенной записью number = number/10.
//         count++;
//     }
//     return count;
// }
// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"The number of digit in {num} is {CountDigit(num)}");

// // Напишите программу, которая принимает на вход число (А) и выдаёт произведение чисел от 1 до А.
// int FindMulti(int number)
// {
//     int multipl = 1;//объявляем переменную, хранилище для промежуточного результата
//     if (number >= 1) // проверка, что число положительное, в противном случае выводим -1
//     {
//         for(int current = 1; current <= number; current++) //объявили переменную, которая существует только в цикле for
//         {
//             multipl *= current;
//         } // краткая форма увеличения левого значения на правое, присваиваем mult  значение current
//         return multipl;
//     }
//     else 
//         return -1;
    
    
// }
// Console.Write("Input a number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Multiply of numbers from 1 to {a} is {FindMulti(a)}");

/* Массив
Метод по генерации произвольного массива
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.*/

// int[] CreateRandomArray(int size, int minValue, int maxValue) // размер массива, максимальное значение и минимальное
// {
//     int[] array = new int[size]; // выделяем память под массив- надо запомнить, имя массива (array), тип массива int, размер массива size
    
//     for(int i = 0; i < size; i++) //  при работе с массивом, это всегда цикл, i- индекс
//         array[i] = new Random().Next(minValue, maxValue + 1);

//     return array; // возвращаем массив, пишем только его имя!

// }
//  void ShowArray(int[] array) // войтовский метод будем вызывать массив
//  {
//     Console.Write("Array is: "); // красивая финтифлюшка для вывода массива
    
//     for (int i =0; i < array.Length; i++) // обращаемся к длине массива
//         Console.Write(array[i] + " ");

//     Console.WriteLine(" ;) \n"); // \n  переход на новую строку

//  }
// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);

/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. */

// int DegreeNums(int num1, int num2)
// {
//     int degree = num1 ; //объявляем переменную, хранилище для промежуточного результата num1=2 num2 =3
//     int current = 2 ;
//     if (num2 >= 1) // проверка, что число положительное, в противном случае выводим -1
//     {
//         while (current <= num2) //0< 3
//         {
//             degree *= num1; // 2*2
//             current++;
//         }
//         return degree;
//     }
//     else 
//         return -1;     
// }
// Console.Write("Input a num1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a num2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($" The degree {num1} of  {num2} is {DegreeNums(num1, num2)}");

/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. */
// int SumDigit(int number)
// {
//     int sum = 0; // переменная отвечает за сумму
//     int a = 0; // запись последней цифры
//     while (number > 10)
//     {
//         a = number % 10; // получаем последнюю цифру числа
//         sum += a; // прибавляем каждый раз последнюю цифру (остаток)  
//         number = number / 10;   
//     } 
    
//         if (number < 10)
//             {
//                 sum = sum + number;
//             }
      
//     return sum;
    
// }
// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"The sum of digit of number {num} is {SumDigit(num)}");

/* Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

// int[] CreateArray(int size)
// { 
//     int[] array = new int[size]; // выделяем память под массив- надо запомнить, имя массива (array), тип массива int, размер массива size
//     Console.Write("Введите массив ");

//     for(int i = 0; i < size; i++) //  при работе с массивом, это всегда цикл, i- индекс
//         array[i] = Convert.ToInt32(Console.ReadLine());

//     return array; // возвращаем массив, пишем только его имя!
// }
//  void SetArray(int[] array) // войдовский метод будем вызывать массив
//  {
//     Console.Write("Array is: "); // красивая финтифлюшка для вывода массива
    
//     for (int i =0; i < array.Length; i++) // обращаемся к длине массива
//         Console.Write(array[i] + " ");

//  }
 
// Console.Write("Input a size of elements: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateArray(m);
// SetArray(myArray);

// // Семинар 5 
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
// int[] CreateRandomArray(int size, int minValue, int maxValue) // метод создает рандомный массив , размер массива, максимальное значение и минимальное
// {
//     int[] array = new int[size]; // выделяем память под массив- надо запомнить, имя массива (array), тип массива int, размер массива size

//     for(int i = 0; i < size; i++) //  при работе с массивом, это всегда цикл, i- индекс
//         array[i] = new Random().Next(minValue, maxValue + 1);

//     return array; // возвращаем массив, пишем только его имя!

// }
//  void ShowArray(int[] array) // войтовский метод будем вызывать массив
//  {
//     Console.Write("Array is: "); // красивая финтифлюшка для вывода массива
    
//     for (int i =0; i < array.Length; i++) // обращаемся к длине массива
//         Console.Write(array[i] + " ");

//     Console.WriteLine(" ;) \n"); // \n  переход на новую строку

//  }
// int GetNegativeSum(int[]array)
// {
//     int sum = 0;

//     for(int i = 0; i < array.Length; i++)
    
//         if(array[i] < 0) // сумма элементов массива меньше нуля
//             sum += array[i];
        
//     return sum;
// }
// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);

// int negativeSum = GetNegativeSum(myArray);
// Console.WriteLine("Sum of negative elements is" + negativeSum);

/*Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. */

// int[] CreateRandomArray(int size, int minValue, int maxValue) // метод создает рандомный массив , размер массива, максимальное значение и минимальное
// {
//     int[] array = new int[size]; // выделяем память под массив- надо запомнить, имя массива (array), тип массива int, размер массива size

//     for(int i = 0; i < size; i++) //  при работе с массивом, это всегда цикл, i- индекс
//         array[i] = new Random().Next(minValue, maxValue + 1);

//     return array; // возвращаем массив, пишем только его имя!

// }
 void ShowArray(int[] array) // войтовский метод будем вызывать массив
 {
    Console.Write("Array is: "); // красивая финтифлюшка для вывода массива
    
    for (int i =0; i < array.Length; i++) // обращаемся к длине массива
        Console.Write(array[i] + " ");

    Console.WriteLine("  \n"); // \n  переход на новую строку
 }                

// bool FindNum(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num)
//         {
//             return true;
//         }


//     }
//     return false;
// }
// Console.WriteLine("ВВедите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(5, 1, 99);
// ShowArray(array);
// Console.WriteLine(FindNum(array, num));

// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

// int FindElements( int[] array, int min, int max)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= min && array[i] <= max)
        
//             count++;

//     }
//     return count;
// }
// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите min:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите max:");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size, 1, 10);
// ShowArray(array);
// Console.WriteLine(FindElements(array, min, max));

//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот. 
//  void F(int[] a) //метод принимает на вход весь массив
//  {
//     a[0] +=5; //увеличиваем нулевой элемен на 5 и сразу выводим на экран
//     Console.WriteLine(a[0]);
//      }

// int[] num = {5, 6, 4};
// F(num);
// Console.WriteLine(num[0]); // переменные массива всегда ссылочный тип

// /*теперь решаем задачу выше: Напишите программу замена элементов массива: положительные элементы замените на соответствующие
//  отрицательные, и наоборот */ 

//  void SetOppositeArray(int[] array)
//  {
//     for(int i = 0; i < array.Length; i++)
//         {
//             array[i] *= -1; // меняем знак на противоположный
//         }
//  }      
// Console.WriteLine("Input a number of elements: "); // введите размер массива
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a min possible value:"); 
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a max possible value:");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// SetOppositeArray(myArray);
// ShowArray(myArray);
//  HW 5 
//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных
// чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size, int minValue, int maxValue) // метод создает рандомный массив , размер массива, максимальное значение и минимальное
{
    int[] array = new int[size]; // выделяем память под массив- надо запомнить, имя массива (array), тип массива int, размер массива size


    for(int i = 0; i < size; i++) //  при работе с массивом, это всегда цикл, i- индекс
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array; // возвращаем массив, пишем только его имя!
} 
int EvenCount(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
            
    }
    return count;
}
Console.WriteLine("input a numbers of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value:"); 
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value:");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, 100, 999);
ShowArray(myArray);
Console.WriteLine(EvenCount(myArray));

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76