
int fact = 1, f;

Console.WriteLine("Digite o numero do qual quer o fatorial:");
f=Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= f; i++) 
{
    fact = fact * i;
}

Console.WriteLine("Factorial de {0} é {1}", f, fact);