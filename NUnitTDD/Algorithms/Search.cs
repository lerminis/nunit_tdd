using System;

namespace NUnitTDD.Algorithms
{
    public class Search
    {
        public static int LinearSearch(int[] data, int target)
        {
            for (var i = 0; i < data.Length; i++)
            {
                if (data[i] == target) return i;
            }

            return -1;
        }

        public static int BinarySearch(int[] data, int target)
        {
            var min = 0;
            var max = data.Length - 1; 
            
            while (min <= max)  
            {  
                var mid = (min + max) / 2;  
                
                if (target == data[mid]) return mid;
                
                if (target < data[mid]) max = mid - 1;  
                
                else min = mid + 1;  
            }  

            return -1;
        }
    }
}