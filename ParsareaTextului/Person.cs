using System;
class Person
{
    public string Prenume { get; set; }
    public string Nume { get; set; }
    public string Oras { get; set; }

    public Person(string prenume, string nume, string oras)
    {
        Prenume = prenume;
        Nume = nume;
        Oras = oras;
    }

    public void Afisare()
    {
        Console.WriteLine($"{Prenume} {Nume} {Oras}");
    }
}
