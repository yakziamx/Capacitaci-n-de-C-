bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine("Bienvenido a la calculadora de Yakzia");
    Console.WriteLine("Opciones disponibles");
    Console.WriteLine("1. Sumar 2 números");
    Console.WriteLine("2. Restar 2 números");
    Console.WriteLine("3. Multiplicar 2 números");
    Console.WriteLine("4. Dividir 2 números");
    Console.WriteLine("5. Salir de la aplicación");
    Console.WriteLine();
    Console.Write("Escribe el número de opción: ");

    string? opcion = Console.ReadLine();
    int numeroOpcion = 0;
    bool esOpcionNumerica = int.TryParse(opcion, out numeroOpcion);
    Console.WriteLine();

    if (!esOpcionNumerica)
    {
        Console.WriteLine($"La opción que escribiste ({opcion}) no es válida.");
        Console.ReadLine();
        continue;
    }

    if (numeroOpcion > 5)
    {
        Console.WriteLine($"El número de opción que escribiste ({numeroOpcion}) no es válido.");
        Console.ReadLine();
        continue;
    }
    else if (numeroOpcion == 5)
    {
        Console.WriteLine("Gracias por usar la calculadora.");
        break;
    }

    int numeroUno = 0;
    int numeroDos = 0;

    Console.WriteLine();

    Console.Write("Indica el primer número entero: ");
    string? textoNumeroUno = Console.ReadLine();
    if(int.TryParse(textoNumeroUno, out numeroUno) == false){
        Console.WriteLine("No escribiste un número entero válido.");
        Console.ReadLine();
        continue;
    }

    Console.Write("Indica el segundo número entero: ");
    string? textoNumeroDos = Console.ReadLine();
    if(int.TryParse(textoNumeroDos, out numeroDos) == false){
        Console.WriteLine("No escribiste un número entero válido.");
        Console.ReadLine();
        continue;
    }

    Console.WriteLine();

    switch (numeroOpcion){
        case 1:
            Calculadora.Sumar(numeroUno, numeroDos);
            break;
        case 2:
            Calculadora.Restar(numeroUno, numeroDos);
            break;
        case 3:
            Calculadora.Multiplicar(numeroUno, numeroDos);
            break;
        case 4:
            Calculadora.Dividir(numeroUno, numeroDos);
            break;
    }
}

Console.ReadLine();