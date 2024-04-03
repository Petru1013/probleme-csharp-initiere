using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

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
        public static int CalculeazaDiferenta(int[] vector)
        {
            int pare = 0;
            int impare = 0;
            
            foreach(int n in vector)
            {
                if (n % 2 == 0)
                {
                    pare++;
                }
                else
                {
                    impare++;
                }
            }

            int dif = Math.Abs(impare - pare);
             
            return dif;
        }

        public static int CountDiv(int n)
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

        public static bool EstePrimII(int n)
        {
            return CountDiv(n) == 2;
        }

        public static void ReplaceLastPrime(int[] vector)
        {
            for(int i = vector.Length - 1; i >= 0; i--)
            {
                if (EstePrimII(vector[i]))
                {
                    vector[i] = 0;
                    return;
                }
            }
        }

        public static void ReplaceAllPrimes(int[] vector)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                if (EstePrimII(vector[i]))
                {
                    vector[i] = 0;
                }
            }
        }

        public static void AfisareMultipliiLastII(int[] nums)
        {
            // a multiplu b, a % b == 0

            int last = nums[nums.Length - 1];

            for(int i = 0;i < nums.Length; i++) 
            {
                if (nums[i] % last==0)
                {
                    Console.Write(nums[i] + " ");
                }
            }
        }

        public static void AfisareAlternativa(int[] vector)
        {
            for (int i = 0;i<vector.Length/2 ; i++)
            {
                Console.WriteLine(vector[i]);
                Console.WriteLine(vector[vector.Length-1-i]);
            }
            if (vector.Length % 2 != 0)
            {
                Console.WriteLine(vector[vector.Length/2]);
            }
        }

        public static void AfisareAlternativaII(int[] vector)
        {
            for(int i = 0, j = vector.Length - 1; i <= j; i++, j--)
            {
                if(i != j)
                {
                    Console.Write(vector[i] + " " + vector[j] + " ");
                }
                else
                {
                    Console.Write(vector[i]);
                }
            }
        }

        public static int IndiceMax(int[] vector)
        {
            int max = int.MinValue;
            int pos = -1;

            for(int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > max)
                {
                    max = vector[i];
                    pos = i;
                }
            }

            return pos;
        }

        public static int IndiceMin(int[] vector)
        {
            int min = int.MaxValue;
            int pos = -1;

            for(int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < min) 
                {
                    min = vector[i];
                    pos = i;
                }
            }
            return pos;
        }

        public static int CountNumereEgaleCuDiferentaDintreMaxSiMin(int[] vector)
        {
            int min, max;
            MaxSiMin(vector, out min, out max);
            int diferenta = max - min;
            int count = 0;

            for(int i = 0;i < vector.Length;i++)
            {
                if (vector[i] == diferenta)
                { 
                    count++; 
                }
            }

            return count;
        }

        public static void AfisareIntreMinMax(int[] vector)
        {
            int posMax = IndiceMax(vector);
            int posMin = IndiceMin(vector);

            if(posMax < posMin)
            {
                int retinut = posMax;
                posMax = posMin;
                posMin = retinut;
            }

            for(int i = posMin; i <= posMax; i++)
            {
                Console.Write(vector[i] + " ");
            }
        }

        public static int PosPrimPar(int[] vector)
        {
            for(int i = 0;i<vector.Length;i++)
            {
                if (vector[i] % 2 == 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int PosUltiPar(int[] vector)
        {
            for (int i = vector.Length - 1; i >= 0; i--)
            {
                if (vector[i] % 2 == 0)
                {
                    return i;
                }
            }

            return -1;
        }


        public static void AfisareIntrePrimulSiUltimulPar(int[] vector)
        {
            int first = PosPrimPar(vector);
            int last = PosUltiPar(vector);

            for(int i= first; i<= last; i++)
            {
                Console.Write(vector[i] + " ");
            }
        }

        public static int NumereElementeMariMedia(int[] vector)
        {
            int suma = 0;
            int numarElem = vector.Length;

            foreach(int i in vector)
            {
                suma+= i;
            }

            double media = (double)suma / numarElem;
            Console.WriteLine(media);

            int contor = 0;
            foreach(int i in vector)
            {
                if (i > media)
                {
                    contor++;
                }
            }
            return contor;
        }

        public static int NrElemente(int[] vector)
        {
            if(vector.Length < 3)
            {   
                return 0;
            }

            int primEl = vector[0];
            int ultimEl = vector[vector.Length-1];

            if (ultimEl < primEl)
            {
                int retinut = ultimEl;
                ultimEl = primEl;
                primEl = retinut;
            }

            int contor = 0;
            for(int i = 1; i< vector.Length-1; i++) 
            {
                if (vector[i] >= primEl && vector[i] <= ultimEl)
                {
                    contor++;
                }
            }
            return contor;
        }

        public static bool PrimeIntreEle(int a, int b)
        {
            int min = a < b ? a : b;


            for(int i = 2; i <= min; i++)
            {
                if(a % i == 0 && b % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int CountRest(int[] a, int[] b, int rest)
        {
            int count = 0;
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < b.Length; j++) 
                {
                    if (a[i] % b[j] == rest)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static bool ApartineVectorului(int[] vector, int valoare)
        {
            for(int i = 0;i < vector.Length;i++) 
            {
                if (vector[i] == valoare)
                {
                    return true;
                }
            } 
            return false;
        }

        public static void CelMaiMareNumarPrimSiFrecventaSa(int[] vector, out int nr, out int frecventa)
        {
            int[] f = new int[10];
            for(int i = 0; i < 10; i++)
            {
                f[i] = 0;
            }

            for(int i = 0; i < vector.Length; i++)
            {
                f[vector[i]]++;
            }

            for(int i = 9; i > -1; i--)
            {
                if(EstePrim(i) && f[i] > 0)
                {
                    nr = i;
                    frecventa = f[nr];
                    return;
                }
            }
            nr = -1;
            frecventa = 0;
        }

        public static int CelMaiMareNumarPrim(int[] vector)
        {
            int max = -1;
            for(int i = 0;i<vector.Length;i++)
            {
                if (EstePrim(vector[i]) && vector[i] > max)
                {
                    max = vector[i];
                }
            }
            return max;
        }

        public static int CountAparitii(int[] vector, int valoare)
        {
            int count = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == valoare)
                {
                    count++; 
                }
            }
            return count;
        }

        public static int NumarMaximDeAparitii(int[] vector)
        {
            int[] f = new int[10];
            for (int i = 0; i < 10; i++)
            {
                f[i] = 0;
            }

            for (int i = 0; i < vector.Length; i++)
            {
                f[vector[i]]++;
            }

            int max = -1;
            int valoareMax = -1;
            for(int i = 0; i < 10; i++)
            {
                Console.Write(f[i] + " ");
                if (f[i] > max)
                {
                    max = f[i];
                    valoareMax = i;
                }
            }
            Console.WriteLine();
            return valoareMax;
        }

        public static int[] PrimulMultiplu(int a,int b)
        {
            int[] multiplu=new int[b];
            for (int i = 0;i < b; i++)
            {
                multiplu[i]=(i+1)*a;
            }
            return multiplu;
        }

        public static int ProdDig(int numar)
        {
            int produc = 1;

            while (numar != 0)
            {
                int dig = numar % 10;
                if (dig % 2 != 0)
                {
                    produc *= dig;
                }
                numar /= 10;
            }

            return produc;
        }

        public static int DimDivizor(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return i * i;
                }
            }
            return n * n;
        }

        public static void PuteriN(int n,int p)
        {
            int putereMultiplu = 0;
            while((int)Math.Pow(n, putereMultiplu) <= p)
            {
                Console.WriteLine((int)Math.Pow(n, putereMultiplu));
                putereMultiplu++;
            }
        }

        public static bool PatratPerfect(int n)
        {
            double rad = Math.Sqrt(n);

            return rad == (int)rad;
        }

        public static bool CubPerfect(int n)
        {
            double rad = Math.Cbrt(n);
            return rad == (int)rad;
        }
    }
}
