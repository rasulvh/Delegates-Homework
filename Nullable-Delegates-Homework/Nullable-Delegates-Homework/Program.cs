using System;
using System.Collections.Generic;
using System.Linq;

namespace Nullable_Delegates_Homework
{
    class Program
    {
        //public delegate bool CheckNums(int num);



        static void Main(string[] args)
        {
            #region Nullable
            //string name = null;
            //Person person = null;

            //string name = null;
            //string text = name;

            //int? a = null;
            //Console.WriteLine(a);

            //Test test = new Test();
            //Console.WriteLine(test.Id);
            #endregion

            #region Delegate-Bool-Predicate
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(SumNums(CheckNumsGreaterThanFour, nums));


            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = nums.FindAll(m => m > 4);
            //var result = nums.FindAll(m => m % 2 == 0);
            //var result = nums.FindAll(m => m % 2 == 1);
            //var result = nums.FindAll(m => m % 2 == 0 && m > 6);

            //var result = nums.FindAll(CheckNumsGreaterThanFour);

            //List<int> nums = new List<int> { 1, 5, 10, 15, 21, 32, 42, 53, 63 };

            //var result = SumOfNumsDividedInto21(CheckNumsDividedInto21, nums);

            //Console.WriteLine(result);

            //var result = nums.FindAll(m => m % 21 == 0).Sum(m => m);

            //Console.WriteLine(result);
            #endregion


        }

        #region Nullable
        //public static string GetData(int? id)
        //{
        //    if (id is null)
        //    {
        //        return "Not found";
        //    }
        //    return "";
        //}
        #endregion

        #region Delegate-Bool-Predicate

        //public static bool CheckNumsDividedInto21(int num)
        //{
        //    return num % 21 == 0;
        //}

        //public static int SumOfNumsDividedInto21(Predicate<int> func, List<int> list)
        //{
        //    int sum = 0;

        //    foreach (var item in list)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}



        //public static bool CheckOddNums(int num)
        //{
        //    return num % 2 == 1;
        //}
        //public static bool CheckEvenNums(int num)
        //{
        //    return num % 2 == 0;
        //}
        //public static bool CheckNumsGreaterThanFour(int num)
        //{
        //    return num > 4;
        //}


        //public static int SumNums(Predicate<int> func, int[] arr)
        //{
        //    int sum = 0;

        //    foreach (var item in arr)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        //public static int EvenNums(int[] arr)
        //{
        //    int sum = 0;

        //    foreach (var item in arr)
        //    {
        //        if (item % 2 == 0)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        //public static int NumsGreaterThanFour(int[] arr)
        //{
        //    int sum = 0;

        //    foreach (var item in arr)
        //    {
        //        if (item > 4)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}
        #endregion


    }

    #region Nullable
    //class Person
    //{

    //}

    //class Test
    //{
    //    public int? Id { get; set; }
    //}
    #endregion
}