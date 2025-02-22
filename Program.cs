using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1) Calculadora básica");
            Console.WriteLine("2) Validación de contraseña");
            Console.WriteLine("3) Verificar número primo");
            Console.WriteLine("4) Sumar números pares");
            Console.WriteLine("5) Conversión de temperatura");
            Console.WriteLine("6) Contador de vocales");
            Console.WriteLine("7) Cálculo de factorial");
            Console.WriteLine("8) Juego de adivinanza");
            Console.WriteLine("9) Intercambio de valores");
            Console.WriteLine("10) Tabla de multiplicar");
            Console.WriteLine("11) Salir");

            Console.Write("Elija una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": Calculadora(); break;
                case "2": ValidarContraseña(); break;
                case "3": NumerosPrimos(); break;
                case "4": SumaPares(); break;
                case "5": ConversionTemperatura(); break;
                case "6": ContarVocales(); break;
                case "7": Factorial(); break;
                case "8": JuegoAdivinanza(); break;
                case "9": Intercambio(); break;
                case "10": TablaMultiplicar(); break;
                case "11": Console.WriteLine("Saliendo..."); return;
                default: Console.WriteLine("Opción no válida."); break;
            }
        }
    }

    static void Calculadora()
    {
        try
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Operaciones: 1) Suma 2) Resta 3) Multiplicación 4) División");
            Console.Write("Elija una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": Console.WriteLine($"Resultado: {num1 + num2}"); break;
                case "2": Console.WriteLine($"Resultado: {num1 - num2}"); break;
                case "3": Console.WriteLine($"Resultado: {num1 * num2}"); break;
                case "4":
                    if (num2 != 0) Console.WriteLine($"Resultado: {num1 / num2}");
                    else Console.WriteLine("No se puede dividir por cero.");
                    break;
                default: Console.WriteLine("Opción no válida."); break;
            }
        }
        catch { Console.WriteLine("Entrada inválida."); }
    }

    static void ValidarContraseña()
    {
        string contraseña = "1234";
        string intento;
        do
        {
            Console.Write("Ingrese la contraseña: ");
            intento = Console.ReadLine();
        } while (intento != contraseña);
        Console.WriteLine("Acceso concedido.");
    }

    static void NumerosPrimos()
    {
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(EsPrimo(num) ? "Es primo" : "No es primo");
    }

    static bool EsPrimo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    static void SumaPares()
    {
        int suma = 0, num;
        do
        {
            Console.Write("Ingrese un número (0 para salir): ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) suma += num;
        } while (num != 0);
        Console.WriteLine($"Suma de números pares: {suma}");
    }

    static void ConversionTemperatura()
    {
        Console.WriteLine("1) Celsius a Fahrenheit 2) Fahrenheit a Celsius");
        Console.Write("Elija una opción: ");
        string opcion = Console.ReadLine();
        Console.Write("Ingrese la temperatura: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        if (opcion == "1") Console.WriteLine($"Resultado: {(temp * 9 / 5) + 32} °F");
        else if (opcion == "2") Console.WriteLine($"Resultado: {(temp - 32) * 5 / 9} °C");
        else Console.WriteLine("Opción no válida.");
    }

    static void ContarVocales()
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine().ToLower();
        int contador = 0;
        foreach (char letra in frase) if ("aeiou".Contains(letra)) contador++;
        Console.WriteLine($"Número de vocales: {contador}");
    }

    static void Factorial()
    {
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());
        int resultado = 1;
        for (int i = 1; i <= num; i++) resultado *= i;
        Console.WriteLine($"Factorial de {num}: {resultado}");
    }

    static void JuegoAdivinanza()
    {
        Random rnd = new Random();
        int numeroSecreto = rnd.Next(1, 101);
        int intento;
        do
        {
            Console.Write("Adivina el número (1-100): ");
            intento = int.Parse(Console.ReadLine());
            Console.WriteLine(intento < numeroSecreto ? "Demasiado bajo." : intento > numeroSecreto ? "Demasiado alto." : "¡Correcto!");
        } while (intento != numeroSecreto);
    }

    static void Intercambio()
    {
        Console.Write("Ingrese el primer número: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        int b = int.Parse(Console.ReadLine());
        (a, b) = (b, a);
        Console.WriteLine($"Valores intercambiados: a = {a}, b = {b}");
    }

    static void TablaMultiplicar()
    {
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++) Console.WriteLine($"{num} x {i} = {num * i}");
    }
}
