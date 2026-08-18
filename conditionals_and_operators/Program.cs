using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    try
    {
        /*Conditionals*/

        // var num = ConsoleExtension.GetInt("Escribe un número entero: ");
        // if (num > 0)
        //     Console.WriteLine("El número es positivo");
        // else if (num < 0)
        //     Console.WriteLine("El número es negativo");
        // else
        //     Console.WriteLine("El número es cero");

        /*End Conditionals*/

        /*********************************************************************************************/

        /*Operators*/

        var num1 = ConsoleExtension.GetDouble("Ingrese el primer número.: ");
        var num2 = ConsoleExtension.GetDouble("Ingrese el segundo número: ");

        Console.WriteLine($"Suma..........: {num1 + num2}");
        Console.WriteLine($"Resta.........: {num1 - num2}");
        Console.WriteLine($"Multiplicación: {num1 * num2}");
        Console.WriteLine($"División......: {(num2 != 0 ? num1/num2 : "Indeterminado")}");



        /*End Operators*/
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar [S]í, [N]o?: ", options);        
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("::::: GAME OVER ::::::");



