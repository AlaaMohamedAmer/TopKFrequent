using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TopKFrequent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution s1= new solution();
            List<int> result = s1.TopKFrequent(new int[] { 1, 1, 2, 2, 3 }, 2);
            Console.WriteLine(string.Join(", ", result));
            Console.ReadKey();
        }
    }

    public class solution
    {
        public List<int> TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            List<int> orderedNumbers = frequencyMap.Keys.OrderByDescending(key => frequencyMap[key]).ToList();

            List<int> topK = orderedNumbers.Take(k).ToList();

            return topK;
        }
    }
}
