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

        // Se dă un șir cu n elemente, numere naturale. Determinați diferența în valoare
        // absolută dintre numărul de valori pare din șir și numărul de valori impare din șir.

        public static void Problema11()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            Console.WriteLine("Diferenta absoluta intre pare si impare: " + Functii.CalculeazaDiferenta(vector));
        }

        // Se citește un vector cu n elemente, numere naturale.
        // Să se înlocuiască ultimul element prim din vector cu 0, apoi să se afișeze vectorul.

        public static void Problema12()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            Functii.ReplaceLastPrime(vector);
            Functii.Afisare(vector);
        }

        // Se citește un vector cu n elemente, numere naturale.
        // Să se înlocuiască fiecare element prim din vector cu 0, apoi să se afișeze vectorul.
        public static void Problema13()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            Functii.ReplaceAllPrimes(vector);
            Functii.Afisare(vector);
        }

        // Să se afișeze elementele din vector care sunt multipli ai ultimului element.
        public static void Problema14()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            Functii.AfisareMultipliiLastII(vector);
        }

        // Să se afișeze elementele vectorului în următoarea ordine: primul, ultimul, al doilea, penultimul, etc.
        public static void Problema15()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            // Functii.AfisareAlternativa(vector); - METODA 1
            Functii.AfisareAlternativaII(vector); // METODA 2
        }

        public static void Problema16()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            Console.WriteLine(Functii.CountNumereEgaleCuDiferentaDintreMaxSiMin(vector));
        }

        // Se citește un vector cu n elemente, numere naturale distincte. Să se afișeze elementele cuprinse între elementul
        // cu valoarea minimă și cel cu valoare maximă din vector, inclusiv acestea.
        public static void Problema17()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            Functii.AfisareIntreMinMax(vector);
        }

        // Se citește un vector cu n elemente, numere naturale.
        // Să se determine suma valorilor elementelor cuprinse între primul și ultimul element
        // par al vectorului, inclusiv acestea.
        public static void Problema18()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            Functii.AfisareIntrePrimulSiUltimulPar(vector);
        }

        // Se dă un vector cu n numere naturale.
        // Să se determine câte dintre elemente au valoarea
        // strict mai mare decât media aritmetică a elementelor vectorului.
        public static void Problema19()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            Console.WriteLine(Functii.NumereElementeMariMedia(vector));
        }

        // Se dă un șir cu n elemente, numere reale. Să se determine câte dintre elemente se
        // află în afara intervalului închis determinat de primul și ultimul element.
        public static void Problema20()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            Console.WriteLine(Functii.NrElemente(vector));
        }

        public static void Problema21()
        {
            Console.WriteLine(Functii.PrimeIntreEle(4, 5));
            Console.WriteLine(Functii.PrimeIntreEle(25, 27));
            Console.WriteLine(Functii.PrimeIntreEle(8, 14));
        }

        // Se dau două șiruri A și B, fiecare format din câte N numere naturale, și un număr natural R.
        // Aflați numărul perechilor (i,j) pentru care restul împărțirii numărului Ai la Bj este R.
        public static void Problema22()
        {
            int[] a = { 12, 17, 23, 54, 81 }, b = { 9, 7, 2, 10, 17 };
            int rest = 3;

            Console.WriteLine(Functii.CountRest(a,b, rest));
        }

        //Se dă o listă cu numere naturale.
        //Să se determine numerele naturale nenule cu cel mult patru cifre care nu apar în lista dată.
        public static void Problema23()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
           
            for (int i = 9999; i >= 1; i--)
            {
                if(!Functii.ApartineVectorului(vector, i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        //Să se scrie un program care citeşte cel mult 1.000.000 de numere naturale din intervalul închis [0,9]
        //şi determină cel mai mare număr prim citit şi numărul său de apariţii.
        public static void Problema24()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            int nr, frecventa;
            Functii.CelMaiMareNumarPrimSiFrecventaSa(vector, out nr, out frecventa);
            Console.WriteLine(nr);
            Console.WriteLine(frecventa);

            Console.WriteLine("METODA 2");
            nr = Functii.CelMaiMareNumarPrim(vector);
            frecventa = Functii.CountAparitii(vector, nr);
            Console.WriteLine(nr);
            Console.WriteLine(frecventa);
        }

        // Se dau mai multe numere naturale formate din exact o cifră.
        // Determinaţi cifrele cu număr maxim de apariţii.

        public static void Problema25()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
            Console.WriteLine(Functii.NumarMaximDeAparitii(vector));
        }

        

        //Se citesc n numere naturale reprezentând înălțimile a n clădiri.
        //Cerința problemei este de a realiza un proiect de arhitectură în care clădirile sunt ordonate descrescător după înălțimea lor.

        public static void Problema26()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
        }

        //Se citesc două numere naturale a și b. Afișați în ordine crescătoare primii b multipli nenuli ai numărului a.
        public static void Problema27()
        {
            int[] vector;
            Functii.CitireFisier(out vector);

        }

        //Să se scrie un program care să determine produsul cifrelor impare ale unui număr natural citit de la tastatură.

        public static void Problema28()
        {
            int[] vector;
            Functii.CitireFisier(out vector);
        }

        //Se dă un număr natural n. Calculați pătratul celui mai mic divizor propriu al său.

        public static void Problema29() 
        {
            int[] vector;
            Functii.CitireFisier(out vector);
        }
        //Se dau două numere naturale nenule n și p.Afișați în ordine crescătoare puterile lui n mai mici sau egale cu p.

        public static void Problema30()
        {
            Functii.PuteriN(3, 40);
        }

        //Se citește un număr n și apoi n numere naturale. Să se verifice pentru fiecare număr dacă este pătrat perfect.
        public static void Problema31()
        {
            Console.WriteLine(Functii.PatratPerfect(27));
        }

        //Se citește un număr n și apoi n numere naturale. Să se verifice pentru fiecare număr dacă este cub perfect.
        public static void Problema32()
        {
            Console.WriteLine(Functii.CubPerfect(27));
        }
    }
}
