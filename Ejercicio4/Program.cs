Console.WriteLine("Ingrese una cadena de texto:");
string texto1 = Console.ReadLine().Trim(); // Elimina espacios al principio y final

// 1. Longitud de la cadena
Console.WriteLine($"La longitud de la cadena es: {texto1.Length}");

// 2. Concatenar con otra cadena
Console.WriteLine("Ingrese una segunda cadena para concatenar:");
string texto2 = Console.ReadLine().Trim();
string textoConcatenado = texto1 + " " + texto2;
Console.WriteLine($"Cadena concatenada: {textoConcatenado}");

// 3. Substring (extraer subcadena)
if (texto1.Length >= 5)
{
    string subcadena = texto1.Substring(0, 5);
    Console.WriteLine($"Subcadena de los primeros 5 caracteres: {subcadena}");
}

// 4. Calculadora con resultado en texto
Console.WriteLine("Ingrese el primer número:");
string strNum1 = Console.ReadLine().Trim();
Console.WriteLine("Ingrese el segundo número:");
string strNum2 = Console.ReadLine().Trim();
float num1 = float.Parse(strNum1);
float num2 = float.Parse(strNum2);
float suma = num1 + num2;
Console.WriteLine("La suma de " + num1.ToString() + " y " + num2.ToString() + " es igual a: " + suma.ToString());

// 5. Recorrer con foreach
Console.WriteLine("Caracteres de la primera cadena:");
foreach (char c in texto1)
{
    Console.WriteLine(c);
}

// 6. Buscar ocurrencia
Console.WriteLine("Ingrese una palabra a buscar en la primera cadena:");
string palabraBuscada = Console.ReadLine().Trim();
int posicion = texto1.IndexOf(palabraBuscada);
if (posicion >= 0)
    Console.WriteLine($"La palabra '{palabraBuscada}' fue encontrada en la posición: {posicion}");
else
    Console.WriteLine("La palabra no fue encontrada.");

// 7. Mayúsculas y minúsculas
Console.WriteLine("En mayúsculas: " + texto1.ToUpper());
Console.WriteLine("En minúsculas: " + texto1.ToLower());

// 8. Separar por un carácter con Split()
Console.WriteLine("Ingrese una cadena separada por comas:");
string lista = Console.ReadLine().Trim();
string[] partes = lista.Split(',');
Console.WriteLine("Elementos separados:");
foreach (string parte in partes)
{
    Console.WriteLine(parte.Trim());
}

// 9. Resolver ecuación simple tipo “20+5”
Console.WriteLine("Ingrese una ecuación simple (ej. 8+2, 9-4):");
string ecuacion = Console.ReadLine().Trim();
char[] operadores = { '+', '-', '*', '/' };
foreach (char op in operadores)
{
    int i = ecuacion.IndexOf(op);
    if (i > 0)
    {
        float op1 = float.Parse(ecuacion.Substring(0, i).Trim());
        float op2 = float.Parse(ecuacion.Substring(i + 1).Trim());
        float resultado = 0;

        switch (op)
        {
            case '+': resultado = op1 + op2; break;
            case '-': resultado = op1 - op2; break;
            case '*': resultado = op1 * op2; break;
            case '/': resultado = op2 != 0 ? op1 / op2 : float.NaN; break;
        }

        Console.WriteLine($"El resultado de {op1} {op} {op2} es: {resultado}");
        break;
    }
}

// BONUS: CompareTo y EndsWith
if (texto1.CompareTo(texto2) == 0)
    Console.WriteLine("Las dos cadenas ingresadas son iguales (CompareTo).");
else
    Console.WriteLine("Las cadenas no son iguales (CompareTo).");

if (texto1.EndsWith("fin"))
    Console.WriteLine("La cadena termina con 'fin'.");
else
    Console.WriteLine("La cadena no termina con 'fin'.");

