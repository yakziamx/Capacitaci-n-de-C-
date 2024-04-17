public static class Calculadora
{
    public static void Sumar(int numeroUno, int numeroDos){
        int resultado = numeroUno + numeroDos;
        string mensaje = $"La suma de {numeroUno} + {numeroDos}";
        ImprimirResultado(mensaje, resultado);
    }

    public static void Restar(int numeroUno, int numeroDos)
    {
        int resultado = numeroUno - numeroDos;
        string mensaje = $"La resta de {numeroUno} - {numeroDos}";
        ImprimirResultado(mensaje, resultado);
    }

    public static void Multiplicar(int numeroUno, int numeroDos)
    {
        int resultado = numeroUno * numeroDos;
        string mensaje = $"La multiplicación de {numeroUno} x {numeroDos}";
        ImprimirResultado(mensaje, resultado);
    }

    public static void Dividir(double numeroUno, double numeroDos)
    {
        double resultado = numeroUno / numeroDos;
        string mensaje = $"La división de {numeroUno} / {numeroDos}";
        ImprimirResultado(mensaje, resultado);
    }

    private static void ImprimirResultado(string mensaje, int resultado){
        Console.WriteLine(mensaje);

        var colorDeFuenteOriginal = Console.ForegroundColor;
        Console.ForegroundColor = ObtenerColorDeConsolaPersonalizado(resultado);

        Console.WriteLine($"= {resultado}");
        
        Console.ForegroundColor = colorDeFuenteOriginal;
        Console.ReadLine();
    }

    private static void ImprimirResultado(string mensaje, double resultado)
    {
        Console.WriteLine(mensaje);

        var colorDeFuenteOriginal = Console.ForegroundColor;
        Console.ForegroundColor = ObtenerColorDeConsolaPersonalizado(resultado);

        Console.WriteLine($"= {resultado}");
        
        Console.ForegroundColor = colorDeFuenteOriginal;
        Console.ReadLine();
    }

    private static ConsoleColor ObtenerColorDeConsolaPersonalizado(double resultado)
    {
        if (resultado == 0)
            return ConsoleColor.Blue;
        else if (resultado > 0)
            return ConsoleColor.Green;
        else
            return ConsoleColor.Red;
    }
}
