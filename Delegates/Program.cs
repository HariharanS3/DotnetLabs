using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Oops;

class Program
{
    //Created a new datatype
    //Viz. Declaration of Delegate
  

    public delegate void PM(string requirement);
    static void Main()
    {
        Thread t1 = new Thread(() =>
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Hand Movement animation:: x-co-ordinate={i}");
            }

        });
        Thread t2 = new Thread(() => {
            for (int i = 1000; i > 0; i--) {
                Console.WriteLine($"Ball Movement animation::y-co-ordinate= {i}");
            }
        });
        t1.Start();
        t2.Start();
        Thread.Sleep(3000);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("The game has completed!!!");

    }

    private static void LinqLambda2()
    {
        //Collection of Rectangles
        List<Rectangle> rectangles = new List<Rectangle>();
        rectangles.Add(new Rectangle(10, 5));
        rectangles.Add(new Rectangle(10, 3));
        rectangles.Add(new Rectangle(20, 7));
        rectangles.Add(new Rectangle(25, 5));
        //Query:Get all rectangles whose length is 10
        /* rectangles
             .Where((r) => { return r.Length == 10; })
             .ToList()
             .ForEach((r) => { Console.WriteLine($"Length: {r.Length} | Breadth: {r.Width}");});
         //Using LINQ-SQL in .net
         var searchRectangles = from r in rectangles
                                where r.Length == 10
                                select r;
         //Display
         searchRectangles
             .ToList()
             .ForEach((r) =>
             {
                 Console.WriteLine($"Output from LINQ: Rectangle Length X Breadth:: :{r.Length}X{r.Width}");
             });*/
        /* rectangles
            .Where((r) => { return r.Width == 3; })
            .ToList()
            .ForEach((r) => { Console.WriteLine($"Length: {r.Length} | Breadth: {r.Width}"); });
         //Using LINQ-SQL in .net
         var searchRectangles = from r in rectangles
                                where r.Width == 3
                                select r;
         //Display
         searchRectangles
             .ToList()
             .ForEach((r) =>
             {
                 Console.WriteLine($"Output from LINQ: Rectangle Length X Breadth:: :{r.Length}X{r.Width}");
             });*/

        rectangles
           .Where((r) => { return r.Length == 10 && r.Width == 5; })
           .ToList()
           .ForEach((r) => { Console.WriteLine($"Length: {r.Length} | Breadth: {r.Width}"); });
        //Using LINQ-SQL in .net
        var searchRectangles = from r in rectangles
                               where r.Length == 10 && r.Width == 5
                               select r;
        //Display
        searchRectangles
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Output from LINQ: Rectangle Length X Breadth:: :{r.Length}X{r.Width}");
            });
    }

    private static void Search()
    {
        List<string> names = new List<string>();
        names.Add("Meena");
        names.Add("Teena");
        names.Add("Reena");
        names.Add("Reena Chakravarthy");
        names.ForEach((str) => { Console.WriteLine(str); });

        // List<string> result = names.Where((str) => { return str == "Reena"; }).ToList();
        List<string> result1 = names.Where((str) => { return str.StartsWith("Re"); }).ToList();
        //Console.WriteLine("Search for 'Reena'");
        //result.ForEach((str) => { Console.WriteLine($"Found match for: {str}"); });
        Console.WriteLine("Search for names with 'Re'");
        result1.ForEach((str) => { Console.WriteLine($"Found match for: {str}"); });
    }

    private static void SimpleLinq(List<string> names)
    {
        //LINQ=>Language Integrated Query==SQL in .Net
        var queryOutput = (from str in names
                           where str == "Reeena" && str.Contains("Chakravarthy")
                           select str).ToList();
        queryOutput.ForEach((str) => { Console.WriteLine(str); });
    }

    private static void CallDelegates()
    {
        //Object or Instantiation of Delegate
        PM Vimal = new PM((requirement) => { Console.WriteLine("I, Hari have attended the training "); });
        Vimal += (requirement) => { Console.WriteLine("I, ABC have attended the training "); };
        Vimal += (requirement) => { Console.WriteLine("I, QWERTY have attended the training "); };
        //Calling Vimal
        //Invoking Delegate
        Vimal("Tax Tech Training for The team");
    }

}