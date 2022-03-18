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
