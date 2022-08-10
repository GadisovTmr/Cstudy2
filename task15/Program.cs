// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите день недели");
// int week = Convert.ToInt32(Console.ReadLine ());

// if (week == 6)
// {
//     Console.WriteLine("Это выходной день");
// }
// else if (week == 7)
// {
//     Console.WriteLine("Это выходной день");
// }
// else
// {
//     Console.WriteLine("Это будний день");
// }

Console.WriteLine("Введите день недели");
int week = Convert.ToInt32(Console.ReadLine ());

if ((week == 6) ||(week == 7))
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Это будний день");
}