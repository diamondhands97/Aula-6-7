
    Console.Write("Limite superior do intervalo de inteiros?");
    int N = Convert.ToInt32(Console.ReadLine());
    int Soma = 0;

    for (int i = 1; i <= N; i++) 
    {
        Soma += i;
    }

    Console.WriteLine("Total da adição dos {0} inteiros={1}", N, Soma);
