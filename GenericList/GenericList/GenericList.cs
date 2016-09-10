using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericList<T> : IEnumerable 
    {

        public T[] newArray;
        int count = 0;
        string toString;

        public GenericList()
        {
            newArray = new T[] { };
        }

        public void Add(T item)
        {

            T[] tempArray = new T[newArray.Length + 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                tempArray[i] = newArray[i];
            }
            tempArray[newArray.Length] = item;

            newArray = tempArray;

        }

        public bool Compare<U>(U newArray, U item)
        {
            return EqualityComparer<U>.Default.Equals(newArray, item);

        }

        public void Remove(T item)
        {
            int m = 0;
            for (int k = 0; k < newArray.Length; k++)
            {
                if (Equals(newArray[k], item))
                {
                    m++;
                }
            }

            T[] tempArray = new T[newArray.Length - m];
            int j = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                if (!Equals(newArray[i], item))
                { 
                    tempArray[j] = newArray[i];
                    j++;
                }
            }
            newArray = tempArray;
        }
        public IEnumerator GetEnumerator()
        {

            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] != null)
                {
                    yield return newArray[i];
                }
            }
        }

       
        public string ChangeString()
        {
            for (int i = 0; i < newArray.Length; i++)
            {
                toString += newArray[i].ToString();
            }
            Console.WriteLine(toString);
            return toString;
        }

        public static GenericList<T> operator +(GenericList<T> list1, GenericList<T> list2)
        {

            GenericList<T> resultList = new GenericList<T>();
            foreach (T item in list1)
            {
                resultList.Add(item); 
            }
            foreach (T item in list2)
            {
                resultList.Add(item);
            }

            return resultList;
        }

      
        public static GenericList<T> operator -(GenericList<T> list1, GenericList<T> list2)
        {
            GenericList<T> result = new GenericList<T>();

            foreach (T item2 in list2)
            {
                list1.Remove(item2);
            }

            return list1;
        }

      
        public int Count()
        {
            foreach (T item in newArray)
            {
                count += 1;
            }
            return count;
        }


        public GenericList<T> Zipper(GenericList<T> list1, GenericList<T> list2)
        {

            GenericList<T> zippedResult = new GenericList<T>();

            for (int i = 0; i < newArray.Length + 3; i++)

            {
                zippedResult.Add(list1.newArray[i]);
                zippedResult.Add(list2.newArray[i]);
            }

            return zippedResult;
        }
       

        public void SortList(GenericList <T>  list) 
        {
           T temp ;

            for (int write = 0; write < newArray.Length; write++)
            {
                for (int sort = 0; sort < newArray .Length - 1; sort++)
                {
                    var result = Comparer<T>.Default.Compare(newArray[sort], newArray[sort + 1]);

                    if ( result > 0)
                    {
                        temp = newArray [sort + 1];
                        newArray [sort + 1] = newArray [sort];
                        newArray [sort] = temp;
                    }
                }
                Console.Write("{0} ", newArray[write]);
            }
        }
      

    }
}
 

   

