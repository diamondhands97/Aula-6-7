
    const int valorInicia = 1500, anoInicial = 2022, totalAnos = 3;
    int i;

    Console.WriteLine(String.Format("{0,8}|{1,8}|{2,8}|{3,8}|", "1500$", "2%", "2.5%", "3%"));

    for (i = 1; i <= totalAnos; i++)
    {
        Console.Write(String.Format("{0,8}|", anoInicial + i));
        Console.Write(String.Format("{0,8}|", Math.Round(valorInicia * Math.Pow(1 + (2.0 / 100), i), 2)));
        Console.Write(String.Format("{0,8}|", Math.Round(valorInicia * Math.Pow(1 + (2.5 / 100), i), 2)));
        Console.Write(String.Format("{0,8}|", Math.Round(valorInicia * Math.Pow(1 + (3.0 / 100), i), 2)));
        Console.WriteLine();
    }

/*Console.Write("|-----------|--------|-----------|-----------|-----------------------------------------------------------------------");
Console.Write("| 1500€ | 2% | 2,5% | 3% |");
Console.Write("|-----------|--------|-----------|-----------|-----------------------------------------------------------------------");
Console.Write("| 2023 | {0} | {1} | {2} |", total[1][1], total[1][2], total[1][3]);
Console.Write("|-----------|--------|-----------|-----------|-----------------------------------------------------------------------");
Console.Write("| 2024 | {0} | {1} | {2} |", total[2][1], total[2][2], total[2][3]);
Console.Write("|-----------|--------|-----------|-----------|-----------------------------------------------------------------------");
Console.Write("| 2025 | {0} | {1} | {2} |", total[3][1], total[3][2], total[3][3]);
Console.Write("|-----------|--------|-----------|-----------|-----------------------------------------------------------------------");
*/

