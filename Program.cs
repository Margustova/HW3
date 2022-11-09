//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
int FindSum(int number)
{
    int sum = 0;//объявляем переменную, хранилище для промежуточного результата
    for(int current = 1; current <= number; current++) //объявили переменную, которая существует только в цикле for
        sum += current; // краткая форма увеличения левого значения на правое, присваиваем sum  значение current
    return sum;
}
Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of numbers from 1 to {a} is {FindSum(a)}");
