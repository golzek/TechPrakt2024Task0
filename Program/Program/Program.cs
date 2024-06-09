using System.Text;
Console.OutputEncoding=Encoding.UTF8;
Console.Write("Введіть число:");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть число:");
double b = Convert.ToDouble(Console.ReadLine());

double sum = a + b;
Console.WriteLine($"Сума чисел:{sum}");