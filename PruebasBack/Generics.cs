using System.Runtime.CompilerServices;

public class MiLista<T>
{
    private List<T> _list;
    private int _limit;

    public MiLista(int _limit)
    {
        this._limit = _limit;
        this._list = new List<T>();
    }

    public void add(T element)
    {
        if (this._list.Count < this._limit)
        {
            this._list.Add(element);
        }

    }

    public void getInfo()
    {
        for (var i = 0; i < this._limit; i++)
        {
            Console.WriteLine(this._list[i]);
        }
    }
}