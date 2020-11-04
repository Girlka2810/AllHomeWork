using NUnit.Framework;
using AllHomeWork;
using System;
namespace NUnitTestProject1
{
    public class AllHomeWorkTests
    {
        public class VariablesTests
        {
            public class SolveEquation
            {
                [TestCase(1, 2, 9)]
                [TestCase(10, 12, 97)]
                [TestCase(1, 3, 7)]
                public void SimpleFraction(double a, double b, double expected)
                {
                    double acctual = VariablesMath.SimpleFraction(a, b);
                    Assert.AreEqual(expected, acctual);
                }
                [TestCase(2, 2)]
                [TestCase(3, 3)]
                [TestCase(4, 4)]
                [TestCase(20, 20)]

                public void SimpleFractionNegative(double a, double b)
                {
                    try
                    {
                        VariablesMath.SimpleFraction(a, b);
                    }
                    catch
                    {
                        Assert.Pass();
                    }
                    Assert.Fail();
                }


                [TestCase(4, 2, 2)]
                [TestCase(8, 2, 4)]
                [TestCase(6, 3, 2)]
                [TestCase(50, 2, 25)]
                [TestCase(60, 2, 30)]
                [TestCase(-4, 2, -2)]
                public void SimpleDivisionTests(double a, double b, double expected)
                {
                    double actual = VariablesMath.SimpleDivision(a, b);
                    Assert.AreEqual(expected, actual);
                }
                [TestCase(2, 0)]
                public void SimpleDivisionNegative(double a, double b)
                {
                    try
                    {
                        VariablesMath.SimpleDivision(a, b);
                    }
                    catch
                    {
                        Assert.Pass();
                    }
                    Assert.Fail();
                }
                [TestCase(4, 2, 0)]
                [TestCase(6, 2, 0)]
                [TestCase(6, 3, 0)]
                [TestCase(35, 10, 5)]
                [TestCase(-4, 2, 0)]
                public void RemainderOfTheDivisionTests(double a, double b, double expected)
                {
                    double actual = VariablesMath.FindRemainder(a, b);
                    Assert.AreEqual(expected, actual);
                }
            }
            [TestCase(2, 5, 6, 0.5)]
            [TestCase(4, 5, 6, 0.25)]
            [TestCase(25, 8, 5, -0.12)]
            [TestCase(8, 4, 2, -0.25)]
            public void FindX(double a, double b, double c, double expected)
            {
                double actual = VariablesMath.FindX(a, b, c);
            }
            [TestCase(0, 2, 3)]
            public void FindXNegative(double a, double b, double c)
            {
                try
                {
                    VariablesMath.FindX(a, b, c);
                }
                catch
                {
                    Assert.Pass();
                }
                Assert.Fail();
            }
            [TestCase(1, 3, 5, 6, 0.75, 2.25)]
            [TestCase(3, 5, 7, 12, 1.75, -0.25)]
            [TestCase(7, 5, 10, 2, -1, 12)]
            public void FindKAndB(double x1, double y1, double x2, double y2, double expectedK, double expectedB)
            {
                double actualK = VariablesMath.SolveIndexK(x1, y1, x2, y2);
                double actualB = VariablesMath.SolveIndexB(x1, y1, x2, y2);
                Assert.AreEqual(expectedK, actualK);
                Assert.AreEqual(expectedB, actualB);
            }
            [TestCase(7, 5, 7, 5)]
            public void FindKAndBNegative(double x1, double y1, double x2, double y2)
            {
                try
                {
                    VariablesMath.SolveIndexK(x1, y1, x2, y2);
                    VariablesMath.SolveIndexB(x1, y1, x2, y2);
                }
                catch
                {
                    Assert.Pass();
                }
                Assert.Fail();
            }
        }
        public class BrunchingTests
        {
            [TestCase(2, 4, -2)]
            [TestCase(2, 2, 4)]
            [TestCase(5, 4, 9)]
            [TestCase(3, 4, -1)]

