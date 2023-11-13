using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace BenchmarkDotNetBugReproduction;

[SimpleJob(RuntimeMoniker.NativeAot70)]
public class Benchmarks
{
    [Benchmark]
    public void Foo()
    {
        Thread.Sleep(5);
    }
}