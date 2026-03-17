class Estudiante
{
    public string Nombre;
    public double Nota1;
    public double Nota2;
    public double Nota3;

    public double Promedio()
    {
        return (Nota1 +  Nota2 + Nota3) / 3;
    }

    public string Estado()
    {
        if (Promedio() >= 61)
        {
            return "Aprobado";
        }
        else
        {
            return "Reprobado";
        }
    }

    public void Mostrar()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Promedio: " + Promedio().ToString("F2"));
        Console.WriteLine("Estado: " + Estado());
    }
}

class program
{
    static void Main()
    {
        List<Estudiante> lista = new List<Estudiante>();

        Console.WriteLine("Ingrese la cantidad de estudiantes a registrar: ");
        int cantidad = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            Estudiante e = new Estudiante();

            Console.WriteLine("Estudiante" + (i + 1));

            Console.WriteLine("Nombre del estudiante: ");
            e.Nombre = Console.ReadLine();

            Console.WriteLine("Primer Nota: ");
            e.Nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segunda Nota: ");
            e.Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Tercera Nota: ");
            e.Nota3 = double.Parse(Console.ReadLine());

            lista.Add(e);
        }

        Console.WriteLine("Listado de estudiantes: ");
        foreach (Estudiante e in lista)
        {
            e.Mostrar();
        }

        Estudiante mejor = lista[0];

        foreach (Estudiante e in lista)
        {
            if (e.Promedio() > mejor.Promedio());
            {
                mejor = e;
            }
        }
        Console.WriteLine("Mejor Estudiante");
        mejor.Mostrar();

        Console.ReadKey();
    }
}
