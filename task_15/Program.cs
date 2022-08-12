//  Напишите программу, которая принимает на вход цифру,
//   обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case >7:
        Console.WriteLine("Нет такого дня");
        break;
    case >5:
        Console.WriteLine("Day off");
        break;
    case >1:
        Console.WriteLine("Sorry still working day.");
        break;
    default:
        Console.WriteLine("Нет такого дня");
        break;  
}