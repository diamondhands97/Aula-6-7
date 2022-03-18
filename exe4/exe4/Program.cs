const string Caract = "XXX";
const string Espaco = "   ";
int larg = 5, comp = 5;
for (int c = 1; c <= comp; c++)
    Console.Write(Caract);
Console.WriteLine();
for (int l = 1; l <= larg; l++)
{
    Console.Write(Caract);
    for (int w = 1; w <= comp-2; w++)
        Console.Write(Espaco);
    Console.WriteLine(Caract);
}
for (int c = 1; c <= comp; c++)
    Console.Write(Caract);
Console.WriteLine();



int altura, largura = 0;

do
{
    Console.Write("Altura do triangulo: ");
    altura = Convert.ToInt32(Console.ReadLine());



    Console.Write("Largura do triangulo: ");
    largura = Convert.ToInt32(Console.ReadLine());
} while (altura != largura);

for (int i = 0; i <= largura; i++)
{
    Console.Write("___");
}

Console.WriteLine();

for (int x = 0; x <= altura; x++)
{
    Console.Write("|");
    for (int i = 0; i <= largura; i++)
    {
        Console.Write(" ");
    }
    Console.WriteLine("|");
}

Console.Write("|");
for (int i = 0; i <= largura; i++)
{
    Console.Write("___");
}
Console.Write("|");