// вывести третью цифру задонного числа
 Console.WriteLine("Введите число");
 int num = Convert.ToInt32(Console.ReadLine());
 int count = 0;

 if( num > 99)
{
 while(num > 999)
 {
    num = num / 10;
    count++;
 }
num = num % 10;
System.Console.WriteLine(num);
}
else 
{
   Console.WriteLine("число не трёхзначное");
}



