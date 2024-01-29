interface iVenta
{
    decimal Total { get; set; }
}

interface iSave
{
    public void Save();

}

public class Ventas : iVenta, iSave
{
    public decimal Total { get; set; }

    public void Save()
    {
        Console.WriteLine("Interfaz aplicada correctamente : iSave !");
    }

}

public class Auto : iSave
{
    public void Save()
    {
        Console.WriteLine("Interfaz aplicada en AUTO");
    }
}

