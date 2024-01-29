class LINQ
{
    public void Nombres()
    {

        var nombres = new List<string>()
    {
        "Vale",
        "Osvaldo",
        "Opaco11",
        "SPINO"
        };

        var nameresult = from n in nombres
                         where n.Length > 4
                         orderby n
                         select n;

        foreach (var nombre in nameresult)
        {
            Console.WriteLine(nombre);
        }

    }
}