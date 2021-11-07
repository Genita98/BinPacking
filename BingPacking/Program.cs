using System;
using System.Collections.Generic;
using System.Linq;

namespace BinPacking
{
      class BinPacking
    {
        static void Main(string[] args)
        {

            List<int> weight = BinPacking.generateListOfWeights(10);
            Console.WriteLine("Weights of elements: {0}", string.Join(",", weight));
            int c = 50;
            int n = weight.Count;
            Console.WriteLine("Bins that will be filled are: " + populateBins(weight, n, c));



        }
        public int binCapacity = 50;
        public static int numberOfBins = 10;
        public static List<int> Weights = new List<int>();
        public static List<int> elementsOfBin = new List<int>();

        public static List<int> generateListOfWeights(int count)
        {
            Random random = new Random();
         
            //Generate random numbers in range 1 and 30
            for (int i = 0; i < count; ++i)
                Weights.Add(random.Next(1,50));
            return Weights;
        }


       public static int populateBins(List<int> weight, int n, int capacity)
       {
 
        // Initialization of result (Count of bins) and remaining capacity in the current bin
        
        int res = 0, bin_remaining = capacity;
 
        // Place items one by one
        for (int i = 0; i < n; i++)
        {
            // If this item can't fit in current bin
            if (weight[i] > bin_remaining)
            {
                res++; // Use a new bin
                bin_remaining = capacity - weight[i];
            }
            else
                bin_remaining -= weight[i];
        }
        return res;
       }

     
    }
}
