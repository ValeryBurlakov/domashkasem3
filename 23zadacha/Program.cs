// на вход число, на выход спискок кубов от 1 до n. 1 8 27 64 125
Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    // Console.Write(i * i * i + " ");
    Console.WriteLine(i + " в 3 степени = " + Math.Pow(i, 3));
}