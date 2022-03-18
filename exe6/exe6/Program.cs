int a = 0;
int b = 1;
int c = 0;

for (int i = 2; i < 20; i++)
{
    c = a + b;
    a = b;
    b = c;
        
    
    Console.WriteLine(a);
}

