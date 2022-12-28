// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет            // 12821 -> да               // 23432 -> да

// Быть может прямолинейно, но не нашел разбора по оператору string. 

// int KOMOK = new Random().Next(9999, 100000);
// Console.WriteLine("Ваше случайное число: " + KOMOK);
Console.WriteLine("Введите 5-значное число, чтобы узнать палиндром это или нет : ");
int KOMOK = Convert.ToInt32(Console.ReadLine());

int KO = KOMOK/10000;
int OM = KOMOK/1000%10;
int MO = KOMOK%100/10;
int OK = KOMOK%10;

if (9999 >= KOMOK || KOMOK >= 100000)
{
    Console.WriteLine("Это не 5-значное число!!!");
}
else if (9999 < KOMOK && KOMOK < 100000 && KO == OK && OM == MO)
{
    Console.WriteLine("Это палиндром!!!");
}
else
{
    Console.WriteLine("Это не палиндром!");
}

// Console.WriteLine(KO);
// Console.WriteLine(OM);
// Console.WriteLine(MO);
// Console.WriteLine(OK);
