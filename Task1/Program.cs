Console.Write("Введите число: ");
string? number1S = Console.ReadLine();
double number1D;

Console.Write("Введите второе число: ");
string? number2S = Console.ReadLine();
double number2D;

if (double.TryParse(number1S, out number1D))
{
    if (double.TryParse(number2S, out number2D))
    {
        if (number1D > number2D)
        {
           Console.WriteLine(number1D); 
        }
        else
        {
            Console.WriteLine(number2D);
        }
    }
    else 
    {
        Console.WriteLine("Ошибка ввода! Необходимо ввести число");
    }
}
else
{
    Console.WriteLine("Ошибка ввода! Необходимо ввести число");
} 
