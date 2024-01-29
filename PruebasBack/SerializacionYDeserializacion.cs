public class Persona
{
    public string nombre { get; set; }
    public int edad { get; set; }

    public Persona(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad   = edad;
    }

    public string getNombre()
    {
        return this.nombre;
    }

    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public int getEdad()
    {
        return this.edad;
    }

    public void setEdad(int edad)
    {
        this.edad = edad;
    }

    public override string ToString()
    {
        return this.nombre + " " + this.edad;
    }
}