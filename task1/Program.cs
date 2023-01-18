Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int result = (num - ((num / 100) * 100) - (num % 10)) / 10;

System.Console.WriteLine(result);

