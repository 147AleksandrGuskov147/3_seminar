// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите кординату х для числа A: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату y для числа A: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату z для числа A: ");
int Az = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату x для числа B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату y для числа B: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату z для числа B: ");
int Bz = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By-Ay, 2) + Math.Pow(Bz - Az, 2)), 2); 
Console.WriteLine(distance);
