using System;

class Program
{
    static void Main()
    {
        int testes;

        Console.Write("Insira o número de testes desejados: ");
        testes = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < testes; i++)
        {
            Console.Write("Digite o número desejado: ");
            string numero = Console.ReadLine().Trim();

            int leds = CalcularLeds(numero);

            Console.WriteLine($"{leds} leds");
            Console.WriteLine("------------------------------------");
        }
    }

    static int CalcularLeds(string numero)
    {
        int leds = 0;

        foreach (char digito in numero)
        {
            switch (digito)
            {
                case '0':
                    leds += 6;
                    break;

                case '1':
                    leds += 2;
                    break;

                case '2':
                    leds += 5;
                    break;

                case '3':
                    leds += 5;
                    break;

                case '4':
                    leds += 4;
                    break;

                case '5':
                    leds += 5;
                    break;

                case '6':
                    leds += 6;
                    break;

                case '7':
                    leds += 3;
                    break;

                case '8':
                    leds += 7;
                    break;

                case '9':
                    leds += 6;
                    break;
            }
        }

        return leds;
    }
}
