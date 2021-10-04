using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Compute
    {
        public static async Task<List<int>> ExecuteAsync(string[] args)
        {
            var results = new List<int>();

            var tasks = RunFibonacci(args);

            foreach (var task in tasks)
            {
                var result = await task;
                results.Add(result);
            }

            return results;
        }

        private static int Fib(int i) =>
            i switch
            {
                int when i <= 2 => 1,
                _ =>  Fib(i - 2) + Fib(i - 1)
            };
        
        private static List<Task<int>> RunFibonacci(string[] strings)
        {
            var list = new List<Task<int>>();
            foreach (var input in strings)
            {
                var task = Task.Run(() => Fib(Convert.ToInt32(input)));
                list.Add(task);
            }

            return list;
        }
        
        
    }
}