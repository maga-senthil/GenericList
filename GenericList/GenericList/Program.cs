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
            Number.Add(1);


            GenericList<int> AddNumber = new GenericList<int>();
            AddNumber.Add(1);
            AddNumber.Add(2);
            AddNumber.Add(3);
            AddNumber.Add(4);
            AddNumber.Add(5);

            //Number.Remove(3);

            //Number.ChangeString();

            //GenericList<int> CombinedList = Number + AddNumber;

            //GenericList<int> RemoveList = Number - AddNumber;

            GenericList<int> Zip = new GenericList<int>();
            Number.Zipper(Number,AddNumber);
            foreach (var number in Zip)
            {
                Console.WriteLine(number);
            }

            Number.Count();

            GenericList<string> Animals = new GenericList<string>();
            Animals.Add("Dog");
            Animals.Add("Cat");
            Animals.Add("Cow");
            Animals.Add("Horse");
            Animals.SortList(Animals);
           
            Console.ReadLine();
        }
       
    }
 }
