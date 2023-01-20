// Дни недели
Console.WriteLine("введите число");
int day = Convert.ToInt32(Console.ReadLine());

// switch (day)
// {
//     case 1:
//     System.Console.WriteLine("noy");
//     break;
//     case 2:
//     System.Console.WriteLine("noy");
//     break;
//     case 3:
//     System.Console.WriteLine("noy");
//     break;
//     case 4:
//     System.Console.WriteLine("noy");
//     break;
//     case 5:
//     System.Console.WriteLine("noy");
//     break;
//     case 6:
//     System.Console.WriteLine("yes");
//     break;
//     case 7:
//     System.Console.WriteLine("yes");
//     break;
// }

if(day == 6 || day == 7)
{
    Console.WriteLine("yes");
}
if(day < 6)
{
    Console.WriteLine("noy");
}
