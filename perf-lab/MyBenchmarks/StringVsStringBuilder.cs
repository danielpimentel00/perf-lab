using BenchmarkDotNet.Attributes;
using System.Text;

namespace perf_lab.MyBenchmarks;

public class StringVsStringBuilder
{
    [Params(1000, 10000, 100000)]
    public int TotalIterations { get; set; }

    [Benchmark]
    public string MyString()
    {
        string result = "";
        int t = TotalIterations <= 0 ? 1000 : TotalIterations;
        for (int i = 0; i < t; i++)
        {
            result += i;
        }
        return result;
    }

    [Benchmark]
    public string MyStringBuilder()
    {
        StringBuilder result = new("");
        int t = TotalIterations <= 0 ? 1000 : TotalIterations;
        for (int i = 0; i < t; i++)
        {
            result.Append(i);
        }
        return result.ToString();
    }
}