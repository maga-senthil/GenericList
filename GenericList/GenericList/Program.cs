using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        { 
            GenericList<int> Number = new GenericList<int>();
            Number.Add(1);
            Number.Add(2);
            Number.Add(3);
            Number.Add(5);
            Number.Add(6);

            GenericList<int> AddNumber = new GenericList<int>();
            AddNumber.Add(1);
            AddNumber.Add(2);
            AddNumber.Add(3);
            AddNumber.Add(4);
            AddNumber.Add(5);

            Number.Remove(3);

            Number.ChangeString();

            GenericList<int> CombinedList = Number + AddNumber;

            GenericList<int> RemoveList = Number - AddNumber;

            Number.Zipper(AddNumber);

            Number.Count();

            Console.ReadLine();
        }
       
    }
 }
