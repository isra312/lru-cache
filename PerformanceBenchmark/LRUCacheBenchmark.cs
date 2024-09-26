using BenchmarkDotNet.Attributes;
using Cache;

namespace PerformanceBenchmark;

public class LRUCacheBenchmark
{
    readonly LRUCache cache = new(1000);

    [Benchmark]
    public void PutBenchmark()
    {
        int rnd = new Random().Next(1, 1001);
        cache.Put(rnd, rnd);
    }

    [Benchmark]
    public void GetBenchmark()
    {
        int rnd = new Random().Next(1, 1001);
        cache.Get(rnd);
    }
}
