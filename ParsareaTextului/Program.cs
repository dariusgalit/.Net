using System;

class Program
{
    static void Main()
    {
        string text = "John.Davidson/Belgrade Michael.Barton/Krakow Ivan.Perkinson/Moscow";

        string[] persoaneText = text.Split(' ');

        Person[] persoane = new Person[persoaneText.Length];

        for (int i = 0; i < persoaneText.Length; i++)
        {
            string[] numeOras = persoaneText[i].Split('/');

            string[] prenumeNume = numeOras[0].Split('.');

            string prenume = prenumeNume[0];
            string nume = prenumeNume[1];
            string oras = numeOras[1];

            persoane[i] = new Person(prenume, nume, oras);
        }

        foreach (Person p in persoane)
        {
            p.Afisare();
            Console.WriteLine();
        }
    }
}
