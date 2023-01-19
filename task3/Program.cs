// вывести третью цифру задонного числа
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// while(num != 0)
// {
//    num = num / 10;
//    count++;
// }
// System.Console.WriteLine(count); 
// Смог только узнать длинну числа через деление, а дальше я не могу придумать как решить

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string text = Convert.ToString(num);

if (text.Length > 2)
{
   Console.WriteLine(text[2]);
}
else {
   Console.WriteLine("нет");
}
