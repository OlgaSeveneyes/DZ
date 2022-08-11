Console.Write("Введите число: ");
string? N = Console.ReadLine();
int Ni;

if (int.TryParse(N, out Ni))
{
    if (Ni % 2 == 0)
    {
      Console.WriteLine("Четное");  
    }
    else 
    {
      Console.WriteLine("Нечетное");    
    }
}
else
{
    Console.WriteLine("Ошибка ввода! Необходимо ввести число");
} 
