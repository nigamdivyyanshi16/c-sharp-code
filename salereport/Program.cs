// See https://aka.ms/new-console-template for more information
using System.IO;
using solution;
namespace salereport
{
    class Sale

    {
        static void Main(string[] args)
        {
            
            Abc obj = new Abc();
            obj.input();
            obj.output();
            obj.indi();

        }
    }
}

namespace solution
{
    class Abc
    {
        string[,] arr = new string[2,5];
        int i, j, omin, omax;
            public void input()
            {
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("enter empname");
                arr[i, 0] = Console.ReadLine();

                for (j = 1; j <5; j++)
                {
                   
                        Console.WriteLine("enter sales for month " + (j + 1));
                        arr[i, j] = Console.ReadLine();
                    
                }
            }
            }

        public void indi() 
        {
            int av, min = Convert.ToInt32(arr[0,0]), max = Convert.ToInt32(arr[0, 0]), n,s=0,n1;
            string nm = Console.ReadLine();
            for (i=0;i<2;i++)
            {
                if (nm.Equals(arr[i, j]))
                {
                    for(j=1;j<5; j++)
                    {
                        n = Convert.ToInt32(arr[i,j]);
                        s = s + n;
                        av = s / 4;
                        for(int k=j+1;k<12;j++)
                        {
                            n1 = Convert.ToInt32(arr[i,k]);
                            max = Math.Max(max, n1);
                            min=Math.Min(min, n1);
                        }

                    }
                }
            }
           // Console.WriteLine("average= " + av);
            Console.WriteLine("Max=" + max);
            Console.WriteLine("Min=" + min);
        }

        public void output()
        {
            Console.WriteLine("EmpName\t Jan\t Feb\t march\t April\t May\t June\t July\t August\t Sept\t Oct\t Nov\t Dec\t");
            for (i = 0; i < 2; i++)
            {

                for (j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j] + " \t");
                }
                Console.WriteLine();
            }
        }
    }
}