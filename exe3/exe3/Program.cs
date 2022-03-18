
const char Caract = 'X';
const char Espaco = ' ';
int larg = 5, comp = 10;
for (int c = 1; c <= comp; c++) 
    Console.Write(Caract);
Console.WriteLine();
for (int l = 1; l <= larg; l++)
{
    Console.Write(Caract);
    for (int w = 2; w <= comp - 1; w++) 
        Console.Write(Espaco);
    Console.WriteLine(Caract);
}
for (int c = 1; c <= comp; c++)   
    Console.Write(Caract);
    Console.WriteLine();
    
