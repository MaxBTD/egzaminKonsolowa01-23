
/****************************************************************************
    nazwa funkcji:          NWD()
    opis funkcji:            Funkcja oblicza najwiekszy wspolny
                            dzielnik algorytmem Euklidesa\
    parametry wejściowe:    int a - pierwsza liczba podana przez użytkownika
                            int b - druga liczba podana przez użytkownika
    zwracany typ i opis:     int - zmienna a, w której przechowywana jest
                            wartość NWD
    autor:                  12394372115
****************************************************************************/
int NWD(int a, int b)
{
    while (a != b)
    {
        if (a > b)
            a -= b;
        else
            b -= a;
    }

    return a;
}

int a, b;

do
{
    Console.WriteLine("Wprowadź pierwsza liczbe:  ");
} while (!int.TryParse(Console.ReadLine(), out a));

do
{
    Console.WriteLine("Wprowadź druga liczbe:  ");
} while (!int.TryParse(Console.ReadLine(), out b));

Console.WriteLine($"Najwiekszy wspólny dzielnik tych liczb: {NWD(a, b)}");