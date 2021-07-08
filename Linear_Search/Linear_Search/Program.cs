using System;
using System.Collections.Generic;

namespace Linear_Search
{
    class Program
    {
        public static string Linear_Search(List<int>arr,int searchValue)
        {
            for(int i = 0;i<arr.Count;i++)
            {
                if(arr[i] ==searchValue)
                {
                    return $"Search value : {searchValue} Position : {i+1}.";
                }
            }
            return $"Search value : {searchValue} not found.";
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Search Value : ");
            List<int> arr = new List<int>() {23,2,45,1,100,7 };
            int searchValue = Convert.ToInt32(Console.ReadLine());
            string result = Linear_Search(arr,searchValue);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
