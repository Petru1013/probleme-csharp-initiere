namespace probleme_vectori
{
    public class Solutii
    {
        // Se dă un șir cu n elemente, numere naturale.
        // Determinați diferența în valoare absolută dintre numărul
        // de valori pare din șir și numărul de valori impare din șir.
        
        public static void Problema1()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            int pare, impare;
            Functii.CatePareSiImpare(vector, out pare, out impare);
            Console.WriteLine(Math.Abs(pare - impare));
        }

        // Se citește un vector cu n elemente, numere naturale.
        // Să se înlocuiască ultimul element prim din vector cu 0,
        // apoi să se afișeze vectorul.

        public static void Problema2()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            Functii.InlocuireUltimPrim(vector);
            Functii.Afisare(vector);
        }

        // Se citește un vector cu n elemente, numere naturale.
        // Să se afișeze elementele din vector care sunt
        // multipli ai ultimului element.

        public static void Problema3()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            Functii.AfisareMultipliiLast(vector);
        }

        // Se citește un vector cu n elemente, numere naturale.
        // Să se afișeze elementele cu indici pari în ordinea crescătoare a indicilor,
        // iar elementele cu indici impari în ordinea descrescătoare a indicilor.

        public static void Problema4()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            Functii.AfisareIndiciPari(vector);
            Console.WriteLine();
            Functii.AfisareIndiciImpari(vector);
        }

        // Se citește un vector cu n elemente, numere naturale.
        // Să se afișeze elementele vectorului în următoarea ordine: primul, ultimul, al doilea, penultimul, etc.

        public static void Problema5()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            Functii.AfisareaOrdineaVect(vector);
        }
        
        // Sa se verifice daca numarul n este palindrom (ex: 121 palindrom, 123 nu e palindrom)

        public static void Problema6()
        {
            int n;
            Console.Write("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Numarul " + (Functii.EstePalindrom(n) ? "" : "nu ") + "este palindrom.");
        }

        //Se dă n. Să se afișeze 10n.

        public static void Problema7()
        {
            int n;
            Console.Write("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(Functii.Power(10, n));
        }

        //Se dau n numere naturale.Calculați media lor geometrică
        public static void Problema8()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            Console.WriteLine(Math.Pow(Functii.ProdusVector(vector), (double)1 / vector.Length));
        }

        //Se dau două numere naturale nenule n și p. Afișați în ordine crescătoare puterile lui n mai mici sau egale cu p.
        public static void Problema9()
        {
            int n = 3, p = 82;
            int maxp = Functii.MaxPower(n, p);

            for(int i = 0; i <= maxp; i++)
            {
                Console.Write(Functii.Power(n, i) + " ");
            }
            Console.WriteLine();
        }

        public static void Problema10()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            Console.WriteLine("Numarele " + (Functii.CuburiPerfecte(vector) ? "" : "nu ") + "sunt cuburi.");
        }
    }
}
