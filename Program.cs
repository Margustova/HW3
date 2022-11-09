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
int CountDigit(int number)
{
    int count = 0;
    if (number == 0)
    {
        count = 1;
    }    
    while (number != 0)
    {
        number /= 10; //a/=b это деление с присваиванием, является сокращенной записью number = number/10.
        count++;
    }
    return count;
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The number of digit in {num} is {CountDigit(num)}");

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