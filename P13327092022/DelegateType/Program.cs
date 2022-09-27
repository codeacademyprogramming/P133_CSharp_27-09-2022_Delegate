using DelegateType.Models;
using System;
using System.Collections.Generic;

namespace DelegateType
{
    class Program
    {
        public delegate bool Test();
        public delegate bool Test<T>(int a);
        public delegate bool Test<T,T2>(int a);

        static void Main(string[] args)
        {

            //int[] arr = { 5, 7, 10, 12, 13, 15, 17, 20 };

            //GetNums(arr, IsEven);
            //GetNums(arr, IsOdd);
            //GetNums(arr, IsdevideByFive);
            ////Anonym Method
            //GetNums(arr, delegate(int num) 
            //{
            //    //if (true)
            //    //{
            //    //    for (int i = 0; i < length; i++)
            //    //    {

            //    //    }
            //    //}
            //    return num % 3 == 0; 
            //});
            //Lambda Expression
            //GetNums(arr, n => n % 3 == 0);
            //GetNums(arr, n => 
            //{
            //    //if (true)
            //    //{
            //    //    for (int i = 0; i < length; i++)
            //    //    {

            //    //    }
            //    //}
            //    return true;
            //});

            //Check check = new Check(IsEven);

            //Console.WriteLine(check(15));
            //Console.WriteLine(check.Invoke(12));

            //Check check = IsEven;
            ////Console.WriteLine(check(15));

            //check += IsOdd;
            ////Console.WriteLine(check(15));

            //check += IsdevideByFive;
            ////Console.WriteLine(check(15));

            //check += delegate (int num)
            //{
            //    Console.WriteLine("Is Devide By Three");
            //    return num % 3 == 0;
            //};

            //check += n => 
            //{
            //    Console.WriteLine("lambda");

            //    return n % 4 == 0 && n % 8 == 0;
            //};

            //check -= IsEven;

            //check -= delegate (int num)
            //{
            //    Console.WriteLine("Is Devide By Three");
            //    return num % 3 == 0;
            //};

            //check -= n =>
            //{
            //    Console.WriteLine("lambda");

            //    return n % 4 == 0 && n % 8 == 0;
            //};

            //Console.WriteLine(check(15));

            //Test<string>(delegate (string str) 
            //{
            //    Console.WriteLine(str+" Hello World");
            //}, "P133");

            //Write<int, bool> write = delegate (int num)
            //{
            //    return num % 2 == 0;
            //};

            //Write<int, string> write1 = n => $"{n} Hello World";

            //Console.WriteLine(write1(15));

            #region Built In Type Delegate
            #region Action - Return Type-i Void ve maksimum 0-dan 16-a qeder Methodlari Temsi Edir
            //Action action = delegate ()
            //{
            //    Console.WriteLine(" Sifir Parametrli Action");
            //};
            //action();


            //Action<string, int, bool> action1 = testAction;

            #endregion

            #region Func - Return Type Void-den Ferqli Olan ve 0-dan 16 -a qeder parametr qebul Methodlari Temsil Edir
            //Func<bool> func = TestFunc;
            //Func<int, bool> func1 = IsEven;


            #endregion
            #region Predicate
            //Predicate<int> predicate = IsOdd;

            #endregion
            #endregion

            List<Student> students = new List<Student>
            {
                new Student{ Name = "Emin",SurName="Suleymanov",Age = 18},
                new Student{ Name = "Samed",SurName="Aliyev",Age = 20},
                new Student{ Name = "Ramiz",SurName="Quliyev",Age = 20},
                new Student{ Name = "Namiq",SurName="Abilov",Age = 19},
                new Student{ Name = "Orxan",SurName="Memmedli",Age = 26},
                new Student{ Name = "Nurlan",SurName="Nezerov",Age = 28},
                new Student{ Name = "Aqil",SurName="Soltanli",Age = 19},
                new Student{ Name = "Narmin",SurName="Qapciyeva",Age = 20},
            };

            //Console.WriteLine(students.Exists(CheckAgeGraterThan20));
            //Console.WriteLine(students.Exists(CheckLessThan20AndContainingE));
            //Console.WriteLine(students.Exists(delegate(Student student) 
            //{
            //    return student.SurName == "mammadov";
            //}));
            //Console.WriteLine(students.Exists(s=>s.Age > 26 && s.Age < 28));

            //Student student = students.Find(CheckStudentByName);

            //Console.WriteLine($"{student.Name} {student.SurName} {student.Age}");

            //Student student1 = CustomFind(CheckStudentByName, students);
            //Student student1 = students.CustomFind(CheckStudentByName);

            //Console.WriteLine($"{student1.Name} {student1.SurName} {student1.Age}");

            //foreach (Student student in students)
            //{
            //    if (student.Age > 20)
            //    {
            //        Console.WriteLine(true);
            //        break;
            //    }
            //}

            students.ForEach(WriteStu);
        }

        static void WriteStu(Student student)
        {
            if (student.Age > 20)
            {
                Console.WriteLine($"{student.Name} {student.SurName} {student.Age}");
            }
        }


        static bool CheckStudentByName(Student student)
        {
            return student.Name == "Samed";
        }

        static bool CheckLessThan20AndContainingE(Student student)
        {
            return student.Age < 20 && student.Name.Contains('W');
        }

        static bool CheckAgeGraterThan20(Student student)
        {
            return student.Age > 20;
        }

        //static bool TestFunc()
        //{
        //    return true;
        //}
        //static void testAction(string a, int b, bool c)
        //{

        //}


        //static void Test<T>(Write<T> write, T item)
        //{
        //    write.Invoke(item);
        //}

        static int[] GetNums(int[] nums, Check check)
        {
            int[] evenNums = { };

            foreach (int item in nums)
            {
                bool test = check.Invoke(item);

                if (test)
                {
                    Array.Resize(ref evenNums, evenNums.Length + 1);
                    evenNums[evenNums.Length - 1] = item;
                }
            }

            return evenNums;
        }

        //static int[] GetEvenNums(int[] nums)
        //{
        //    int[] evenNums = { };

        //    foreach (int item in nums)
        //    {
        //        if (IsEven(item))
        //        {
        //            Array.Resize(ref evenNums, evenNums.Length + 1);
        //            evenNums[evenNums.Length - 1] = item;
        //        }
        //    }

        //    return evenNums;
        //}


        //static int[] GetOddNums(int[] nums)
        //{
        //    int[] oddNums = { };

        //    foreach (int item in nums)
        //    {
        //        if (IsOdd(item))
        //        {
        //            Array.Resize(ref oddNums, oddNums.Length + 1);
        //            oddNums[oddNums.Length - 1] = item;
        //        }
        //    }

        //    return oddNums;
        //}

        //static int[] GetDevideByFiveNums(int[] nums)
        //{
        //    int[] oddNums = { };

        //    foreach (int item in nums)
        //    {
        //        if (IsdevideByFive(item))
        //        {
        //            Array.Resize(ref oddNums, oddNums.Length + 1);
        //            oddNums[oddNums.Length - 1] = item;
        //        }
        //    }

        //    return oddNums;
        //}

        static bool IsEven(int num)
        {
            Console.WriteLine("Is Even");
            return num % 2 == 0 ? true : false;
        }

        static bool IsOdd(int num)
        {
            Console.WriteLine("Is Odd");

            return num % 2 != 0 ? true : false;
        }

        static bool IsdevideByFive(int num)
        {
            Console.WriteLine("Is Devide By Five");

            return num % 5 == 0 ? true : false;
        }
    }
}
