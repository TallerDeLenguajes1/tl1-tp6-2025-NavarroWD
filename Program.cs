
bool continuar = true;

while (continuar)
{
    Console.Write(" ------ CALCULADORA ------- \n");
    Console.Write("Ingrese una opcion:  \n");
    Console.Write("1: SUMAR \n");
    Console.Write("2: RESTAR \n");
    Console.Write("3: MULTIPLICAR \n");
    Console.Write("4: DIVIDIR \n");
    Console.Write("5: SALIR \n");
    string opcion = Console.ReadLine();

    bool numero = int.TryParse(opcion, out int i);
    if (opcion == "5")
    {
        Console.Write("Saliendo... \n");
        break;
    }

    int num1, num2;

    Console.Write("Ingrese el primer numero.  \n");
    while (!int.TryParse(Console.ReadLine(), out num1))
    {
        Console.Write("Ingrese un numero valido.  \n");
    }

    Console.Write("Ingrese el segundo numero.  \n");
    while (!int.TryParse(Console.ReadLine(), out num2))
    {
        Console.Write("Ingrese un numero valido.  \n");
    }

    int resultado = 0;

    switch (opcion)
    {
        case "1":
            resultado = num1 + num2;
            Console.Write($"Resultado: {resultado} \n");
            break;
        case "2":
            resultado = num1 - num2;
            Console.Write($"Resultado: {resultado} \n");
            break;
        case "3":
            resultado = num1 * num2;
            Console.Write($"Resultado: {resultado} \n");
            break;
        case "4":
            resultado = num1 / num2;
            Console.Write($"Resultado: {resultado} \n");
            break;
        default:
            Console.Write("Opcion no valida. \n");
            break;
    }
    Console.Write("\n Desea realizar otro calculo? \n");
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower() != "s")
            {
                continuar = false;
            }


}



