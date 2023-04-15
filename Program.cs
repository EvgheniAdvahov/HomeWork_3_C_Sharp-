// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
// Console.WriteLine("Pleae enter 5 digit number");
// int number = Convert.ToInt32(Console.ReadLine());
// int number2 = (number % 10000)/10;

// if((number % 10 == number /10000) && (number2 % 10 == number2 / 100))
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Console.WriteLine("Please inter x1 ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please inter y1 ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please inter z1 ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Please inter x2 ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please inter y2 ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please inter z2 ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
// result = Math.Round(result,2);
// Console.WriteLine($"Result is: {result}");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Please enter the number");
// int number = Convert.ToInt32(Console.ReadLine());

// for(int i=1; i<= number; i++)
// {
//     Console.WriteLine(Math.Pow(i,3));
// }