/*
    Escribir un programa que muestre en pantalla los números del 1 al 50, sustituyendo
    los múltiplos de 3 por la palabra “Fizz”, 
    los múltiplos de 5 por "Buzz" y 
    los múltiplos de ambos, es decir, los múltiplos de 3 y 5, por la palabra “FizzBuzz”.
*/

int inicio = 1;
int fin = 50;

for (int i = inicio; i <= fin; i++) 
{
    string imprimir = string.Empty;

    if (i % 3 == 0 && i % 5 == 0)
        imprimir = "FizzBuzz";
    else if (i % 3 == 0)
        imprimir = "Fizz";
    else if (i % 5 == 0)
        imprimir = "Buzz";
    else
        imprimir = i.ToString();

    Console.WriteLine(imprimir);
}