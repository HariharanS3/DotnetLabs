using System;
class Program
{
    public delegate void Calc(int n1, int n2);
    static void Main()
    {
        Calc Calci = new Calc((n1,n2)=>{
            int div = n1 / n2;
            Console.WriteLine($"n1/n2: {div})");
        });
        Calci += (n1, n2) => {
            int mul = n1 * n2;
            Console.WriteLine($"n1*n2: {mul}");
        };
        Calci += (n1, n2) => {
            int subs = n1 - n2;
            Console.WriteLine($"n1-n2: {subs}");
        };
        Calci += (n1, n2) => {
            int add = n1 + n2;
            Console.WriteLine($"n1+n2: {add}");
        };
        Calci(10, 5);
        Console.WriteLine("n1 is 10 & n2 is 5");

    }

}