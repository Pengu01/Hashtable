using System;
using System.Collections.Generic;

namespace Hashtable_true
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> key = new List<int>();
            List<string> value = new List<string>();
            while(true)
            {
                Console.WriteLine("Show/Add/Delete");
                string what = Console.ReadLine();
                if (what == "Add")
                {
                    Console.WriteLine("Insert Key");
                    int tempkey = Convert.ToInt32(Console.ReadLine());
                    bool exist = key.Contains(tempkey);
                    if (exist == true)
                    {
                        Console.WriteLine("Key already exist, try again");
                        continue;
                    }
                    key.Add(tempkey);
                    Console.WriteLine("Insert Value");
                    value.Add(Console.ReadLine());
                    continue;
                } if (what == "Show")
                {
                    for (int i = 0; i <= key.Count - 1; i++)
                    {
                        Console.WriteLine(key[i] + ": " + value[i]);
                    }
                    continue;
                } if (what == "Delete")
                {
                    for (int i = 0; i <= key.Count - 1; i++)
                    {
                        Console.WriteLine(key[i] + ": " + value[i]);
                    }
                    Console.WriteLine("Type key of value to delete");
                    int delete = Convert.ToInt32(Console.ReadLine());
                    int indexdelete = key.IndexOf(delete);
                    key.RemoveAt(indexdelete);
                    value.RemoveAt(indexdelete);
                }
            }
        }
    }
}
