Console.Write("Введите число: ");
string? num1S = Console.ReadLine();
int num1D;

Console.Write("Введите второе число: ");
string? num2S = Console.ReadLine();
int num2D;

Console.Write("Введите третье число: ");
string? num3S = Console.ReadLine();
int num3D;

int max = 0;

if (int.TryParse(num1S, out num1D))
{
    max = num1D;
    
    if (int.TryParse(num2S, out num2D))
    {
        if (int.TryParse(num3S, out num3D))
        {
            if (num2D > max)
            {
                max = num2D;
            }
            if (num3D > max) 
            {
                max = num3D;
            }
            Console.WriteLine(max);
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
}
else
{
    Console.WriteLine("Ошибка ввода! Необходимо ввести число");
} 
