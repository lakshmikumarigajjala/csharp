using System;

namespace enumerators
{
    class Program
{
    enum depts
    {
        hr=2,salesdept=3,marketingdept
    }
    static void Main(string[] args)
    {
        int deptno = (int)depts.marketingdept;
        Console.WriteLine(deptno);
        Console.WriteLine();
        Console.Read();
    }
}
}
