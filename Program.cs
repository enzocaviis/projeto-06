Console.Clear();
int n1;

Console.Write("Informe um numero para obter seu modulo: ");
n1 = int.Parse(Console.ReadLine());

Console.Clear();
if (n1 >= 0)
{
    Console.WriteLine($"Modulo de {n1} = {n1}");
}
else
{
    Console.WriteLine($"Modulo de {n1} = {n1 * (-1)}");
}

