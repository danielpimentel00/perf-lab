using BenchmarkDotNet.Running;
using perf_lab.MyBenchmarks;

//BenchmarkRunner.Run<Md5VsSha256>();
//BenchmarkRunner.Run<StringVsStringBuilder>();
BenchmarkRunner.Run<LinqVsManualLoop>();