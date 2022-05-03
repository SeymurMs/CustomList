using System;
using System.Collections.Generic;

namespace CustomLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CustomList<int> vs = new CustomList<int>();
         

            vs.CustomAddList(6);
            vs.CustomAddList(4);
            vs.CustomAddList(1);
            vs.CustomAddList(8);
            vs.CustomAddList(3);


            Console.WriteLine(vs.Count);
            Console.WriteLine(vs.Capacity);


            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=========");

            // Console.WriteLine(vs.CustomContainsList(0));


            // foreach (var item in vs.CustomFindAllList(x => x == 1))
            // {
            //     Console.WriteLine(item);
            // }
            //;
            // Console.WriteLine(vs.CustomIndexOfList(1));

            // Console.WriteLine(vs.CustomFindIndexList(0, x => x == 1))
          
            vs.CustomRemoveAtList(4);
            //foreach (var item in vs)
            //{

            //    Console.WriteLine(item);
            //}
            //List<int> vs2 = new List<int> { 1,2,3,4,5,6,7,8,9,10,11};
            //    vs2.Capacity = 10;
            //foreach (var item in vs2)
            //{
            //    Console.WriteLine(item);
            //}






            //exist+
            //find+
            //findall+
            //findindex+
            //indexof+
            //remove+
            //removeAll+
            //removeAt+
            //.sort
            //List.capacity+
            //count+



        }
       
        
        
   
        
       
    }
}
