namespace probleme_vectori
{
    public class Functii
    {
        public static void CitireFisier(out int[] vector)
        {
            List<int> list = new List<int>();
            StreamReader sr = new StreamReader("F:\\mycode\\csharp\\probleme\\probleme-vectori\\probleme-vectori\\Resources\\valori.txt");

            while (!sr.EndOfStream)
            {
                list.Add(int.Parse(sr.ReadLine()));
            }

            vector = list.ToArray();
        }

        public static void CatePareSiImpare(int[] vector, out int pare, out int impare)
        {
            pare = 0;
            impare = 0;

            foreach (int i in vector)
            {
                if (i % 2 == 0)
                {
                    pare++;
                }
                else
                {
                    impare++;
                }
            }
        }

        public static int CountDivizori(int n)
        {
            int count = 0;
            for(int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static bool EstePrim(int n)
        {
            return CountDivizori(n) == 2;
        }
        
        public static void InlocuireUltimPrim(int[] vector)
        {
            for(int i = vector.Length - 1; i >= 0; i--)
            {
                if (EstePrim(vector[i]))
                {
                    vector[i] = 0;
                    return;
                }
            }
        }

        public static void Afisare(int[] vector)
        {
            foreach (int i in vector)
            {
                Console.Write(i + " ");
            }
        }

        public static void AfisareMultipliiLast(int[] vector)
        {
            for(int i = 0;i < vector.Length - 1; i++)
            {
                if (vector[i] % vector.Last() == 0)
                {
                    Console.Write(vector[i] + " ");
                }
            }
        }

        public static void AfisareIndiciPari(int[] vector)
        {
            for(int i = 0;i<vector.Length; i += 2)
            {
                Console.Write(vector[i] + " ");
            }
        }

        public static void AfisareIndiciImpari(int[] vector)
        {
            int start = vector.Length % 2 == 1 ? vector.Length - 2 : vector.Length - 1;
            for (int i = start; i > 0; i -= 2)
            {
                Console.Write(vector[i] + " ");
            }
        }

        public static void AfisareaOrdineaVect(int[] vector)
        {
            for (int i = 0, j = vector.Length - 1; i <= j; i++, j--)
            {
                if (i == j)
                {
                    Console.Write(vector[i] + " ");
                }
                else
                {
                    Console.Write(vector[i] + " " + vector[j] + " ");
                }
            }
        }

        public static void MaxSiMin(int[] vector,out int min,out int max)
        {
            min = 0;    
            max = 0;

            foreach (int i in vector) 
            { 
                if (i>max)
                {
                    max = i;
                }
                else if (i < min)
                {
                    min = i;
                }
                     
            }
        }

        public static int IndexulMaximului(int[] vector)
        {
            int index = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > vector[index])
                {
                    index = i;
                }
            }
            return index;
        }

        public static int IndexulMinimului(int[] vector)
        {
            int index = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > vector[index])
                {
                    index = i;
                }
            }
            return index;
        }

        public static int IntorsNumar(int n)
        {
            int rezultat = 0;

            while (n > 0)
            {
                rezultat *= 10;
                rezultat += n % 10;
                n /= 10;
            }

            return rezultat;
        }

        public static bool EstePalindrom(int n)
        {
            return (IntorsNumar(n) == n);
        }

        public static int Power(int num, int power)
        {
            int result = 1;

            while(power > 0)
            {
                result *= num;
                power--;
            }

            return result;
        }

        public static int ProdusVector(int[] vector)
        {
            int result = 1;

            foreach(int i in vector)
            {
                result *= i;
            }

            return result;
        }

        public static int MaxPower(int n, int p)
        {
            return (int)Math.Log(p, n);
        }

        // Math.Pow(n, 1/3) = intreg
        public static bool CuburiPerfecte(int[] vector)
        {
            foreach(int n in vector)
            {
                double cubeRoot = Math.Cbrt(n);

                if (cubeRoot != Math.Floor(cubeRoot))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
