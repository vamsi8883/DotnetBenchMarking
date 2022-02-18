using BenchmarkDotNet.Running;
using BenchMarkLearning;

BenchMark test = new();
//test.test();


var summary = BenchmarkRunner.Run<BenchMark>();
    Console.ReadKey();

//firsrun = 5.554 us