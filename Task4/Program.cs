Console.Write("Введите число: ");
string? N = Console.ReadLine();
int Ni;
int K = 0;

if (int.TryParse(N, out Ni))
{
    if (Ni % 2 == 0)
    {
     while (Ni > K)
      {
        K = K + 2;
        Console.WriteLine(K);  
      }
    }
    else 
    {
       while (Ni-1 > K)
       {
        K = K + 2;
        Console.WriteLine(K);
       } 
    } 
}
else
{
    Console.WriteLine("Ошибка ввода! Необходимо ввести число");
} 


