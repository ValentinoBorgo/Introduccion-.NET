using System.ComponentModel.DataAnnotations;
using System.Text.Json;
/*VentaImpuestos venta = new VentaImpuestos(12, "Valentino");
venta.setTotal(234);
venta.setNombre("Valentino Borgo");
Console.WriteLine(venta.getInfo());
Ventas ventas = new Ventas();
ventas.Save();
Auto auto = new Auto();
auto.Save();
MiLista<int> list = new MiLista<int>(5);
MiLista<String> nombres = new MiLista<String>(2);
list.add(1);
list.add(2);
list.add(3);
list.add(4);
list.add(5);
list.getInfo();
nombres.add("Carlos");
nombres.add("Vale");
nombres.add("Marino");
nombres.getInfo();
*/

Persona per1 = new Persona("Valentino", 24);
Console.WriteLine(per1.ToString());

string json = JsonSerializer.Serialize(per1);

Console.WriteLine(json);

string myJson = @"{
    ""nombre"":""Valentino"",
    ""edad"":24
}
";

Persona? per2 = JsonSerializer.Deserialize<Persona>(myJson);
Console.WriteLine(per2?.getNombre()+ " " + per2?.getEdad());

DateTime hoy = new DateTime(2024,01,29);

Console.WriteLine(funcionesPuras.resta(10,2));
Console.WriteLine(funcionesPuras.obtenerMañana(hoy));

var muestra = funcionesPuras.mostrar("HOLA MAN");
Console.WriteLine(muestra);

LINQ li = new LINQ();
li.Nombres();




class Venta
{
    //Convencion de privacidad en C# "_".
    private decimal _Total { get; set; }

    public Venta(decimal total)
    {
        this._Total = total;
    }

    //Virtual se utiliza para adaptar el metodo a que pueda sobreescribirse
    public virtual String getInfo()
    {
        return "El total es " + this._Total;
    }

    public decimal getTotal()
    {
        return this._Total;
    }

    public void setTotal(decimal total)
    {
        this._Total = total;
    }

}

class VentaImpuestos : Venta
{
    private string nombre;

    public VentaImpuestos(decimal total, string nombre) : base(total)
    {
        this.nombre = nombre;
    }

    public string getNombre()
    {
        return this.nombre;
    }

    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }

    //Metodo sobreescrito
     public override String getInfo()
    {
        return "El total es " + this.getTotal() + " y el nombre del contribuyente es " + this.nombre;
    }
}

