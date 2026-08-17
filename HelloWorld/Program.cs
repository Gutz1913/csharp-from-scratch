namespace HelloWorld;

class Program
{
    static void Main()
    {
        var dateConverted = new DateOnly();
        var nameInput = string.Empty;
        var birthDateInput = string.Empty;
        Console.WriteLine("¡Hola, Bienvenido al calculador de años!");
        Console.Write("Escribe tu nombre: ");
        nameInput = Console.ReadLine();
        Console.WriteLine($"Un gusto conocerte {nameInput}");
        Console.Write("Escribe tu fecha de nacimiento en formato dd/mm/yy: ");
        birthDateInput = Console.ReadLine();
        bool isDateValid = DateOnly.TryParse(birthDateInput, out dateConverted);
        if (!isDateValid)
            Console.WriteLine($"La fecha de nacimiento es inválida, usted nos envió este dato erróneo: {birthDateInput}");
        var person = new Person
        {
            Name = nameInput,
            BirthDate = dateConverted,
            Age = DateTime.Now.Year - dateConverted.Year
        };

        Console.WriteLine($"Tú nombre es.............: {person.Name}");
        Console.WriteLine($"Tú fecha de nacimiento es: {person.BirthDate}");
        Console.WriteLine($"Tú edad es...............: {person.Age} años");

        Console.WriteLine();
    }

    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}