/* Registrar datos de una persona
nombres, apellidos, sexo, edad
*/
using System;
struct Persona
{
    public string nombre;
   public string apellidos;
    public Boolean sexo;
    public int edad;
}

class Program()
{
    static Persona[] personas = new Persona[10];

    public static void Agregar(string nom, string ape, int edad, Boolean sexo, int posicion)
    {
        Persona per = new Persona();
        per.nombre = nom;
        per.apellidos = ape;
        per.edad = edad;
        per.sexo = sexo;
        personas[posicion] = per;
        Console.Beep();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Registro guardado");
        Console.ResetColor();

    }

    public static void PedirDatos(int pos)
    {
        string nombre;
        string apellidos;
        bool sexo;
        int edad;

        Console.Write("Dime tu nombre: ");
        nombre = Console.ReadLine();
        Console.Write("Dime tu apellido: ");
        apellidos = Console.ReadLine();
        Console.Write("Dime tu sexo [True para masculino, False para femenino]: ");
        sexo = Boolean.Parse(Console.ReadLine());
        Console.Write("Dime tu edad: ");
        edad = int.Parse(Console.ReadLine());

        Agregar(nombre, apellidos, edad, sexo, pos);

    }

    public static void Menu()
    {
        int op = 0, pos = 0;
        do
        {
            Console.WriteLine("1. Agregar ");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("3. Eliminar ");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Opcion");
            op = int.Parse(Console.ReadLine());
        } while (op != 4);
    }
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;

        Menu();
    }
}



