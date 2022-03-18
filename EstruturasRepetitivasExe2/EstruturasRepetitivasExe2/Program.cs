
int a,b = 0;

do
{
	Console.WriteLine("Digite o valor Inicial do intervalo:");
	a = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("Digite o valor Final do intervalo:");
	b = Convert.ToInt32(Console.ReadLine());

}while (a > b);

for (int i = a; i <= b; i++) 
{
	if (i % 2 != 0)
	{
		Console.WriteLine("{0}",i);
	}
}