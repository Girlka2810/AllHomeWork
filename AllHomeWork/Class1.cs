using System;

namespace AllHomeWork
{
    public class VariablesMath
    {
        static public double SimpleFraction(double a, double b)
        {
            if (b == a)
            {
                throw new Exception("B can't be equal to A");
            }
            else
            {
                double c = (5 * a + b * b) / (b - a);
                return c;
            }
        }


        static public double SimpleDivision(double a, double b)
        {
            if (b == 0)
            {

                throw new Exception("B can't be equal to 0");
            }
            else
            {
                double c = a / b;

                return c;
            }
        }
        static public double FindRemainder(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception("B can't be equal to 0");
            }
            else
            {
                double c = a % b;
                return c;
            }
        }

        static public double FindX(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("A can't be equal to 0");
            }
            else
            {
                double x = (c - b) / a;
                return x;
            }
        }

        static public double SolveIndexK(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                throw new Exception("x1 can't be equal to x2");
            }
            else
            {
                double k = (y1 - y2) / (x1 - x2);
                return k;
            }
        }
        static public double SolveIndexB(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                throw new Exception("x1 can't be equal to x2");
            }
            else
            {
                double k = (y1 - y2) / (x1 - x2);
                double b = y2 - k * x2;
                return b;
            }

        }
    }
    public class Branching
    {
        static public int CompareAAndBAndSolve(int a, int b)
        {
            if (a > b)
            {
                return (a + b);
            }
            else if (a == b)
            {
                return (a * b);
            }
            else
            {
                return (a - b);
            }
        }

        static public string FindQuater(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return ("1-st quater");
            }
            else if (x < 0 && y > 0)
            {
                return ("2-nd quater");
            }
            else if (x < 0 && y < 0)
            {
                return ("3-d quater");
            }
            else
            {
                return ("4-th quater");
            }
        }

        static public int[] SelectionSort(int[] arr)
        {
            int min, temp;
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
            return arr;

        }
        static public int[] SortInIncreasingNumbers(int a, int b, int c)
        {
            int[] array = new int[3] { a, b, c };
            array = SelectionSort(array);
            return array;
        }

        static public string FindDiscriminant(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            double x1 = -b + Math.Sqrt(d) / (2 * a);
            double x2 = -b - Math.Sqrt(d) / (2 * a);
            double x3 = -b / 2 * a;
            if (d > 0)
                return ("Корни квадратного уравнения: " + "x1 = " + x1 + ", x2 = " + x2);
            else if (d == 0)
                return ("Уравнение имеет один корень: " + "x1 = " + x3);
            else
                return ("Квадратное уравнение не имеет решений");
        }

        static public string IdentifyNumber(int a)
        {
            string num = "";
            if (a < 10)
                throw new Exception("A must be from 10 to 99");
            if (a / 10 == 1 && a % 10 == 0)
                num += ("Десять ");
            if (a / 10 == 1 && a % 10 == 1)
                num += ("Одинадцать ");
            if (a / 10 == 1 && a % 10 == 2)
                num += ("Двенадцать ");
            if (a / 10 == 1 && a % 10 == 3)
                num += ("Тринадцать ");
            if (a / 10 == 1 && a % 10 == 4)
                num += ("Четырнадцать ");
            if (a / 10 == 1 && a % 10 == 5)
                num += ("Пятнадцать ");
            if (a / 10 == 1 && a % 10 == 6)
                num += ("Шеснадцать ");
            if (a / 10 == 1 && a % 10 == 7)
                num += ("Семнадцать ");
            if (a / 10 == 1 && a % 10 == 8)
                num += ("Восемнадцать ");
            if (a / 10 == 1 && a % 10 == 9)
                num += ("Девятнадцать ");
            if (a / 10 == 2)
                num += ("Двадцать ");
            if (a / 10 == 3)
                num += ("Тридцать ");
            if (a / 10 == 4)
                num += ("Сорок ");
            if (a / 10 == 5)
                num += ("Пятьдесят ");
            if (a / 10 == 6)
                num += ("Шестьдесят ");
            if (a / 10 == 7)
                num += ("Семьдесят ");
            if (a / 10 == 8)
                num += ("Восемьдесят ");
            if (a / 10 == 9)
                num += ("Девяносто ");
            if (a / 10 > 1)
            {
                if (a % 10 == 1)
                    num += ("Один");
                else if (a % 10 == 2)
                    num += ("Два");
                else if (a % 10 == 3)
                    num += ("Три");
                else if (a % 10 == 4)
                    num += ("Четыре");
                else if (a % 10 == 5)
                    num += ("Пять");
                else if (a % 10 == 6)
                    num += ("Шесть");
                else if (a % 10 == 7)
                    num += ("Семь");
                else if (a % 10 == 8)
                    num += ("Восемь");
                else if (a % 10 == 9)
                    num += ("Девять");
                else if (a % 10 == 0)
                    num += ("Ноль");
            }
            return num;
        }
    }
    public class CyclesMethods
    {
        public static int RaiseAintoB(int a, int b)
        {
            int c = 1;
            for (int i = 0; i < b; i++)
            {
                c = c * a;
            }
            return c;
        }

        public static string FindNumbersDivededInrange1To1000OnEnteredNumber(int a)
        {
            string num = "";
            for (int i = 1; i <= 1000; i += 1)
            {
                if (i % a == 0)
                {
                    num += (i + "  ");
                }
                if (a < 1 && a > 1000)
                {
                    throw new Exception("'A' sould be in range 1 to 1000");
                }
            }
            return num;
        }

        public static int FindQuantityOfNumbersWhichPowLessThanA(int a)
        {
            int count = 0;
            for (int i = 1; i * i <= a; i += 1)
            {
                count += 1;
            }
            return count;
        }

        public static int FindNOD(int a)
        {
            int nod = 0;
            for (int i = 1; i < a; i += 1)
            {
                if (a % i == 0)
                    nod = i;
            }
            return nod;
        }

        public static string FindQuantityOfAllNumbersInRangeAToBDevidedTo7(int a, int b)
        {
            int sum = 0;
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                        sum += i;
                }
                for (int i = b; i <= a; i++)
                {
                    if (i % 7 == 0)
                        sum += i;
                }
            }
            string c;
            if (a > b)
            {
                c = ("Сумма чисел в диапозоне от " + b + " до " + a + " : " + sum);
            }
            else
            {
                c = ("Сумма чисел в диапозоне от " + a + " до " + b + " : " + sum);
            }
            return c;
        }

        public static string FindFibonachiNumber(int Nfibo)
        {
            int fibo1 = 1;
            int fibo2 = 1;
            for (int i = 2; i <= Nfibo; i++)
            {
                fibo1 = fibo2 - fibo1;
                fibo2 = fibo1 + fibo2;
            }
            string result = ($"{Nfibo}-ое число ряда Фибоначчи: " + fibo2);
            return result;
        }

        public static string SolveAlgorithmEvklida(int a, int b)
        {
            int a1 = a;
            int b1 = b;
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            string result = ($"Наибольший делитель чисел {a1} и {b1} : {Math.Max(a, b)} ");
            return result;
        }

        public static double FindCubicRoot(double n)
        {
            double rightBoarder = n;
            double leftBoarder = 0;
            double midPoint = 0;

            while (rightBoarder - leftBoarder >= 0.000001)
            {
                midPoint = (leftBoarder + rightBoarder) / 2;

                if (midPoint * midPoint * midPoint == n)
                    break;
                if (midPoint * midPoint * midPoint > n)
                {
                    rightBoarder = midPoint;
                }
                else
                {
                    leftBoarder = midPoint;
                }
            }
            return midPoint;
        }

        public static int FindQuantOfOddNumber(int a)
        {
            int oddNum = 0;
            int evenNum = 0;
            int a1 = a;
            while (a > 0)
            {
                if (a % 2 == 0)
                    evenNum += 1;
                else
                    oddNum += 1;
                a = a / 10;
            }
            return oddNum;
        }

        public static int SortMirror(int a)
        {
            int b = 0;
            while (a != 0)
            {
                b = b * 10 + a % 10;
                a = a / 10;
            }
            return b;
        }

        public static int FindSumOfEvenNumberBigerThanSumOfOddNum(int currentValue)
        {
            int oddNumberCount = 0;
            int evenNumberCount = 0;
            int x = 0;
            for (int i = 1; i <= currentValue; i++)
            {
                int evenNumberSum = 0;
                int oddNumberSum = 0;
                int buf = i;
                while (buf % 10 != 0)
                {
                    if (buf % 2 == 0)
                    {
                        evenNumberSum += buf % 10;
                    }
                    else
                        oddNumberSum += buf % 10;
                    buf /= 10;
                }

                if (evenNumberSum > oddNumberSum)
                    x++;
            }
            return x;
        }

        public static string FindTheSameNumber(int a, int b)
        {
            string s = "No";
            int temp = b;
            while (a != 0)
            {

                while (b != 0)
                {
                    if (a % 10 == b % 10)
                    {
                        s = "Yes";
                    }
                    b /= 10;
                }
                b = temp;
                a /= 10;
            }
            return s;
        }
    }
    public class ArraysMethods
    {
        public static int[] InputRandomArray(int n)
        {

            int[] array = new int[n];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 100);
            }
            return array;
        }

        public static int FindMinElemOfArr(int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
                if (min >= a[i])
                {
                    min = a[i];
                }
            return min;
        }
        public static int FindMaxElemOfArr(int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
                if (max <= a[i])
                {
                    max = a[i];
                }
            return max;
        }
        public static int FindIndexOfMinElem(int[] a)
        {
            int min = a[0];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
                if (min >= a[i])
                {
                    min = a[i];
                    index = i;
                }
            return index;
        }
        public static int FindIndexOfMaxElem(int[] a)
        {
            int max = a[0];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
                if (max <= a[i])
                {
                    max = a[i];
                    index = i;
                }
            return index;
        }
        public static int FindSummOfOddIndexElem(int[] a)
        {
            int oddIndexSum = 0;
            for (int i = 0; i < a.Length; i++)
                if (i % 2 != 0)
                {
                    oddIndexSum += a[i];
                }
            return oddIndexSum;
        }
        public static int[] ReversArray(int[] ar)
        {
            int t;
            int lenght = ar.Length;
            for (int i = 0; i < lenght / 2; i++)
            {
                t = ar[i];
                ar[i] = ar[lenght - i - 1];
                ar[lenght - i - 1] = t;
            }
            return ar;
        }
        public static int SumOfOddElementQuantity(int[] a)
        {
            int oddElementQuant = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int temp = i;
                if (temp % 2 != 0)
                {
                    oddElementQuant++;
                }
            }
            return oddElementQuant;
        }
        public static int[] SortArrayChangeTheHalfs(int[] arr)
        {
            int[] a = new int[arr.Length];
            Array.Copy(arr, a, arr.Length);
            int half = arr.Length / 2;
            for (int i = 0; i < half; i++)
            {
                int t = a[i];
                if (a.Length % 2 == 0)
                {
                    a[i] = a[half + i];
                    a[half + i] = t;
                }
                else
                {
                    a[i] = a[half + i + 1];
                    a[half + i + 1] = t;
                }
            }
            return a;
        }
        public static int[] SortAraySelection(int[] arr)
        {
            int[] a = new int[arr.Length];
            Array.Copy(arr, a, arr.Length);
            int temp;
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;
        }
        public static int[] SortArrayBubble(int[] arr)
        {
            int[] a = new int[arr.Length];
            Array.Copy(arr, a, arr.Length);
            int temp;
            for (int i = 1; i < a.Length; i++)
            {
                temp = a[i];
                int j = i;
                while (j > 0 && temp > a[j - 1])
                {
                    a[j] = a[j - 1];
                    j--;
                    a[j] = temp;
                }

            }
            return a;
        }
    }
    public class Arrays2DMethods
    {
        public static int[,] InputRandomArray2D(int n, int n1)
        {
            int[,] array = new int[n, n1];
            Random r = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(0, 100);
                }
            }
            return array;
        }
        public static int FindMinElemOfArr2D(int[,] arr)
        {
            int[,] a = new int[arr.GetLength(1), arr.GetLength(0)];
            Array.Copy(arr, a, arr.Length);
            int min = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    if (min >= a[i, j])
                    {
                        min = a[i, j];
                    }
            }
            return min;
        }
        public static int FindMaxElemOfArr2D(int[,] arr)
        {
            int[,] a = new int[arr.GetLength(1), arr.GetLength(0)];
            Array.Copy(arr, a, arr.Length);
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    if (max <= a[i, j])
                    {
                        max = a[i, j];
                    }
            }
            return max;
        }
        public static int[] FindIndexOfMinElem2D(int[,] a)
        {
            int min = a[0, 0];
            int indexI = 0;
            int indexJ = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)

                    if (min >= a[i, j])
                    {
                        min = a[i, j];
                        indexI = i;
                        indexJ = j;
                    }
            }
            int[] ar = new int[2] { indexI, indexJ };
            return ar;
        }
        public static int[] FindIndexOfMaxElem2D(int[,] a)
        {
            int max = a[0, 0];
            int indexI = 0;
            int indexJ = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    if (max <= a[i, j])
                    {
                        max = a[i, j];
                        indexI = i;
                        indexJ = j;
                    }
            }
            int[] ar = new int[2] { indexI, indexJ };
            return ar;
        }
        public static int FindQuantityOfElementsThatBiggerThanNeighbour2D(int[,] a)
        {
            int n = a.GetLength(0);
            int n1 = a.GetLength(1);
            int count = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    bool left = j != 0 && a[i, j] > a[i, j - 1] || j == 0;
                    bool right = j != n1 - 1 && a[i, j] > a[i, j + 1] || j == n1 - 1;
                    bool up = i != 0 && a[i, j] > a[i - 1, j] || i == 0;
                    bool down = i != n - 1 && a[i, j] > a[i + 1, j] || i == n - 1;
                    if (left && right && up && down)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public static int[,] TransporateArray(int[,] a)
        {
            int[,] b = new int[a.GetLength(1), a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[j, i] = a[i, j];
                }
            }
            return b;
        }
    }
}
