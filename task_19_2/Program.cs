// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет            // 12821 -> да               // 23432 -> да

Console.WriteLine("Введите 5-значное число, чтобы узнать палиндром это или нет : ");
int A = Convert.ToInt32(Console.ReadLine());
string aStr = Convert.ToString(A);

if (9999 >= A || A >= 100000)
{
    Console.WriteLine("Это не 5-значное число!!!");
}
else if (9999 < A && A < 100000 && aStr[0] == aStr[4] && aStr[1] == aStr[3])
{
    Console.WriteLine("Это палиндром!!!");
}
else
{
    Console.WriteLine("Это не палиндром!");
}
