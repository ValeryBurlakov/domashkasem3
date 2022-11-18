// проверка пятизначного числа на палидромность
// 12821 = да. 14212 = нет

// 1 метод математический, 2 через массив и строку:

// 1. Математический метод
Console.WriteLine("Введите пятизначное число:");
int numbers = Convert.ToInt32(Console.ReadLine());
int num1 = numbers / 10000;
int num5 = numbers % 10;
int num2 = (numbers / 1000) % 10;
int num4 = (numbers / 10) % 10;
int count = (int)Math.Log10(numbers) + 1;
Console.WriteLine($"num1 = {num1} и num5 = {num5}, num2 = {num2} и num4 = {num4}");
if (count == 5)
    if(num1 == num5 && num2 == num4)
    {
      Console.WriteLine("Да, число палиндром");
    }
    else
    {
       Console.WriteLine("нет, не такое");
    }
else
{
    Console.WriteLine("Вы ввели не пятизначное число, перезапустите программу");
}

// 2. Метод через строку и массив:
// Console.WriteLine("введите пятизначное число: "); 
// string? str = Console.ReadLine();
// char[] arr;
// arr = str.ToCharArray();
// int length = str.Length;
// if (length == 5)
//     if(arr[0] == arr[4] && arr[1] == arr[3])
//     Console.WriteLine("Да, число палидромдромддрромное");
//     else
//     {
//         Console.WriteLine("нет, не такое");
//     }
// else
// {
//     Console.WriteLine("Вы ввели не пятизначное число, перезапустите программу");
// }