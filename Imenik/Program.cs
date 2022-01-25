bool izlaz = false;
List<string> Imena = new();
List<string> Email = new();
do
{
    StampajMeni();
    Console.Write("Izbor? ");
    string izb = Console.ReadLine();
    switch (izb)
    {
        case "1":
            unesiIme();
            break;

        case "2":
            eMail();
            break;

        case "3":
            index();
            break;

        case "4":
            indexEmail();
            break;

        case "5":
            brisanje();
            break;

        case "6":
            brisiEmail();
            break;

        case "7":
            dovidjenja();
            break;

        default:
            Console.WriteLine("ERROR INPUT");
            Console.ReadKey();
            break;
    }
    Console.Clear();

} while (!izlaz);

void StampajMeni()
{
    Console.WriteLine("==============================");
    Console.WriteLine("1. Unos osobe                |");
    Console.WriteLine("2. Unos E-mail adrese        |");
    Console.WriteLine("3. Prikaz osoba              |");
    Console.WriteLine("4. Prikaz email              |");
    Console.WriteLine("5. Brisanje imena            |");
    Console.WriteLine("6. Brisanje e-maila          |");
    Console.WriteLine("7. Izlaz                     |");
    Console.WriteLine("==============================");
}

void unesiIme()
{
    do
    {
        Console.Write("Unesite ime: ");
        Imena.Add(Console.ReadLine());

    } while (false);
}

void eMail()
{
    do
    {
        Console.Write("Unesite E-mail: ");
        Email.Add(Console.ReadLine());

    } while (false);
}


void index()
{
    for (int indeks = 0; indeks < Imena.Count; indeks++)
    {
        Console.WriteLine($"{indeks + 1}. {Imena[indeks]}");
    }
    Console.ReadKey();
}
void indexEmail()
{
    for (int indeks = 0; indeks < Email.Count; indeks++)
    {
        Console.WriteLine($"{indeks + 1}.{Email[indeks]}");
    }
    Console.ReadKey();
}

void brisanje()
{
    if (Imena.Remove(Console.ReadLine()))
    {
        Console.WriteLine("Uspesno obrisan");
        Console.ReadLine();
    }
    else
    {
        Imena.RemoveAt(Imena.Count - 1);
        Console.WriteLine("Ne");
    }
}

void brisiEmail()
{
    if (Email.Remove(Console.ReadLine()))
    {
        Console.WriteLine("Uspesno obrisan");
        Console.ReadLine();
    }
    else
    {
        Email.RemoveAt(Email.Count - 1);
        Console.WriteLine("Ne");
    }
}

void dovidjenja()
{
    Console.WriteLine("Dovidjenja");
    Console.ReadLine();
    izlaz = true;
}