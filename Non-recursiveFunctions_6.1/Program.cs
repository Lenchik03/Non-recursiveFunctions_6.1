using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Xml;

namespace З.А_задание_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a, b, c, d, n;
            //Console.WriteLine("Сколько точек?");

            //int.TryParse(Console.ReadLine(), out n);
            //int A, B, C;
            //(int, int, int) input = InputPoint();
            //A = input.Item1;
            //B = input.Item2;
            //C = input.Item3;
            //int result = NOD1(A, B, C);

            //Prosto(result);

            //int r = Fact();
            //Console.WriteLine(r);


            //int[] array = Array(n*2);
            //double[] result = Test1(array);
            //Output(result);

            //int[] massiv = Massiv(n);
            //int predMax = Test2(massiv);
            //Console.WriteLine(predMax);

            //Console.WriteLine(result);
            //int.TryParse(Console.ReadLine(), out a);
            //int.TryParse(Console.ReadLine(), out b);

            //int.TryParse(Console.ReadLine(), out c);
            //int.TryParse(Console.ReadLine(), out d);
            //int nod = NOD(a, b);
            //int nod2 = NOD(c, d);
            //int nod3 = NOD(nod, nod2);
            //int nok = NOK(a, b, c);
            //int max = Max(a, b);
            //max = Max(max, c);
            //int min = Min(a,b);
            //min = Min(min, c);
            //double s = SixYgol(a);
            ////Console.WriteLine(nod3);
            ////Console.WriteLine(nok);
            //Console.WriteLine(max + min);
            //Console.WriteLine(s);



        }
        //static int Fact()
        //{
        //    int summa = 0;
        //    int j = 1;
        //    for (int i = 1; i < 10; i++)
        //    {
        //        j *= i;
        //        if (i % 2 != 0)
        //        {
        //            summa += j;
        //        }
        //    }
        //    return summa;
        //}
        //static void Prosto(int x)
        //{
        //    if (x > 1)
        //    {
        //        Console.WriteLine("Не являются!!!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Являются!!!");
        //    }
        //}
        //static int NOD1(int x, int y, int z)
        //{
        //    for (int i = x; i > 0; i--)
        //    {
        //        if (x % i == 0 && y % i == 0 && z % i == 0)
        //            return i;
        //    }
        //    return -1;
        //}
        //static (int, int, int) InputPoint()
        //{
        //    (int, int, int) result;
        //    int.TryParse(Console.ReadLine(), out result.Item1);
        //    int.TryParse(Console.ReadLine(), out result.Item2);
        //    int.TryParse(Console.ReadLine(), out result.Item3);
        //    return result;
        //}

        //static int Test2(int[] arr)
        //{
        //    int max = int.MinValue;
        //    int pred = int.MinValue;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] > max)
        //        {
        //            pred = max;
        //            max = arr[i];

        //        }
        //        else if (arr[i] > pred)
        //        {
        //            pred = arr[i];
        //        }

        //    }
        //    return pred;

        //}
        //static int[] Massiv(int n)
        //{
        //    int[] array = new int[n];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        array[i] = int.Parse(Console.ReadLine());
        //    }
        //    return array;
        //}

        //static void Output(double[] array)
        //{
        //    for (int i = 0; i < 5; i++)
        //    {

        //        Console.WriteLine(array[i]);
        //    }
        //}
        //static int[] Array(int n)
        //{
        //    int[] array = new int[n];
        //    for (int i = 0; i < array.Length; i += 2)
        //    {
        //        array[i] = int.Parse(Console.ReadLine());
        //        array[i + 1] = int.Parse(Console.ReadLine());
        //    }
        //    return array;
        //}
        //static double[] Test1(int[] array)
        //{

        //    double[] coord = new double[5];

        //    double max = double.MinValue;

        //    for (int i = 0; i < array.Length - 2; i += 2)
        //    {
        //        for (int j = i + 2; j < array.Length; j += 2)
        //        {
        //            double rast = Pari(array[i], array[i + 1], array[j], array[j + 1]);
        //            if (rast > max)
        //            {
        //                max = rast;
        //                coord[0] = max;
        //                coord[1] = array[i];
        //                coord[2] = array[i + 1];
        //                coord[3] = array[j];
        //                coord[4] = array[j + 1];

        //            }
        //        }
        //    }
        //    return coord;
        //}
        //static double Pari(int x1, int y1, int x2, int y2)
        //{
        //    double S = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        //    return S;
        //}

        //static int NOD(int x, int y)
        //{
        //    for (int i = x; i > 0; i--)
        //    {
        //        if (x % i == 0 && y % i == 0)
        //            return i;
        //    }
        //    return 1;
        //}

        //static int NOK(int x, int y, int z)
        //{
        //    int min = x > y ? y : x;
        //    for (int i = min; ; i++)
        //    {
        //        if (i % x == 0 && i % y == 0 && i % z == 0)
        //            return i;
        //    }
        //}

        //static int Max(int x, int y)
        //{
        //    return (x > y) ? x : y;
        //}

        //static int Min(int x, int y)
        //{
        //    return (x < y) ? x : y;
        //}

        //static double SixYgol(double x)
        //{
        //    return (3 * Math.Sqrt(3) * Math.Pow(x, 2)) / 2;
        //}


    }
}