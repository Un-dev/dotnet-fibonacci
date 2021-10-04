using System;
using System.Threading.Tasks;
using Xunit;

namespace Fibonacci.Tests
{
    public class FibonacciUnitTest
    {
        [Fact]
        public async Task Execute44ShouldRetrun701408733()
        {
            var result = await Compute.ExecuteAsync(new[] {"44"});
            Assert.Equal(701408733, result[0]);
        }
    }
}