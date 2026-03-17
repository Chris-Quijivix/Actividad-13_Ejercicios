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


}
