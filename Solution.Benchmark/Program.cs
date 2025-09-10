using BenchmarkDotNet.Running;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Solution.Benchmark;

class Program
{
    static void Main(string[] args)
    {
        /*var orders = TestDataGenerator.GenerateOrders(1);

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        string json = JsonSerializer.Serialize(orders, options);
        Console.WriteLine(json);*/
        BenchmarkRunner.Run<Benchmarks>();
    }
}
