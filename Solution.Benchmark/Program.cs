using BenchmarkDotNet.Running;

namespace Solution.Benchmark;

class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<Benchmarks>();
    }
}
