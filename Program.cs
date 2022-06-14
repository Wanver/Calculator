using System;
internal class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtracao");
        Console.WriteLine("3 - Divisao");
        Console.WriteLine("4 - Multiplicacao");
        Console.WriteLine("5 - Porcentagem");
        Console.WriteLine("6 - Sair");

        Console.WriteLine("-------------------");
        Console.WriteLine("Selecione uma opcao: ");

        short res = short.Parse(Console.ReadLine());

        switch (res)
        {

            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: Porcentagem(); break;
            case 6: System.Environment.Exit(0); break;
            default: Menu(); break;

        }
    }
    static void Soma()
    {

        Console.Clear();
        Console.WriteLine("Primeiro valor ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());


        Console.WriteLine(" ");

        float resultado = v1 + v2;
        // Console.WriteLine("O resultado da soma e: " + resultado);
        Console.WriteLine($"O resultado da soma e: {resultado}");
        // Console.WriteLine($"O resultado da soma e: {v1 + v2}");
        // Console.WriteLine("O resultado da soma e: " + (v1 + v2));

        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 - v2;
        Console.WriteLine($"O resultado da subatracao e: {resultado} ");
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 / v2;
        Console.WriteLine($"O resultado da divisao e: {resultado}");
        Console.ReadKey();
        Menu();

    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 * v2;
        Console.WriteLine($"O resultado da multiplicacao e: {resultado}");

        Console.ReadKey();
        Menu();
    }

    static void Porcentagem()
    {
        Console.Clear();

        Console.WriteLine("Primeiro digite o valor real: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Agora digite a porcentagem: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = (v1 / 100) * v2;
        Console.WriteLine($"O resultado é: {resultado}");

        Console.ReadKey();
        Menu();

    }
}