            public void Conditions1(int a, int b, int expected)
            {
                int actual = Branching.CompareAAndBAndSolve(a, b);
                Assert.AreEqual(expected, actual);
            }
            [TestCase(2, 4, "1-st quater")]
            [TestCase(2, -2, "4-th quater")]
            [TestCase(-5, -4, "3-d quater")]
            [TestCase(-3, 4, "2-nd quater")]

            public void Quater(int a, int b, string expected)
            {
                string actual = Branching.FindQuater(a, b);
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void AssendingNumbers1()
            {
                int[] expected = new int[3] { 1, 2, 3 };
                int[] actual = Branching.SortInIncreasingNumbers(3, 2, 1);
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void AssendingNumbers2()
            {
                int[] expected = new int[3] { -10, 250, 450 };
                int[] actual = Branching.SortInIncreasingNumbers(450, 250, -10);
                Assert.AreEqual(expected, actual);
            }

            [TestCase(2, 4, 1, "Корни квадратного уравнения: x1 = -3,2928932188134525, x2 = -4,707106781186548")]
            [TestCase(1, 2, 1, "Уравнение имеет один корень: x1 = -1")]
            [TestCase(1, 2, 0, "Корни квадратного уравнения: x1 = -1, x2 = -3")]
            [TestCase(8, 2, 4, "Квадратное уравнение не имеет решений")]
            public void FindDiscriminant(double a, double b, double c, string expected)
            {
                string actual = Branching.FindDiscriminant(a, b, c);
                Assert.AreEqual(expected, actual);
            }
            [TestCase(11, "Одинадцать ")]
            [TestCase(22, "Двадцать Два")]
            [TestCase(43, "Сорок Три")]
            [TestCase(99, "Девяносто Девять")]
            public void WriteNumber(int a, string expected)
            {
                string actual = Branching.IdentifyNumber(a);
                Assert.AreEqual(expected, actual);
            }
            [TestCase(0)]
            [TestCase(2)]
            [TestCase(4)]
            [TestCase(9)]
            public void WriteNumberNegative(int a)
            {
                try
                {
                    Branching.IdentifyNumber(a);
                }
                catch
                {
                    Assert.Pass();
                }
                Assert.Fail();
            }
        }
        public class CycleTests
        {
            [TestCase(2, 2, 4)]
            [TestCase(2, 3, 8)]
            [TestCase(2, 0, 1)]
            [TestCase(5, 2, 25)]
            [TestCase(11, 2, 121)]
            public void PowerATest(int a, int b, int expected)
            {
                int actual = AllHomeWork.CyclesMethods.RaiseAintoB(a, b);
                Assert.AreEqual(actual, expected);
            }

            [TestCase(250, "250  500  750  1000  ")]
            [TestCase(500, "500  1000  ")]
            [TestCase(200, "200  400  600  800  1000  ")]
            [TestCase(550, "550  ")]
            [TestCase(100, "100  200  300  400  500  600  700  800  900  1000  ")]
            public void FindingNumbersTest(int a, string expected)
            {
                string actual = AllHomeWork.CyclesMethods.FindNumbersDivededInrange1To1000OnEnteredNumber(a);
                Assert.AreEqual(actual, expected);
            }
            [TestCase(2, 1)]
            [TestCase(4, 2)]
            [TestCase(100, 10)]
            [TestCase(25, 5)]
            public void PowLessATest(int a, int expected)
            {
                int actual = AllHomeWork.CyclesMethods.FindQuantityOfNumbersWhichPowLessThanA(a);
                Assert.AreEqual(actual, expected);
            }
            [TestCase(100, 50)]
            [TestCase(15, 5)]
            [TestCase(123546, 61773)]
            [TestCase(25, 5)]
            public void NODTest(int a, int expected)
            {
                int actual = AllHomeWork.CyclesMethods.FindNOD(a);
                Assert.AreEqual(actual, expected);
            }
            [TestCase(10, 500, "Сумма чисел в диапозоне от 10 до 500 : 17885")]
            [TestCase(1254, 123, "Сумма чисел в диапозоне от 123 до 1254 : 111699")]
            [TestCase(456, 5698, "Сумма чисел в диапозоне от 456 до 5698 : 2306920")]
            [TestCase(0, 25, "Сумма чисел в диапозоне от 0 до 25 : 42")]
            public void DevidingTo7Test(int a, int b, string expected)
            {
                string actual = AllHomeWork.CyclesMethods.FindQuantityOfAllNumbersInRangeAToBDevidedTo7(a, b);
                Assert.AreEqual(actual, expected);
            }
            [TestCase(10, "10-ое число ряда Фибоначчи: 55")]
            [TestCase(3, "3-ое число ряда Фибоначчи: 2")]
            [TestCase(56, "56-ое число ряда Фибоначчи: -1781832971")]
            [TestCase(25, "25-ое число ряда Фибоначчи: 75025")]
            public void FibonachiTest(int a, string expected)
            {
                string actual = AllHomeWork.CyclesMethods.FindFibonachiNumber(a);
                Assert.AreEqual(actual, expected);
            }
            [TestCase(100, 5, "Наибольший делитель чисел 100 и 5 : 5 ")]
            [TestCase(5, 100, "Наибольший делитель чисел 5 и 100 : 5 ")]
            [TestCase(45, 784, "Наибольший делитель чисел 45 и 784 : 1 ")]
            [TestCase(152, 2564, "Наибольший делитель чисел 152 и 2564 : 4 ")]
            public void AlgoritmEvklidaTest(int a, int b, string expected)
            {
                string actual = AllHomeWork.CyclesMethods.SolveAlgorithmEvklida(a, b);
                Assert.AreEqual(actual, expected);
            }
            [TestCase(27, 3.00000062584877)]
            [TestCase(625, 8.54987942148)]
            [TestCase(425, 7.518473686650395)]
            [TestCase(725, 8.983508800156415)]
            public void CubicRootTest(double n, double expected)
            {
                double actual = AllHomeWork.CyclesMethods.FindCubicRoot(n);
                Assert.AreEqual(actual, expected);
            }
            [TestCase(123456, 3)]
            [TestCase(2468, 0)]
            [TestCase(13579, 5)]
            [TestCase(2574, 2)]
            public void OddNumberTest(int a, int expected)
            {
                double actual = AllHomeWork.CyclesMethods.FindQuantOfOddNumber(a);
                Assert.AreEqual(actual, expected);
            }
            [TestCase(123, 321)]
            [TestCase(4589, 9854)]
            [TestCase(874521, 125478)]
            [TestCase(2574, 4752)]
            public void MirrorSortTest(int a, int expected)
            {
                int actual = AllHomeWork.CyclesMethods.SortMirror(a);
                Assert.AreEqual(actual, expected);
            }
            [TestCase(23, 10)]
            [TestCase(14235, 5174)]
            [TestCase(764859, 283327)]
            [TestCase(54637012, 19758731)]
            [TestCase(15, 6)]
            public void SumEvenNumbTest(int a, int expected)
            {
                int actual = AllHomeWork.CyclesMethods.FindSumOfEvenNumberBigerThanSumOfOddNum(a);
                Assert.AreEqual(actual, expected);
            }
            [TestCase(100, 5, "No")]
            [TestCase(5234, 316780, "Yes")]
            [TestCase(45, 784, "Yes")]
            [TestCase(190, 2564, "No")]
            [TestCase(2564, 190, "No")]
            [TestCase(196, 2564, "Yes")]
            [TestCase(2564, 196, "Yes")]
            [TestCase(190, 784562, "No")]
            [TestCase(98723, 45678, "Yes")]
            public void SameNumbersTest(int a, int b, string expected)
            {
                string actual = AllHomeWork.CyclesMethods.FindTheSameNumber(a, b);
                Assert.AreEqual(actual, expected);
            }
        }
        public class ArrayTests
        {
            [TestCase(new int[] { 1, 2, 3 }, 1)]
            [TestCase(new int[] { 4, 42212, 3, 233, 42 }, 3)]
            [TestCase(new int[] { -1, 23242, 413 }, -1)]
            [TestCase(new int[] { -1231, 79872, 3423 }, -1231)]

            public void MinElemTest(int[] a, int expected)
            {
                int actual = AllHomeWork.ArraysMethods.FindMinElemOfArr(a);
                Assert.AreEqual(expected, actual);
            }
            [TestCase(new int[] { 1, 2, 3 }, 3)]
            [TestCase(new int[] { 4, 42212, 3, 233, 42 }, 42212)]
            [TestCase(new int[] { -1, 23242, 413 }, 23242)]
            [TestCase(new int[] { -1231, 79872, 3423 }, 79872)]

            public void MaxElemTest(int[] a, int expected)
            {
                int actual = AllHomeWork.ArraysMethods.FindMaxElemOfArr(a);
                Assert.AreEqual(expected, actual);
            }
            [TestCase(new int[] { 1, 2, 3 }, 0)]
            [TestCase(new int[] { 4, 42212, 3, 233, -42 }, 4)]
            [TestCase(new int[] { -1, 23242, -413 }, 2)]
            [TestCase(new int[] { -1231, 79872, 342303 }, 0)]

            public void FindIndexOfMinElemTest(int[] a, int expected)
            {
                int actual = AllHomeWork.ArraysMethods.FindIndexOfMinElem(a);
                Assert.AreEqual(expected, actual);
            }
            [TestCase(new int[] { 1, 2, 3 }, 2)]
            [TestCase(new int[] { 4, 42212, 3, 233, -42 }, 1)]
            [TestCase(new int[] { -1, 23242, -413 }, 1)]
            [TestCase(new int[] { -1231, 79872, 342303 }, 2)]

            public void FindIndexOfMaxElemTest(int[] a, int expected)
            {
                int actual = AllHomeWork.ArraysMethods.FindIndexOfMaxElem(a);
                Assert.AreEqual(expected, actual);
            }
            [TestCase(new int[] { 1, 2, 3 }, 2)]
            [TestCase(new int[] { 4, 42212, 3, 233, -42 }, 42212 + 233)]
            [TestCase(new int[] { -1, 23242, -413 }, 23242)]
            [TestCase(new int[] { -1231, 79872, 342 }, 79872)]

            public void FindSummOfOddIndexElemTest(int[] a, int expected)
            {
                int actual = AllHomeWork.ArraysMethods.FindSummOfOddIndexElem(a);
                Assert.AreEqual(expected, actual);
            }

            [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
            [TestCase(new int[] { 4, 42212, 3, 233, -42 }, new int[] { -42, 233, 3, 42212, 4 })]
            [TestCase(new int[] { -1, 23242, -413 }, new int[] { -413, 23242, -1 })]
            [TestCase(new int[] { -1231, 79872, 342 }, new int[] { 342, 79872, -1231 })]

            public void ReversArrayTest(int[] a, int[] expected)
            {
                int[] actual = AllHomeWork.ArraysMethods.ReversArray(a);
                Assert.AreEqual(expected, actual);
            }

            [TestCase(new int[] { 1, 2, 3 }, 1)]
            [TestCase(new int[] { 4, 42212, 3, 233, -42 }, 2)]
            [TestCase(new int[] { -1, 23242, -413, 1212, 1232, 543, 56789, 1235 }, 4)]
            [TestCase(new int[] { -1231, 79872, 342, 125, 2154, 2356, 488, 654, 89, 4, 2, 66, 4, 6, 6487, 5, 0 }, 8)]

            public void SumOfOddElementQuantityTest(int[] a, int expected)
            {
                int actual = AllHomeWork.ArraysMethods.SumOfOddElementQuantity(a);
                Assert.AreEqual(expected, actual);
            }
            [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
            [TestCase(new int[] { 4, 42212, 3, 233, -42 }, new int[] { 233, -42, 3, 4, 42212 })]
            [TestCase(new int[] { -1, 23242, -413 }, new int[] { -413, 23242, -1 })]
            [TestCase(new int[] { -1231, 79872, 342, 10 }, new int[] { 342, 10, -1231, 79872 })]
            [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 4, 5, 6, 1, 2, 3 })]

            public void SortArrayChangeTheHalfTest(int[] a, int[] expected)
            {
                int[] actual = AllHomeWork.ArraysMethods.SortArrayChangeTheHalfs(a);
                Assert.AreEqual(expected, actual);
            }
            [TestCase(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
            [TestCase(new int[] { 10, 2, 43, 67, 98 }, new int[] { 2, 10, 43, 67, 98 })]
            [TestCase(new int[] { 15, 3, 321, 45, 78, 6, 23, 4, 0 }, new int[] { 0, 3, 4, 6, 15, 23, 45, 78, 321 })]
            [TestCase(new int[] { 5, -1, 0, 78, 6, 1215, -1254 }, new int[] { -1254, -1, 0, 5, 6, 78, 1215 })]

            public void SortArraySelectionTest(int[] a, int[] expected)
            {
                int[] actual = AllHomeWork.ArraysMethods.SortAraySelection(a);
                Assert.AreEqual(expected, actual);
            }
            [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
            [TestCase(new int[] { 10, 2, 43, 67, 98 }, new int[] { 98, 67, 43, 10, 2 })]
            [TestCase(new int[] { 15, 3, 321, 45, 78, 6, 23, 4, 0 }, new int[] { 321, 78, 45, 23, 15, 6, 4, 3, 0 })]
            [TestCase(new int[] { 5, -1, 0, 78, 6, 1215, -1254 }, new int[] { 1215, 78, 6, 5, 0, -1, -1254 })]

            public void SortArrayBubbleTest(int[] a, int[] expected)
            {
                int[] actual = AllHomeWork.ArraysMethods.SortArrayBubble(a);

                Assert.AreEqual(expected, actual);
            }
        }
        public class Array2DTests
        {
            [TestCase(1, 1)]
            [TestCase(2, 2)]
            [TestCase(3, 3)]
            [TestCase(4, 4)]
            public void FindMinElemOfArr2DTests(int Array2DMock, int ExpectedMinMock)
            {
                int expected = GetExpectedMinMock(ExpectedMinMock);
                int[,] arr = GetArray2DMock(Array2DMock);
                int actual = AllHomeWork.Arrays2DMethods.FindMinElemOfArr2D(arr);
                Assert.AreEqual(actual, expected);
            }
            [TestCase(1, 1)]
            [TestCase(2, 2)]
            [TestCase(3, 3)]
            [TestCase(4, 4)]
            public void FindMaxElemOfArr2DTests(int Array2DMock, int ExpectedMaxMock)
            {
                int expected = GetExpectedMaxMock(ExpectedMaxMock);
                int[,] arr = GetArray2DMock(Array2DMock);
                int actual = AllHomeWork.Arrays2DMethods.FindMaxElemOfArr2D(arr);
                Assert.AreEqual(actual, expected);
            }
            [TestCase(1, 1)]
            [TestCase(2, 2)]
            [TestCase(3, 3)]
            [TestCase(4, 4)]
            public void FindIndexOfMinElem2DTests(int Array2DMock, int ExpectedMinIndexMock)
            {
                int[] expected = GetExpectedMinIndexMock(ExpectedMinIndexMock);
                int[,] arr = GetArray2DMock(Array2DMock);
                int[] actual = AllHomeWork.Arrays2DMethods.FindIndexOfMinElem2D(arr);
                Assert.AreEqual(actual, expected);
            }
            [TestCase(1, 1)]
            [TestCase(2, 2)]
            [TestCase(3, 3)]
            [TestCase(4, 4)]
            public void FindIndexOfMaxElem2DTests(int Array2DMock, int ExpectedMaxIndexMock)
            {
                int[] expected = GetExpectedMaxIndexMock(ExpectedMaxIndexMock);
                int[,] arr = GetArray2DMock(Array2DMock);
                int[] actual = AllHomeWork.Arrays2DMethods.FindIndexOfMaxElem2D(arr);
                Assert.AreEqual(actual, expected);
            }
            [TestCase(1, 1)]
            [TestCase(2, 2)]
            [TestCase(3, 3)]
            [TestCase(4, 4)]
            public void FindQuantityOfElementsThatBiggerThanNeighbour2DTests(int Array2DMock, int ExpectedQuantityMock)
            {
                int expected = GetExpectedQuantityMock(ExpectedQuantityMock);
                int[,] arr = GetArray2DMock(Array2DMock);
                int actual = AllHomeWork.Arrays2DMethods.FindQuantityOfElementsThatBiggerThanNeighbour2D(arr);
                Assert.AreEqual(actual, expected);
            }
            [TestCase(1, 1)]
            [TestCase(2, 2)]
            [TestCase(3, 3)]
            [TestCase(4, 4)]
            public void TransporateArrayTests(int Array2DMock, int ExpectedQuantityMock)
            {
                int[,] expected = GetExpectedTransporateMock(ExpectedQuantityMock);
                int[,] arr = GetArray2DMock(Array2DMock);
                int[,] actual = AllHomeWork.Arrays2DMethods.TransporateArray(arr);
                Assert.AreEqual(actual, expected);
            }
            public int[,] GetArray2DMock(int n)
            {
                int[,] arr;
                switch (n)
                {
                    case 1:
                        arr = new int[,] { { 10, 2, 3 }, { 4, 5, 6 }, { 100, 45, 12 } };
                        return arr;
                    case 2:
                        arr = new int[,] { { -10, 289, 233 }, { 14, 455, 26 } };
                        return arr;
                    case 3:
                        arr = new int[,] { { -45, 21 }, { -4587, 564 } };
                        return arr;
                    case 4:
                        arr = new int[,] { { 0, 12 }, { 454, 788 }, { 99, 1 }, { 567, -12020 } };
                        return arr;
                    default:
                        throw new Exception();
                }
            }
            public int GetExpectedMinMock(int a)
            {
                switch (a)
                {
                    case 1:
                        return 2;
                    case 2:
                        return -10;
                    case 3:
                        return -4587;
                    case 4:
                        return -12020;
                    default:
                        throw new Exception();
                }
            }
            public int GetExpectedMaxMock(int a)
            {
                switch (a)
                {
                    case 1:
                        return 100;
                    case 2:
                        return 455;
                    case 3:
                        return 564;
                    case 4:
                        return 788;
                    default:
                        throw new Exception();
                }
            }

            public int[] GetExpectedMinIndexMock(int a)
            {
                int[] arr;
                switch (a)
                {
                    case 1:
                        arr = new int[2] { 0, 1 };
                        return arr;
                    case 2:
                        arr = new int[2] { 0, 0 };
                        return arr;
                    case 3:
                        arr = new int[2] { 1, 0 };
                        return arr;
                    case 4:
                        arr = new int[2] { 3, 1 };
                        return arr;
                    default:
                        throw new Exception();
                }
            }
            public int[] GetExpectedMaxIndexMock(int a)
            {
                int[] arr;
                switch (a)
                {
                    case 1:
                        arr = new int[2] { 2, 0 };
                        return arr;
                    case 2:
                        arr = new int[2] { 1, 1 };
                        return arr;
                    case 3:
                        arr = new int[2] { 1, 1 };
                        return arr;
                    case 4:
                        arr = new int[2] { 1, 1 };
                        return arr;
                    default:
                        throw new Exception();
                }
            }
            public int GetExpectedQuantityMock(int a)
            {
                switch (a)
                {
                    case 1:
                        return 2;
                    case 2:
                        return 1;
                    case 3:
                        return 1;
                    case 4:
                        return 2;
                    default:
                        throw new Exception();
                }
            }
            public int[,] GetExpectedTransporateMock(int a)
            {
                int[,] arr;
                switch (a)
                {
                    case 1:
                        arr = new int[,] { { 10, 4, 100 }, { 2, 5, 45 }, { 3, 6, 12 } };
                        return arr;
                    case 2:
                        arr = new int[,] { { -10, 14 }, { 289, 455 }, { 233, 26 } };
                        return arr;
                    case 3:
                        arr = new int[,] { { -45, -4587 }, { 21, 564 } }; ;
                        return arr;
                    case 4:
                        arr = new int[,] { { 0, 454, 99, 567 }, { 12, 788, 1, -12020 } };
                        return arr;
                    default:
                        throw new Exception();
                }
            }
        }

    }
}