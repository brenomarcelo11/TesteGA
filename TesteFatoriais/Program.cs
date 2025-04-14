using System;
class Program
{
    static void Main()
    {
        string linha;

        Console.Write("Digite pares de números (ex: 4 4): ");

        while ((linha = Console.ReadLine()) != null)
        {
            string[] partes = linha.Trim().Split(' ');
            int m = int.Parse(partes[0]);
            int n = int.Parse(partes[1]);

            long soma = Fatorial(m) + Fatorial(n);
            Console.WriteLine($"Soma dos fatoriais: {soma}");
            Console.WriteLine("---------------------------------------");

            Console.Write("Digite pares de números (ex: 4 4): ");
        }
    }

    static long Fatorial(int n)
    {
        long resultado = 1;
        for (int i = 2; i <= n; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
}
