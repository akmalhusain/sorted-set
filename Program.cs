using System;
using System.Collections.Generic;
class listprogram
{
    static void Main(string[] args)
    {
        var name =new SortedSet<string>();
        name.Add("akmal");
        name.Add("shakib");
        name.Add("sharukh");
        name.Add("mailk");
        name.Add("akmal");
        Console.WriteLine("before remove\n");
        foreach(var i in name)
        {
         Console.WriteLine(i);
        }
        name.Remove("mailk");
        Console.WriteLine("after remove\n");
        foreach (var i in name)

            { 
            
            Console.WriteLine(i);
        }
    }
}
