Console.WriteLine("=== Calculadora V2 ===");

double numero = pedirNumero("Ingrese un numero. \n");

Console.WriteLine($"\n Valor absoluto: {Math.Abs(numero)}");
Console.WriteLine($"\n Cuadrado: {Math.Pow(numero,2)}");

if (numero >= 0)
{
    Console.WriteLine($"\n Raiz cuadrada: {Math.Sqrt(numero)}");
}
else
{
    Console.WriteLine("Raiz cuadrada no definida para numeros negativos. ");
}

Console.WriteLine($"\n Coseno: {Math.Sin(numero)}");
Console.WriteLine($"\n Seno: {Math.Cos(numero)}");
Console.WriteLine($"\n Parte entera: {Math.Truncate(numero)}");

Console.Write("\n Ingrese dos numeros para comparar.");
double num1 = pedirNumero("Primer numero: ");
double num2 = pedirNumero("Segundo numero: ");

Console.WriteLine($"\n Maximo: {Math.Max(num1, num2)}");
Console.WriteLine($"\n Minimo: {Math.Min(num1, num2)}");

double pedirNumero(String mensaje)
{
    double numero;
    Console.WriteLine(mensaje);
    while (!double.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("\n Invalido. Ingrese un numero.");
    }
    return numero;
}