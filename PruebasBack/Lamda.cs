class Lamda
{

    Func<int, int, int> sub = (a, b) => a - b;

    Func<int, int> multi = a => a * 2;

    Func<int, int> divi = a =>
    {
        return a / 2;
    };

}