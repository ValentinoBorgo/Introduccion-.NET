class funcionesPuras
{
     public static int resta(int a, int b)
    {
        return a - b;
    }

    public static DateTime obtenerMañana(DateTime date)
    {
        return date.AddDays(1);
    }

    public static string mostrar(string mensaje)
    {
        return mensaje;
    }
}