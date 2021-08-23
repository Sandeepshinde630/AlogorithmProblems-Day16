using System;
using System.Collections;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithm Problems");
            String str = "ABC";
            int n = str.Length;
            ProblemNo1 problemNo1 = new ProblemNo1();
            problemNo1.run1(str, 0, n - 1);
            problemNo1.IterationPermutation(str);

            //ProblemNo2 problemNo2 = new ProblemNo2();
            //problemNo2.runNo2();
            //ProblemNo3 problem3 = new ProblemNo3();
            //problem3.run3();
            //ProblemNo4 problemNo4 = new ProblemNo4();
            //problemNo4.run4();
            //ProblemNo5 problemNo5 = new ProblemNo5();
            //problemNo5.run5();
            //ProblemNo6 problemNo6 = new ProblemNo6();
            //problemNo6.run6();
            //ProblemNo7 problemNo7 = new ProblemNo7();
            //problemNo7.run7();

        }
    }
}