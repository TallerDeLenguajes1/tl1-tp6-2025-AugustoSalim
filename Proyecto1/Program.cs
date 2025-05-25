// See https://aka.ms/new-console-template for more information

float result;
int eleccion = 1, nEleccion;

do
{
    Console.WriteLine("Ingrese el primer numero con el que quiere trabajar");
    string y = Console.ReadLine();
    int numeroy;
    bool esNumeroy = int.TryParse(y, out numeroy);

    Console.WriteLine("Ingrese el segundo numero con el que quiera trabajar");
    string x = Console.ReadLine();
    int numerox;
    bool esNumerox = int.TryParse(x, out numerox);

    Console.WriteLine("Ingrese la operacion que quiere realizar:");
    Console.WriteLine("1) Suma");
    Console.WriteLine("2) Resta");
    Console.WriteLine("3) Multiplicacion");
    Console.WriteLine("4) Division");
    Console.WriteLine("0) Salir");
    string choice = Console.ReadLine();
    bool esNumeroEleccion = int.TryParse(choice, out eleccion);

    switch (eleccion)
    {
        case 1:
            result = numeroy + numerox;
            Console.WriteLine($"Resultado: {numeroy} + {numerox} = {result}");
            break;
        case 2:
            result = numeroy - numerox;
            Console.WriteLine($"Resultado: {numeroy} - {numerox} = {result}");
            break;
        case 3:
            result = numeroy * numerox;
            Console.WriteLine($"Resultado: {numeroy} x {numerox} = {result}");
            break;
        case 4:
            if (numerox == 0)
            {
                Console.WriteLine("Error: División por cero no permitida.");
            }
            else
            {
                result = numeroy / numerox;
                Console.WriteLine($"Resultado: {numeroy} / {x} = {result}");
            }
            break;
    }
    Console.WriteLine("Quiere seguir? 1)- Si 0)- No");
    choice = Console.ReadLine();
    bool nuevaEleccion = int.TryParse(choice, out nEleccion);
    eleccion = nEleccion;
} while (eleccion != 0);



do
{
    Console.WriteLine("Ingrese el primer numero con el que quiere trabajar");
    string num1 = Console.ReadLine();
    float numero1;
    bool esNumero1 = float.TryParse(num1, out numero1);

    if (esNumero1)
    {
        result = Math.Abs(numero1);
        Console.WriteLine($"Valor Absoluto: |{numero1}| = {result}");

        result = (float)Math.Pow(numero1, 2);
        Console.WriteLine($"Potencia de 2: {numero1}^2 = {result}");

        result = (float)Math.Sqrt(numero1);
        Console.WriteLine($"Raiz Cuadrada: {numero1}^(1/2) = {result}");

        result = (float)Math.Sin(numero1);
        Console.WriteLine($"Seno: Sen({numero1}) = {result}");

        result = (float)Math.Cos(numero1);
        Console.WriteLine($"Coseno: Cos({numero1}) = {result}");

        result = (int)numero1;
        Console.WriteLine($"Parte Entera: Parte entera de {numero1} = {result}");
    }
    else
    {
        Console.WriteLine("Entrada inválida. Debes ingresar un número.");
    }

    Console.WriteLine("Ingrese el primer numero con el que quiere trabajar");
    string num2 = Console.ReadLine();
    int numero2;
    bool esNumero2 = int.TryParse(num2, out numero2);

    Console.WriteLine("Ingrese el segundo numero con el que quiera trabajar");
    string num3 = Console.ReadLine();
    int numero3;
    bool esNumero3 = int.TryParse(num3, out numero3);

    if (numero2 > numero3)
    {
        Console.WriteLine($"El maximo entre los dos numeros es: {numero2}");
        Console.WriteLine($"El minimo entre los dos numeros es: {numero3}");
    }
    else if (numero2 < numero3)
    {
        Console.WriteLine($"El maximo entre los dos numeros es: {numero3}");
        Console.WriteLine($"El minimo entre los dos numeros es: {numero2}");
    }
    else
    {
        Console.WriteLine($"El numero {numero2} y el numero {numero3} son los mismos");
    }

    Console.WriteLine("Quiere seguir? 1)- Si 0)- No");
    string choice = Console.ReadLine();
    bool nuevaEleccion = int.TryParse(choice, out nEleccion);
    eleccion = nEleccion;
} while (eleccion != 0);
