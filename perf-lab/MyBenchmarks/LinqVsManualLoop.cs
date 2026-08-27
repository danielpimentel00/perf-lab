using BenchmarkDotNet.Attributes;

namespace perf_lab.MyBenchmarks;

public class LinqVsManualLoop
{
    private int[] data = [];

    [GlobalSetup]
    public void Setup()
    {
        data = new int[10000];
        for (int i = 0; i < 10000; i++)
        {
            data[i] = i;
        }
    }

    [Benchmark]
    public int Linq()
    {
        return data.Where(x => x % 2 == 0).Sum();
    }

    [Benchmark]
    public int ManualLoop()
    {
        int sum = 0;
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] % 2 == 0)
            {
                sum += data[i];
            }
        }
        return sum;
    }
}
