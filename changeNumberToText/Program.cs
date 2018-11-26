using System;

class Program
{

    static void Main()
    {
        const int MaxValue = 19;
        const int MinValue = -19;
        Console.WriteLine("Iveskite sveika skaiciu nuo -19 iki 19.");
        string ivedimas = Console.ReadLine();
        if (ArSkaicius(ivedimas))
        {
            //Console.WriteLine($"Ivesta {ivedimas} reiksme yra skaicius.");
            int skaicius = Convert.ToInt32(ivedimas); 
            if (PatikrintiRezi(skaicius, MaxValue, MinValue))
            {
                //Console.WriteLine($"Ivestas skaicius {ivedimas} teisinguose reziuose.");
                Console.WriteLine($"Reiksme zodziais:\n{ArNeigiamas(skaicius)}"+ SkaiciaiZodziais(Math.Abs(skaicius)));
            }
            else
            {
                Console.WriteLine($"Ivestas skaicius {ivedimas} neteisinguose reziuose.");
            }
        }
        else
        {
            Console.WriteLine($"Ivesta {ivedimas} reiksme nera skaicius.");
        }

        Console.ReadLine();
    }


    static bool ArSkaicius(string ivedimas)
    {
        //if (ivedimas == "-9" || ivedimas == "-8" || ivedimas == "-7" || ivedimas == "-6" || ivedimas == "-5" || ivedimas == "-4" || ivedimas == "-3" || ivedimas == "-2" || ivedimas == "-1" || ivedimas == "0" || ivedimas == "1" || ivedimas == "2" || ivedimas == "3" || ivedimas == "4" || ivedimas == "5" || ivedimas == "6" || ivedimas == "7" || ivedimas == "8" || ivedimas == "9")
        //{
        //    return true;
        //}
        //    return false;
        int arSkaicius;
        bool skaicius = int.TryParse(ivedimas, out arSkaicius);
        return skaicius;
    }

    static bool PatikrintiRezi(int skaicius, int MaxValue, int MinValue)
    {
        if (skaicius >= MinValue && skaicius <= MaxValue)
        {
            return true;
        }
        return false;
    }


    static string ArNeigiamas(int skaicius)
    {
        if (skaicius < 0)
        {
            return "minus ";
        }
        return " ";
    }


    static string SkaiciaiZodziais(int skaicius)
    {
        if (skaicius < 10)
        {
            return SkaiciaiVienetai(skaicius);
        }

        return " ";
    }

    static string SkaiciaiVienetai(int skaicius)
    {
        switch (skaicius)
        {
            case 0:
                return "nulis";
            case 1:
                return "vienas";
            case 2:
                return "du";
            case 3:
                return "trys";
            case 4:
                return "keturi";
            case 5:
                return "penki";
            case 6:
                return "sesi";
            case 7:
                return "septyni";
            case 8:
                return "astuoni";
            case 9:
                return "devyni";
            default:
                return "Klaida";  
        }
         

        //if (skaicius == 0)
        //{
        //    return "nulis";
        //}
        //else if (skaicius == 1)
        //{
        //    return "vienas";
        //}
        //else if (skaicius == 2)
        //{
        //    return "du";
        //}
        //else if (skaicius == 3)
        //{
        //    return "trys";
        //}
        //else if (skaicius == 4)
        //{
        //    return "keturi";
        //}
        //else if (skaicius == 5)
        //{
        //    return "penki";
        //}
        //else if (skaicius == 6)
        //{
        //    return "sesi";
        //}
        //else if (skaicius == 7)
        //{
        //    return "septyni";
        //}
        //else if (skaicius == 8)
        //{
        //    return "astuoni";
        //}
        //else if (skaicius == 9)
        //{
        //    return "devyni";
        //}
        //else if (skaicius == 10)
        //{
        //    return "desimt";
        //}
        //else if (skaicius == 11)
        //{
        //    return "vienuolika";
        //}
        //else if (skaicius == 12)
        //{
        //    return "dvylika";
        //}
        //else if (skaicius == 13)
        //{
        //    return "trylika";
        //}
        //else if (skaicius == 14)
        //{
        //    return "keturiolika";
        //}
        //else if (skaicius == 15)
        //{
        //    return "penkiolika";
        //}
        //else if (skaicius == 16)
        //{
        //    return "sesiolika";
        //}
        //else if (skaicius == 17)
        //{
        //    return "septyniolika";
        //}
        //else if (skaicius == 18)
        //{
        //    return "astuoniolika";
        //}
        //else
        //{
        //    return "devyniolika";
        //}
    }
 }